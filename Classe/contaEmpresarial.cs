

namespace ExercicioHernca_2.Classes
{
    internal class ContaEmpresa : Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresa(double anuidade, double limiteEmprestimo, double totalEmprestimo, string numeroConta, string agencia, 
            string titulo, double Saldo) : base(agencia, numeroConta, titulo, Saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public ContaEmpresa()
        {
        }

        public void FazerEmprestimo(double valor)
        {
            Anuidade = 5;
            LimiteEmprestimo = Saldo;
            TotalEmprestimo = 0;


            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("Não há saldo suficiente");
            }

            else
            {

                if (valor <= 5000)
                {
                    LimiteEmprestimo = LimiteEmprestimo - valor;
                    TotalEmprestimo = valor + Saldo;

                    Console.WriteLine("Empréstimo realizado!");
                }

                else
                {
                    LimiteEmprestimo = (LimiteEmprestimo - valor) - Anuidade;
                    TotalEmprestimo = valor + Saldo;

                    Console.WriteLine("Empréstimo realizado!\n" + "obs: devido a regulamentação do sistema" +
                       " foi retirado mais 5 reais de taxa do seu limite");
                }
            }
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                if (valor >= 5000)
                {
                    Saldo -= 5;
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void RealizarEmprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
            }
            else
            {
                Console.WriteLine("Valor indisponivel!");
            }
        }
    }
}