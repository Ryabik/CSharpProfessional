using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Examples;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.Background;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicTask:
                    TaskExample.ShowTask();
                    break;
                case ExamplesEnumeration.TaskStatus:
                    TaskExample.ShowTaskStatus();
                    break;
            }

            Console.Read();
        }
    }
}
