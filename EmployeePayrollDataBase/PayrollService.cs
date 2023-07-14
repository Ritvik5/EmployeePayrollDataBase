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

        public static List<Employee> employees = new List<Employee>();


        public static void CheckConnection()
        {
            using (SqlConnection con1 = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog = Payroll_Service; integrated security = true "))
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }

        public bool Display()
        {
            try
            {
                using (con)
                {
                    Employee model = new Employee();
                    string query = "SELECT * FROM Employee_Payroll";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("-----------Data-------------");
                        while (reader.Read())
                        {
                            model.Id = Convert.ToInt32(reader["ID"]);
                            model.Name = Convert.ToString(reader["Name"]);
                            model.Salary = Convert.ToDecimal(reader["Salary"]);
                            model.StartDate = Convert.ToDateTime(reader["StartDate"]);
                            model.Phone = Convert.ToString(reader["Phone"]);
                            model.Address = Convert.ToString(reader["Address"]);
                            model.BasicPay = Convert.ToDecimal(reader["BasicPay"]);
                            model.Deductions = Convert.ToDecimal(reader["Deductions"]);
                            model.TaxablePay = Convert.ToDecimal(reader["TaxablePay"]);
                            model.NetPay = Convert.ToDecimal(reader["NetPay"]);
                            employees.Add(model);
                            foreach (var obj in employees)
                            {
                                Console.WriteLine("Id         = " + obj.Id);
                                Console.WriteLine("Name       = " + obj.Name);
                                Console.WriteLine("Salary     = " + obj.Salary);
                                Console.WriteLine("StartDate  = " + obj.StartDate);
                                Console.WriteLine("Phone      = " + obj.Phone);
                                Console.WriteLine("Address    = " + obj.Address);
                                Console.WriteLine("BasicPay   = " + obj.BasicPay);
                                Console.WriteLine("Deductions = " + obj.Deductions);
                                Console.WriteLine("TaxablePay = " + obj.TaxablePay);
                                Console.WriteLine("NetPay     = " + obj.NetPay);

                                Console.WriteLine("\n-----------Record-------------\n");
                            }
                        }
                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went Wrong" + ex);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
