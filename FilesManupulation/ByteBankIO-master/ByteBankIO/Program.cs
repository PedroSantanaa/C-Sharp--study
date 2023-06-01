using ByteBankIO;
using System.Text;
using System.Text.Unicode;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        using(var fluxoDeArquivo=new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor=new StreamReader(fluxoDeArquivo);
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
                Console.WriteLine(linha);
            }
        }
       Console.ReadLine();
    }
        
}