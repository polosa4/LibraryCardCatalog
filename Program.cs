using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

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

                        Console.WriteLine("List of books in Card Catalog: ");

                        
                        if (File.Exists(fileName))
                        {
                            XDocument doc = XDocument.Load(fileName);

                            var books = doc.Descendants("Title");

                            foreach (var book in books)
                            {
                                Console.WriteLine(book.Value);

                            }
                        }
                        else
                        {
                            Console.WriteLine("File name does not exist. Select option number 2 to add books or 3 to exit. ");
                        }
                        
                        Console.ReadLine();

                   

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

