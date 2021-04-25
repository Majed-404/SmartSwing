using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.Identity.Models
{
    public class TradSaveContext:DbContext
    {
        public TradSaveContext()
        {

        }
        public TradSaveContext(DbContextOptions<TradSaveContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        //public DbSet <Group> groups { get; set; }
        //public DbSet <UserGroup> Usergroups { get; set; }
        //public DbSet <AdminEmail> AdminEmails { get; set; }
    }
}
