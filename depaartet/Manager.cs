using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace depaartet
{
    public class Manager : Employee //дочерний класс
    {
        public string post { get; set; }
        public int salary { get; set; }
        public Manager()
        {
            
        }
        public Manager(string fullName) : base(fullName)
        {
            Position = "Менеджер";
            Salary = 50000;
        }
    }
}
