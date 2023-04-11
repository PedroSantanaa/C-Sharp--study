using bitebank_adm.Funcionarios;

namespace bitebank_adm.SistemaInterno;

public interface IAutenticavel
{
    public string Login { get; set; }
    public string Senha { get; set; }
    public bool Autenticar(string login,string senha);
}