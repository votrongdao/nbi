﻿using System.Collections.Generic;
using NBi.NUnit;
using NBi.Xml;
using NUnit.Framework;

namespace NBi.Testing.Xml
{
    [TestFixture]
    public class PlayConstraintTest
    {
        protected string _connectionString;

        #region Setup & Teardown

        [SetUp]
        public void SetUp()
        {
            //If available use the user file
            if (System.IO.File.Exists("ConnectionString.user.config"))
            {
                _connectionString = System.IO.File.ReadAllText("ConnectionString.user.config");
            }
            else if (System.IO.File.Exists("ConnectionString.config"))
            {
                _connectionString = System.IO.File.ReadAllText("ConnectionString.config");
            }
        }

        [TearDown]
        public void TearDown()
        {
        }

        #endregion
        
        [Test]
        public void TestCase_Play_Success()
        {
            var constraint = new SyntacticallyCorrectConstraint(_connectionString);
            var testCase = new TestCaseXml() { Sql = "SELECT * FROM Product;" };

            testCase.Play(constraint);
            Assert.Pass();
        }

        [Test]
        public void Test_Play_Success()
        {
            var t = new TestXml()
            {
                Constraints = new List<AbstractConstraintXml>() { new SyntacticallyCorrectXml() { ConnectionString = _connectionString } },
                TestCases = new List<TestCaseXml>() { new TestCaseXml() { Sql = "SELECT * FROM Product;" } }
            };

            t.Play();

            Assert.Pass();
        }
    }
}