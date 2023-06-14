using System.Collections.ObjectModel;

namespace SetsClasses;

public class Curso
{
    //Dicionario
    private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
    private ISet<Aluno> alunos = new HashSet<Aluno>();
    private IList<Aula> aulas;
    private string cursoNome;
    private string instrutor;
    

    public Curso(string cursoNome, string instrutor)
    {
        this.cursoNome = cursoNome;
        this.instrutor = instrutor;
        aulas = new List<Aula>();
    }

    public IList<Aula> Aulas => new ReadOnlyCollection<Aula>(aulas);
    public IList<Aluno> Alunos => new ReadOnlyCollection<Aluno>(alunos.ToList());

    public string CursoNome
    {
        get => cursoNome;
        set => cursoNome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Instrutor
    {
        get => instrutor;
        set => instrutor = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Adiciona(Aula aula)
    {
        aulas.Add(aula);
    }

    public void Matricula(Aluno aluno)
    {
        alunos.Add(aluno);
        dicionarioAlunos.Add(aluno.NumeroDeMatricula,aluno);
    }

    public bool EstaMatriculado(Aluno aluno)
    {
        return alunos.Contains(aluno);
    }

    public Aluno BuscaMatriculado(int numeroDeMatricula)
    {
        // foreach (var aluno in alunos)
        // {
        //     if (aluno.NumeroDeMatricula==numeroDeMatricula)
        //     {
        //         return aluno;
        //     }
        //
        // }
        //
        // throw new Exception("Matricula não encontrado:" + numeroDeMatricula);
        Aluno? aluno = null;
        // return dicionarioAlunos[numeroDeMatricula];
        dicionarioAlunos.TryGetValue(numeroDeMatricula, out aluno);
        return aluno;
    }

    public void SubtituirAluno(Aluno aluno)
    {
        dicionarioAlunos[aluno.NumeroDeMatricula] = aluno;
    }
}