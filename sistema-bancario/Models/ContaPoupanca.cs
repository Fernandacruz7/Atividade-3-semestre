using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario.Models
{
    public class ContaPoupanca : Conta
    {

        public ContaPoupanca(string titular, decimal saldoInicial) : base(titular, saldoInicial)
        {

        }

        // a maneira como a poupança saca, naotem o limite especial
        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                Console.WriteLine($"o valor de sacar deve ser positivo");

            if (valor > Saldo)
                Console.WriteLine($"saldo insuficiente!!");

            Saldo -= valor;


        }
    }
}