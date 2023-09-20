using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHernca_2.Classes
{
    internal class Conta
    {

        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public string Titulo { get; set; }
        public double Saldo { get; set; }

        public Conta(string agencia, string numeroConta, string titulo, double saldo)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;
            Titulo = titulo;
            Saldo = saldo;
        }

        public Conta() { }
        public virtual void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Não há saldo suficiente");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque realizado!");
            }
        }
        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                Console.WriteLine("Deposito realizado!");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar esta ação!");

            }
        }

    }
}