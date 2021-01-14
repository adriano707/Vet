using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Produto
{

    public class Tipo
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public Tipo(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Ativo = true;
        }

        /// <summary>
        /// Metodo para testar se nome já existe, caso o nome já exista p metodo retorna falso 
        /// e encerra o programa.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool MudarNome(string nome)
        {
            // se nome já existe encerra a função.
            if (nome == Nome) return false;
            // Se a condição fpr falsa será alterado o nome.
            Nome = nome;
            return true;
        }

        public void Ativar()
        {
            if (Ativo == false)
                Ativo = true;
        }

        public void Desativar()
        {
            if (Ativo == true)
                Ativo = false;
        }
    }
}
