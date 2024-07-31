using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkSınıfPratigi
{
    // Creating the class property's.
    public class Person
    {
        public string name;
        public string surname;
        public DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string SurName
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public DateTime BirthDay
        {
            get
            { 
                return birthday;
            }
            set
            {
                birthday = value;
            }
        
        }
        // Writing on the secreen that student and teacher property's class
        public void WriteInfo()
        {
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Birthday: " + birthday.ToShortDateString());
        }
       
    }
}
