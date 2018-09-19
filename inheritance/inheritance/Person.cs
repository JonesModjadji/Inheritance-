using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Person
    {
        public string Address;
        public int Age;
        public string City;
        public string Name;

        public Person(string CAdd,int CAge,string CCity,string CName)
        {
            Address = CAdd;
            Age = CAge;
            City = CCity;
            Name = CName;
        }

    }
}
