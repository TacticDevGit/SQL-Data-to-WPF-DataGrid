using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace DataGrid_to_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> MyEmployees { get; set; }

        public MainWindow()
        {
            InitializeComponent();


            using (AppdataContext _context = new AppdataContext())
            {
                MyEmployees = _context.Employees.ToList();
            }

            EmployeesList.ItemsSource = MyEmployees;
        }

        

    }
}
