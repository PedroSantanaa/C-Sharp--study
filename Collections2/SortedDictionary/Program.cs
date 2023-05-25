// See https://aka.ms/new-console-template for more information

using SortedList;

internal class Program
{
    public static void Main(string[] args)
    {
        //Sorted Dictionary
        IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
        sorted.Add("VT", new Aluno("Vanessa", 34672));
        sorted.Add("AL", new Aluno("Ana", 5617));
        sorted.Add("RN", new Aluno("Rafael", 17645));
        sorted.Add("WM", new Aluno("Wanderson", 11287));
        Console.WriteLine();
        
        foreach (var aluno in sorted)        
        {
            Console.WriteLine(aluno);
        }
        
        
    }
}