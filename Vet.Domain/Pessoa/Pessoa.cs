using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    public class Pessoa
    {
        private List<Endereco.Endereco> _enderecos;
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public IReadOnlyCollection<Endereco.Endereco> Endereco => _enderecos;

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            _enderecos = new List<Endereco.Endereco>();
        }

        public bool AdicionarEndereco(Endereco.Endereco endereco) {
            _enderecos.Add(endereco);
            return true;
        }

    }
}
