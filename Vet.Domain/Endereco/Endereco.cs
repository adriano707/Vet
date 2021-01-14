using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Endereco
{
    public class Endereco
    {
        public Guid Id { get; private set; }
        public Bairro Bairro { get; private set; }
        public Cidade Cidade { get; private set; }
        public Estado Estado { get; private set; }
        public string CEP { get; private set; }
        public string Numero { get; private set; }
        public string Rua { get; private set; }
        public string Complemento { get; private set; }

        public Endereco(Bairro bairro, Cidade cidade, Estado estado, string cep, string numero, string rua, string complemento)
        {
            Id = Guid.NewGuid();
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro)); 
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            CEP = cep ?? throw new ArgumentNullException(nameof(cep));
            Numero = numero;
            Rua = rua ?? throw new ArgumentNullException(nameof(rua));
            Complemento = complemento;
        }
    }
}
