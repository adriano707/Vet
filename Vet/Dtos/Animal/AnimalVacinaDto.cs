using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;
using Vet.Domain.Produto;

namespace Vet.Dtos.AnimalDto
{
    public class AnimalVacinaDto
    {
        public Guid Id { get; set; }
        public Produto.Vacinas Vacina { get; set; }
        public double Dose { get; set; }
        public double Peso { get; set; }
        public DateTimeOffset Data { get; set; }
        public DateTimeOffset DataReforco { get; set; }
        public DateTimeOffset DataVencimento { get; set; }
        public Pessoa.Veterinario Veterinario { get; set; }
    }
}
