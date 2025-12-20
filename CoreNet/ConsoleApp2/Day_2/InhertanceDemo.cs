// Define the namespace for organizing related classes
namespace ConsoleApp2.Day_2
{
    // Internal class means it is accessible only within this assembly
    internal class InhertanceDemo
    {
        #region Inheritance
        // Base class Person
        public class Person
        {
            // Field to store the name of the person
            public string name = "abc";

            // Field to store the age of the person
            public int age = 10;
        }

        // Derived class Employee inherits from Person
        public class Employee : Person
        {
            // Field to store employee ID
            public int emp_id = 101;
        }
        #endregion

        #region Main method
        // Entry point of the program
        static void Main(string[] args)
        {
            // Create an object of Employee class
            Employee emp = new Employee();

            // Access inherited fields (name, age) and Employee-specific field (emp_id)
            // Print them to the console
            Console.WriteLine("Name : {0}, Age : {1}, ID : {2}", emp.name, emp.age, emp.emp_id);
        }
        #endregion
    }
}
