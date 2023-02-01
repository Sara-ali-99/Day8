﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Day8.Models
{
    public class Department
    {
        [Key]
        public int Number { get; set; }
        [Display(Name= "Department Name")]
        public string? Name { get; set; }
        public virtual List<Location>? locations { get; set; }
        public virtual List<Project>? projects { get; set; }
        public virtual List<Employee>? EmpWork { get; set; }
        [ForeignKey("EmpManage")]
        public virtual int? ESSN {get;set;}
        public virtual Employee EmpManage { get; set; }
    }
}
