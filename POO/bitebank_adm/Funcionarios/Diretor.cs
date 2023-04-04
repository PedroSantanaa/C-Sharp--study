namespace bitebank_adm.Funcionarios;

public class Diretor:Funcionario
{
    public Diretor(string cpf):base(cpf,5000)
    {
        
        Console.WriteLine("Criando um Diretor/a!!!");
    }


    //metodos
    public override double GetBonificacao()
    {
        return Salario*0.5;
    }
    
    public override void AumentarSalario()
    {
        Salario *=  1.15;
    }

}