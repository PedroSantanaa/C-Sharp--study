// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        string aulaIntro="Introdução a coleções";
        string aulaModelando = "Modelando as classes";
        string aulaSets = "Trabalhando com conjuntos";

        //Tamanho e conteudo pre estabelcido
        string[] aulas = {
            aulaIntro, aulaModelando, aulaSets
        };
        //Tamanho mas conteudo nao estabelecido
        string[] aulas2 = new string[3];
        aulas2[0] = aulaIntro;
        aulas2[1] = aulaModelando;
        aulas2[2] = aulaSets;
        Imprimir(aulas2);
        
        //IndexOf
        Console.WriteLine("A aula de introdução a coleções etá no indice "+ Array.IndexOf(aulas2,aulaIntro));
        Console.WriteLine(Array.LastIndexOf(aulas2,aulaIntro));
        //Reverse
        Array.Reverse(aulas2);
        Imprimir(aulas2);
        Array.Reverse(aulas2);
        Imprimir(aulas2);
        //Resize
        Array.Resize(ref aulas2,2);
        Imprimir(aulas2);
        
    }

    private static void Imprimir(string[] aulas2)
    { 
        foreach (var aula in aulas2)
        {
            Console.WriteLine(aula);
        }
    }
}