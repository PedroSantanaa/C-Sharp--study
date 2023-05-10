namespace SetsClasses;

public class Aula
{
    private string titulo;
    private int tempo;

    public string Titulo
    {
        get => titulo;
        set => titulo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Tempo
    {
        get => tempo;
        set => tempo = value;
    }

    public Aula(string titulo, int tempo)
    {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public override string ToString()
    {
        return $"[Titulo: {titulo}, Tempo: {tempo}minutos]";
    }
}