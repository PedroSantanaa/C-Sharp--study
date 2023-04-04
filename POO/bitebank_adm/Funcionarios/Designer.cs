namespace bitebank_adm.Funcionarios;

public class Designer:Funcionario
{
    public Designer(string cpf):base(cpf,3000)
    {
        
        Console.WriteLine("Criando um Designer!!!");
    }

    //metodos
    public override double GetBonificacao()
    {
        return Salario*0.17;
    }
    
    public override void AumentarSalario()
    {
        Salario *=  1.11;
    }
}