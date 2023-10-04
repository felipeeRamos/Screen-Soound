class Banda
{
    private List<Album> Albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;   
    }
    public string Nome { get; }

    public void AdicionarAlbum (Album Album)
    {
        Albums.Add(Album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");

        foreach (Album Album in Albums)
        {
            Console.WriteLine($"Album: {Album.Nome}");
        }
    }
        


}