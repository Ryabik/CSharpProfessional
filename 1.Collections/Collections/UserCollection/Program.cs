using System;
using System.Collections.Generic;
using System.Collections;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection collection = new UserCollection();
            collection.Array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (var element in collection)
                Console.WriteLine(element);

            Console.Read();
        }
    }
}
