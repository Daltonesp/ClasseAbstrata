﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
