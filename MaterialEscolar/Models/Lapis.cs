using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Models
{
    public class Lapis
    {
        private string dureza;
        private bool apontado;
        private int percentualGrafite;

        public string Dureza    
        {
            get { return dureza; }
            set { dureza = value; }
        }
        public bool Apontado
        {
            get { return apontado; }    
            set { apontado = value; }
        }

        public int PercentualGrafite
        {
            get { return percentualGrafite; }
            set { percentualGrafite = value; }   
        }
        public Lapis(string dureza)
        {
            Dureza = dureza;
            Apontado = true;
            PercentualGrafite = 100;
        }

        public void Exibir()
        {
            Console.WriteLine("Dureza: " + Dureza);
            Console.WriteLine("% Grafite: " + PercentualGrafite);
        }

        public void QuebrarPonta()
        {
            if(PercentualGrafite < 15)
            {
                Console.WriteLine("Compre outro lapís");
                return;
            }
            apontado = false;
            GastarGrafite(15);
        }

        public void Apontar()
        {
            if(percentualGrafite < 5)
            {
                Console.WriteLine("Compre outro lapís");
                return ;
            }
            apontado = true;
            GastarGrafite(5);
        }

        private void GastarGrafite(int _percentual)
        {
            percentualGrafite -= _percentual;
            if (percentualGrafite < 0)
                percentualGrafite = 0;
        }

        public void Escrever(string _texto)
        {
            if (percentualGrafite < 10)
            {
                Console.WriteLine("Compre outro lapís");
                return;
            }
            if(!Apontado)
            {
                Console.WriteLine("Aponte o lapís");
                return;
            }
            Console.WriteLine(_texto);
            GastarGrafite(10);
        }

    }
}   
          
    
