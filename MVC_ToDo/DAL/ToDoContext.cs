using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_ToDo.Models;


namespace MVC_ToDo.DAL
{
    public class ToDoContext :DbContext
    {
        public ToDoContext(): base("connectionString")
        {

        }
        public DbSet<ToDo> ToDo { get; set; }
    }
}