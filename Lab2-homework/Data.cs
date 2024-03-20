using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    internal static class Data
    {
        public static List<Visitor> Visitors = new List<Visitor>();
        public static List<Employee> Employees = new List<Employee>();

        public static void addEmployee(Employee employee)
        {
            
            if (Employees.Contains(employee))
            {
                Guid employeeID = employee.id;
                int index = Employees.FindIndex(x => x.id == employeeID);
                Employees[index].SetActive(true);
                Console.WriteLine("The employee already exists, but it was set as active!");
            }
            else
            {
                Employees.Add(employee);
                Console.WriteLine("Employee added!");
            }
        }

        public static void removeEmployee(Guid employeeID)
        {
            int index = Employees.FindIndex(x => x.id == employeeID);
            if (index != -1)
            {
                Employees[index].SetActive(false);
                Console.WriteLine("The employee " + Employees[index].name +" is deactivated!");
            }
            else Console.WriteLine("The employee doesn't exist!");
        }

        public static void addVisitor(Visitor visitor)
        {
            if (Visitors.Contains(visitor))
            {
                Guid visitorID = visitor.id;
                int index = Visitors.FindIndex(x => x.id == visitorID);
                Visitors[index].SetActive(true);
                Console.WriteLine("The visitor already exists, but it was set as active!");
            }
            else
            {
                Visitors.Add(visitor);
                Console.WriteLine("Visitor added!");
            }
        }

        public static void removeVisitor(Guid visitorID)
        {
            int index = Visitors.FindIndex(x => x.id == visitorID);
            if (index != -1)
            {
                Visitors[index].SetActive(false);
                Console.WriteLine("The visitor " + Visitors[index].name + " is deactivated!");
            }
        }

        //Give a role to an employee, for our case: Designer, Developer, Manager, Cybersecurity Analyst
        public static void makeDesigner(Guid employeeID, String graphicalTabletID)
        {
            int index = Employees.FindIndex(x => x.id == employeeID);
            if (index != -1)
            { // Employee found
                Employee employee = Employees[index];
                Designer designer = new Designer(employee, graphicalTabletID);
                Employees[index] = designer;
                Console.WriteLine("The employee " + employee.name +" is now a Designer!");
            }
            else
            {
                Console.WriteLine("The employee doesn't exist!");
            }
        }

        public static void makeDeveloper(Guid employeeID)
        {

            int index = Employees.FindIndex(x => x.id == employeeID);
            if (index != -1)
            { // Employee found
                Employee employee = Employees[index];
                Developer developer = new Developer(employee);
                Employees[index] = developer; 
                Console.WriteLine("The employee " + employee.name +" is now a Developer!");
            }
            else
            {
                Console.WriteLine("The employee doesn't exist!");
            }
        }

        public static void makeManager(Guid employeeID)
        {
            int index = Employees.FindIndex(x => x.id == employeeID);
            if (index != -1)
            { // Employee found
                Employee employee = Employees[index];
                Manager manager = new Manager(employee);
                Employees[index] = manager;
                Console.WriteLine("The employee " + employee.name +" is now a Manager!");
            }
            else
            {
                Console.WriteLine("The employee doesn't exist!");
            }
        }

        public static void makeCybersecurity(Guid employeeID)
        {
            int index = Employees.FindIndex(x => x.id == employeeID);
            if (index != -1)
            { // Employee found
                Employee employee = Employees[index];
                Cybersecurity cybersecurity = new Cybersecurity(employee);
                Employees[index] = cybersecurity;
                Console.WriteLine("The employee " + employee.name + " is now a Cybersecurity Analyst!");
            }
            else
            {
                Console.WriteLine("The employee doesn't exist!");
            }
        }
    }
}
