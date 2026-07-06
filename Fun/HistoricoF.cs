using System;
using System.Collections.Generic;

namespace SistemaRh.Modelos
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<HistoricoDepartamento> HistoricoTransferencias { get; private set; }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
            HistoricoTransferencias = new List<HistoricoDepartamento>();
        }
    }

    public class HistoricoDepartamento
    {
        public int FuncionarioId { get; set; }
        public string FuncionarioNome { get; set; }
        public string DepartamentoAnterior { get; set; }
        public string DepartamentoNovo { get; set; }
        public DateTime DataTransferencia { get; set; }
    }
}
