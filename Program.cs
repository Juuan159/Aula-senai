using System;
using System.Collections;
using System.Linq;

namespace ATTGit.Fun;
    class Program
{

    static void Main()
    {
        List<Departamento> departamentos = new List<Departamento>();
        List<Funcionarios> funcionarios = new List<Funcionarios>();
        DepartamentoService ChamarD = new DepartamentoService(departamentos);
        FuncionarioService ChamarF = new FuncionarioService(funcionarios);
        Relatorios ChamarR = new Relatorios();

        while(true)
        {
        Console.WriteLine("-------------MENU------------");
        Console.WriteLine("Se for o primeiro login escolha a opcão 1, Ja que não possui departamentos!");
        Console.WriteLine("1. Cadastrar Departamento!");
        Console.WriteLine("2. Cadastrar Funcionário!");   
        Console.WriteLine("3. Relatórios!");
        Console.WriteLine("4. Vincular Gerente ao Departamento!");
        Console.WriteLine("5. Sair!");
        
        Console.WriteLine("Escolha uma opcão!");

        string entrada = Console.ReadLine() ?? string.Empty;

            
        if (!int.TryParse(entrada, out int esc))
    {
        Console.WriteLine("Erro: Por favor, digite apenas números! De um ENTER para continuar!");
        Console.ReadKey();
        continue; 
    }

        switch (esc)
        {
                    
        case 1:
            ChamarD.CadastrarDepartamento();
            break;

        case 2:
            ChamarF.CadastrarFuncionario(departamentos);
            break;

        case 3:
            Console.WriteLine("-------------MENU RELATÓRIOS------------");
            Console.WriteLine("1. Consulta Funcionário por Matrícula!");
            Console.WriteLine("2. Folha de Pagamento!");   
            Console.WriteLine("3. Relatório por Departamento!");
            Console.WriteLine("4. Sair!");
            Console.WriteLine("Escolha uma opcão!");

            string entrada1 = Console.ReadLine() ?? string.Empty;
            if (!int.TryParse(entrada1, out int esc1))
    {
            Console.WriteLine("Erro: Por favor, digite apenas números! De um ENTER para continuar!");
            Console.ReadKey();
            break;
    }
            switch (esc1)
        {
            case 1:
                ChamarR.ConsultaMatricula(funcionarios, departamentos);
                break;
            case 2:
                ChamarR.FolhaPagamento(funcionarios);
                break;
            case 3:
                ChamarR.RelatorioPorDepartamento(funcionarios, departamentos);
                break;
            case 4:
                Console.WriteLine("Saindo do menu de relatórios... De ENTER para continuar!");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Erro: Opção inválida! Escolha um número de 1 a 4. De ENTER para continuar!");
                Console.ReadKey();
                break;           
        }
            break;
            
        case 4:
            ChamarD.AlterarGerente(funcionarios);
            break;
            
        case 5:
            Console.WriteLine("Saindo do sistema... Até mais!");
            return;
        
        default:
            Console.WriteLine("Erro: Opção inválida! Escolha um número de 1 a 5. De ENTER para continuar!");
            Console.ReadKey();
            break;
        }
    }
    }
}

