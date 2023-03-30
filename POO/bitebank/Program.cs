using bitebank.Contas;
using bitebank.Titular;

namespace bitebank;

class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaDoAndre= new ContaCorrente();
        // contaDoAndre.titular="Andre Silva";
        contaDoAndre.Numeroagencia=15;
        contaDoAndre.Conta="1010-x";
        contaDoAndre.SetSaldo(100);

        Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        Console.WriteLine("Numero agencia"+contaDoAndre.Numeroagencia);

        contaDoAndre.Depositar(100);
        Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        if(contaDoAndre.Saque(300)){
            Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
        }else{
            Console.WriteLine("Saldo insuficiente");}

        ContaCorrente contaDaMaria=new ContaCorrente();
        // contaDaMaria.titular="Maria Silva";
        contaDaMaria.Numeroagencia=23;
        contaDaMaria.Conta="1212-x";
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
        ContaCorrente contaDePedro = new ContaCorrente();
        contaDePedro.Titular = cliente;
        contaDePedro.SetSaldo(100);
        contaDePedro.Conta = "111-x";
        contaDePedro.Numeroagencia = 15;

        Console.WriteLine("Titular "+contaDePedro.Titular.Nome);
        Console.WriteLine("Profissão "+contaDePedro.Titular.Profissao);
        Console.WriteLine("CPF "+contaDePedro.Titular.Cpf);
        Console.WriteLine("Saldo "+contaDePedro.GetSaldo());
        
        


    }
}