using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using TodoWebApplication.Models;

namespace TodoWebApplication.DAL
{
    public class TodoInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<TodoContext>
    {
        protected override void Seed(TodoContext context)
        {
        }
    }
}