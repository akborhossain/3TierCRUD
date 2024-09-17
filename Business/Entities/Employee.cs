using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public  required string Email { get; set; }
        public string? Address { get; set; }
    }
}
