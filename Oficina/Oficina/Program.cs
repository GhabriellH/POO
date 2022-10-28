using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu = new Pneu(30, "Michelan");
            
            //pneu.Exibir();
            //Pneu pneuMichelan = new Pneu(16, "Michelan");
            Carro carro = new Carro("Fiat", "SUV");
          
                //carro.LigarDesligar();
                carro.Acelerar(100);
                carro.Frear(20);
                carro.Exibir();
        }
    }
}