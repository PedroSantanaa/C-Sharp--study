using ListaSomenteLeitura;


class Program
{
    public static void Main(string[] args)
    {
        Curso cSharpColecoes = new Curso("C Sharp Coleções", "Pedro");
        cSharpColecoes.Adiciona(new Aula("Aprendendo listas",20));
        Imprimir(cSharpColecoes.Aulas);
    }
    private static void Imprimir(IList<Aula> aulas)
    {
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);
        }
        
    }
}