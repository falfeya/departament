using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depaartet
{
    public class Director : Employee //дочерний класс
    {
        public string post { get; set; }
        public int salary { get; set; }
        public Director() 
        {
            
        }
        public Director(string fullName) : base(fullName)
        {
            Position = "Директор";
            Salary = 100000;
        }
    }
}
