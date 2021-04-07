using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;
using Vet.Domain.Consulta;
using Vet.Domain.Pessoa;
using Vet.Dtos.Animal;

namespace Vet.Dtos.Consulta
{
    public class ConsultaDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset DataInicio { get; set; }
        public PessoaDto Cliente { get; set; }
        public PessoaDto Veterinario { get; set; }
        public double Peso { get; set; }
        public double Temperatura { get; set; }
        public string QueixaPrincipal { get; set; }
        public string Procedimento { get; set; }
        public double Total { get; set; }
        public double Unitario { get; set; }
        public int Quantidade { get; set; }
        public string Situacao { get; set; }
        public AnimalDto Paciente { get; set; }
        public string Observacoes { get; set; }
        public DateTimeOffset DataLimiteRetorno { get; set; }
        public DateTimeOffset DataEncerramento { get; set; }
        public Status Status { get; set; }
    }
}
