using ByteBankIO;

internal partial class Program
{
    private static void UsandoStreamReader(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            //Linha unica
            // var linha=leitor.ReadLine();
            //Console.WriteLine(linha);
            //Arquivo completo
            //var texto=leitor.ReadToEnd();
            //Console.WriteLine(texto);
            //Linha a linha
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();

                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"Conta numero: {contaCorrente.Numero}, Agencia:{contaCorrente.Agencia}, Saldo:{contaCorrente.Saldo}";

                Console.WriteLine(msg);
                //Console.WriteLine(linha);
            }
        }
        Console.ReadLine();
    }
    static ContaCorrente ConverterStringParaContaCorrente(string? linha)
        {
            var campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace(".", ",");
            var titularConta = campos[3];

            //transformando para int

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = titularConta;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;

        }
    }
