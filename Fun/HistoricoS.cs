using System;
using System.Collections.Generic;
using SistemaRh.Modelos;

namespace SistemaRh.Servicos
{
    public class Relatorio
    {
        public void GerarHistoricoCompletoFuncionario(Funcionario funcionario)
        {
            Console.WriteLine($"=== RELATÓRIO DE HISTÓRICO: {funcionario.Nome.ToUpper()} ===");
            
            Console.WriteLine("\n[Histórico de Cargos]");
            if (funcionario.HistoricoCargos.Count == 0) Console.WriteLine("Nenhuma alteração registrada.");
            foreach (var hCargo in funcionario.HistoricoCargos)
            {
                Console.WriteLine($"- {hCargo.DataAlteracao:dd/MM/yyyy}: De {hCargo.CargoAnterior} para {hCargo.CargoNovo} ({hCargo.Motivo})");
            }

            Console.WriteLine("\n[Histórico de Salários]");
            if (funcionario.HistoricoSalarios.Count == 0) Console.WriteLine("Nenhuma alteração registrada.");
            foreach (var hSalario in funcionario.HistoricoSalarios)
            {
                Console.WriteLine($"- {hSalario.DataAlteracao:dd/MM/yyyy}: De R$ {hSalario.SalarioAnterior:N2} para R$ {hSalario.SalarioNovo:N2} | Motivo: {hSalario.TipoAumento}");
            }
            Console.WriteLine(new string('=', 40));
        }

        public void GerarHistoricoMovimentacaoDepartamento(Departamento departamento)
        {
            Console.WriteLine($"=== HISTÓRICO DE MOVIMENTAÇÃO DO SETOR: {departamento.Nome.ToUpper()} ===");
            
            if (departamento.HistoricoTransferencias.Count == 0) Console.WriteLine("Nenhuma transferência registrada para este departamento.");
            foreach (var transf in departamento.HistoricoTransferencias)
            {
                Console.WriteLine($"- {transf.DataTransferencia:dd/MM/yyyy}: {transf.FuncionarioNome} veio de '{transf.DepartamentoAnterior}' para '{transf.DepartamentoNovo}'");
            }
            Console.WriteLine(new string('=', 40));
        }
    }
}
