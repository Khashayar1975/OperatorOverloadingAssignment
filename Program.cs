using System;

namespace EmployeeComparison
{
    internal class Program
    {
        // Main method is the entry point of the application.
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Create the second Employee object.
            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "David";
            employee2.LastName = "Brown";

            // Compare employees using overloaded == operator.
            bool areEqual = employee1 == employee2;

            // Compare employees using overloaded != operator.
            bool areNotEqual = employee1 != employee2;

            // Display comparison results.
            Console.WriteLine("Employees are equal: " + areEqual);
            Console.WriteLine("Employees are not equal: " + areNotEqual);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}
