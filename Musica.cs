// criando classe com propriedades tipadas para usar em outros arquivos adiciono o puplic antes da propriedade pra diser que essa propriedade é pplica

class Musica
{

    //construtor

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
 
    public Banda Artista { get;  }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero  Genero { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence ao {Artista}";
 

    // criando  um comportamento pra class musica que vai exibir uma fixa tecninca
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            System.Console.WriteLine("Adquira o pano Plus+");
        }
    }
}