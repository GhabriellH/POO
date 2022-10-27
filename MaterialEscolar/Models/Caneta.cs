namespace Models
{
	public class Caneta
	{
        private string cor;
        private bool tampada;
        private bool caida;
        private bool estourada;
        private int percentualCarga;
        private string marca;
        private string material;


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
        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }

        public Caneta(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            Material = _material;
            PercentualCarga = 100;
        }

        public void Tampar()
        {
            Tampada = true; 
        }
        public void Destampar()
        {
            Tampada = false;
        }

        public void Escrever(string _texto)
        {
            if(Tampada)
            {
                Console.WriteLine("A caneta está tampada.");
                return; 
            }
            if(caida)
            {
                Console.WriteLine("Pegue a do chão");
            }
            if(Estourada)
            {
                Console.WriteLine("A caneta está estourada");
            }
            Console.WriteLine(_texto);
            PercentualCarga -= 10;
        }

        public void Exibir()
        {
            Console.WriteLine("cor: " + Cor);
            Console.WriteLine("marca: " + Marca);
            Console.WriteLine("material: " + Material);
            Console.WriteLine("% carga: " + PercentualCarga);
            Console.WriteLine("Tampada: " + Convert.ToString(Tampada));   
        }

    }

}