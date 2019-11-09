﻿using LINQ.HelpMaterial;
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
                Console.WriteLine(adult.ToString());            
        }

        public static void DefferedExecution()
        {
            var characters = PersonsService.GetPersons();

            var adults = characters.Where(character => character.FirstName.StartsWith("A"));

            characters.Add(new Person("Andrew", "Harlan", true, 37));

            //Запрос выполняется в момент его использования
            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}
