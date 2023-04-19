using bitebank.Contas;
using bitebank.Excecoes;
using bitebank.Titular;

void Parte1()
{
    // ContaCorrente contaDoAndre= new ContaCorrente(15,"1010-x");
    // // contaDoAndre.titular="Andre Silva";
    // // contaDoAndre.Numeroagencia=15;
    // // contaDoAndre.Conta="1010-x";
    // contaDoAndre.SetSaldo(100);
    //
    // Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
    // Console.WriteLine("Numero agencia"+contaDoAndre.Numeroagencia);
    //
    // contaDoAndre.Depositar(100);
    // Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
    // if(contaDoAndre.Saque(300)){
    //     Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
    // }else{
    //     Console.WriteLine("Saldo insuficiente");}
    //
    // ContaCorrente contaDaMaria=new ContaCorrente(23,"1212-x");
    // // contaDaMaria.titular="Maria Silva";
    // // contaDaMaria.Numeroagencia=23;
    // // contaDaMaria.Conta="1212-x";
    // contaDaMaria.SetSaldo(50);
    //
    // if(contaDoAndre.Transferir(50,contaDaMaria)){
    //     Console.WriteLine("O saldo de André é R$"+contaDoAndre.GetSaldo());
    //     Console.WriteLine("O saldo de Maria é R$"+contaDaMaria.GetSaldo());
    // }else{
    //     Console.WriteLine("Saldo insuficiente de André");
    //
    // }
    //
    // contaDoAndre.Show();
    //
    // Cliente cliente = new Cliente();
    // cliente.Nome = "Pedro";
    // cliente.Profissao = "estudante";
    // cliente.Cpf = "111-222";                    
    // ContaCorrente contaDePedro = new ContaCorrente(15,"111-x");
    // contaDePedro.Titular = cliente;
    // contaDePedro.SetSaldo(100);
    // // contaDePedro.Conta = "111-x";
    // // contaDePedro.Numeroagencia = 15;
    //
    // Console.WriteLine("Titular "+contaDePedro.Titular.Nome);
    // Console.WriteLine("Profissão "+contaDePedro.Titular.Profissao);
    // Console.WriteLine("CPF "+contaDePedro.Titular.Cpf);
    // Console.WriteLine("Saldo "+contaDePedro.GetSaldo());
    //
    // ContaCorrente conta4 = new ContaCorrente(18,"111-x");
    // conta4.SetSaldo(500);
    // // conta4.Numeroagencia = 18;
    // conta4.Titular = new Cliente();
    //
    // Console.WriteLine(conta4.GetSaldo());
    // Console.WriteLine(conta4.Numeroagencia);

}

void Excecoes()
{
    ContaCorrente conta1 = new ContaCorrente(123, "1234-x");
    Console.WriteLine(ContaCorrente.TaxaDeOperacao);
    try
    {
        ContaCorrente conta2 = new ContaCorrente(0, "1234-x");
    //     conta2.SetSaldo(100);
    //     conta2.Saque(50);
    //     Console.WriteLine(conta2.GetSaldo());
    //     conta2.Saque(60);
    //     Console.WriteLine(conta2.GetSaldo());
     }
    catch (ArgumentException e)
    {
        Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
        Console.WriteLine(e.StackTrace);
        Console.WriteLine(e.Message);
        Console.WriteLine(e.ParamName);
    }
    catch (SaldoInsuficienteException e)
    {
        Console.WriteLine("Operação nao realizada,saldo insuficiente!!");
        Console.WriteLine(e.Message);
    }
    
}

Excecoes();