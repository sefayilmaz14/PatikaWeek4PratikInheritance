using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PratikInheritance
{
    public class Student : BasePerson
    {
        //Field Tanımlamaları
        private int _studentNumber;
        
        //Propetry Tanımlamaları
        public int StudentNumber { get; set; }

        public void StudentNumberDisplay()//Konsol ekranına bilgileri gösteren method
        {
            Console.WriteLine($"Öğrenci Numarası:{StudentNumber}");
        }
    }
}
