// See https://aka.ms/new-console-template for more information

using SetsClasses;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando curso
        Curso cursoAlura = new Curso("Sets","Tiago");
        //Adicionando 3 aulas
        cursoAlura.Adiciona(new Aula("Set com classes",20));
        cursoAlura.Adiciona(new Aula("Set com hashcode",20));
        cursoAlura.Adiciona(new Aula("Set com equals",20));
        //Instanciando 3 alunos com suas matrículas:
        //Vanessa Tonini - 34672
        //Ana Losnak - 5617
        //Rafael Nercessian - 17645

        Aluno vanessa = new Aluno("Vanessa Tonini", 34672);
        Aluno ana = new Aluno("Ana Losnak", 5617);
        Aluno rafael = new Aluno("Rafael Nercessian ", 17645);
        Aluno tonini=new Aluno("Vanessa Tonini", 34672);    
        
        //Matriculando os alunos no curso
        cursoAlura.Matricula(vanessa);
        cursoAlura.Matricula(ana);
        cursoAlura.Matricula(rafael);
        
        //Imprimindo
        foreach (var aluno in cursoAlura.Alunos)
        {
            Console.WriteLine(aluno);
        }
        
        //O aluno esta matriculado??
        Console.WriteLine($"O aluno a1- {vanessa.Nome} está matriculado??");
        //Metodo para verificar isso
        Console.WriteLine(cursoAlura.EstaMatriculado(vanessa));
        //e verificar se Tonini está matriculada
        Console.WriteLine("Tonini está matriculada? " + cursoAlura.EstaMatriculado(tonini));
        //mas a1 == a Tonini?
        Console.WriteLine("a1 == a Tonini?");
        Console.WriteLine(vanessa == tonini);
        //o que ocorreu? a1 é equals a Tonini?
        Console.WriteLine("a1 é equals a Tonini?");
        Console.WriteLine(vanessa.Equals(tonini));
        
        Console.Clear();
        //Buscar aluno por numero de matricula
        Console.WriteLine("Quem é o aluno com a matricula 5617??");
        Aluno aluno5617=cursoAlura.BuscaMatriculado(5617);
        Console.WriteLine("Aluno 5617: "+aluno5617);
        //Quem eh o aluno 5618??
        Console.WriteLine("Quem é o aluno com a matricula 5618??");
        Aluno aluno5618=cursoAlura.BuscaMatriculado(5618);
        Console.WriteLine("Aluno 5618: "+aluno5618);
        
        //Substituir aluno
        Aluno fabio = new Aluno("Fabio Gushiken", 5617);
        cursoAlura.SubtituirAluno(fabio);
        //Buscar aluno por numero de matricula
        Console.WriteLine("Quem é o aluno com a matricula 5617??");
        Console.WriteLine(cursoAlura.BuscaMatriculado(5617));
        
    }
}