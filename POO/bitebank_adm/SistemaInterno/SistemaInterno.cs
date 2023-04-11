using bitebank_adm.Funcionarios;

namespace bitebank_adm.SistemaInterno;

public class SistemaInterno
{
    
    public bool Logar(IAutenticavel funcionario,string login,string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(login,senha);
        if (usuarioAutenticado)
        {
            Console.WriteLine("Bem vindo ao sistema, usuario autenticado!!");
            return true;
        }
        Console.WriteLine("Login /ou Senha de autenticação incorreta");
        return false;

    }
}