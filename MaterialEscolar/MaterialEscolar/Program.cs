using Models;

public class Program
{
    private static void Main(string[] args)
    { 
        Caderno caderno = new Caderno("");
        Caneta caneta = new Caneta("Azul", "Bic", "Madeira");
        Lapis lapis = new Lapis("");
        Apontador apontador = new Apontador("Preto", "Estrela", "Plastico");
        apontador.Exibir();
        Borracha borracha = new Borracha("Branca","Fabercastell","borracha");
    }
}