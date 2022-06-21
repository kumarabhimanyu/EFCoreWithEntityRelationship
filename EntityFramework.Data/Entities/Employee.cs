﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Data.Entities
{
    public class Employee

    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? Address { get; set; }

        public ICollection<EmployeeEducation> EducationList { get; set; }

    }
}
