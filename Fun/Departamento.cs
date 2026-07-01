using System;
using System.Collections.Generic;
using System.Linq;

namespace ATTGit.Fun;

    public class Departamento   
{
    public string Id { get; set; }  
    public string Nome { get; set; }
    public string Sigla { get; set; }
    public int Ramal { get; set; }    
    public string IdGerente { get; set; } 
}

    public class DepartamentoService
{
    private List<Departamento> departamentos;

    public DepartamentoService(List<Departamento> departamentos)
    {
        this.departamentos = departamentos;
    }

    public void CadastrarDepartamento()
    {
        Console.WriteLine("Registre os Departamentos e seus dados respectivamente:");
        
            while (true)
        {
            
            Departamento Contador = new Departamento();

            Console.WriteLine($"Entre com o Id do Departamento:!");
            string id = Console.ReadLine();

            if (departamentos.Any(d => d.Id == id))
        {
            Console.WriteLine("Erro: Já existe um departamento cadastrado com este ID! Tente outro.");
            continue;
        }
            Contador.Id = id;

            Console.WriteLine("Nome do Departamento:");

            Contador.Nome = Console.ReadLine();

            Console.WriteLine("Sigla do Departamento:");

            Contador.Sigla = Console.ReadLine();

            Console.WriteLine("Entre com o Ramal(Numeros) do Departamento:");

            Contador.Ramal = int.Parse(Console.ReadLine());

            departamentos.Add(Contador);

            Console.WriteLine("Digite um Número qualquer se deseja adicionar mais um Departamento ou 0 se deseja encerrar:");
            int esc = int.Parse(Console.ReadLine());

            if (esc == 0)
        {
            break;
        }
        }
    }

    public void AlterarGerente(List<Funcionarios> funcionarios)
    {
        Console.WriteLine("Entre com o Id do Departamento que deseja alterar o gerente:");
        string idDepartamento = Console.ReadLine();
        Departamento departamento = departamentos.FirstOrDefault(d => d.Id == idDepartamento);

        if (departamento != null)
        {
            Console.WriteLine("Entre com o Id do Novo Gerente:");
            string idG = Console.ReadLine();
            Funcionarios funcionario = funcionarios.FirstOrDefault(d => d.IdF == idG);

        if (funcionario != null)
        {
            departamento.IdGerente = idG;
            Console.WriteLine($"Gerente do departamento {departamento.Nome} alterado para {idG}.");
        }
        }
        else
        {
            Console.WriteLine("Departamento não encontrado.");
        }
    }

    public void ListarDepartamentos()
    {
        // lógica para listar todos os departamentos
    }
}
