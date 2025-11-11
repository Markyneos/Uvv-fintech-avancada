using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model.Entities
{
    internal class BancoDbContext : DbContext
    {
        public DbSet<Banco>? BancoS { get; set; }
        public DbSet<Calendario> CalendarioS { get; set; }
        public DbSet<Cliente> ClienteS { get; set; }
        public DbSet<Compromisso> CompromissoS { get; set; }
        public DbSet<Corrente> CorrenteS { get; set; }
        public DbSet<Depositar> DepositarS { get; set; }
        public DbSet<GerenciadorDeClientes> GerenciadorDeClientesS { get; set; } 
        public DbSet<GerenciadorDeContas> GerenciadorDeContasS { get; set; }
        public DbSet<GerenciadorDeTransacoes> GerenciadorDeTransacoesS { get; set; }
        public DbSet<Poupanca> PoupancaS { get; set; }
        public DbSet<Sacar> SacarS { get; set; }
        public DbSet<Transferir> TransferirS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Server=(localdb)\\mssqllocaldb;Database=UVVFintechAvancada;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            model
        }

    }
}
