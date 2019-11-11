using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class OrderByClause
    {
        public static void ShowOrederBy()
        {
            var characters = PersonsService.GetPersons();

            var adults = from character in characters
                         orderby character.FirstName 
                         select character;

            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }

        public static void OrderByExtensionSyntax()
        {
            var characters = PersonsService.GetPersons();

            var adults = characters.Where(x => x.Age > 20).OrderByDescending(x => x.Gender).ThenBy(x => x.FirstName);

            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}
