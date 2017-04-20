﻿using System.Xml.Serialization;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        public string BookName { get; set; }
        private string _filename;
        private string books;

        public CardCatalog()
        {

        }
        public CardCatalog(string fileName)
        {
            _filename = fileName;
            if (File.Exists(fileName))
            {
                
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
