using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TE_DFA.Models
{
    public partial class Employee
    {
        [Key]
        public int Eid { get; set; }

        [Required(ErrorMessage = "Enter the Employee Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Ename { get; set; }

        [Required(ErrorMessage = "Enter the Employee age")]
        [Range(21, 45, ErrorMessage = "Not Eligible")]
        public int? Eage { get; set; }

        [Required(ErrorMessage = "Enter the Employee Designation")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Designation must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Edes { get; set; }
    }
}
