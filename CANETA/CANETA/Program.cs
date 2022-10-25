using System;
using MODELS;

namespace Material
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CANETINHAS");

            Caneta canetaBic = new Caneta("Azul",14,0.5,"BIC","PLÁSTICO",2.0,"COMUM");
            canetaBic.Exibir();
            canetaBic.Destampar();
            canetaBic.Escrever("Nome: Ghabriell");
            canetaBic.Escrever("Profissão suporte");
            canetaBic.Escrever("Idade: 17");
            canetaBic.Escrever("Endereço: em casa");

            Console.WriteLine("\n");
            Caneta canetaHidro = new Caneta("vermelho", 12, 1.0, "COMPACTO", "METAL", 1.0, "INTERMEDIARIA");
            canetaHidro.Exibir();
            canetaHidro.Destampar();
            canetaHidro.Escrever("Nome: Ghabriell");
            canetaHidro.Escrever("Profissão suporte");
            canetaHidro.Escrever("Idade: 17");
            canetaHidro.Escrever("Endereço: em casa");
        }
    }
}