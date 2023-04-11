using bitebank_adm.SistemaInterno;

namespace bitebank_adm.Funcionarios;

public class GerenteDeContas:FuncionarioAutenticavel
{
    public GerenteDeContas(string cpf):base(cpf,4000)
    {
        
        Console.WriteLine("Criando um Gerente De Contas!!!");
    }

    //metodos
    public override double GetBonificacao()
    {
        return Salario*0.25;
    }
    
    public override void AumentarSalario()
    {
        Salario *=  1.05;
    }

}