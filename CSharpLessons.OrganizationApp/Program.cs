﻿using System;
using System.Collections.Generic;
using CSharpLessons.OrganizationModel;

namespace CSharpLessons.OrganizationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();

            var taxOffice = new TaxOffice();

            var alice = new Employee() { Name = "Alice", Title = "Test Engineer" };
            var bruce = new Employee() { Name = "Bruce", Title = "Developer" };
            var chloe = new Manager() { Name = "Chloe", Title = "Program Manager" };
            var doris = new Employee() { Name = "Doris", Title = "Build Engineer" };
            var ethan = new Manager() { Name = "Ethan", Title = "Release Manager" };
            var frank = new Manager() { Name = "Frank", Title = "Director" };

            var organization = new Organization();
            organization.AddEmployee(alice, chloe, taxOffice);
            organization.AddEmployee(bruce, chloe, taxOffice);
            organization.AddEmployee(chloe, frank, taxOffice);
            organization.AddEmployee(doris, ethan, taxOffice);
            organization.AddEmployee(ethan, frank, taxOffice);
            organization.AddEmployee(frank, null, taxOffice);
            organization.Director = frank;

            organization.FireEmployee(bruce);
            Console.WriteLine(organization);

            // organization.PrintEmployeeCards();
            // System.Console.WriteLine("--- TAX PAYERS: ---");
            // taxOffice.PrintTaxPayers();


            End();
        }

        static void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
