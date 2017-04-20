using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the file: ");
            var userFilename = Console.ReadLine();
            if (userFilename != null) {
                Console.WriteLine();
            }

            var myBookList = new List<Book>();
            myBookList.Add(new Book
            {
                Author = "Name",
                Title = "Title",
                Year = 2013
            });

         

        }
    }
}
