using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        AutenticacaoUtil Autenticado { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return this.Autenticado.ValidarSenha(Senha, senha);
        }
    }
}
