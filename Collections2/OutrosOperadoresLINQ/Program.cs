internal class Program
{
    private static void Main(string[] args)
    {
        List<Mes> meses = new List<Mes>()
        {

            new Mes("Janeiro", 31),
            new Mes("Fevereiro", 28),
            new Mes("Março", 31),
            new Mes("Abril", 30),
            new Mes("Maio", 31),
            new Mes("Junho", 30),
            new Mes("Julho", 31),
            new Mes("Agosto", 31),
            new Mes("Setembro", 30),
            new Mes("Outubro", 31),
            new Mes("Novembro", 30),
            new Mes("Dezembro", 31)
        };

        var consulta = meses.Take(3);
        foreach (var mes in consulta)
        {

            Console.WriteLine(mes);
        }
        Console.WriteLine();
        var consulta2=meses.Skip(3);
        foreach(var mes in consulta2) { 
        
            Console.WriteLine(mes);
            }
    }
    class Mes /*: IComparable*/
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        //public int CompareTo(object? obj)
        //{
        //    Mes mes = obj as Mes;
        //    return this.Nome.CompareTo(mes.Nome);
        //}

        public override string ToString()
        {
            return $"{Nome}-{Dias}";
        }
    }
}