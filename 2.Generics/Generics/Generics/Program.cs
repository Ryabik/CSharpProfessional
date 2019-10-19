using System;
using Generics.Examples;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.BasicAccount;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicAccount:
                    Account basicAccount = new Account(5);
                    basicAccount.ShowSum();
                    basicAccount.GetSum();
                    break;
                case ExamplesEnumeration.GenericAccount:
                    Account<double> genericAccount = new Account<double>(5.23);
                    genericAccount.ShowSum();
                    genericAccount.GetSum();
                    break;
                case ExamplesEnumeration.DoubleGenericAccount:
                    Account<string, int> doubleGenericAccount = new Account<string, int>("35", 332);
                    doubleGenericAccount.ShowData();
                    doubleGenericAccount.GetData();
                    break;
            }

            Console.Read();
        }
    }
}
