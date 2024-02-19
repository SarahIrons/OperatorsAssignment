using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName;
        public string LastName;

        //Create an Employee class with Id, FirstName and LastName properties.
        //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.Remember that comparison operators must be overloaded in pairs.
        public static bool operator ==(Employee employeeA, Employee employeeB)
        {
            if (employeeA.Id.Equals(employeeB.Id))
                return true;
            else return false;
        }
        
        public static bool operator !=(Employee employeeA, Employee employeeB)
        {
            if (employeeA.Id.Equals(employeeB.Id))
                return false;
            else return true;

        }
        
    }
}
