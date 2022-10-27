using Models;

public class Program
{
    private static void Main(string[] args)
    { 
        Caderno caderno = new Caderno("");
        Caneta caneta = new Caneta("Azul", "Bic", "Madeira");
        caneta.Exibir();
        caneta.Escrever("Ghabriell");
        caneta.Exibir();
        Lapis lapis = new Lapis("");
        Apontador apontador = new Apontador("Preto", "Estrela", "Plastico");
        Borracha borracha = new Borracha("Branca","Fabercastell","borracha");
    }
}