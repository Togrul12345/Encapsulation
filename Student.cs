using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        public string _name;
        public int _age;

        public string GetName
        {
            get { return _name; }
            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("uygun deyil");
                }
            }

        }
        public int GetAge
        {
            get { return _age; }
            set
            {
                
                if (value < 17)
                {
                    
                    Console.WriteLine($"student's age is less");
                }
                else
                {
                    _age = value;
                   
                }
            }
        }
    }

}






