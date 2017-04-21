using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    public class CardCatalog                    // creating a new CardCatalog and inherit the Book class
    {
        
        private string _filename;                      // declaring a new attribute 
        public List<Book> books;                       // declaring a new attribute List that is going to list out book class

        //private string books;

        //public CardCatalog()
        //{

        //}
        public CardCatalog(string fileName)
        {
            _filename = fileName;
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    using (XmlReader reader = XmlReader.Create(fs))
                    {
                        books = (List<Book>)serializer.Deserialize(reader);
                    }
                }

            }
            else
            {
                books = new List<Book>();
            }
        }
        
        

        public List<Book> ListBooks()
        {
            return books;
        }
        public void Save(string fileName)   //declaring a constructor to save new xml file which takes a string parameter 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));   //creating a new xml serializer that is going to take a List of books

            using (FileStream fs = new FileStream(_filename, FileMode.Create))   //calling a new FileStream class that is going to take all included data stored in a filename and create a new file called fileName
            {
                using (XmlWriter writer = XmlWriter.Create(fs))
                {
                    serializer.Serialize(writer, books);
                }
            }
        }


    }
}
