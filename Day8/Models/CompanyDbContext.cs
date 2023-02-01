﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day8.Models
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext()
        {

        }
        public CompanyDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dependent> Dependents { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Works_On> Works_s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Identity;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Works_On>().HasKey("ESSN", "proNumber");
            modelBuilder.Entity<Location>().HasKey("location", "deptNumber");
            modelBuilder.Entity<Dependent>().HasKey(s => new { s.Name, s.SSN });
            modelBuilder.Entity<Employee>().HasOne(s => s.Works_For).WithMany(n => n.EmpWork);
            modelBuilder.Entity<Employee>().HasOne(s => s.Manage).WithOne(s=>s.EmpManage);
        }
    }
}
