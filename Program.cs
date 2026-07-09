using System;
using System.Collections.Generic;
using ATTGit.Fun;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionarios> funcionarios = new List<Funcionarios>();
        List<Departamento> departamentos = new List<Departamento>();

        FuncionarioService funcionarioService = new FuncionarioService(funcionarios);
        DepartamentoService departamentoService = new DepartamentoService(departamentos);
        Relatorios relatorios = new Relatorios();

        while (true)
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("\n Em caso de Primeiro acesso, cadastre os Departamentos e seus respectivos Gerentes antes de usar as demais funções.");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Cadastrar Departamento");
            Console.WriteLine("3 - Alterar Gerente de Departamento");
            Console.WriteLine("4 - Alterar Cargo de Funcionário");
            Console.WriteLine("5 - Alterar Salário de Funcionário");
            Console.WriteLine("6 - Consultar Funcionário por Matrícula");
            Console.WriteLine("7 - Folha de Pagamento");
            Console.WriteLine("8 - Relatório por Departamento");
            Console.WriteLine("9 - Histórico Salarial de Funcionário");
            Console.WriteLine("10 - Lista de Gerentes de Departamento");
            Console.WriteLine("11 - Listar Departamentos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    funcionarioService.CadastrarFuncionario(departamentos);
                    break;

                case "2":
                    departamentoService.CadastrarDepartamento();
                    break;

                case "3":
                    departamentoService.AlterarGerente(funcionarios);
                    break;

                case "4":
                    Console.WriteLine("Digite o Id do Funcionário:");
                    string idFuncCargo = Console.ReadLine() ?? string.Empty;
                    var funcCargo = funcionarios.Find(f => f.IdF == idFuncCargo);
                    if (funcCargo != null)
                    {
                        Console.WriteLine("Digite o novo cargo (Id do Departamento):");
                        string novoCargo = Console.ReadLine() ?? string.Empty;
                        Console.WriteLine("Motivo da alteração:");
                        string motivo = Console.ReadLine() ?? string.Empty;
                        funcCargo.AlterarCargo(novoCargo, motivo);
                        Console.WriteLine("Cargo alterado com sucesso!");
                    }
                    break;

                case "5":
                    Console.WriteLine("Digite o Id do Funcionário:");
                    string idFuncSalario = Console.ReadLine() ?? string.Empty;
                    var funcSalario = funcionarios.Find(f => f.IdF == idFuncSalario);
                    if (funcSalario != null)
                    {
                        Console.WriteLine("Digite o novo salário:");
                        string entradaSalario = Console.ReadLine() ?? string.Empty;
                        if (double.TryParse(entradaSalario, out double novoSalario))
                        {
                            Console.WriteLine("Tipo de aumento (Promoção, Ajuste, etc.):");
                            string tipoAumento = Console.ReadLine() ?? string.Empty;
                            funcSalario.AlterarSalario(novoSalario, tipoAumento);
                            Console.WriteLine("Salário alterado com sucesso!");
                        }
                    }
                    break;

                case "6":
                    relatorios.ConsultaMatricula(funcionarios, departamentos);
                    break;

                case "7":
                    relatorios.FolhaPagamento(funcionarios);
                    break;

                case "8":
                    relatorios.RelatorioPorDepartamento(funcionarios, departamentos);
                    break;

                case "9":
                    Console.WriteLine("Digite o Id do Funcionário:");
                    string idHist = Console.ReadLine() ?? string.Empty;
                    var funcHist = funcionarios.Find(f => f.IdF == idHist);
                    if (funcHist != null)
                    {
                        Console.WriteLine("Digite a data inicial (dd/MM/yyyy):");
                        DateTime inicio = DateTime.Parse(Console.ReadLine() ?? "01/01/2000");
                        Console.WriteLine("Digite a data final (dd/MM/yyyy):");
                        DateTime fim = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());
                        relatorios.HistoricoSalarialFuncionario(funcHist, inicio, fim);
                    }
                    break;

                case "10":
                    Console.WriteLine("Digite o Id do Departamento:");
                    string idDep = Console.ReadLine() ?? string.Empty;
                    var dep = departamentos.Find(d => d.Id == idDep);
                    if (dep != null)
                    {
                        relatorios.ListaGerentesDepartamento(dep);
                    }
                    break;

                case "11":
                    departamentoService.ListarDepartamentos();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            
            
        }
    }
}
