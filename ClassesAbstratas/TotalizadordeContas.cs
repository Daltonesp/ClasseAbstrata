using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class TotalizadordeContas
    {

        public double Total { get; private set; }

        public void Soma(Conta conta)
        {

            this.Total += conta.Saldo;
        }
    }
}
