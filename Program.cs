using System;
using System.Linq;

namespace ATTGit.Fun;
    class Program
{
    static void Main()
    {
        List<Departamento> departamentos = new List<Departamento>();
        int id = 0;

        Console.WriteLine("Registre os Departamentos e seus dados respectivamente:");
        
        while (true)
        {
            id++;
            Departamento Contador = new Departamento();

            Console.WriteLine($"Id do Departamento é {id}!");

            Contador.Id = id;

            Console.WriteLine("Nome do Departamento:");
            string nome = Console.ReadLine();

            Contador.Nome = nome;

            Console.WriteLine("Sigla do Departamento:");
            string sigla = Console.ReadLine();

            Contador.Sigla = sigla;

            Console.WriteLine("Id do Gerente responsável pelo Departamento:");
            int idgerente = int.Parse(Console.ReadLine());

            Contador.IdGerente = idgerente;

            Console.WriteLine("Entre com o Ramal do Departamento:");
            int ramal = int.Parse(Console.ReadLine());

            Contador.Ramal = ramal;

            Console.WriteLine("Digite um Número qualquer se deseja adicionar mais um Departamento ou 0 se deseja encerrar:");
            int esc = int.Parse(Console.ReadLine());
            if (esc == 0)
            {
                id = 0;
                break;
            }

        

    
    }
}
