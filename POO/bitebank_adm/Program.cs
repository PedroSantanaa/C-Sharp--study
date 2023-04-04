using bitebank_adm.Funcionarios;
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
CalcularBonificacao();