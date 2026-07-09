namespace ATTGit.Fun;

public class Relatorios
{
    public void ConsultaMatricula(List<Funcionarios> funcionarios, List<Departamento> departamentos)
    {
        Console.WriteLine("Digite a matrícula do funcionário:");
        string entrada = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(entrada, out int matricula))
        {
            var funcionario = funcionarios.FirstOrDefault(f => f.Matricula == matricula);
            if (funcionario != null)
            {
                var departamento = departamentos.FirstOrDefault(d => d.Id == funcionario.IdD);
                Console.WriteLine($"Funcionário: {funcionario.Nome}, Departamento: {departamento?.Nome}");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }

    public void FolhaPagamento(List<Funcionarios> funcionarios)
    {
        double total = funcionarios.Sum(f => f.Salario);
        Console.WriteLine($"Total da folha de pagamento: R$ {total}");
    }

    public void RelatorioPorDepartamento(List<Funcionarios> funcionarios, List<Departamento> departamentos)
    {
        foreach (var dep in departamentos)
        {
            var lista = funcionarios.Where(f => f.IdD == dep.Id).ToList();
            double total = lista.Sum(f => f.Salario);
            Console.WriteLine($"Departamento: {dep.Nome}, Funcionários: {lista.Count}, Total Salários: R$ {total}");
        }
    }
     public void HistoricoSalarialFuncionario(Funcionarios funcionario, DateTime inicio, DateTime fim)
    {
        Console.WriteLine($"Histórico salarial de {funcionario.Nome} entre {inicio:dd/MM/yyyy} e {fim:dd/MM/yyyy}:");
        var historico = funcionario.HistoricoSalarios
            .Where(h => h.DataAlteracao >= inicio && h.DataAlteracao <= fim);

        foreach (var h in historico)
        {
            Console.WriteLine($"- {h.DataAlteracao:dd/MM/yyyy}: R$ {h.SalarioAnterior} → R$ {h.SalarioNovo} ({h.TipoAumento})");
        }
    }

    public void ListaGerentesDepartamento(Departamento departamento)
    {
        Console.WriteLine($"Gerentes que já passaram pelo departamento {departamento.Nome}:");
        foreach (var h in departamento.HistoricoGerentes)
        {
            Console.WriteLine($"- {h.IdGerente} em {h.DataAlteracao:dd/MM/yyyy}");
        }
    }
}