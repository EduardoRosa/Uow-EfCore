using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_Mapping
{
    public class ProfessorMapping : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> entity)
        {
            entity.ToTable("Professores");
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Ativo)
                .HasColumnName("");
                
        }
    }
}
