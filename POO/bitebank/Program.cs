using bitebank.Contas;
using bitebank.Titular;

namespace bitebank;

class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaDoAndre= new ContaCorrente(15,"1010-x");
        // contaDoAndre.titular="Andre Silva";
        // contaDoAndre.Numeroagencia=15;
        // contaDoAndre.Conta="1010-x";
        contaDoAndre.SetSaldo(100);

        Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        Console.WriteLine("Numero agencia"+contaDoAndre.Numeroagencia);

        contaDoAndre.Depositar(100);
        Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        if(contaDoAndre.Saque(300)){
            Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        }else{
            Console.WriteLine("Saldo insuficiente");}

        ContaCorrente contaDaMaria=new ContaCorrente(23,"1212-x");
        // contaDaMaria.titular="Maria Silva";
        // contaDaMaria.Numeroagencia=23;
        // contaDaMaria.Conta="1212-x";
        contaDaMaria.SetSaldo(50);

        if(contaDoAndre.Transferir(50,contaDaMaria)){
            Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
            Console.WriteLine("O saldo de Maria é R$"+contaDaMaria.GetSaldo());
        }else{
            Console.WriteLine("Saldo insuficiente de André");
  
        }

        contaDoAndre.Show();

        Cliente cliente = new Cliente();
        cliente.Nome = "Pedro";
        cliente.Profissao = "estudante";
        cliente.Cpf = "111-222";                    
        ContaCorrente contaDePedro = new ContaCorrente(15,"111-x");
        contaDePedro.Titular = cliente;
        contaDePedro.SetSaldo(100);
        // contaDePedro.Conta = "111-x";
        // contaDePedro.Numeroagencia = 15;

        Console.WriteLine("Titular "+contaDePedro.Titular.Nome);
        Console.WriteLine("Profissão "+contaDePedro.Titular.Profissao);
        Console.WriteLine("CPF "+contaDePedro.Titular.Cpf);
        Console.WriteLine("Saldo "+contaDePedro.GetSaldo());

        ContaCorrente conta4 = new ContaCorrente(18,"111-x");
        conta4.SetSaldo(500);
        // conta4.Numeroagencia = 18;
        conta4.Titular = new Cliente();

        Console.WriteLine(conta4.GetSaldo());
        Console.WriteLine(conta4.Numeroagencia);




    }
}