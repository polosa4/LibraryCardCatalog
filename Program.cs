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
            Console.Clear();
            int option = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. List All books");
                Console.WriteLine("2. Add a book ");
                Console.WriteLine("3. Save and Exit");
                string inputChoice = Console.ReadLine();
                int.TryParse(inputChoice, out option);
                switch (option)
                {
                    case 1:
                        foreach (var book in newCatalog.ListBooks())
                        {
                            Console.WriteLine("{0}{ 1}{ 2}", book.Author, book.Title, book.Year);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the book author name");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the book title name");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the book year");
                        string year = Console.ReadLine();
                        newCatalog.books.Add(new Book { Author = author, Title = title, Year = year });
                        break;
                    case 3:
                        newCatalog.Save(fileName);
                        break;
                }
            } while (option != 3);
        }
    }
} 



    //        newCatalog.books.Add(new Book { Title = "CodingTemple", Author = "Joan Rowling" });
           
    //        newCatalog.books.Add(new Book { Title = "Hello World"});
    //        newCatalog.Save(fileName);

    //    }

    //        //var myBookList = new List<Book>();
    //        //myBookList.Add(new Book
    //        //{
    //        //    Author = "Name",
    //        //    Title = "Title",
    //        //    Year = 2013
    //        //});

         

    //    }
    //}

