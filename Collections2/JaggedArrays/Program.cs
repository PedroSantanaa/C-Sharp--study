internal class Program
{
    private static void Main(string[] args)
    {
        //família 1: Família Flinstones
        //família 2: Família Simpsons
        //família 3: Família Dona Florinda

        //JAGGED ARRAYS

        string[][] familias = new string[3][];
        familias[0] = new string[] { "Fred", "Vilma", "Pedrita" };
        familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
        familias[2] = new string[] { "Florinda", "Kiko" };

        //Para printar

        foreach (var s in familias)
        {
            Console.WriteLine(string.Join(",",s));
        }

    }
}