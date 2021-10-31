﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab11.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer then 50 characters.")]
        [Column("First Name")]

        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}