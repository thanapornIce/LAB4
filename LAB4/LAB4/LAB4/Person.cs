using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double GPA { get; set; }
        public Person(string name, int year, double GPA)
        {
            this.Name = name;
            this.Year = 2566 - year;
            this.GPA = GPA;
        }
    }
}

