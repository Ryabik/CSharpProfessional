using Delegates.DelegatesExamples;
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.DelegateAnounymousMethodVsLambda;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.DelegatesBasicSyntaxShow:
                    BasicSyntaxDelegate.ShowDelegate();
                    break;
                case ExamplesEnumeration.DelegateShortSyntax:
                    ShortSyntaxDelegate.ShowShortSyntax();
                    break;
                case ExamplesEnumeration.DelegateNonStatic:
                    NonStaticDelegate.ShowNonStaticDelegate();
                    break;
                case ExamplesEnumeration.DelegateCombined:
                    CombinedDelegates.ShowCombinedDelegate();
                    break;
                case ExamplesEnumeration.DelegateAnonymousMethod:
                    AnonymousMethodsDelegate.ShowAnonymousMethod();
                    break;
                case ExamplesEnumeration.DelegateAnonymousMethodReturn:
                    AnonymousMethodsDelegate.MethodWithReturnType();
                    break;
                case ExamplesEnumeration.DelegateLambdaExpression:
                    LambdaExpressionDelegate.ShowLambdaExpression();
                    break;
                case ExamplesEnumeration.DelegateAnounymousMethodVsLambda:
                    LambdaExpressionDelegate.AnonymousMethodVsLambda();
                    break;
            }

            Console.Read();
        }
    }
}
