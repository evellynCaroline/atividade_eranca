using COnta.Classe;
using System.Threading.Channels;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha alguma das opçoes : \n 1- Conta Comum \n 2- Empresarial \n - Conta Estudante ");
        
        int opcao = Convert.ToInt32(Console.ReadLine());
        
        conta Conta = new conta();

        switch (opcao )
        {
            case 1:
            Conta.NConta = Convert.ToInt32(Console.ReadLine());
            Conta.Agencia = Console.ReadLine();
            Conta.Titular = Console.ReadLine();
                break;

            case 2:

                break;

        }
        
    }

    
}