using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Vet.Domain.Animal;
using Vet.Domain.Consulta;
using Vet.Domain.Endereco;
using Vet.Domain.Financeiro;
using Vet.Domain.Internacao;
using Vet.Domain.Login;
using Vet.Domain.Pessoa;
using Vet.Domain.Produto;

namespace Vet.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DbSet<AnimalVacina> AnimalVacina { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Dieta> Dieta { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Habitat> Habitat { get; set; }
        public DbSet<Internacao> Internacao { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Pelo> Pelo { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Porte> Porte { get; set; }
        public DbSet<Procedimento> Procedimento { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Vacinas> Vacinas { get; set; }
        public DbSet<Cliente> Cliente { set; get; }

        public DataContext()
        { 
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
