// See https://aka.ms/new-console-template for more information

class Caracteres{

  static void Main(string[] args){
    Console.WriteLine("Condicionais");

    int idadePedro=16;
    int qtdPessoas=0;
    bool convite=true;
    if(idadePedro>18 || qtdPessoas>0 || convite){
      Console.WriteLine("Pedro é maior de idade ou está acompanhado, logo pode entrar na festa");
    }else{
      Console.WriteLine("Pedro é menor de idade ou não esta acompanhado");
    }

  
  }
}
