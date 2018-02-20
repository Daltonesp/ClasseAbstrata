using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesAbstratas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaCorrente CCorrente = new ContaCorrente();
            ContaPoupanca CPoupanca = new ContaPoupanca();

            CCorrente.Deposita(100);
            CPoupanca.Deposita(100);


            Conta conta = CPoupanca;
            CCorrente.Saca(10);


           

            MessageBox.Show("Saldo: " + CCorrente.Saldo);


        }
    }
}
