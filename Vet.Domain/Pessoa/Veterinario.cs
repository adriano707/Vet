using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    public class Veterinario : Pessoa
    {
        public string CRMV { get; private set; }

        public Veterinario(string nome, string crmv) : base(nome)
        {
            CRMV = crmv ?? throw new ArgumentNullException(nameof(crmv)); ;
        }
    }
}
