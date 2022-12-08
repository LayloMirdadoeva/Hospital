using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Booking
    {
        public int Id { get; set; } 
        public string ClientName { get; set; }
        public string Branch { get; set; }
        public string Date { get; set; }

        public void Branches()
        {
            Console.WriteLine("Number is 54");
                
        }
    }
}
