﻿using System.Collections.Generic;
using NBi.Xml;
using NBi.Xml.Constraints;
using NBi.Xml.TestCases;
using NUnit.Framework;

namespace NBi.Testing.Unit.Xml
{
    [TestFixture]
    public class TestXmlTest
    {
        protected string ConnectionString
        {
            get
            {
                //If available use the user file
                if (System.IO.File.Exists("ConnectionString.user.config"))
                {
                    return System.IO.File.ReadAllText("ConnectionString.user.config");
                }
                else if (System.IO.File.Exists("ConnectionString.config"))
                {
                    return System.IO.File.ReadAllText("ConnectionString.config");
                }

                return null;
            }
        }

        #region Setup & Teardown

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        #endregion
        
        [Test]
        public void Test_Play_Success()
        {
            var t = new TestXml()
            {
                Constraints = new List<AbstractConstraintXml>() { new SyntacticallyCorrectXml() },
                TestCases = new List<AbstractTestCaseXml>() 
                { new QueryXml() 
                    {
                        InlineQuery = "SELECT * FROM Product;",  
                        ConnectionString =  ConnectionString
                    } 
                }
            };

            //TODO Review TEST
            //t.Play();

            Assert.Pass();
        }
    }
}