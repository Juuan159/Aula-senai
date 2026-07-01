namespace ATTGit.Fun;
    public class Funcionarios
{
    public string Nome { get; set; }  
    public int Matricula { get; set; }
    public string Cpf { get; set; }
    public string Endereço { get; set; }    
    public string IdF { get; set; }
    public double Salario { get; set; }
    public string IdD { get; set; }
    public string DataN { get; set; }
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
            Funcionarios Contadorr = new Funcionarios();

            Console.WriteLine($"Entre com o nome do Funcionario:");

            Contadorr.Nome = Console.ReadLine();

            while(true)
        {
            Console.WriteLine("Entre com a Matricula:");
            string matricula = Console.ReadLine();

            if (int.TryParse(matricula, out int MatrNum))
        {

            if (funcionarios.Any(d => d.Matricula == MatrNum))
        {
            Console.WriteLine("Erro: Já existe um Funcionario cadastrado com esta Matricuça! Tente outro.");
            continue;
        }
        
            Contadorr.Matricula = MatrNum;
            break;
        }
            else
        {
            Console.WriteLine("Erro: Entre com os  Numeros de sua Matricula ! Tente outro.");      
        }
        }
            while(true)
        {   Verif Chamar = new Verif();
            Console.WriteLine("Entre com o CPF em Numeros:");
            string cpf = Console.ReadLine();

            if (Chamar.ValidCpf(cpf))
        {
            Contadorr.Cpf = cpf;
            break;
        }
            else
        {
            Console.WriteLine("Entre com um  CPF valido em Numeros 11 digitos!");
            continue;            
        }
        }
        

            Console.WriteLine("Entre com o Id do Funcionario:");

            string idf = Console.ReadLine();

            if (funcionarios.Any(d => d.IdF == idf))
        {
            Console.WriteLine("Erro: Já existe um Funcionario cadastrado com este Id! Tente outro.");
            continue;
        }

            Contadorr.IdF = idf;

            bool valido = false;

            string data = "00000000";
        
            while(valido == false)
        {
                            
            Console.WriteLine("Entre com a data de Nascimento EX(20102000)):");

            data = Console.ReadLine();            

            if (Verif.ValidData(data))
        {
            valido = true;                     
        }
            else
        {
            Console.WriteLine("Erro: Digite uma data válida com 8 caracteres! A data deve ser maior que 20/06/1950."); 
            continue;
        }
        }

            Contadorr.DataN = data;

            Console.WriteLine("Entre com o endereço:");

            Contadorr.Endereço = Console.ReadLine();

            Console.WriteLine("Entre com o Id do departamento:");

            while (true)
        {
            Contadorr.IdD = Console.ReadLine();
            Departamento departamento = departamentos.FirstOrDefault(d => d.Id == Contadorr.IdD);
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
            Console.WriteLine("Entre com o salarario:");
            string salario = Console.ReadLine();

            if (double.TryParse(salario, out double Salario))
        {
            Contadorr.Salario = Salario;
            break;
        }
            else
        {
            Console.WriteLine("Entre com seu Salario!");
            continue;            
        }    
        }
            funcionarios.Add(Contadorr);

                
            bool querSair = false;
            while (true)
            {
                Console.WriteLine("Digite um Número qualquer se deseja adicionar mais Funcinarios ou 0 se deseja encerrar:");
                string entradaEsc = Console.ReadLine();

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