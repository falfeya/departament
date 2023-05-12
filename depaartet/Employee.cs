using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depaartet
{
    public class Employee //главный класс работников
    {
        public Employee(string fullName)
        {
            Id = ++count; //для записи айди
            FullName = fullName;
        }        
        public Employee()
        {

        }
        public static int count = 0;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
