using System;

namespace EntityFrameworkExample.EntityFrameworkExamples
{
    public static class GetData
    {
        public static void GetCharactersFromDb()
        {
            var dbContext = new CSharpAdvancedContext();            
            var characters = dbContext.Characters;

            foreach (var c in characters)
            {
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
            }          
        }

        //Самостоятельно создайте метод, который будет выводить персонажей из 
    }
}
