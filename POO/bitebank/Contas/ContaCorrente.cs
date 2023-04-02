using bitebank.Titular;

namespace bitebank.Contas
{
    public class ContaCorrente
    {
        private int _numeroAgencia;
        public static int TotalContasCriadas { get; private set; }

        public int Numeroagencia
        {
            get => _numeroAgencia;
            private set {
                if (value > 0) {
                    _numeroAgencia = value; }
            }
        }
        public string Conta { get; set; }
        private double _saldo;

        public Cliente Titular { get; set; }

        public ContaCorrente(int numeroAgencia, string numeroConta )
        {
            Numeroagencia = numeroAgencia;
            Conta = numeroConta;
            TotalContasCriadas++;
        }
        

        public void Depositar(double valor){
            _saldo+=valor;
        }
        public bool Saque(double valor)
        {
            if(valor<=_saldo){
                _saldo-=valor;
                return true;
            }

            return false;

        }

        public bool Transferir(double valor,ContaCorrente destino)
        {
            if(_saldo<valor){
                return false;
            }
            Saque(valor);
            destino.Depositar(valor);
            return true;

        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }

            _saldo = valor;
        }

        public double GetSaldo() => _saldo;
        public void Show(){
            Console.WriteLine("Informações da conta: "+Titular+ " "+ _numeroAgencia+" "+Conta+" "+_saldo);
        }
    }
}