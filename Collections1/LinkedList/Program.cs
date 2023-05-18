// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        //Criando uma lista
        List<string> frutas = new List<string>
        {
            "abacate", "banana", "caqui", "damasco", "figo"
        };
        //Imprimir a lista
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        //Linked List
        LinkedList<string> dias = new LinkedList<string>();
        //adicionando itens-quarta
        var d4=dias.AddFirst("quarta");
        //quarta é o primeiro elemento do linked list
        //cada elemento é um nó
        //para pegar o valor de d4
        Console.WriteLine(d4.Value);
        //adicionar segunda antes de quarta
        var d2=dias.AddBefore(d4, "segunda");
        //adicionar terça de pois de segunda
        var d3 = dias.AddAfter(d2, "terça");
        //sexta dps quarta
        var d6 = dias.AddAfter(d4, "sexta");
        //sabado dps da sexta
        var d7 = dias.AddAfter(d6, "sabado");
        //quinta antes sexta
        var d5 = dias.AddBefore(d6, "quinta");
        //domingo antes de segunda
        var d1 = dias.AddBefore(d2, "domingo");
        //printar
        foreach (var dia in dias)  
        {
            Console.WriteLine(dia);
        }
        //para encontrar um item
        var quarta = dias.Find("quarta");
        //para remover
        //dias.Remove("quarta") ou dias.Remove(d4)
        


    }
}