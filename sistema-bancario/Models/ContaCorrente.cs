using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario.Models
{
    public class ContaCorrente : Conta
    {
        private const decimal Limite = 200; // limite especial

        //repasse os dados para o construtor da base 

        public ContaCorrente(string titular, decimal saldoInicial) : base(titular, saldoInicial)
        {
        }

        public override void Sacar(decimal valor)
        {
            //implementar a logica do metodo sacar
            if (valor <= 0)

                Console.WriteLine($"O valor de sacar deve ser positivo.");

            if (valor > Saldo )

                Console.WriteLine($"Saldo insuficiente.");

            
          
            Saldo-= valor;    
        }
    }
}