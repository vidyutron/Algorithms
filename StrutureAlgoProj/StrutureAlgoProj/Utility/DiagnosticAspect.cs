using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutureAlgoProj.Utility
{
    [Serializable]
    public class DiagnosticAspect: OnMethodBoundaryAspect
    {
        [NonSerialized]
        public Stopwatch _sw;
        public override void OnEntry(MethodExecutionArgs args)
        {
            //Console.WriteLine("The {0} method has been entered.", args.Method.Name);
            _sw = new Stopwatch();
            _sw.Start();
        }


        public override void OnExit(MethodExecutionArgs args)
        {
            _sw.Stop();
            Console.WriteLine($"The Execution took : {_sw.ElapsedMilliseconds} Milliseconds");
        }

    }
}
