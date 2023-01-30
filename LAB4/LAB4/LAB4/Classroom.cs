using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Classroom
    {
        public List<Person> PersonList = new List<Person>();
        public List<int> YearList = new List<int>();
        public List<double> GPAList = new List<double>();
        public List<string> NameList = new List<string>();

        public void addPerson(Person p)
        {
            PersonList.Add(p);
            YearList.Add(p.Year);

        }
        public string ShowPerson()
        {
            string results = "";
            foreach (var p in PersonList)
            {
                results += p.Name + "\n";
            }
            return results;
        }
        public int ShowAllAge()
        {

            return YearList.Sum();
        }

        public void SetGPA()
        {
            foreach (var p in PersonList)
            {
                GPAList.Add(p.GPA);
                NameList.Add(p.Name);
            }
        }
        public double ShowGPAMax()
        {
            return GPAList.Max();
        }
        public double ShowGPAMin()
        {
            return GPAList.Min();
        }

        public string ShowGPAMaxName2()
        {
            return NameList[GPAList.IndexOf(GPAList.Max())];
        }
        public string ShowGPAMinName3()
        {
            return NameList[GPAList.IndexOf(GPAList.Min())];



        }    
    }
}
