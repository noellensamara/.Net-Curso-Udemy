using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExeContaBancariaEncapsulamento
{
    class Cliente
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        /*------------------ Construtores ---------------------*/
        public Cliente(int conta, string nome, double saldo) : this(saldo)
        {

            Conta = conta;
            Nome = nome;
            Saldo = saldo;

        }

        public Cliente(double saldo)
        { 
        
        }

        /*------------------- Métodos --------------------*/
        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: " + Saldo;
        }


        public void Deposito(double saldo)
        {
            Saldo += saldo;            
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo;
            Saldo -= +5;
        }

    }
}
