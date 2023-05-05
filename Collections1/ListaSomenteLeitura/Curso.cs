using System.Collections.ObjectModel;

namespace ListaSomenteLeitura;

public class Curso
{
    private IList<Aula> aulas;
    private string cursoNome;
    private string instrutor;

    public Curso(string cursoNome, string instrutor)
    {
        this.cursoNome = cursoNome;
        this.instrutor = instrutor;
        aulas = new List<Aula>();
    }

    public IList<Aula> Aulas
    {
        get => new ReadOnlyCollection<Aula>(aulas);
    }

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

    internal void Adiciona(Aula aula)
    {
        aulas.Add(aula);
    }
}