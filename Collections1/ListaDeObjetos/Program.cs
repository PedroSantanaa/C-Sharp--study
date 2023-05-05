// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        var aulaIntro=new Aulas("Introdução a coleções",20);
        var aulaModelando =new Aulas( "Modelando as classes",18);
        var aulaSets = new Aulas("Trabalhando com conjuntos",16);

        //Para listas definidas
        List<Aulas> aulas = new List<Aulas>
        {
            aulaIntro, aulaModelando, aulaSets
        };
        //Para listas vazias
        List<Aulas> aulas2 = new List<Aulas>();
        aulas2.Add(aulaIntro);
        aulas2.Add(aulaModelando);
        aulas2.Add(aulaSets);
        Imprimir(aulas);
        Imprimir(aulas2);
    }

    private static void Imprimir(List<Aulas> aulas)
    {
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);
        }
        
    }
}

class Aulas
{
    private string titulo;
    private int tempo;

    public string Titulo
    {
        get => titulo;
        set => titulo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Tempo
    {
        get => tempo;
        set => tempo = value;
    }

    public Aulas(string titulo, int tempo)
    {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public override string ToString()
    {
        return $"[Titulo: {titulo}, Tempo: {tempo}minutos]";
    }
}