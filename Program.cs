
using Jogo_Prorotype;
using Jogo_Prorotype.Models;

Personagem  per = new Personagem();

per.Nome = "";
per.QuantidadeVida = 100;
per.ForcaAtaque = 10;
per.Classe = "";


Console.WriteLine(per.Nome);
Console.WriteLine(per.QuantidadeVida);
Console.WriteLine(per.ForcaAtaque);
Console.WriteLine(per.Classe);



Personagem copia = per.Clone();

copia.Nome = "";
copia.QuantidadeVida = 100;
copia.ForcaAtaque = 30;
copia.Classe = "";

Console.WriteLine(copia.Nome);
Console.WriteLine(copia.QuantidadeVida);
Console.WriteLine(copia.ForcaAtaque);
Console.WriteLine(copia.Classe);