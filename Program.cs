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

        while(true)
        {
        Console.WriteLine("-------------MENU------------");
        Console.WriteLine("Se for o primeiro login escolha a opcão 1, Ja que não possui departamentos!");
        Console.WriteLine("1. Cadastrar Departamento");
        Console.WriteLine("2. Cadastrar Funcionário");   
        Console.WriteLine("3. Relatórios");
        Console.WriteLine("4. Vincular Gerente ao Departamento!");
        Console.WriteLine("5. Sair");
        
        Console.WriteLine("Escolha uma opcão");

        int opcão = int.Parse(Console.ReadLine());

        switch (opcão)
        {
                    
        case 1:
            ChamarD.CadastrarDepartamento();
            break;

        case 2:
            ChamarF.CadastrarFuncionario(departamentos);
            break;

        case 3:
            break;
            
        case 4:
            ChamarD.AlterarGerente(funcionarios);
            break;
            
        case 5:
            Console.WriteLine("Saindo do sistema... Até mais!");
            return;
        }  
    }
    }
}

