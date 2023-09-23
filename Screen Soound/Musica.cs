using System.Reflection.Metadata;

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
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