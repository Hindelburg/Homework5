using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Address
    {
        public int id { get; set; }
        public int customerNum { get; set; }
        public DateTime dob { get; set; }
        public string fullName { get; set; }
        public string city { get; set; }
        public string st { get; set; }
        public int zip { get; set; }
        public string street { get; set; }
        public DateTime currentDate { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}: {fullName} DOB = {dob} Current Date = {currentDate} Customer Number = {customerNum} Address = {street} {city} {st} {zip}";
        }
    }
}