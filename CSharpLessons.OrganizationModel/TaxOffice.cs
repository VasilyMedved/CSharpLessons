using System;
using System.Collections.Generic;

namespace CSharpLessons.OrganizationModel
{
    public class TaxOffice
    {
        private List<IEmployee> _taxPayers = new List<IEmployee>();

        public List<IEmployee> taxPayers {get{return _taxPayers;}}

        public void RegisterEmployee(IEmployee employee)
        {
            _taxPayers.Add(employee);
            Console.WriteLine($"Now pay taxes, {employee}!!!");
        }

        public void PrintTaxPayers(){
            foreach(IEmployee emp in _taxPayers){
                System.Console.WriteLine(emp);
            }
        }
    }
}
