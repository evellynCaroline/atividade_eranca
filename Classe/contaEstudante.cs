
namespace COnta.Classe
{
    internal class contaEstudante:conta
    {
        public double LimitecheqEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstitui { get; set; }

        public contaEstudante(double limitechequeEspecial, string Cpf, string instituicao, int nconta, string agencia, string titularConta,
            double saldo): base(nconta, agencia, titularConta,saldo) 
        { 
            this.Saldo = saldo;
            this.Cpf = Cpf;

        }

        public override void Saque(double valor)
        {
            if(valor <= Saldo + LimiteChequeEspecial)
            {
                Saldo -= valor;

            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

    }
}
