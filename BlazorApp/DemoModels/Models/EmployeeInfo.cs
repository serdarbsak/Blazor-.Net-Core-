using System;
using System.Collections.Generic;

namespace DemoModels.Models
{
    public partial class EmployeeInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Company { get; set; }
    }
}
