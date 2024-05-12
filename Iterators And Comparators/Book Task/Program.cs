using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book onebooks = new Book("Animal Farm", 2003, "George Orwell");
            Book twobooks = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book threbook = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(onebooks, twobooks, threbook);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
}
