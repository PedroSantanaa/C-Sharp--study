namespace bitebank_adm.Funcionarios;

public class Auxiliar:Funcionario
{

    public Auxiliar(string cpf):base(cpf,2000)
    {
        
        Console.WriteLine("Criando um Auxiliar!!!");
    }

    //metodos
    public override double GetBonificacao()
    {
        return Salario*0.2;
    }
    
    public override void AumentarSalario()
    {
        Salario *=  1.1;
    }

}
