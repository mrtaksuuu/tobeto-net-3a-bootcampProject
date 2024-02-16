using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Employee
    {
        public string Position { get; set; }
        public int UserId { get; set; }


        public Employee() 
        {
        
        }

        public Employee(string position, int userId)
        {
            Position = position;
            UserId = userId;
        }
    }
}
