using System;
using System.Collections.Generic;

namespace Vet.Domain.Animal
{
    public class Animal
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        private List<AnimalVacina> _aninalVacina;   

        public Animal(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            _aninalVacina = new List<AnimalVacina>();
        }

    }
}
