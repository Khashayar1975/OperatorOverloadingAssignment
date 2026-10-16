using System;

// Create the first Employee object
Employee employee1 = new Employee();

// Assign values to the first employee
employee1.Id = 101;
employee1.FirstName = "John";
employee1.LastName = "Smith";

// Create the second Employee object
Employee employee2 = new Employee();

// Assign values to the second employee
employee2.Id = 101;
employee2.FirstName = "David";
employee2.LastName = "Johnson";

// Display information about the first employee
Console.WriteLine("Employee 1:");
Console.WriteLine($"ID: {employee1.Id}");
Console.WriteLine($"Name: {employee1.FirstName} {employee1.LastName}");

// Display information about the second employee
Console.WriteLine("\nEmployee 2:");
Console.WriteLine($"ID: {employee2.Id}");
Console.WriteLine($"Name: {employee2.FirstName} {employee2.LastName}");

// Compare employees using the overloaded == operator
Console.WriteLine("\nAre employees equal?");
Console.WriteLine(employee1 == employee2);

// Compare employees using the overloaded != operator
Console.WriteLine("\nAre employees different?");
Console.WriteLine(employee1 != employee2);

// Keep the console window open until a key is pressed
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();