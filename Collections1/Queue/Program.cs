// See https://aka.ms/new-console-template for more information

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("Kombi");
            Enfileirar("Ferrari");
            Enfileirar("Hb20");
            LiberarCarro();
            LiberarCarro();
            LiberarCarro();
            LiberarCarro();
            LiberarCarro();
            LiberarCarro();

        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine("Entrou na fila: " + veiculo);
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

        private static void LiberarCarro()
        {
            if (!pedagio.Any()) return;

            string carro=pedagio.Dequeue();
            Console.WriteLine("Saiu da fila: "+carro);
            ImprimirFila();
        }
    }
}

