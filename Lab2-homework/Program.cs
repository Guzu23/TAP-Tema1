using System;

namespace Lab2_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var visitor1 = new Visitor("Dan1 danut", "danut1zdan@gmail.com", "danutboss1");
            var visitor2 = new Visitor("Dan2 danut", "danut2zdan@gmail.com", "danutboss2");
            var visitor3 = new Visitor("Dan3 danut", "danut3zdan@gmail.com", "danutboss3");

            Data.addVisitor(visitor1);
            Data.addVisitor(visitor2);
            Data.addVisitor(visitor3);

            Console.WriteLine("Total visitors: " + Data.Visitors.Count);
            Console.WriteLine("Total active visitors: " + Data.Visitors.Count(x =>x.isActive));

            Data.removeVisitor(visitor1.id);

            Console.WriteLine("After deleting visitor1: ");
            Console.WriteLine("Total visitors: " + Data.Visitors.Count);
            Console.WriteLine("Total active visitors: " + Data.Visitors.Count(x => x.isActive));

            var employee1 = new Employee("Guzu Razvan1", "guzurazvan1@ymail.com", "parola1", 4000, "WD41", "Image1");
            var employee2 = new Employee("Guzu Razvan2", "guzurazvan2@ymail.com", "parola2", 4000, "WD42", "Image2");
            var employee3 = new Employee("Guzu Razvan3", "guzurazvan3@ymail.com", "parola3", 4000, "WD43", "Image3");
            var employee4 = new Employee("Guzu Razvan4", "guzurazvan4@ymail.com", "parola4", 4000, "WD45", "Image4");
            var employee5 = new Employee("Guzu Razvan5", "guzurazvan5@ymail.com", "parola5", 4000, "WD45", "Image5");

            Data.addEmployee(employee1);
            Data.addEmployee(employee2);
            Data.addEmployee(employee3);
            Data.addEmployee(employee4);
            Data.addEmployee(employee5);

            Console.WriteLine("Total employees: " + Data.Employees.Count);
            Console.WriteLine("Total active employees: " + Data.Employees.Count(x => x.isActive));

            Data.removeEmployee(employee1.id);

            Console.WriteLine("After deleting employee1: ");
            Console.WriteLine("Total employees: " + Data.Employees.Count);
            Console.WriteLine("Total active employees: " + Data.Employees.Count(x => x.isActive));


            Data.makeDeveloper(employee2.id);

            var employee = Data.Employees.FirstOrDefault(x => x.id == employee2.id);
          
            if (employee is Developer) Console.WriteLine("The employee is indeed a developer!");
            else Console.WriteLine("Not a developer");

            Console.WriteLine("\nEmployees list: ");
            foreach (var employed in Data.Employees)
            {
                Console.WriteLine($"ID: {employed.id}, Name: {employed.name}");
            }
            Console.WriteLine("");

            Data.Employees[3].login("guzurazvan4@ymail.com", "parola4");
            Data.Employees[3].SendNotification("Salut! Test!", "guzurazvan5@ymail.com");
            Data.Employees[3].logout();
            Console.WriteLine("");

            Console.WriteLine("Reading the previous email:");
            Data.Employees[4].emails[0].readEmail();
        }
    }
}
