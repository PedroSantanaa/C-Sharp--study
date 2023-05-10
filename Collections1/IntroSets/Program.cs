// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        ISet<string> alunos = new HashSet<string>();
        //Adcionando alunos
        alunos.Add("Vanessa");
        alunos.Add("Pedro");
        alunos.Add("Isabela");
        Console.WriteLine(alunos);
        Console.WriteLine(string.Join(",",alunos));
        //Add mais alunos
        alunos.Add("Tiago");
        alunos.Add("Alberto");
        alunos.Add("Larissa");
        Console.WriteLine(string.Join(",",alunos));
        //Removendo 1 alunos e add outro
        alunos.Remove("Tiago");
        alunos.Add("Tiago Santana");
        Console.WriteLine(string.Join(",",alunos));
    }
}