using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace depaartet
{
    public class DepartamentGenerator
    {
        public static ObservableCollection<Depart> departaments = new ObservableCollection<Depart>();
        private static readonly Random _random = new Random();
        public DepartamentGenerator()
        {
           
        }
        public static ObservableCollection<Depart> GenerateDepartaments()
        {
            // Создаем работников и добавляем их в департаменты
            for (int i = 1; i <= 10; i++)
            {
                var departament = new Depart(i);
                for (int j = 1; j <= 500; j++)
                {
                    int a = _random.Next(1,4); //выбирается случайное число от 1 до 3
                    if (a == 1) //если генерирует 1, то создается новый экземпляр класса Стафф с именем Иван
                    {
                        var Staff = new Staff("Иванов Иван Иванович");                      
                        departament.Employees.Add(Staff);
                    }
                    else if (a == 2)  //если генерирует 2, то создается новый экземпляр класса Менеджер с именем Андрей
                    {
                        var Manager = new Manager("Петров Андрей Андреевич");
                        departament.Employees.Add(Manager);
                    }
                    else if (a == 3)  //если генерирует 3, то создается новый экземпляр класса Директор с именем Александр
                    {
                        var Director = new Director("Блок Александр Александрович");
                        departament.Employees.Add(Director);
                    }
                }
                departaments.Add(departament); //добавление в коллекцию департаментов
            }           
            return departaments; //возврат коллекции департаментов 
        }
    }
}

