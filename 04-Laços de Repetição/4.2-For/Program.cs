// See https://aka.ms/new-console-template for more information

class Caracteres{

  static void Main(string[] args){
    double investimento=1000;
    double rendimento=0;

    //Para 12 meses
    for(int mes=1;mes<=12;mes++){
      rendimento=investimento*0.005;
      investimento+=rendimento;
      Console.WriteLine("Seu investimento rendeu por "+(mes)+" meses "+" "+"com rendimento de R$"+rendimento+" e no total voce tem R$"+investimento);
    }
    
  
  }
}
