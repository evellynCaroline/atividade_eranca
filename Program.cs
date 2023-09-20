using ExercicioHernca_2.Classes;
using System.Globalization;
using System.Threading.Channels;

public class Program
{
    static void Main(string[] args)
    {
        int Nconta = 1;
        String agencia = "Jipa";
        
        while (true) 
        { 

          Console.WriteLine("Escolha alguma das opçoes : \n 1- Conta Comum \n 2- Conta Empresarial \n 3- Conta Estudante ");
        
          int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do Titular");
            string Titular = Console.ReadLine();
        

           if (opcao == 1)
           {
                //Nconta = += 1;
             Conta conta = new Conta(Nconta, agencia, nomeTitular, 0);

            while(true)
            {
                    Console.WriteLine("1 para depositar, 2 para sacar, 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
            }

           }
          else if (opcao == 2) 
          {
                Console.WriteLine("Digite o cpf do estudante: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Nos informe a instituiçao do estudante: ");
                string instituto = Console.ReadLine(); 

                ContaEstudante ce = new ContaEstudante(100, cpf, Nconta, agencia, Titular, 0);
          }
         else if (opcao == 3) 
            {
            ContaEmpresa Cempresa = new ContaEmpresa(10, 100, Nconta, agencia, Titular, 0);    
            }
        
        }

    }

    
}