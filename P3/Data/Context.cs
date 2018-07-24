using P3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace P3.Data
{
    public class Context : DbContext
    {
       public DbSet<Contact> Contacts { get; set; }
    }
}