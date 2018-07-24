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
        public Context()
        {
            //Initialize database with seed data from ContactInitializer.
            Database.SetInitializer(new ContactInitializer());
        }
       public DbSet<Contact> Contacts { get; set; }
    }
}