using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CrudWPF
{
    class clsEmployeeDB
    {
        public string dbcon()
        {
            string conn = "server=localhost; user id=root; password=; database=employeedb";

            return conn;
        }
    }
}
