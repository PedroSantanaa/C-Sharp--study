namespace SortedList;

public class Aluno
{
    private string nome;
    private int numeroDeMatricula;

    public Aluno(string nome, int numeroDeMatricula)
    {
        this.nome = nome;
        this.numeroDeMatricula = numeroDeMatricula;
    }

    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumeroDeMatricula
    {
        get => numeroDeMatricula;
        set => numeroDeMatricula = value;
    }

    public override string ToString()
    {
        return $"[Nome:{nome} , Matricula:{numeroDeMatricula}]";
    }

    public override bool Equals(object? obj)
    {
        Aluno outro=obj as Aluno;
        if (outro==null)
        {
            return false;
        }
        
        return nome.Equals(outro.nome);
    }

    public override int GetHashCode()
    {
        return nome.GetHashCode();
    }
}
