﻿using System;
using System.Collections.Generic;
using Moq;
using NBi.Core.Analysis.Metadata;
using NBi.Core.Analysis.Metadata.Adomd;
using NBi.Core.Analysis.Request;
using NBi.NUnit.Structure;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace NBi.Testing.Unit.NUnit.Structure
{
    [TestFixture]
    public class ExistsConstraintTest
    {
        [Test]
        public void Matches_GivenDiscoveryRequest_FactoryCalledOnceWithParametersComingFromRequest()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Dimensions,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("expected-dimension-caption", DiscoveryTarget.Dimensions)
                        });

            var elStub = new Mock<IField>();
            var el1 = elStub.Object;
            var el2 = elStub.Object;
            var elements = new List<IField>();
            elements.Add(el1);
            elements.Add(el2);

            var commandStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryMock = new Mock<AdomdDiscoveryCommandFactory>();
            factoryMock.Setup(f => f.BuildExact(request))
                .Returns(commandStub.Object);
            var factory = factoryMock.Object;

            var ctr = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            ctr.Matches(request);

            //Test conclusion            
            factoryMock.Verify(f => f.BuildExact(request), Times.Once());
        }

        [Test]
        public void Matches_GivenDiscoveryRequest_CommandCalledOnce()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.MeasureGroups,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("measure-group", DiscoveryTarget.MeasureGroups)
                                , new CaptionFilter("measure", DiscoveryTarget.Measures)
                        });


            var elStub = new Mock<IField>();
            var el1 = elStub.Object;
            var el2 = elStub.Object;
            var elements = new List<IField>();
            elements.Add(el1);
            elements.Add(el2);

            var commandMock = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandMock.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandMock.Object);
            var factory = factoryStub.Object;

            var ctr = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            ctr.Matches(request);

            //Test conclusion            
            commandMock.Verify(c => c.Execute(), Times.Once());
        }

        [Test]
        public void Matches_GivenDiscoveryRequestFailing_InvestigateCommandCalledOnce()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.MeasureGroups,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("measure-group", DiscoveryTarget.MeasureGroups)
                                , new CaptionFilter("measure", DiscoveryTarget.Measures)
                        });

            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalMock = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalMock.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalMock.Object);
            var factory = factoryStub.Object;

            var ctr = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            try
            {
                Assert.That(request, ctr);
            }
            catch { }

            //Test conclusion            
            commandExternalMock.Verify(c => c.Execute(), Times.Once());
        }

        [Test]
        public void WriteTo_FailingAssertionForDimension_TextContainsCaptionOfExpectedDimensionAndNameOfPerspective()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Dimensions,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("expected-dimension-caption", DiscoveryTarget.Dimensions)
                        });

            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion   
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("perspective-name").And
                                            .StringContaining("expected-dimension-caption"));
        }

        [Test]
        public void WriteTo_FailingAssertionForHierarchy_TextContainsCaptionOfExpectedHierarchyAndCaptionOfFilters()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Hierarchies,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("dimension-caption", DiscoveryTarget.Dimensions)
                                , new CaptionFilter("expected-hierarchy-caption", DiscoveryTarget.Hierarchies)
                        });

            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion     
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("perspective-name").And
                                            .StringContaining("dimension-caption").And
                                            .StringContaining("expected-hierarchy-caption"));
        }

        [Test]
        public void WriteTo_FailingAssertionForMeasureGroup_TextContainsNameOfExpectedMeasureGroupAndNameOfPerspectiveFiltering()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.MeasureGroups,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("expected-measure-group-caption", DiscoveryTarget.MeasureGroups)
                        });


            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion   
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("perspective-name").And
                                            .StringContaining("expected-measure-group-caption"));
        }

        [Test]
        public void WriteTo_FailingAssertionForPerspective_TextContainsNameOfExpectedPerspective()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Perspectives,
                        new List<IFilter>()
                            {
                                new CaptionFilter("expected-perspective-name", DiscoveryTarget.Perspectives)
                        });


            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion  
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("expected-perspective-name"));
        }

        [Test]
        public void WriteTo_FailingAssertionForPerspectiveWithNot_TextContainsFewKeyInfo()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Perspectives,
                        new List<IFilter>()
                            {
                                new CaptionFilter("expected-perspective-name", DiscoveryTarget.Perspectives)
                        });


            var elements = new List<IField>();
            elements.Add(new Perspective("expected-perspective-name"));

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(elements);

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            elements.Add(new Perspective("unexpected-perspective-name"));

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };
            var notExistsConstraint = new NotConstraint(existsConstraint);

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, notExistsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion      
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("not find"));
        }

        [Test]
        public void WriteTo_FailingAssertionForPerspectiveWithInvestigationReturningOtherFields_TextContainsFewKeyInfo()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Perspectives,
                        new List<IFilter>()
                            {
                                new CaptionFilter("expected-perspective-name", DiscoveryTarget.Perspectives)
                        });


            var elements = new List<IField>();
            elements.Add(new Perspective("first-unexpected-perspective-name"));
            elements.Add(new Perspective("second-unexpected-perspective-name"));

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(new List<IField>());

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);
            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining(elements[0].Caption).And
                                            .StringContaining(elements[1].Caption));
        }

        [Test]
        public void WriteTo_FailingAssertionForPerspectiveWithInvestigationReturningNoField_TextContainsFewKeyInfo()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Perspectives,
                        new List<IFilter>()
                            {
                                new CaptionFilter("expected-perspective-name", DiscoveryTarget.Perspectives)
                        });


            var elements = new List<IField>();

            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(new List<IField>());

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                .Returns(elements);

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);
            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion            
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("nothing found"));
        }

        [Test]
        public void WriteTo_FailingAssertionForDimensionWithMinorMistake_TextContainsTheSuggestionOfValue()
        {
            var request = new DiscoveryRequestFactory().BuildDirect(
                        "connectionString",
                        DiscoveryTarget.Dimensions,
                        new List<IFilter>()
                            {
                                new CaptionFilter("perspective-name", DiscoveryTarget.Perspectives)
                                , new CaptionFilter("expected-dimension-caption", DiscoveryTarget.Dimensions)
                        });


            var commandExactStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExactStub.Setup(f => f.Execute())
                .Returns(new List<Dimension>());

            var commandExternalStub = new Mock<AdomdDiscoveryCommand>("connectionString");
            commandExternalStub.Setup(f => f.Execute())
                 .Returns(new List<Dimension>() 
                    { 
                        new Dimension("Dimension", "expected-dimension-catpion") , //two letters permutted
                        new Dimension("Toto", "Toto") 
                    });

            var factoryStub = new Mock<AdomdDiscoveryCommandFactory>();
            factoryStub.Setup(f => f.BuildExact(request))
                .Returns(commandExactStub.Object);

            factoryStub.Setup(f => f.BuildExternal(It.IsAny<MetadataDiscoveryRequest>()))
                .Returns(commandExternalStub.Object);
            var factory = factoryStub.Object;

            var existsConstraint = new ExistsConstraint() { CommandFactory = factory };

            //Method under test
            string assertionText = null;
            try
            {
                Assert.That(request, existsConstraint);
            }
            catch (AssertionException ex)
            {
                assertionText = ex.Message;
            }

            //Test conclusion   
            Console.WriteLine(assertionText);
            Assert.That(assertionText, Is.StringContaining("The value 'expected-dimension-catpion' is close to your expectation."));
        }

       
    }
}
