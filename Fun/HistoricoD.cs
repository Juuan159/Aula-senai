using System;
using System.Collections.Generic;

namespace SistemaRh.Modelos
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargoAtual { get; set; }
        public decimal SalarioAtual { get; set; }
        public int DepartamentoId { get; set; }

        public List<HistoricoCargo> HistoricoCargos { get; private set; }
        public List<HistoricoSalario> HistoricoSalarios { get; private set; }

        public Funcionario(int id, string nome, string cargo, decimal salario, int departamentoId)
        {
            Id = id;
            Nome = nome;
            CargoAtual = cargo;
            SalarioAtual = salario;
            DepartamentoId = departamentoId;
            HistoricoCargos = new List<HistoricoCargo>();
            HistoricoSalarios = new List<HistoricoSalario>();
        }

        public void AlterarCargo(string novoCargo, string motivo)
        {
            HistoricoCargos.Add(new HistoricoCargo
            {
                CargoAnterior = this.CargoAtual,
                CargoNovo = novoCargo,
                DataAlteracao = DateTime.Now,
                Motivo = motivo
            });
            CargoAtual = novoCargo;
        }

        public void AlterarSalario(decimal novoSalario, string tipoAumento)
        {
            HistoricoSalarios.Add(new HistoricoSalario
            {
                SalarioAnterior = this.SalarioAtual,
                SalarioNovo = novoSalario,
                DataAlteracao = DateTime.Now,
                TipoAumento = tipoAumento
            });
            SalarioAtual = novoSalario;
        }
    }

    public class HistoricoCargo
    {
        public string CargoAnterior { get; set; }
        public string CargoNovo { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Motivo { get; set; }
    }

    public class HistoricoSalario
    {
        public decimal SalarioAnterior { get; set; }
        public decimal SalarioNovo { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string TipoAumento { get; set; }
    }
}
