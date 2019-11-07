using LINQ.LinqExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ExtensionMethodSyntax;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicSyntax:
                    BasicSyntax.ShowBasicSyntaxLinq();
                    break;
                case ExamplesEnumeration.GenderCondition:
                    BasicSyntax.ShowConditionWithGender();
                    break;
                case ExamplesEnumeration.ExtensionMethodSyntax:
                    ExtensionMethodSyntax.ShowExtensionMethodSyntax();
                    break;
            }

            Console.Read();
        }
    }
}