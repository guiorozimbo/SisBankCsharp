using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBank
{
    public class Conta
    {
        public int agencia;
        public string conta;
        public string nome;
        public double saldo;
        public int cpf;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}