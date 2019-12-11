using NetCoreWebApp.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Models.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public List<Character> Characters { get; private set; }

        public CharacterRepository()
        {
            GenerateCharacters();
        }

        public void GenerateCharacters()
        {
            Characters = new List<Character>();

            Characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = Gender.Male, Age = 14 });
            Characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = Gender.Male, Age = 25 });
            Characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = Gender.Female, Age = 2700 });
            Characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = Gender.Female, Age = 29 });
            Characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = Gender.Male, Age = 42 });
            Characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = Gender.Male, Age = 29 });
            Characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = Gender.Female, Age = 827 });
            Characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = Gender.Female, Age = 45 });
            Characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = Gender.Male, Age = 42 });
            Characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = Gender.Male, Age = 35 });
        }
    }
}
