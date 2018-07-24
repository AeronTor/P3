using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using P3.Models;

namespace P3.Data
{
    public class ContactInitializer : DropCreateDatabaseAlways<Context>
    {
        //Initialize database with seed data
        protected override void Seed(Context context)
        {
            var contact1 = new Contact()
            {
                ID = 1,
                FirstName = "Tony",
                LastName = "Smith",
                Email = "tonysmith@hotmail.com"
            };

            var contact2 = new Contact()
            {
                ID = 2,
                FirstName = "Sally",
                LastName = "Roger",
                Email = "sroger01@hotmail.com"
            };

            var contact3 = new Contact()
            {
                ID = 3,
                FirstName = "Crazy",
                LastName = "Eighty-Eight",
                Email = "thecrazyeightyeight@gmail.com"
            };

            var contact4 = new Contact()
            {
                ID = 4,
                FirstName = "Tomy",
                LastName = "Smith",
                Email = "tomysmith@hotmail.com"
            };

            context.Contacts.Add(contact1);
            context.Contacts.Add(contact2);
            context.Contacts.Add(contact3);
            context.Contacts.Add(contact4);

            context.SaveChanges();

        }
    }

}