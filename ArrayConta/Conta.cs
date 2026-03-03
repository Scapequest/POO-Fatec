using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public void Sacar(double ValorSacar){
            saldo -= ValorSacar;
        }
        public void Depositar(double valorDeposito){
            saldo += valorDeposito;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine($"Número: {numero:0000} \tTitular: {titular} \tSaldo: {saldo:C}");
        }
    }
}