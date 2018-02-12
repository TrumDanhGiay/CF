using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name ="Name")]
        [MaxLength(256)]
        public String name { get; set; }

        public int Status {get; set; }

        public int Status2 { get; set; }
    }
}