using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp
{
    internal class Student
    {
        public int rollNo;
        public string name;
        public double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value > 0 ? value : 0; }  //if value is greater than zero assign value to rollno else assign 0.
        }
        public string Name
        {
            get { return name; }
            set { name = value.Length >= 5 ? value : string.Empty; }
        }

        // cgpa 
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = (value >= 1 && value <= 10) ? value : 0; }
        }
       //method for percentage
        public double GetPercentage()
        {
            return Cgpa * 10;
        }
        //  override ToString method to display student details
        public override string ToString()
        {
            return $"Roll No: {RollNo}, Name: {Name}, CGPA: {Cgpa}, Percentage: {GetPercentage()}%";
        }
    }
}