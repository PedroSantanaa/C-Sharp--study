// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        string aulaIntro="Introdução a coleções";
        string aulaModelando = "Modelando as classes";
        string aulaSets = "Trabalhando com conjuntos";

        //Para listas definidas
        List<string> aulas = new List<string>
        {
            aulaIntro, aulaModelando, aulaSets
        };
        //Para listas vazias
        List<string> aulas2 = new List<string>();
        aulas2.Add(aulaIntro);
        aulas2.Add(aulaModelando);
        aulas2.Add(aulaSets);
        Imprimir(aulas);
        Imprimir(aulas2);
    }

    private static void Imprimir(List<string> aulas)
    {
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);
        }
        
    }
}