class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);

    }
    public void ExibirDetalhes()
    {
       Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
       foreach (Episodio episodio in episodios)
       {
        Console.WriteLine(episodio.Resumo);
       };
       Console.WriteLine($"\n\n Este podcast possui {TotalEpisodios}.episódios");
       
    }
}