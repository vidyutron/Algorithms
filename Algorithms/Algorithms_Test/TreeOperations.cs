using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.DS.Trees;

namespace Algorithms_Test
{
    [TestClass]
    public class TreeOperations
    {
        [TestMethod]
        public void CreateBST_Test()
        {
            var obj = new CommonOperations();
            obj.CreateBST();
        }
    }
}
