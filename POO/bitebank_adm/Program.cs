using bitebank_adm.Funcionarios;
using bitebank_adm.Parcerias;
using bitebank_adm.SistemaInterno;
using bitebank_adm.Utilitario;

#region MyRegion
// Funcionario pedro=new Funcionario("123456789",1590.50);
//
// pedro.Nome="Pedro Santana";
//
// Console.WriteLine(pedro.Nome);
// Console.WriteLine(pedro.GetBonificacao());
//
// Diretor roberta=new Diretor("0000000");
// roberta.Nome = "Roberta Silva";
//
// Console.WriteLine(roberta.Nome);
// Console.WriteLine(roberta.GetBonificacao());
//
// GerenciadorDeBonificacao gerenciador=new GerenciadorDeBonificacao();
// Console.WriteLine("Total de bonificação: "+gerenciador.TotalBonificacoes);
// gerenciador.Registrar(pedro);
// Console.WriteLine("Total de bonificação: "+gerenciador.TotalBonificacoes);
// gerenciador.Registrar(roberta);
// Console.WriteLine("Total de bonificação: "+gerenciador.TotalBonificacoes);
// Console.WriteLine("Total de funcionarios: "+Funcionario.TotalDeFuncionarios);
//
// pedro.AumentarSalario();
// roberta.AumentarSalario();
//
// Console.WriteLine("Novo salario de pedro: "+pedro.Salario);
// Console.WriteLine("novo salario de roberta: "+roberta.Salario);


#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";
    
    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de bonificação: "+gerenciador.TotalBonificacoes);
}
// CalcularBonificacao();

void SistemaInterno()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("05697787");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "ingrid@gmail.com";
    ingrid.Senha = "123";

    GerenteDeContas alberto = new GerenteDeContas("432432423");
    alberto.Nome = "Alberto Magno";
    alberto.Login = "alberto@gmail.com";
    alberto.Senha = "321";

    ParceiroComercial pedro = new ParceiroComercial();
    pedro.Login = "pedro@gmail.com";
    pedro.Senha = "1234";

    sistema.Logar(ingrid, "ingrid@gmail.com","123");
    sistema.Logar(alberto, "alberto@gmail.com","123");
    sistema.Logar(pedro, "pedro@gmail.com", "1234");
}
SistemaInterno();