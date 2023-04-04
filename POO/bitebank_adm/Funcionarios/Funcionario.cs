namespace bitebank_adm.Funcionarios;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public double Salario { get; protected set; }

    public static int TotalDeFuncionarios { get; private set; }

    public Funcionario(string cpf,double salario)
    {
        Cpf = cpf;
        Salario = salario;
        TotalDeFuncionarios++;
    }

    //metodos
    public abstract double GetBonificacao();
    public abstract void AumentarSalario();


}