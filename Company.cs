using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();
        public Company(string name, DateTime createdOn){
            Name = Name;
            CreatedOn = createdOn;
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public void ListEmployees(){
            foreach (Employee employee in this.Employees){
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {this.Name} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
};



// Expand on the Company class code by
// Adding an Employees property (Its type should be List<Employee>)
// Setting the value of Employees in the constructor as a new List<Employee> (News Flash: Declaring a property gives it an initial vlaue of null). This will allow you to add newly created employees to the Employees list in the final step below.
// Create an Employee.cs file and then define a class for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)
// The Company class should also have a ListEmployees() method which writes a string to the console about each employee, such as "Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."
// In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.