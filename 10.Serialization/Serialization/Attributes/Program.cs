using Attributes.CustomAttributes;
using Attributes.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ShowAllAttributes;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.ShowTypeAttributes:
                    var attribute = new AttributesExample();
                    ExamplesRunner<AttributesExample>.ShowTypeAttributes(attribute);
                    break;
                case ExamplesEnumeration.ShowMethodsAttributes:
                    ExamplesRunner<AttributesExample>.ShowMethodsAttributes(new AttributesExample());
                    break;
                case ExamplesEnumeration.ShowPropertiesAttributes:
                    ExamplesRunner<AttributesExample>.ShowPropertiesAttributes(new AttributesExample());
                    break;
                case ExamplesEnumeration.ShowAllAttributes:
                    ExamplesRunner<AttributesExample>.ShowAllAttributes(new AttributesExample());
                    break;
            }


            Console.Read();
        }
    }
}
