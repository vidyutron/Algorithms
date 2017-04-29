using Algorithms.HackerRank.DS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Test
{
    [TestClass]
    public class HackerRank
    {
        [TestMethod]
        public void TwoDArray_Test()
        {
            var sampleArray = new int[,] { { 1, 1, 1, 0, 0, 0 },
                                           { 0, 1, 0, 0, 0, 0 },
                                           { 1 ,1, 1, 0, 0, 0 },
                                           { 0 ,0, 2, 4, 4, 0 },    
                                           { 0 ,0, 0, 2, 0, 0 },
                                           { 0 ,0, 1, 2, 4, 0 } };
            var twodArray = new TwodArray(sampleArray);
        }
    }
}
