using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public virtual string Info => $"Id: {Id}, FirsName: {FirstName},LastName: {LastName}, PhoneNumber: {Phone}";

        public virtual void Sick()
        {
            Console.WriteLine("Person is sick");
        }
    }
}
