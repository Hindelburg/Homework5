﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Address
    {
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Customer Number")]
        public int customerNum { get; set; }
        [Display(Name = "DOB")]
        public DateTime dob { get; set; }
        [Display(Name = "Full Name")]
        public string fullName { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string st { get; set; }
        [Display(Name = "Zip Code")]
        public int zip { get; set; }
        [Display(Name = "Street")]
        public string street { get; set; }
        [Display(Name = "Current Date")]
        public DateTime currentDate { get; set; }
    }
}