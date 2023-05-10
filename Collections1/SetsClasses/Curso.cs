using System.Collections.ObjectModel;

namespace SetsClasses;

public class Curso
{
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
    }
}