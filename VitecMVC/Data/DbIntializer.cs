using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecMVC.Models;

namespace VitecMVC.Data
{
    public class DbIntializer
    {
        public static void Initialize(UserContext Context)
        {
            Context.Database.EnsureCreated();
            if (Context.User.Any())
            {
                return;
            }
            var User = new User[]
            {
                new User
                {
                    Firstname="Bent",
                    Lastname="Karlsen",
                    Phonenumber=88888888,
                    Email="Bentkarl@fuckme.com",
                    Adress="Lærkevej 28",
                    UserID=1
                }

            };
        }
    }
}
