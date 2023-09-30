class Genero
{
    public string Nome { get; set; }

    public void ExibirGenero(Genero genero)
    {
        Console.WriteLine($"Gênero: {Nome}");
    }
}