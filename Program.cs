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
            string fileName = Console.ReadLine();

            CardCatalog newCatalog = new CardCatalog(fileName);
            newCatalog.BookName = "HarryPoter";
            newCatalog.Save(fileName);

          

         
        }

    }
}

