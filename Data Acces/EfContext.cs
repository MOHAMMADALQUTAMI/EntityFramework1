using System.Collections.Immutable;
using System;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data_Acces
{
    public class EfContext:DbContext
    {
        public DbSet<Employee>? Employees {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql("host=localhost ;port=5432; Database=postgres; username=postgres; password=MUNIA&12 ;IncludeErrorDetail=true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().ToTable("Employees");
    }
}
}