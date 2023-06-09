using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_bitebank
{
    public class ContaCorrente

    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public double saldo;
        
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
        public void Show(){
            Console.WriteLine("Informações da conta: " + this.titular + " " + this.numeroAgencia + " " + this.conta + " " + this.saldo);
        }
    }
}