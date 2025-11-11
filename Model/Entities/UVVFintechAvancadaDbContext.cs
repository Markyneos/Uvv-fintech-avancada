using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model.Entities
{
    internal class UVVFintechAvancadaDbContext : DbContext
    {
        public string DbPath { get; }

        public UVVFintechAvancadaDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "UVVFintechAvancada.db");
        }

        public DbSet<Banco> BancoS { get; set; }
        public DbSet<Calendario> CalendarioS { get; set; }
        public DbSet<Cliente> ClienteS { get; set; }
        public DbSet<Compromisso> CompromissoS { get; set; }
        public DbSet<Corrente> CorrenteS { get; set; }
        public DbSet<Depositar> DepositarS { get; set; }
        public DbSet<GerenciadorDeClientes> GerenciadorDeClientesS { get; set; } 
        public DbSet<GerenciadorDeContas> GerenciadorDeContasS { get; set; }
        public DbSet<GerenciadorDeTransacoesCliente> GerenciadorDeTransacoesClienteS { get; set; }
        public DbSet<GerenciadorDeTransacoesBanco> GerenciadorDeTransacoesBancoS { get; set; }
        public DbSet<Poupanca> PoupancaS { get; set; }
        public DbSet<Sacar> SacarS { get; set; }
        public DbSet<Transferir> TransferirS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tabela de Bancos
            modelBuilder.Entity<Banco>().ToTable("Banco");
            modelBuilder.Entity<Banco>().Property(b => b.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Banco>().Property(b => b.Nome).IsRequired();
            modelBuilder.Entity<Banco>().HasKey(b => b.Id);
            modelBuilder.Entity<Banco>().HasOne<Calendario>().WithOne().HasForeignKey("CalendarioId");
            modelBuilder.Entity<Banco>().HasOne<GerenciadorDeClientes>().WithOne();
            modelBuilder.Entity<Banco>().HasOne<GerenciadorDeContas>().WithOne();
            modelBuilder.Entity<Banco>().HasOne<GerenciadorDeTransacoesBanco>().WithOne();

            //Tabela de Calendários
            modelBuilder.Entity<Calendario>().ToTable("Calendario");
            modelBuilder.Entity<Calendario>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Calendario>().HasKey(c => c.Id);
            modelBuilder.Entity<Calendario>().HasMany<Compromisso>().WithOne();
            modelBuilder.Entity<Calendario>().HasOne<Banco>().WithOne().HasForeignKey("BancoId");

            //Tabela de Clientes
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Cliente>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Cliente>().Property(c => c.Nome).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Cpf).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Rua).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Numero).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Complemento).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Bairro).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Cidade).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Senha).IsRequired();
            modelBuilder.Entity<Cliente>().HasOne<GerenciadorDeTransacoesCliente>().WithOne().HasForeignKey("GerenciadorTransacoesCliente");
            modelBuilder.Entity<Cliente>().HasMany<Conta>().WithOne();
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

            //Tabela de Compromissos
            modelBuilder.Entity<Compromisso>().ToTable("Compromisso");
            modelBuilder.Entity<Compromisso>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Compromisso>().Property(c => c.Nome);
            modelBuilder.Entity<Compromisso>().Property(c => c.Descricao);
            modelBuilder.Entity<Compromisso>().Property(c => c.Datahora).IsRequired();
            modelBuilder.Entity<Compromisso>().HasOne<Calendario>().WithMany().HasForeignKey();
            modelBuilder.Entity<Compromisso>().HasKey(c => c.Id);

            //Tabela de Conta Corrente
            modelBuilder.Entity<Corrente>().ToTable("Corrente");
            modelBuilder.Entity<Corrente>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Corrente>().Property(c => c.Senha).IsRequired();
            modelBuilder.Entity<Corrente>().Property(c => c.Saldo).HasDefaultValue(0);
            modelBuilder.Entity<Corrente>().Property(c => c.TaxaDeRendimento);
            modelBuilder.Entity<Corrente>().HasOne<Cliente>().WithMany().HasForeignKey("ClienteId");
            modelBuilder.Entity<Corrente>().HasOne<Banco>().WithMany().HasForeignKey("IdBanco");
            modelBuilder.Entity<Corrente>().HasKey(c => c.Id);

            //Tabela da Conta Poupança
            modelBuilder.Entity<Poupanca>().ToTable("Corrente");
            modelBuilder.Entity<Poupanca>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Poupanca>().Property(p => p.Senha).IsRequired();
            modelBuilder.Entity<Poupanca>().Property(p => p.Saldo).HasDefaultValue(0);
            modelBuilder.Entity<Poupanca>().Property(p => p.TaxaDeRendimento).IsRequired();
            modelBuilder.Entity<Poupanca>().HasOne<Cliente>().WithMany().HasForeignKey("ClienteId");
            modelBuilder.Entity<Poupanca>().HasOne<Banco>().WithMany().HasForeignKey("IdBanco");
            modelBuilder.Entity<Poupanca>().HasKey(p => p.Id);

            //Tabela da Transação Depositar
            modelBuilder.Entity<Depositar>().ToTable("Depositar");
            modelBuilder.Entity<Depositar>().Property(d => d.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Depositar>().Property(d => d.DataHora).IsRequired();
            modelBuilder.Entity<Depositar>().Property(d => d.Valor).IsRequired();
            modelBuilder.Entity<Depositar>().HasOne<Conta>().WithMany().HasForeignKey("ContaId");
            modelBuilder.Entity<Depositar>().HasKey(d => d.Id);

            //Tabela do Gerenciador de Clientes
            modelBuilder.Entity<GerenciadorDeClientes>().ToTable("GerenciadorDeClientes");
            modelBuilder.Entity<GerenciadorDeClientes>().Property(g => g.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<GerenciadorDeClientes>().HasOne<Banco>().WithOne().HasForeignKey("IdBanco");
            modelBuilder.Entity<GerenciadorDeClientes>().HasMany<Cliente>().WithMany();
            modelBuilder.Entity<GerenciadorDeClientes>().HasKey(g => g.Id);

            //Tabela do Gerenciador de Contas


        }

    }
}
