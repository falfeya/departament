using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depaartet
{
    internal class Staff : Employee //дочерний класс
    {
        public string post { get; set; }
        public int salary { get; set; }
        public Staff()
        {
          
        }
        public Staff(string fullName) : base(fullName)
        {
            Position = "Сотрудник";
            Salary = 30000;
        }

    }
}
