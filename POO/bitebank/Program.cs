using bitebank.Contas;
using bitebank.Titular;

namespace bitebank;

class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaDoAndre= new ContaCorrente();
        // contaDoAndre.titular="Andre Silva";
        contaDoAndre.numeroAgencia=15;
        contaDoAndre.conta="1010-x";
        contaDoAndre.saldo=100;

        Console.WriteLine("O saldo de André é R$"+contaDoAndre.saldo);

        contaDoAndre.Depositar(100);
        Console.WriteLine("O saldo de André é R$"+contaDoAndre.saldo);
        if(contaDoAndre.Saque(300)){
            Console.WriteLine("O saldo de André é R$"+contaDoAndre.saldo);
        }else{
            Console.WriteLine("Saldo insuficiente");}

        ContaCorrente contaDaMaria=new ContaCorrente();
        // contaDaMaria.titular="Maria Silva";
        contaDaMaria.numeroAgencia=23;
        contaDaMaria.conta="1212-x";
        contaDaMaria.saldo=50;

        if(contaDoAndre.Transferir(50,contaDaMaria)){
            Console.WriteLine("O saldo de André é R$"+contaDoAndre.saldo);
            Console.WriteLine("O saldo de Maria é R$"+contaDaMaria.saldo);
        }else{
            Console.WriteLine("Saldo insuficiente de André");
  
        }

        contaDoAndre.Show();

        Cliente cliente = new Cliente();
        cliente.Nome = "Pedro";
        cliente.Profissao = "estudante";
        cliente.Cpf = "111-222";
        ContaCorrente contaDePedro = new ContaCorrente();
        contaDePedro.titular = cliente;
        contaDePedro.saldo = 100;
        contaDePedro.conta = "111-x";
        contaDePedro.numeroAgencia = 15;

        Console.WriteLine("Titular "+contaDePedro.titular.Nome);
        Console.WriteLine("Profissão "+contaDePedro.titular.Profissao);
        Console.WriteLine("CPF "+contaDePedro.titular.Cpf);
        Console.WriteLine("Saldo "+contaDePedro.saldo);
        


    }
}