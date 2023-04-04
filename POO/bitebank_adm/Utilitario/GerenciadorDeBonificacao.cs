using bitebank_adm.Funcionarios;

namespace bitebank_adm.Utilitario;

public class GerenciadorDeBonificacao
{
    public double TotalBonificacoes { get; private set; }
    
    
    //metodos
    public void Registrar(Funcionario funcionario)
    {
        TotalBonificacoes += funcionario.GetBonificacao();
    }
}