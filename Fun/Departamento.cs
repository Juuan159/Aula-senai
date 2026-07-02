using System;
using System.Collections.Generic;
using System.Linq;

namespace ATTGit.Fun;

    public class Departamento   
{
    public string Id  { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Sigla { get; set; } =  string.Empty;
    public string Ramal { get; set; } = string.Empty;   
    public string IdGerente { get; set; } = string.Empty;
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

            Console.WriteLine($"Entre com o Id do Departamento:");
            string id = Console.ReadLine() ?? string.Empty;

            if (departamentos.Any(d => d.Id == id))
        {
            Console.WriteLine("Erro: Já existe um departamento cadastrado com este ID! Tente outro.");
            continue;
        }
            Contador.Id = id;

            Console.WriteLine("Nome do Departamento:");

            Contador.Nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Sigla do Departamento:");

            Contador.Sigla = Console.ReadLine() ?? string.Empty;

            while(true)
        {        
            Console.WriteLine("Entre com o Ramal(Numeros) do Departamento:");
            string ramal = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(ramal, out int Ram))
        {
            Contador.Ramal = ramal;
            break;
        }
        else
        {
            Console.WriteLine("Entre com um ramal valido em apenas numeros!");        
        }
        }
            departamentos.Add(Contador);
            
             bool querSair = false;
            while (true)
            {
                Console.WriteLine("Digite um Número qualquer se deseja adicionar mais um Departamento ou 0 se deseja encerrar:");
                string entradaEsc = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(entradaEsc, out int esc))
                {
                    if (esc == 0)
                    {
                        querSair = true;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: Digite um número válido!");
                }
            }

            if (querSair)
            {
                break;
            }
        }
    }

    public void AlterarGerente(List<Funcionarios> funcionarios)
    {
        Console.WriteLine("Entre com o Id do Departamento que deseja alterar o gerente:");
        string idDepartamento = Console.ReadLine() ?? string.Empty;
        Departamento? departamento = departamentos.FirstOrDefault(d => d.Id == idDepartamento);

        if (departamento != null)
        {
            Console.WriteLine("Entre com o Id do Novo Gerente:");
            string idG = Console.ReadLine() ?? string.Empty;
            Funcionarios? funcionario = funcionarios.FirstOrDefault(d => d.IdF == idG);

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
