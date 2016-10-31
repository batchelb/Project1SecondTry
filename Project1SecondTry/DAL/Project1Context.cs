using Project1SecondTry.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1SecondTry.DAL
{
    public class Project1Context : DbContext
    {
        public Project1Context() : base("Project1Context")
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
    }
}