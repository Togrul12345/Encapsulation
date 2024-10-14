using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        public string _name;
        public int _age;
        public DateTime _birthday;
        public DateTime datetime
        {
            get { return _birthday; }
            set
            {
                if (value.Year < 2000)
                {
                    _birthday = value;
                }
                else
                {
                    Console.WriteLine("uygun deyil");
                }
            }
        }
    }
}
