using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class ExtensionMethodSyntax
    {
        public static void ShowExtensionMethodSyntax()
        {
            var characters = PersonsService.GetPersons();

            var adults = characters.Where(character => character.Age > 20);

            foreach (var adult in adults)
            {
                Console.WriteLine(adult.ToString());
            }
        }
    }
}
