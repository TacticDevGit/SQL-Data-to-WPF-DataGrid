using System;
using System.Collections.Generic;

#nullable disable

namespace DataGrid_to_SQL
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
