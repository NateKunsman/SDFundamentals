using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public class Banana : IFruit
    {
        public Banana () { }
        public Banana(bool isPeeled) 
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peeled a banana";
        }

    }
}
