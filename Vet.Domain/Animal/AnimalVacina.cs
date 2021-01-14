using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Animal
{
    class AnimalVacina
    {
        public Guid Id { get; private set; }
        public Produto.Vacinas Vacina { get; private set; }
        public double Dose { get; private set; }
        public double Peso { get; private set; }
        public DateTimeOffset Data { get; private set; }
        public DateTimeOffset DataReforco { get; private set; }
        public DateTimeOffset DataVencimento { get; set; }
        public Pessoa.Veterinario Veterinario { get; private set; }

        public AnimalVacina(Produto.Vacinas vacina, double dose, double peso, DateTimeOffset data, DateTimeOffset dataReforco, DateTimeOffset dataVencimento, Pessoa.Veterinario veterinario)
        {
            Id = Guid.NewGuid();
            Vacina = vacina ?? throw new ArgumentNullException(nameof(vacina)); 
            Dose = dose;
            Peso = peso;
            Data = data;
            DataReforco = dataReforco;
            DataVencimento = dataVencimento;
            Veterinario = veterinario;
        }
    }
}
