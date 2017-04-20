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
    public class CardCatalog : Book
    {
        public string BookName { get; set; }
        public string _filename;
        //private string books;

        public CardCatalog()
        {

        }
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
        
        public List<Book> books;
        public void Save(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Book>));
                XML.Serialize(stream, this);
            }
        }

       
    }
}
