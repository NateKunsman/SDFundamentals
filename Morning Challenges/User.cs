using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenges
{
    [TestClass]
    public class User 
    {
        public User() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; }

        public DateTime BirthDate { get; set; }

        public void FullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
