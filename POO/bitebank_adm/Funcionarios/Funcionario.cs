namespace bitebank_adm.Funcionarios;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public double Salario { get; set; }


    //metodos
    public double GetBonificacao()
    {
        return Salario * 0.1;
    }
    
    
}