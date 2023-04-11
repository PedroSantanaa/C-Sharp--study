using bitebank_adm.SistemaInterno;

namespace bitebank_adm.Parcerias;

public class ParceiroComercial:IAutenticavel
{
    public string Login { get; set; }
    public string Senha { get; set; }
    public bool Autenticar(string login,string senha)
    {
        return (Login==login && Senha == senha);
    }
}