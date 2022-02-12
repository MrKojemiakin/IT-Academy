using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SurveyApp.Models.Entities;
using System.Data.SqlClient;

namespace SurveyApp.Data.Context
{
    public class SurveyDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Variant> Variants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SurveyAppDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }

       //// protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
       //     base.OnModelCreating(modelBuilder);
       //     modelBuilder
       //     .Entity<User>()
       //     .HasMany(p => p.Surveys)j
       //     .WithMany(p => p.Users)
       //     .UsingEntity(j => j.ToTable("PostTags"));
       // }


    }
}
