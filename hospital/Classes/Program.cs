using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Classes
{
    class Program
    {
        class Week : IEnumerable
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday","Friday" };

            public IEnumerator GetEnumerator()=>days.GetEnumerator();
            
        }

        internal class myPersonList<T>
        {

        }
        static void Main(string[] args)
        {
            var collections = new CollectionClass();
            collections.DictoinaryFunction();
            Console.ReadKey();

            #region
            //string[] DoctorsFullName = new string[] { "Yulduz Mirdadoeva", "Mubina Azimova", "Nurmatov Azim", "Aliev Sheroz" };
            //string[] NursesFullName = new string[] { "Shokirova Asliya", "Kodirova Safiya", "Saymatova Madina", "Alieva Munisa" };
            //string[] NameOfBranches = new string[] { "Leather", "Dentist", "Lore", "Therapist" };
            //string[] ClientFullName = new string[] { "Akramov Umed", "Mansuri Nilufar", "Naziri Parviz", "Dilshodi Shukrona" };

            //var Nurses = new List<Nurse>();
            //for (int i = 0; i < NursesFullName.Length; i++)
            //{
            //    var Nurse = new Nurse()
            //    {
            //        Id = i,
            //        FirstName = NursesFullName[i],
            //        Phone = "+992111442277"
            //    };
            //    Nurses.Add(Nurse);
            //}
            //var Doctors = new List<Doctor>();
            //for (int i = 0; i < DoctorsFullName.Length; i++)
            //{
            //    var Doctor = new Doctor()
            //    {
            //        Id = i,
            //        FirstName = DoctorsFullName[i],
            //        Profession = "dentist",
            //        RoomNumber = "5",


            //    };
            //    Doctors.Add(Doctor);


            //}

            //var Branches = new List<Branches>();
            //for (int i = 0; i < NameOfBranches.Length; i++)
            //{
            //    var Branch = new Branches()
            //    {
            //        Id = i,
            //        DoctorId = i,
            //        NurseId = i,
            //        RoomNumber = i,
            //    };
            //    Branches.Add(Branch);
            //}
            //var Clients = new List<Client>();
            //for (int i = 0; i < ClientFullName.Length; i++)
            //{
            //    var Client = new Client()
            //    {
            //        Id = i,
            //        FirstName = ClientFullName[i],
            //        Phone = "+992985152277",
            //    };
            //    Clients.Add(Client);
            //}

            //var Bookings = new List<Booking>();
            //for (int i = 0; i < ClientFullName.Length; i++)
            //{
            //    var Booking = new Booking()
            //    {
            //        Id = i,
            //        ClientName = ClientFullName[i],
            //        Branch = NameOfBranches[i],
            //        Date = "25",
            //    };
            //    Bookings.Add(Booking);
            //}
            #endregion

            //var client = new Client { Id = 2, FirstName = "Oisha", LastName = "Samieva", Phone = "+992884157777", TypeOfDisease = "Hert disease" };
            //PrintInfo(client);

            Week week = new Week();
            foreach(var day in week)
            {
                Console.WriteLine(day);
            }

            





        }
        #region
        //private static void PrintInfo(Client client)
        //{
        //    Console.WriteLine(client.Info);
        //}

        //static void SayNameDisease(Client client)
        //{
        //    client.Sick();
        //}


        //Doctor[] doctors = new Doctor[15];

        //myPersonList<Person> personList = new myPersonList<Person>();
        #endregion

        
           
        

            
        




    }
}
