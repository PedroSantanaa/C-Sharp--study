// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
        {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian",
            "Priscila Stuani"
        };
        //adicionar: Rafael Rollo
        alunos.Add("Rafael Rollo");
        //adicionar: Fabio Gushiken
        alunos.Add("Fabio Gushiken");
        //adicionar: Fabio Gushiken
        alunos.Add("Fabio Gushiken");
        //adicionar: FABIO GUSHIKEN
        alunos.Add("FABIO GUSHIKEN");

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        ISet<string> outroConjunto = new HashSet<string>();
        //este conjunto é subconjunto de outro?
        alunos.IsSubsetOf(outroConjunto);
        //este conjunto é superconjunto de outro?
        alunos.IsSupersetOf(outroConjunto);
        //este conjunto contem os mesmos elementos?
        alunos.SetEquals(outroConjunto);
        //subtrai os elementos da outra coleção que também estão nesse? ExceptWith
        alunos.ExceptWith(outroConjunto);
        //intersecção dos conjutos
        alunos.IntersectWith(outroConjunto);
        //somente em um ou outro conjunto
        alunos.SymmetricExceptWith(outroConjunto);
        //uniao de conjuntos
        alunos.UnionWith(outroConjunto);
    }
}

internal class ComparadorMinusculo : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}