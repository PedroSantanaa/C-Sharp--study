// See https://aka.ms/new-console-template for more information
using _01_bitebank;
class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaDoAndre = new ContaCorrente();
        contaDoAndre.titular = "Andre Silva";
        contaDoAndre.numeroAgencia = 15;
        contaDoAndre.conta = "1010-x";
        contaDoAndre.saldo = 100;

        Console.WriteLine("O saldo de André é R$" + contaDoAndre.saldo);

        contaDoAndre.Depositar(100);
        Console.WriteLine("O saldo de André é R$" + contaDoAndre.saldo);
        if (contaDoAndre.Saque(300) == true)
        {
            Console.WriteLine("O saldo de André é R$" + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        };

        ContaCorrente contaDaMaria = new ContaCorrente();
        contaDaMaria.titular = "Maria Silva";
        contaDaMaria.numeroAgencia = 23;
        contaDaMaria.conta = "1212-x";
        contaDaMaria.saldo = 50;

        if (contaDoAndre.Transferir(50, contaDaMaria))
        {
            Console.WriteLine("O saldo de André é R$" + contaDoAndre.saldo);
            Console.WriteLine("O saldo de Maria é R$" + contaDaMaria.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente de André");

        }

        contaDoAndre.Show();
    }
}