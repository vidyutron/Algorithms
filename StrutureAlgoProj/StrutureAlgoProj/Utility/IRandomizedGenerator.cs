using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutureAlgoProj.Utility
{
    public interface IRandomizedGenerator
    {
        public int[] OpenNumberArray(int length);
        public List<int> OpenNumberList(int length);
        public double[] OpenDoubleArray(int length);
        public List<double> OpenDoubleList(int length);
        public string StringSequence(int length);
        public string AlphanumericSeqeunce(int length);
        public int[] HundredNumberArray();
        public int[] TenNumberArray();
        public double[] HundredDoubleArray();
        public double[] TenDoubleArray();
    }
}
