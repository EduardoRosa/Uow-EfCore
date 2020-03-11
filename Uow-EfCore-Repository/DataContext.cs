using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Uow_EfCore_Domain.Entities;
using Uow_EfCore_Mapping;

namespace Uow_EfCore_Repository
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Professor> Professores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessorMapping());
        }
    }
}
