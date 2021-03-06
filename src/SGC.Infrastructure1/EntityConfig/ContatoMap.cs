﻿using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Contato> builder)
        {

            builder
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(e => e.Nome)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(e => e.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(e => e.Telefone)
               .HasColumnType("varchar(15)");
        }
    }
}
