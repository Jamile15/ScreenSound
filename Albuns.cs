//criando albun

class Albuns
{
    private List<Musica> musicas = new List<Musica>();

    public Albuns(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicaDoAlbun()
    {
        Console.WriteLine($"Lista de musicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} - Gênero: {musica.Genero.Nome}");
        }
        Console.WriteLine($"A duração total do álbun é de {DuracaoTotal} segundos");
    }
}
