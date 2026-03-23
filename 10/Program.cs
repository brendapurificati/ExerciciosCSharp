using System;
using System.Globalization;

namespace Exercise10
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Enter the first employee's name: ");
            e1.name = Console.ReadLine();
            Console.WriteLine("Enter the first employee's salary: ");
            e1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the second employee's name: ");
            e2.name = Console.ReadLine();
            Console.WriteLine("Enter the second employee's salary: ");
            e2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine($"First employee information:\nName: {e1.name}\nSalary: {e1.salary}");
            Console.WriteLine($"Second employee information:\nName: {e2.name}\nSalary: {e2.salary}");
            Console.WriteLine($"The average salary is: {(e1.salary + e2.salary)/2}.");
        }
    }
}