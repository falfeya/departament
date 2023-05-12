using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depaartet
{
    public class Depart
    {
        public int DepartamentNumber { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }
        public Depart(int departamentNumber) 
        {
            DepartamentNumber = departamentNumber;
            Employees = new ObservableCollection<Employee>(); //новый экземлпяр класса, который используется для хранения списка сотрудников в этом департаменте
        }           
    }
}
