// criando classe com propriedades tipadas para usar em outros arquivos adiciono o puplic antes da propriedade pra diser que essa propriedade é pplica

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    //metodo pra leitura do disponivrl rlr trmdentro do ( vai ta o argumento que e o valor que quero usar no disponivel )
public void EscreveDisponivel(bool value)
{
    disponivel = value;
}

//metodoto pra leitura entregando um valor então coloco o tipo boolean ja que ele tem um return
public bool LeituraDisponivel()
{
    return disponivel;
}

// criando  um comportamento pra class musica que vai exibir uma fixa tecninca
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