class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    private List<Genero> generos = new List<Genero>();
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public String DescricaoResumida => 
        $"A musica {Nome} pertence á banda {Artista}";

    


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no Plano");
        }
        else
        {
            Console.WriteLine("Não disponivel no plano");
        }
    }
}