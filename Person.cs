using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkSınıfPratigi
{
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
        public void WriteInfo()
        {
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Birthday: " + birthday.ToShortDateString());
        }
       
    }
}
