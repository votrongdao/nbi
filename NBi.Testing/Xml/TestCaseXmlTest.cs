﻿using System.Collections.Generic;
using NBi.NUnit;
using NBi.Xml;
using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace NBi.Testing.Xml
{
    [TestFixture]
    public class TestCaseXmlTest
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
        public void TestCase_Play_Success()
        {
            var constraint = new SyntacticallyCorrectConstraint();
            var testCase = new TestCaseXml() 
                { InlineQuery = "SELECT * FROM Product;" ,
                  ConnectionString =  ConnectionString 
                };

            testCase.Play(constraint);
            Assert.Pass();
        }

        [Test]
        public void TestCase_sql_RetrieveContentOfFile()
        {
            //create a text file on disk
            var filename = DiskOnFile.CreatePhysicalFile("QueryFile.sql", "NBi.Testing.Xml.Resources.QueryFile.sql");
           
            //Instantiate a Test Case and specify to find the sql in the fie created above
            var testCase = new TestCaseXml() { Filename = filename };

            // A Stream is needed to read the text file from the assembly.
            string expectedContent;
            using (Stream stream = Assembly.GetExecutingAssembly()
                                           .GetManifestResourceStream("NBi.Testing.Xml.Resources.QueryFile.sql"))
                using (StreamReader reader = new StreamReader(stream))
                   expectedContent = reader.ReadToEnd();
            
            Assert.AreEqual(expectedContent, testCase.Query);
        }

        
    }
}