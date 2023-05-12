using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace depaartet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            employeesDataGrid.ItemsSource = null; //метод для удаления данных
        }
        /*private void FillDataGrid(DataGrid dataGrid, Depart department, int count)
        {
            // Создаем список для хранения рандомных сотрудников
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            // Получаем рандомные сотрудники из департамента
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = rnd.Next(department.Employees.Count);
                employees.Add(department.Employees[index]);
            }
            // Заполняем DataGrid данными из списка сотрудников
            dataGrid.ItemsSource = employees;
        }*/

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {

            DepartamentGenerator.GenerateDepartaments(); //генерация списка отделов и их сотрудников 
            string path = "departaments.txt"; //создается в директории, где расположен выполняемый файл программы
            using (FileStream fs = new FileStream(path, FileMode.Append)) //открытие файлового потока и выполнение над ним операции записи
            {
                using (StreamWriter writer = new StreamWriter(fs)) //запись в файл
                {                   
                    foreach (Depart departament in DepartamentGenerator.departaments) //цикл для перебирания списка всех департаментов
                    {                       
                        foreach (Employee employee in departament.Employees) //цикл для перебирания списка всех сотрудников
                        {
                            writer.WriteLine($"ID: {employee.Id}");
                            writer.WriteLine($"ФИО: {employee.FullName}");
                            writer.WriteLine($"Позиция: {employee.Position}");
                            writer.WriteLine($"Зарплата: {employee.Salary}");
                        }
                    }
                }
            }    
            MessageBox.Show($"Данные сохранены {path}");                                  
        }
        private void LoadData_Click(object sender, RoutedEventArgs e)
        {                             
            DepartamentGenerator.GenerateDepartaments(); //генерации списка отделов и их сотрудников
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[1].Employees; //отображение списка сотрудников отдела с индексом 1
        }

        private void LoadData_Click1(object sender, RoutedEventArgs e)
        {
            DepartamentGenerator.GenerateDepartaments();
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[2].Employees;
        }

        private void LoadData_Click2(object sender, RoutedEventArgs e)
        {
            DepartamentGenerator.GenerateDepartaments();
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[3].Employees;
        }

        private void LoadData_Click3(object sender, RoutedEventArgs e)
        {
            DepartamentGenerator.GenerateDepartaments();
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[4].Employees;
        }

        private void LoadData_Click4(object sender, RoutedEventArgs e)
        {
            DepartamentGenerator.GenerateDepartaments();
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[5].Employees;
        }

        private void LoadData_Click5(object sender, RoutedEventArgs e)
        {
            DepartamentGenerator.GenerateDepartaments();
            employeesDataGrid.ItemsSource = DepartamentGenerator.departaments[6].Employees;
        }
    }
}

