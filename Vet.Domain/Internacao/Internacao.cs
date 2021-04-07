using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Internacao
{
    public class Internacao
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Data { get; private set; }
        public DateTimeOffset PrevisaoAlta { get; private set; }
        public string Animal { get; private set; }
        public string Observacoes { get; private set; }

        public Internacao() { }

        public Internacao(DateTimeOffset data, DateTimeOffset previsaoAlta, string animal, string observacoes)
        {
            Id = Guid.NewGuid();
            Data = DateTimeOffset.Now;
            PrevisaoAlta = previsaoAlta;
            Animal = animal;
            Observacoes = observacoes ?? throw new ArgumentException(nameof(observacoes));
        }
    }
}
