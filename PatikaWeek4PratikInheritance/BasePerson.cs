using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PratikInheritance
{
    public class BasePerson
    {
        //Field Tanımlamaları
        private string _name;
        private string _surname;
        
        //Propetry Tanımlamaları
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public void Display()//Konsol ekranına bilgileri gösteren method
        {
            Console.WriteLine($"Adı:{Name} Soyadı:{Surname}");
        }
    }


    
}
