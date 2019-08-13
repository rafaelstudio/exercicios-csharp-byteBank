using System;

namespace _11_bytebanck
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraConta = new ContaCorrente();
            
             primeiraConta.saldo = 200;
            Console.WriteLine(primeiraConta.saldo);
            primeiraConta.saldo += 100;
            Console.WriteLine(primeiraConta.saldo);

            ContaCorrente segundaConta = new ContaCorrente();
            segundaConta.saldo = 50;

            Console.WriteLine("A primeira conta tem: " + primeiraConta.saldo);
            Console.WriteLine("A segunda conta tem: " + segundaConta.saldo);

            primeiraConta.Depositar(150);
            Console.WriteLine("Saldo apos deposito : "+primeiraConta.saldo);
            primeiraConta.Transferir(200, segundaConta);
            Console.WriteLine("Saldo primeiraConta  apos Tranferencia  : " + primeiraConta.saldo);
            Console.WriteLine("Saldo segundaConta apos Tranferencia    : " + segundaConta.saldo);
            segundaConta.Sacar(50.50);
            Console.WriteLine("Saldoas segundaConta apos saque : "+segundaConta.saldo);

            Console.ReadLine();

           
        }
    }
}
