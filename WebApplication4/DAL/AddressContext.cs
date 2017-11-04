using WebApplication4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class AddressContext : DbContext
    {
        public AddressContext() : base("name=OurDBContext")
        { }

        public virtual DbSet<Address> Addresses { get; set; }
    }
}