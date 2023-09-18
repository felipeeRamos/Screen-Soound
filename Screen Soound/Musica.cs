class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no Plano");
        }
        else
        {
            Console.WriteLine("Não disponivel no plano");
        }
    }
}