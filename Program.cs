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

        while(true)
        {
        Console.WriteLine("-------------MENU------------");
        Console.WriteLine("Se for o primeiro login escolha a opcao 2!");
        Console.Write("1. Cadastrar Departamento");
        Console.WriteLine("2. Cadastrar Funcionário");   
        Console.WriteLine("3. Relatórios");
        Console.WriteLine("4. Sair");
        Console.WriteLine("Escolha uma opcao");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
                    
        case 1:
        Console.WriteLine("Registre os Departamentos e seus dados respectivamente:");
        
        while (true)
        {
            
            Departamento Contador = new Departamento();

            Console.WriteLine($"Entre com o Id do Departamento:!");
            string id = Console.ReadLine();

            Contador.Id = id;

            if (departamentos.Any(d => d.Id == id))
        {
        Console.WriteLine("Erro: Já existe um departamento cadastrado com este ID! Tente outro.");
        continue;
        }

            Console.WriteLine("Nome do Departamento:");
            string nome = Console.ReadLine();

            Contador.Nome = nome;

            Console.WriteLine("Sigla do Departamento:");
            string sigla = Console.ReadLine();

            Contador.Sigla = sigla;

            Console.WriteLine("Id do Gerente responsável pelo Departamento:");
            string idgerente = Console.ReadLine();

            Contador.IdGerente = idgerente;

            Console.WriteLine("Entre com o Ramal(Numeros) do Departamento:");
            int ramal = int.Parse(Console.ReadLine());

            Contador.Ramal = ramal;

            departamentos.Add(Contador);

            Console.WriteLine("Digite um Número qualquer se deseja adicionar mais um Departamento ou 0 se deseja encerrar:");
            int esc = int.Parse(Console.ReadLine());
            if (esc == 0)
            {
                break;
            }
            }
            break;

        case 2:
            while (true)
        {
            
            Funcionarios Contadorr = new Funcionarios();

            Console.WriteLine($"Entre com o nome do Funcionario:");
            string nome = Console.ReadLine();

            Contadorr.Nome = nome;
    
            Console.WriteLine("Entre com a Matricula:");
            int matricula = int.Parse(Console.ReadLine());

            Contadorr.Matricula = matricula;

            Console.WriteLine("Entre com o CPF");
            int cpf = int.Parse(Console.ReadLine());

            Contadorr.Cpf = cpf;

            Console.WriteLine("Entre com o Id do Funcionario:");
            string id = Console.ReadLine();

            Contadorr.IdF = id;

            Console.WriteLine("Entre com a data de Nascimento:");
            string data = Console.ReadLine();

            Contadorr.DataN = data;

            Console.WriteLine("Entre com o endereço:");
            string endereço = Console.ReadLine();

            Contadorr.Endereço = endereço;

            Console.WriteLine("Entre com o Id do departamento:");
            int idd = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o salarario:");
            double salario = int.Parse(Console.ReadLine());

            Contadorr.Salario = salario;

            Contadorr.IdD = idd;

            funcionarios.Add(Contadorr);

            Console.WriteLine("Digite qualquer se deseja adicionar mais funcionarios ou  zero se deseja encerrar o cadastro:");
            int esc = int.Parse(Console.ReadLine());
            if (esc == 0)
            {
                break;
            }
            }
            break;

            case 3:
            
        }
        

        
        














        

    
    }
    }
    }
