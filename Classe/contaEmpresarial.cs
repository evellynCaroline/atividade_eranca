using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COnta.Classe
{
    internal class contaEmpresarial:conta
    {
        public double anuidade {get;set;}
        public double LimiteEmpret { get;set;}
        public double TotalEmprest { get;set;}
    }

    public void Emprestimo (double valor)
    { 
        
    }
}
