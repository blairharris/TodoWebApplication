using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TodoWebApplication.Models;

namespace TodoWebApplication.DAL
{
    public class TodoInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<TodoContext>
    {
        protected override void Seed(TodoContext context)
        {
            var users = new List<User>
            {
                new User { Name = "Blair", Email = "jbh@gmail.com" },
                new User { Name = "Vicky", Email = "vics" }
            };

            foreach( User user in users)
            {
                context.Users.Add(user);
            }
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}