using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLessons.OrganizationModel
{
    public class Organization
    {
        private List<IEmployee> _employees = new List<IEmployee>();

        public IEnumerable<IEmployee> Employees => _employees;

        public IEmployee Director { get; set; }

        public void AddEmployee(IEmployee employee, Manager manager, TaxOffice taxOffice)
        {

            _employees.Add(employee);
            taxOffice.RegisterEmployee(employee);
            if (manager != null)
            {
                manager.AddEmployee(employee);
            }
        }

        public void FireEmployee (IEmployee employee) {
            try {
                _employees.Remove(employee);
                }
            catch (Exception e) {
                System.Console.WriteLine(e);
            };
            
            
        }

        public void PrintEmployeeCards()
        {
            foreach(var employee in _employees)
            {
                Console.WriteLine(employee.EmployeeCard);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            AppendEmployee(sb, Director, 0);
            return sb.ToString();
        }

        private void AppendEmployee(StringBuilder sb, IEmployee employee, int level)
        {
            sb.Append(employee);
            sb.AppendLine();
            foreach(var childEmployee in employee.Employees)
            {
                sb.Append(new string('\t', level + 1));
                AppendEmployee(sb, childEmployee, level + 1);
            }
        }
    }
}