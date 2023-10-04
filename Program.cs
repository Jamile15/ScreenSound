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

Albuns albunDoQueen = new Albuns();
albunDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";

albunDoQueen.AdicionarMusica(musica1);
albunDoQueen.AdicionarMusica(musica2);