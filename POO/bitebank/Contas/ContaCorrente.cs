using bitebank.Titular;

namespace bitebank.Contas
{
    public class ContaCorrente
    {
        private int numeroAgencia;

        public int Numeroagencia
        {
            get => numeroAgencia;
            set {
                if (value > 0) {
                    numeroAgencia = value; }
            }
        }
        public string Conta { get; set; }
        private double saldo;

        public Cliente Titular { get; set; }
        
        public void Depositar(double valor){
            this.saldo+=valor;
        }
        public bool Saque(double valor){
            if(valor<=this.saldo){
                this.saldo-=valor;
                return true;
            }
            else{
                    
                return false;
            }
            
        }

        public bool Transferir(double valor,ContaCorrente destino){
            if(this.saldo<valor){
                return false;
            }else{
                this.Saque(valor);
                destino.Depositar(valor);
                return true;
            }

        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }

            saldo = valor;
        }

        public double GetSaldo() => saldo;
        public void Show(){
            Console.WriteLine("Informações da conta: "+Titular+ " "+ this.numeroAgencia+" "+Conta+" "+this.saldo);
        }
    }
}