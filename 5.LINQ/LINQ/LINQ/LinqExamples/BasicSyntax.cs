﻿using System;
using System.Linq;
using LINQ.HelpMaterial;

namespace LINQ.LinqExamples
{
    public static class BasicSyntax
    {
        public static void ShowBasicSyntaxLinq()
        {
            var characters = PersonsService.GetPersons();

            var adults = from character in characters
                         where character.Age > 20
                         select character;

            foreach (var adult in adults)            
                Console.WriteLine(adult.ToString());            
        }

        public static void ShowConditionWithGender()
        {
            var characters = PersonsService.GetPersons();

            var adults = from character in characters
                         where character.Gender == true
                         select character;

            foreach (var adult in adults)            
                Console.WriteLine(adult.ToString());            
        }

        //Самостоятельно сделать запрос Linq для отбора персонажей длинна имени которых равна длинне фамилии
    }
}
