namespace MODELS
{
    public class Caneta
    {
        public string Cor;
        public double Tamanho;
        public double Peso;
        public bool Tampada;
        public bool Caida;
        public bool Estourada;
        public int PercentualCarga;
        public string Marca;
        public string Material;
        public double Ponta;
        public string TipoPonta;

        public Caneta(string _cor, double _tamanho, double _peso, string _marca, string _material, double _ponta, string _tipoponta)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            Material = _material;
            Ponta = _ponta;         
            TipoPonta = _tipoponta;
            PercentualCarga = 100;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Peso: "+ Peso);  
            Console.WriteLine("Tamapada: " + Convert.ToString(Tampada));
            Console.WriteLine("Caida: " + Convert.ToString(Caida));
            Console.WriteLine("Estourada: " + Convert.ToString(Estourada));
            Console.WriteLine("PercentualCarga: " + PercentualCarga);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Ponta: " + Ponta);
            Console.WriteLine("TipoPonta: " + TipoPonta);
        }

        public void Cair()
        {
            Caida = true;
        }
        public void PegarDoChao()
        {
            Caida = false;
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
            if(Caida == true)
            {
                Console.WriteLine("Pegue-a do chão");
                return;
            }
            if (Tampada == true)
            {
                Console.WriteLine("Destampe a caneta");
                return;
            }
            if (PercentualCarga == 0)
            {
                Console.WriteLine("A caneta está sem tinta");
                return;
            }
            if (Estourada == true)
            {
                Console.WriteLine("A caneta está estourada");
                return;
            }
            Console.WriteLine(_texto);
            PercentualCarga -= 10;
        }
    }
}