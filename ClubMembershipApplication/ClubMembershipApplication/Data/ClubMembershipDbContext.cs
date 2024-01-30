using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    internal class ClubMembershipDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder) 
        {

            optionbuilder.UseSqlite($"Data Source ={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
           
            base.OnConfiguring(optionbuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
