// criando classe com propriedades tipadas para usar em outros arquivos adiciono o puplic antes da propriedade pra diser que essa propriedade é pplica

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

// criando  um comportamento pra class musica
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        if(disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            System.Console.WriteLine("Adquira o pano Plus+");
        }
        }
}