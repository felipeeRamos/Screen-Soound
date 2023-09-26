Album albumCamilaCabello = new Album();
albumCamilaCabello.Nome = "Romance";

Musica musica1 = new Musica();
musica1.Nome = "Bad Kind Of The Butterflies";
musica1.Duracao = 250;

Musica musica2 = new Musica();
musica2.Nome = "Cry In The Club";
musica2.Duracao = 337;

albumCamilaCabello.AdicionarMusica(musica1);
albumCamilaCabello.AdicionarMusica(musica2);

Banda CamilaC = new Banda();
CamilaC.Nome = "Camila Cabello";
CamilaC.AdicionarAlbum(albumCamilaCabello);
CamilaC.ExibirDiscografia();