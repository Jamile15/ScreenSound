// chamo minha calse musica como se fosse um tipo pra por em uma variavel
// esse new musica quer dizer que estamos criando um objeto especifico de tipo Musica

//Musica musica1 = new Musica();
//musica1.Nome = "Roxane";
//musica1.Artista = "The Police";
//musica1.Duracao = 273;
//musica1.Disponivel=(true);
//Console.WriteLine(musica1.DescricaoResumida);


//Musica musica2 = new Musica();
//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 367;
//musica2.Disponivel=(false);
//Console.WriteLine(musica2.DescricaoResumida);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//-----------------------------------------------------------------------------------------------------------------

Banda queen = new Banda("Queen");

Albuns albunDoQueen = new Albuns("A night at the opera");

Genero generoMusica1 = new Genero();
generoMusica1.Nome = "Mista";

Genero generoMusica2 = new Genero();
generoMusica2.Nome = "Pesada";

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
    Genero = generoMusica1,

    };





Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 350,
    Disponivel = false,
    Genero = generoMusica2,
};


albunDoQueen.AdicionarMusica(musica1);
albunDoQueen.AdicionarMusica(musica2);
albunDoQueen.ExibirMusicaDoAlbun();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.AdicionarAlbun(albunDoQueen);
queen.ExibirDiscografia();