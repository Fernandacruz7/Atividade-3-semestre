using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario.Models
{
    public abstract class Conta
    {
        //propriedades:titular e saldo 
        //visibilidade, tipo de dado, nome da propriedade, acessores

        //encapsulamento: o saldo é o dado mais sensivelninguem de fora grava direto
        // protected set: só a classe e as classes filhas podem alterar o saldo
        // de fora só da pra ler, para alterar só por metodos da classe
        // sacar e depositar

        public string Titular { get; }

        public decimal Saldo { get; protected set; }

        protected Conta(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        //metodos sacar e depositar
        //visibiladade, retorno, nome, parametros 
        //metodo com comportamento comum em toda conta

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Depósito precisa ser positivo");

            Saldo += valor; //operador de incremento

        }

        //polimorfismo
        //toda conta sabe sacar
        //a base so exige o metodo, quem diz como é cada classe filha
        public abstract void Sacar(decimal valor);



    }
}