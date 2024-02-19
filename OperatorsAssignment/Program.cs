using System;

namespace OperatorsAssignment
{
    class Program
    {
        public static int Id { get; private set; }

        public static void Main(string[] args)
        {/* In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.Then compare the two Employee objects using the newly overloaded operators and display the results.*/

            Employee employeeA = new Employee();
                employeeA.Id = 5004;
                employeeA.FirstName = "Joe";
                employeeA.LastName = "Jones";

            Employee employeeB = new Employee();
               employeeB.Id = 5004;
                employeeB.FirstName = "Joe";
               employeeB.LastName = "James";

            checkId(employeeA, employeeB);
        

       static void checkId(Employee employeeA, Employee employeeB)
        
                {
                    if (employeeA != employeeB)
                 
                    {
                        Console.WriteLine("Everything checks out and your Id number is valid.");
                    }
                    if (employeeA == employeeB)
                    {
                        Console.WriteLine("There is an error and you have a duplicate employee Id number.");
                    }
                }
            }
          
        
    }
}
