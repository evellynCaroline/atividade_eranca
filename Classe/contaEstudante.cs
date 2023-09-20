
namespace ExercicioHernca_2.Classes
{
    internal class ContaEstudante : Conta
    {
        public string CPF { get; set; }
        public string NomeInstituicao { get; set; }
        public double LImiteCheque { get; set; }

        public ContaEstudante(string cpf, string nomeInstituicao, double lImiteCheque, string numeroConta, string agencia, string titulo, double saldo) : base(agencia, numeroConta, titulo, saldo)
        {
            CPF = cpf;
            NomeInstituicao = nomeInstituicao;
            LImiteCheque = lImiteCheque;
        }

        public ContaEstudante()
        {
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo + LImiteCheque)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }


    }
}