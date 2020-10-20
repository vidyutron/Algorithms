using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutureAlgoProj.Utility
{
    public class RandomizedGenerator : IRandomizedGenerator
    {
        private Random _randomObj;
        private int _min;
        private int _max;
        private string CHARSET      = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string ALPHACHARSET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public RandomizedGenerator(int min=0,int max=20)
        {
            _randomObj = new Random();
            _min = min;
            _max = max;
        }

        public string AlphanumericSeqeunce(int length)
        {
            return new string(Enumerable.Repeat(ALPHACHARSET, length)
                .Select(s => s[_randomObj.Next(s.Length)]).ToArray());
        }

        public double[] HundredDoubleArray()
        {
            return Enumerable
            .Repeat(0, 100)
            .Select(i => _randomObj.NextDouble()* (_max - _min) + _min)
            .ToArray();
        }

        public int[] HundredNumberArray()
        {
            return Enumerable
            .Repeat(0, 100)
            .Select(i => _randomObj.Next(_min,_max))
            .ToArray();
        }

        public double[] OpenDoubleArray(int length)
        {
            return Enumerable
            .Repeat(0, length)
            .Select(i => _randomObj.NextDouble() * (_max - _min) + _min)
            .ToArray();
        }

        public List<double> OpenDoubleList(int length)
        {
            return Enumerable
            .Repeat(0, length)
            .Select(i => _randomObj.NextDouble() * (_max - _min) + _min)
            .ToList();
        }

        public int[] OpenNumberArray(int length)
        {
            return Enumerable
            .Repeat(0, length)
            .Select(i => _randomObj.Next(_min, _max))
            .ToArray();
        }

        public List<int> OpenNumberList(int length)
        {
            return Enumerable
            .Repeat(0, length)
            .Select(i => _randomObj.Next(_min, _max))
            .ToList();
        }

        public string StringSequence(int length)
        {
            return new string(Enumerable.Repeat(CHARSET, length)
                .Select(s => s[_randomObj.Next(s.Length)]).ToArray());
        }

        public double[] TenDoubleArray()
        {
            return Enumerable
            .Repeat(0, 10)
            .Select(i => _randomObj.NextDouble() * (_max - _min) + _min)
            .ToArray();
        }

        public int[] TenNumberArray()
        {
            return Enumerable
            .Repeat(0, 10)
            .Select(i => _randomObj.Next(_min, _max))
            .ToArray();
        }
    }
}
