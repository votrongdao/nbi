﻿using System.IO;
#region Using directives

using System.Xml.Serialization;
using NBi.Xml;
using System.Reflection;
using NBi.Xml.Constraints;
using NUnit.Framework;

#endregion

namespace NBi.Testing.Unit.Xml
{
    [TestFixture]
    public class TestSuiteQueryTest
    {

        #region SetUp & TearDown
        //Called only at instance creation
        [TestFixtureSetUp]
        public void SetupMethods()
        {

        }

        //Called only at instance destruction
        [TestFixtureTearDown]
        public void TearDownMethods()
        {
        }

        //Called before each test
        [SetUp]
        public void SetupTest()
        {
        }

        //Called after each test
        [TearDown]
        public void TearDownTest()
        {
        }
        #endregion

        protected TestSuiteXml DeserializeSample()
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new XmlSerializer(typeof(TestSuiteXml));
            // Declare an object variable of the type to be deserialized.
            TestSuiteXml ts;

            // A Stream is needed to read the XML document.
            using (Stream stream = Assembly.GetExecutingAssembly()
                                           .GetManifestResourceStream("NBi.Testing.Unit.Xml.Resources.TestSuiteQuery.xml"))
            using (StreamReader reader = new StreamReader(stream))
            {
                // Use the Deserialize method to restore the object's state.
                ts = (TestSuiteXml)serializer.Deserialize(reader);
            }
            return ts;
        }

        [Test]
        public void DeserializeEqualToResultSet_QueryFile0_Inline()
        {
            int testNr = 0;
            
            // Create an instance of the XmlSerializer specifying type and namespace.
            TestSuiteXml ts = DeserializeSample();

            Assert.That(ts.Tests[testNr].Constraints[0], Is.TypeOf<EqualToXml>());
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).ResultSet, Is.Not.Null);
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).ResultSet.Rows, Has.Count.EqualTo(2));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).ResultSet.Rows[0].Cells, Has.Count.EqualTo(3));
        }

        [Test]
        public void DeserializeEqualToResultSet_QueryFile1_ExternalFile()
        {
            int testNr = 1;
            
            // Create an instance of the XmlSerializer specifying type and namespace.
            TestSuiteXml ts = DeserializeSample();

            Assert.That(ts.Tests[testNr].Constraints[0], Is.TypeOf<EqualToXml>());
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).ResultSet, Is.Not.Null);
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).ResultSet.File, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void DeserializeEqualToKey_QueryFile2_List()
        {
            int testNr = 2;
            
            // Create an instance of the XmlSerializer specifying type and namespace.
            TestSuiteXml ts = DeserializeSample();

            Assert.That(ts.Tests[testNr].Constraints[0], Is.TypeOf<EqualToXml>());
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Keys, Has.Count.EqualTo(2));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Keys[0], Has.Property("Index").EqualTo(1));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Keys[1], Has.Property("Index").EqualTo(2));
        }

        [Test]
        public void DeserializeEqualToKey_QueryFile3_List()
        {
            int testNr = 3;

            // Create an instance of the XmlSerializer specifying type and namespace.
            TestSuiteXml ts = DeserializeSample();

            Assert.That(ts.Tests[testNr].Constraints[0], Is.TypeOf<EqualToXml>());
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Values, Has.Count.EqualTo(1));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Values[0], Has.Property("Index").EqualTo(3));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Values[0], Has.Property("Type").EqualTo(NBi.Xml.Constraints.EqualTo.ValueXml.TypeChoice.Numeric));
            Assert.That(((EqualToXml)ts.Tests[testNr].Constraints[0]).Values[0], Has.Property("Tolerance").EqualTo(10));
        }

    }
}
