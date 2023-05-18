// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        var navegador = new Navegador();
        navegador.NavegarPara("google.com");
        navegador.NavegarPara("alura.com");
        navegador.NavegarPara("facebook.com");

        navegador.Anterior();
        navegador.Anterior();
        navegador.Anterior();

        navegador.Proximo();
        
    }

    public class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Pagina atual: "+ atual);
        }

        public void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Pagina atual: "+ atual);
        }

        public void Anterior()
        {
            if(historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual= historicoAnterior.Pop();
                Console.WriteLine("Pagina atual: "+ atual);
                
            }
        }

        public void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Pagina atual: "+ atual);
                
            }
        }
    }
}