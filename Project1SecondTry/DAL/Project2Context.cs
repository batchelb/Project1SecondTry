using Project1SecondTry.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1SecondTry.DAL
{
    public class Project2Context : DbContext
    {
        public Project2Context() : base("Project2Context")
        {

        }

        public DbSet<DegreeQuestions> DegreeQuestion { get; set; }
        public DbSet<Degrees> Degree { get; set; }
        public DbSet<Users> User { get; set; }
    }
}