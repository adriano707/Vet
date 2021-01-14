using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    public class Empresa : Pessoa
    {
        public string NomeRazaoSocial { get; private set; }
        public string Complemento { get; private set; }
        public string NomeFantasia { get; private set; }
        public string CNPJ { get; private set; }
        public string IE { get; private set; }
        public string Telefone { get; private set; }

        public Empresa(string nome, string razaoSocial, string nomeFantasia, 
            string complemento, string cnpj, string ie, string telefone) : base(nome)
        {
            NomeRazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Complemento = complemento;
            CNPJ = cnpj;
            IE = ie;
            Telefone = telefone;
        }
    }
}
