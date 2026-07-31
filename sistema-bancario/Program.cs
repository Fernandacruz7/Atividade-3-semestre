using sistema_bancario.Models;
using sistema_bancario.Services;

ContaCorrente conta = new ContaCorrente("Fernanda", 100);
// conta.Depositar(100);

conta.Sacar(300);
try
{
}
catch (Exception erro)
{
    Console.WriteLine($"Erro: {erro.Message}");

}

Console.WriteLine($"Saldo Atual: {conta.Saldo}");


//instanciar um objeto da classe banco

Banco banco = new();

banco.Adicionar(new ContaCorrente("Samuel", saldoInicial: 54000));
banco.Adicionar(new ContaPoupanca("Laura", saldoInicial: 25000));

banco.ProcessarMovimentacoes(); 