using System.Xml.Serialization;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    class CardCatalog
    {
        private string _filename;
        private string books;
        public CardCatalog(string fileName)
        {
            _filename = fileName;
            if (File.Exists(fileName))
            {
                // test
            }
        }
        public void Save(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(CardCatalog));
                XML.Serialize(stream, this);
            }
        }
    }
}
