namespace Models
{
    public class Borracha
    {
        private string cor;
        private string marca;
        private string material;
        private int percentualBorracha;
        private bool apagarTexto;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public int PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }

        public bool ApagarTexto
        {
            get { return apagarTexto; }
            set { apagarTexto = value; }
        }

        public Borracha(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            Material = _material;
            percentualBorracha = 100;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("% Lamina: " + percentualBorracha);
        }

        public void Apagar()
        {
            if (percentualBorracha < 1)
            {
                Console.WriteLine("Compre outro apontador");
                return;
            }
            apagarTexto = true;
            DesgasteBorracha(1);
        }

        private void DesgasteBorracha(int _percentual)
        {
            percentualBorracha -= _percentual;
            if (percentualBorracha < 1)
                percentualBorracha = 0;
        }

        public void Escrever(string _texto)
        {
            if (percentualBorracha < 1)
            {
                Console.WriteLine("Compre outro apontador");
                return;
            }
            Console.WriteLine(_texto);
            DesgasteBorracha(1);
        }
    }
}
