using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PratikInheritance
{
    public class Teacher : BasePerson
    {
        //Field Tanımlamaları
        private double _salary;//Maaş bilgisi küsüratlı olabileceği için double değişkeni ile tanımlandı
        //Propetry Tanımlamaları
        public double Salary { get; set; }//Maaş bilgisi küsüratlı olabileceği için double değişkeni ile tanımlandı

        public void SalaryDisplay()//Konsol ekranına bilgileri gösteren method
        {
            Console.WriteLine($"Maaş Bilgisi:{Salary}");
        }
    }
}
