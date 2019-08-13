using System;
using System.Collections.Generic;
using System.Text;

namespace _11_bytebanck
{
    public  class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int conta;
        public double saldo = 100;


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this.saldo < valor)
            {
                Console.WriteLine("Saldo Insulficiente !!!");
                return false;

            }

            this.saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                Console.WriteLine("Transferencia não realizada, Saldo insulficiente");
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }

    
}
