using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;

namespace Vet.Domain.Consulta
{
    public class Consulta
    {
        public Guid Id { get; private set; }
        public DateTimeOffset DataInicio { get; private set; }
        public Pessoa.Pessoa Cliente { get; set; }
        public Pessoa.Pessoa Veterinario { get; set; }
        public double Peso { get; private set; }
        public double Temperatura { get; private set; }
        public string QueixaPrincipal { get; private set; }
        public string Procedimento { get; private set; }
        public double Total { get; private set; }
        public double Unitario { get; private set; }
        public int Quantidade { get; private set; }
        public string Situacao { get; private set; }
        public Animal.Animal Paciente { get; set; }
        public string Observacoes { get; private set; }
        public DateTimeOffset DataLimiteRetorno { get; set; }
        public DateTimeOffset DataEncerramento { get; set; }
        public Status Status { get; set; }

        public Consulta(DateTimeOffset dataInicio, double peso, double temperatura, string queixaPrincipal, string procedimento,  double total, double unitario, int quantidade, string situacao, string observacoes)
        {
            Id = Guid.NewGuid();
            DataInicio = dataInicio;
            Peso = peso;
            Temperatura = temperatura;
            QueixaPrincipal = queixaPrincipal;
            Procedimento = procedimento;
            Total = total;
            Unitario = unitario;
            Quantidade = quantidade;
            Situacao = situacao;
            Observacoes = observacoes;
        }

        public void IniciarConsulta()
        {
            Status = Status.EmAndamento;
            DataInicio = DateTimeOffset.Now;
        }

        public void FinalizarConsulta()
        {
            Status = Status.Finalizada;
            DataEncerramento = DateTimeOffset.Now;
            DataLimiteRetorno = DateTimeOffset.Now.Add(TimeSpan.FromDays(15));
        }
    }
}
