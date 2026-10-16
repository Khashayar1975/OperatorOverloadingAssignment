using System;

// Define the Employee class
public class Employee
{
    // Property to store the employee's ID
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; } = "";

    // Property to store the employee's last name
    public string LastName { get; set; } = "";

    // Overload the == operator to compare employees by ID
    public static bool operator ==(Employee? employee1, Employee? employee2)
    {
        // If both references point to the same object, return true
        if (ReferenceEquals(employee1, employee2))
            return true;

        // If either employee is null, return false
        if (employee1 is null || employee2 is null)
            return false;

        // Compare employee IDs
        return employee1.Id == employee2.Id;
    }

    // Overload the != operator
    public static bool operator !=(Employee? employee1, Employee? employee2)
    {
        // Return the opposite of the == comparison
        return !(employee1 == employee2);
    }

    // Override Equals to maintain consistent equality behavior
    public override bool Equals(object? obj)
    {
        // Check whether obj is an Employee with the same ID
        return obj is Employee other && Id == other.Id;
    }

    // Override GetHashCode to match the equality comparison
    public override int GetHashCode()
    {
        // Generate a hash code using the employee ID
        return Id.GetHashCode();
    }
}
