using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Vet.Domain.Animal;

namespace Vet.Data
{
    class DataContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
    }
}
