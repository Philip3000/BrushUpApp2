using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpApp2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? toString { get; set; }
        public enum GenderType { Male, Female }
        public override string ToString()
        {
            toString = $"{Id},{Name}";
            return toString;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException();
            }
            if (Name.Length == 0)
            {
                throw new ArgumentException();
            }
        }
        public void Validate()
        {
            ValidateName();
        }
    }
}
