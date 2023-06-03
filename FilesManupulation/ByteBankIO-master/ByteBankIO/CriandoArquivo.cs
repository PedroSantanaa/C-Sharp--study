using ByteBankIO;
using System.Text;
using System.Text.Unicode;

partial class Program
{
    static void CriandoArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo=new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "45617895 4768.40,Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes=encoding.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes,0,bytes.Length);

        }

    }
    static void CriandoArquivoComWrite()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor=new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("45617895 4768.40,Gustavo Santos");
        }
    }
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 10; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                Console.WriteLine($"Linha {i} escrita no arquivo,Tecle Enter...");
                Console.ReadLine(); 

            }

        }
    }

}
