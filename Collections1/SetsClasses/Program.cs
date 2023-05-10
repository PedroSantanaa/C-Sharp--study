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
        
        //Matriculando os alunos no curso
        cursoAlura.Matricula(vanessa);
        cursoAlura.Matricula(ana);
        cursoAlura.Matricula(rafael);
        
        //Imprimindo
        foreach (var aluno in cursoAlura.Alunos)
        {
            Console.WriteLine(aluno);
        }

    }
}