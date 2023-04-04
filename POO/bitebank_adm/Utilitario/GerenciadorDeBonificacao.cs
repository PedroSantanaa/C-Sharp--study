using bitebank_adm.Funcionarios;

namespace bitebank_adm.Utilitario;

public class GerenciadorDeBonificacao
{
    public double TotalBonificacoes { get; private set; }
    
    //metodos
    public void Registrar(Funcionario funcionario)
    {
        this.TotalBonificacoes += funcionario.GetBonificacao();
    }
    public void Registrar(Diretor funcionario)
    {
        this.TotalBonificacoes += funcionario.GetBonificacao();
    }
}