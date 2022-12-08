using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     interface IToothache
     {
        void speed();
       
     }
    interface IFlu
    {
        void temperature();
    }
    interface ILungs
    {
        void xRen();
    }
    interface IKidneys
    {
        void ultrasound();
        void pressure();
    }
    interface ISomache
    {
        void ultrasound();
        void blood();
    }
}
