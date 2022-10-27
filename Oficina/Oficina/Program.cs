using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu = new Pneu(30, "Michelan");
            pneu.Girar(5);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Freiar(900);
            pneu.Girar(999);
            pneu.Exibir();

        }
    }
}