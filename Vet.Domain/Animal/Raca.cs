﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Animal
{
    public class Raca
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Especie Especie { get; set; }

        public Raca() { }

        public Raca(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }
    }
}
