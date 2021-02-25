using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EmployeeModel;


namespace mydbclass2.DBoperations
{
    public class employeeRepository
    {
        public int Addemployee( employee emp)
        {

            using (EmployeeDBEntities context = new EmployeeDBEntities())
            {
                EmpDBtable empobj = new EmpDBtable()
                {
                    Address = emp.Address,
                    Email = emp.Email,
                    FullName = emp.FullName,
                    Country =emp.Country
                   
                };


                context.EmpDBtables.Add(empobj);
                context.SaveChanges();
                return empobj.id;
                
             }


        }



    }

}

