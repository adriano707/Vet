﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.AnimalDto
{
    public class RacaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Especie Especie { get; set; }
    }
}
