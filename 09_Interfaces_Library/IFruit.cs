using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }

        string Peel();
    }
    public class Pear : IFruit
    {
        public Pear() { }
        public Pear(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        
        public string Name { get { return "Pear"; } }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            return "You grab a peeler and peel the pear";
        }
    }
    public class Grapefruit : IFruit
    {
        public Grapefruit() { }
        public Grapefruit(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name { get { return "Grapefruit"; } }

        public bool IsPeeled { get; set; }
        public string Peel()
        {
            IsPeeled = true;
            return "you peeled a Grapefruit";
        }
        public string Squeeze()
        {
            return "You squeeze the grapefruit to make juice";
        }
    }
        public class Strawberry : IFruit
        {
            public string Name { get { return "Strawberry"; } }

            public bool IsPeeled { get; } = false;

            public string Peel()
            {
                return "Do you really peel strawberries?";
            }
        }
    }

