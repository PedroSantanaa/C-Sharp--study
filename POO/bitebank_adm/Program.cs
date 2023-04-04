using bitebank_adm.Funcionarios;
using bitebank_adm.Utilitario;

Funcionario pedro=new Funcionario();

pedro.Nome="Pedro Santana";
pedro.Cpf="123456789";
pedro.Salario=1590.50;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta=new Diretor
{
    Nome = "Roberta Silva",
    Cpf = "0000000",
    Salario = 5000
};

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador=new GerenciadorDeBonificacao();
Console.WriteLine(gerenciador.TotalBonificacoes);
gerenciador.Registrar(pedro);
Console.WriteLine(gerenciador.TotalBonificacoes);
gerenciador.Registrar(roberta);
Console.WriteLine(gerenciador.TotalBonificacoes);