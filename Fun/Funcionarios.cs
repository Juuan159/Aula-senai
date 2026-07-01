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

            if (matricula.Length == 8 && int.TryParse(matricula, out int MatrNum))
        {

            if (funcionarios.Any(d => d.Matricula == MatrNum))
        {
            Console.WriteLine("Erro: Já existe um Funcionario cadastrado com esta Matricuça! Tente outro.");
            continue;
        }
        
            Contadorr.Matricula = MatrNum;
            break;
        }
        }
            Console.WriteLine("Entre com o CPF");

            Contadorr.Cpf = Console.ReadLine();

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
            
            Console.WriteLine("Entre com o salarario:");
            double salario = double.Parse(Console.ReadLine());

            Contadorr.Salario = salario;

            funcionarios.Add(Contadorr);

            Console.WriteLine("Digite qualquer se deseja adicionar mais funcionarios ou  zero se deseja encerrar o cadastro:");
            int esc = int.Parse(Console.ReadLine());
            if (esc == 0)
        {
            break;
        }
        }
    }
}    