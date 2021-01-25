using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;
using Vet.Domain.Consulta;
using Vet.Domain.Pessoa;

namespace Vet.Dtos.Consulta
{
    public class ConsultaDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset DataInicio { get; set; }
        public Pessoa.Pessoa Cliente { get; set; }
        public Pessoa.Pessoa Veterinario { get; set; }
        public double Peso { get; set; }
        public double Temperatura { get; set; }
        public string QueixaPrincipal { get; set; }
        public string Procedimento { get; set; }
        public double Total { get; set; }
        public double Unitario { get; set; }
        public int Quantidade { get; set; }
        public string Situacao { get; set; }
        public Animal.Animal Paciente { get; set; }
        public string Observacoes { get; set; }
        public DateTimeOffset DataLimiteRetorno { get; set; }
        public DateTimeOffset DataEncerramento { get; set; }
        public Status Status { get; set; }
    }
}
