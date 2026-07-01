namespace ATTGit.Fun;

public class Verif
{
    public static bool ValidData(string n)
    {
            if (n.Length == 8 && int.TryParse(n, out _))
            {
                int dia = int.Parse(n.Substring(0, 2));
                int mes = int.Parse(n.Substring(2, 2));
                int ano  = int.Parse(n.Substring(4, 4));

                if (mes >= 1 && mes <= 12)
                {
                    int[]DiaDMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                    DiaDMes[1] = 29;

                    if (dia >= 1 && dia <=DiaDMes[mes - 1])
                    {
                        if ((dia > 20 && mes >= 6 && ano >= 1950) || (mes >= 6 && ano >= 1950) || (dia >= 1 && dia <=DiaDMes[mes - 1] && mes > 6 && ano >= 1950) || (dia >= 1 && dia <=DiaDMes[mes - 1] && mes >= 1 && ano >= 1951))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
    }
    public static bool ValidCpf(string n)
    {
        if (n.Length == 11 && n.All(char.IsDigit))
        {
            return true; 
        }
        else
        {
            return false;
        }
    }
}

