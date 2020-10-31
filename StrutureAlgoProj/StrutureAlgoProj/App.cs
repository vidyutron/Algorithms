using Microsoft.Extensions.Configuration;
using StrutureAlgoProj.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutureAlgoProj
{
    public class App
    {
        private readonly IConfiguration _config;
        private IRandomizedGenerator _randGen;

        public App(IConfiguration config,IRandomizedGenerator randGen)
        {
            _config = config;
            _randGen = randGen;
        }

        public void Run()
        {
            //Console.WriteLine($"Randomly Generated String : {_randGen.StringSequence(54)}");
            //Console.WriteLine("Hello from App.cs");

            //var smeArrya = _randGen.OpenNumberArray(45680);

            TestRun();
            Console.ReadLine();
        }

        [DiagnosticAspect]
        private void TestRun()
        {
            int sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
        }
    }
}
