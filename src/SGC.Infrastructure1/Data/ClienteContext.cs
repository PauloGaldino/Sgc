using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options){}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<ProfissaoCliente> ProfissoesClientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Configurações do Cliente
            //mapeamento
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>().Property(c => c.CPF)
                .HasColumnType("varchar (11)")
                .IsRequired();
            #endregion

            #region Configurações do Contato

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

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

            #region Configurações do Endereço
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar (200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Complemento)
                .HasColumnType("varchar (100)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
               .HasColumnType("varchar (15)")
               .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
               .HasColumnType("varchar (200)")
               .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Cidade)
               .HasColumnType("varchar (200)")
               .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Estado)
               .HasColumnType("char (2)")
               .IsRequired();
            #endregion

            #region Configurações das Profissões
            modelBuilder.Entity<Profissao>().Property(e => e.Nome)
               .HasColumnType("varchar (200)")
               .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.Descricao)
               .HasColumnType("varchar (1000)")
               .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.CBO)
               .HasColumnType("varchar (200)")
               .IsRequired();
            #endregion

            #region Configurações ProfissaoCliente
            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(p => p.Cliente)
                .WithMany(p => p.ProfissoesClientes)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
               .HasOne(p => p.Profissao)
               .WithMany(p => p.ProfissoesClientes)
               .HasForeignKey(p => p.ProfissaoId);

            #endregion

            #region Configurações Menu
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(p => p.Cliente)
                .WithMany(p => p.ProfissoesClientes)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
               .HasOne(p => p.Profissao)
               .WithMany(p => p.ProfissoesClientes)
               .HasForeignKey(p => p.ProfissaoId);

            #endregion
        }
    }
}
