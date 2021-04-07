using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    public class Cliente : Pessoa
    {
        public List<Animal.Animal> Animal { get; set; }

        public Cliente() { }

        public Cliente(string nome): base(nome)
        {
            Animal = new List<Animal.Animal>();
        }
    }
}