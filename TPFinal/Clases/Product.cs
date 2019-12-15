using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
   
        public class Product
        {
            public string number { get; set; }
            public string name { get; set; }
            public string type { get; set; }

        public Product(string pNumber, string pName, string pType)
        {
            this.number = pNumber;
            this.name = pName;
            this.type = pType;
        }
    }
    
}
