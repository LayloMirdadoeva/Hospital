using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Branches<T>
    {
        public T Id { get; set; }
        public T DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int NurseId { get; set; }
        public Nurse Nurse { get; set; }
        public int RoomNumber { get; set; }


    }
}
