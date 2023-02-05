using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpApp2.Models
{
    public class Student : Person
    {
        public int Semester { get; set; }

        public override string ToString()
        {
            toString += Semester;
            return toString;
        }
       
        public void ValidateSemester()
        {
            if (Semester < 1)
            {
                throw new ArgumentException();
            }
            else if (Semester > 8)
            {
                throw new ArgumentException();
            }
        }
        public void Validate()
        {
            ValidateName();
            ValidateSemester();
        }
    }
}
