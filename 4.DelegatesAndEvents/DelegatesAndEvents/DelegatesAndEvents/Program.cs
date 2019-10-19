using Delegates.DelegatesExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.DelegatesBasicSyntaxShow;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.DelegatesBasicSyntaxShow:
                    BasicSyntaxDelegate.ShowDelegate();
                    break;
            }

            Console.Read();
        }
    }
}
