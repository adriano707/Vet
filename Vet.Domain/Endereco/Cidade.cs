﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Endereco
{
    public class Cidade
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Cidade() { }

        public Cidade(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }
    }
}
