using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace CSharp_CrudWPF
{
    /// <summary>
    /// Interaction logic for EmployeeAddForm.xaml
    /// </summary>
    public partial class EmployeeAddForm : Window
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        clsEmployeeDB employeeDB = new clsEmployeeDB();

        public EmployeeAddForm()
        {
            InitializeComponent();
            cn = new MySqlConnection(employeeDB.dbcon());
        }
    }
}
