﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLite.CodeFirst.Builder.NameCreators;

namespace SQLite.CodeFirst.Test.UnitTests.Builder.NameCreators
{
    [TestClass]
    public class IndexNameCreatorTest
    {
        [TestMethod]
        public void CreateIndexName()
        {
            string result = IndexNameCreator.CreateName("MyTable", "MyProperty");
            Assert.AreEqual("\"IX_MyTable_MyProperty\"", result);
        }

        [TestMethod]
        public void CreateIndexNameEscaped()
        {
            string result = IndexNameCreator.CreateName("\"base.MyTable\"", "MyProperty");
            Assert.AreEqual("\"IX_base.MyTable_MyProperty\"", result);
        }
    }
}
