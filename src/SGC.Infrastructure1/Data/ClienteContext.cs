using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options){}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Configurações do Cliente
            modelBuilder.Entity<Cliente>().Property(c => c.CPF)
                .HasColumnType("varchar (11)")
                .IsRequired();
            #endregion

            #region Configurações do Contato
            modelBuilder.Entity<Contato>().Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Email)
                .HasColumnType("varchar (100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Telefone)
                .HasColumnType("varchar (20)")
                .IsRequired();

            #endregion
        }
    }
}
