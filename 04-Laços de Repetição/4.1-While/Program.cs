// See https://aka.ms/new-console-template for more information

class Caracteres{

  static void Main(string[] args){
    double investimento=1000;

    //rendimento 0.5% ao mes
    double rendimento=0;
    // rendimento=investimento*0.005;
    // investimento+=rendimento;
    // Console.WriteLine("Seu investimento rendeu: R$"+rendimento+" "+"e no total voce tem R$"+investimento);

    //Para 12 meses
    int mes=1;
    while(mes<=12){
      rendimento=investimento*0.005;
      investimento+=rendimento;
      mes+=1;
    }
    Console.WriteLine("Seu investimento rendeu por "+(mes-1)+" meses "+"e no total voce tem R$"+investimento);
  
  }
}
