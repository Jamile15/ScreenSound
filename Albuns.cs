//criando albun

class Albuns
{
    private List<Musica> musicas=new List<Musica>();
    public string Nome { get; set; }
    public int Duracao { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
}
