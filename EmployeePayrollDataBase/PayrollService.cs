using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollDataBase
{
    public class PayrollService
    {
        public static SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog = Payroll_Service; integrated security = true ");

        public static void CheckConnection()
        {
            using (SqlConnection con1 = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog = Payroll_Service; integrated security = true "))
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}
