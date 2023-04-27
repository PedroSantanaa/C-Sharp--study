namespace bitebank;

public class LeitorDeArquivos
{
    public string Arquivo { get; }

    public LeitorDeArquivos(string arquivo)
    {
        Arquivo = arquivo;

        // throw new FileNotFoundException();

        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }

    public string LerProximaLinha()
    {
        Console.WriteLine("Lendo linha. . .");

        throw new IOException();

        return "Linha do arquivo";
    }

    public void Fechar()
    {
        Console.WriteLine("Fechando arquivo.");
    }
}
