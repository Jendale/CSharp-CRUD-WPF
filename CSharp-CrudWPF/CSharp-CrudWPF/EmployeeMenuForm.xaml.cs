﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace CSharp_CrudWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEmployeeAddForm_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddForm employeeAddForm = new EmployeeAddForm();
            employeeAddForm.ShowDialog();
        }
    }
}
