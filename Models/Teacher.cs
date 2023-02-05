using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpApp2.Models
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public List<string>? Classes { get; set; }
        

        public override string ToString()
        {
            toString += Salary;
            return toString;
        }
        public void ValidateSalary()
        {
            if (Salary <= 0)
            {
                throw new ArgumentException();
            }
        }
        public void ValidateClasses()
        {
            if (Classes == null)
            {
                throw new ArgumentNullException();
            }
        }

        public new void Validate()
        {
            ValidateName();
            ValidateSalary();
            ValidateClasses();
        }
    }
}
