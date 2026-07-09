using System;
using System.Collections.Generic;
using System.Linq;

namespace ATTGit.Fun;

public class Funcionarios
{
    public string IdF { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty; 
    public int Matricula { get; set; } 
    public string Cpf { get; set; } = string.Empty;
    public string Endereco { get; set; }  = string.Empty;  
    public double Salario { get; set; } 
    public string IdD { get; set; } = string.Empty;
    public string DataN { get; set; } = string.Empty;

    public List<HistoricoCargo> HistoricoCargos { get; private set; }
    public List<HistoricoSalario> HistoricoSalarios { get; private set; }

    public Funcionarios()
    {
        HistoricoCargos = new List<HistoricoCargo>();
        HistoricoSalarios = new List<HistoricoSalario>();
    }

    public void AlterarCargo(string novoCargo, string motivo)
    {
        HistoricoCargos.Add(new HistoricoCargo
        {
            CargoAnterior = this.IdD,
            CargoNovo = novoCargo,
            DataAlteracao = DateTime.Now,
            Motivo = motivo
        });
        IdD = novoCargo;
    }

    public void AlterarSalario(double novoSalario, string tipoAumento)
    {
        HistoricoSalarios.Add(new HistoricoSalario
        {
            SalarioAnterior = this.Salario,
            SalarioNovo = novoSalario,
            DataAlteracao = DateTime.Now,
            TipoAumento = tipoAumento
        });
        Salario = novoSalario;
    }
}

public class HistoricoCargo
{
    public string CargoAnterior { get; set; } = string.Empty;
    public string CargoNovo { get; set; } = string.Empty;
    public DateTime DataAlteracao { get; set; }
    public string Motivo { get; set; } = string.Empty;
}

    public class HistoricoSalario
{
    public double SalarioAnterior { get; set; }
    public double SalarioNovo { get; set; }
    public DateTime DataAlteracao { get; set; }
    public string TipoAumento { get; set; } = string.Empty;
}


    public class FuncionarioService
{
    private List<Funcionarios> funcionarios;

    public FuncionarioService(List<Funcionarios> funcionarios)
    {
        this.funcionarios = funcionarios;
    }

    public void CadastrarFuncionario(List<Departamento> departamentos)
    {
        while (true)
        {
            Funcionarios novoFuncionario = new Funcionarios();

            Console.WriteLine("Entre com o nome do Funcionário:");
            novoFuncionario.Nome = Console.ReadLine() ?? string.Empty;

            while(true)
            {
                Console.WriteLine("Entre com a Matricula do Funcionário:");
                string matricula = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(matricula, out int MatrNum))
                {
                    if (funcionarios.Any(d => d.Matricula == MatrNum))
                    {
                        Console.WriteLine("Erro: Já existe um Funcionário cadastrado com esta Matricula! Tente outro.");
                        continue;
                    }
                    novoFuncionario.Matricula = MatrNum;
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: Entre com os números da Matricula!");      
                }
            }

            while(true)
            {   
                Console.WriteLine("Entre com o CPF em Números:");
                string cpf = Console.ReadLine() ?? string.Empty;

                if (Verif.ValidCpf(cpf))
                {
                    novoFuncionario.Cpf = cpf;
                    break;
                }
                else
                {
                    Console.WriteLine("CPF inválido! Digite 11 dígitos.");
                }
            }

            Console.WriteLine("Entre com o Id do Funcionário:");
            string idf = Console.ReadLine() ?? string.Empty;

            if (funcionarios.Any(d => d.IdF == idf))
            {
                Console.WriteLine("Erro: Já existe um Funcionário cadastrado com este Id! Tente outro.");
                continue;
            }
            novoFuncionario.IdF = idf;

            bool valido = false;
            string data = "00000000";
            while(!valido)
            {
                Console.WriteLine("Entre com a data de Nascimento do Funcionário EX(20102000)):");
                data = Console.ReadLine() ?? string.Empty;           
                if (Verif.ValidData(data))
                {
                    valido = true;                     
                }
                else
                {
                    Console.WriteLine("Erro: Digite uma data válida com 8 caracteres!");
                }
            }
            novoFuncionario.DataN = data;

            Console.WriteLine("Entre com o endereço:");
            novoFuncionario.Endereco = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Entre com o Id do departamento:");
            while (true)
            {
                novoFuncionario.IdD = Console.ReadLine() ?? string.Empty;
                Departamento? departamento = departamentos.FirstOrDefault(d => d.Id == novoFuncionario.IdD);
                if (departamento != null)
                {
                    break;    
                }
                else
                {
                    Console.WriteLine("Departamento não encontrado.");       
                }
            }

            while(true)
            {    
                Console.WriteLine("Entre com o salário:");
                string salario = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(salario, out double Salario))
                {
                    novoFuncionario.Salario = Salario;
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: Digite um valor válido!");
                }    
            }

            funcionarios.Add(novoFuncionario);

            bool querSair = false;
            while (true)
            {
                Console.WriteLine("Digite um Número qualquer se deseja adicionar mais Funcionário ou 0 se deseja encerrar:");
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
}
