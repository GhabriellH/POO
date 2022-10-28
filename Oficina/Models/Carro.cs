namespace Models
{
    public class Carro
    {
        private int velocidadeAtual;
        private string marca;
        private string modelo;
        private int odomentro;
        private double tanque;
        private bool ligado;
        private Pneu pneuDianteiroDireito;
        private Pneu pneuDianteiroEsquerdo;
        private Pneu pneuTraseiroDireito;
        private Pneu pneuTraseiroEsquerdo;

        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            set { velocidadeAtual = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Odomentro
        {
            get { return odomentro; }
            set { odomentro = value; }
        }
        public double Tanque
        {
            get { return tanque; }
            set { tanque = value; }
        }

        public bool Ligado
        {
            get { return ligado; }
            set { ligado = value; }
        }

        public Pneu PneuDianteiroDireito
        {
            get { return pneuDianteiroDireito; }
            set 
            { 
                if(VelocidadeAtual == 0)
                pneuDianteiroDireito = value; 
                else
                    Console.WriteLine("TU VAI TROCAR O PNEU COM O CARRO EM MOVIMENTO?");
            }
        }
        public Pneu PneuDianteiroEsquerdo   
        {
            get { return pneuDianteiroEsquerdo; }
            set 
            {
                if (VelocidadeAtual == 0)
                    pneuDianteiroEsquerdo = value;
                else
                    Console.WriteLine("TU VAI TROCAR O PNEU COM O CARRO EM MOVIMENTO?");
            }
        }
        public Pneu PneuTraseiroDireito
        {
            get { return pneuTraseiroDireito; }
            set 
            {
                if (VelocidadeAtual == 0)
                    pneuTraseiroDireito = value;
                else
                    Console.WriteLine("TU VAI TROCAR O PNEU COM O CARRO EM MOVIMENTO?");
            }
        }
        public Pneu PneuTraseiroEsquerdo
        {
            get { return pneuTraseiroEsquerdo; }
            set 
            {
                if (VelocidadeAtual == 0)
                    pneuTraseiroEsquerdo = value;
                else
                    Console.WriteLine("TU VAI TROCAR O PNEU COM O CARRO EM MOVIMENTO?");
            }
        }
        public Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = 0;
            this.odomentro = 0;
            Tanque = 5;
            Ligado = true;
            PneuDianteiroDireito  = new Pneu(16, "Pirelli");
            PneuDianteiroEsquerdo = new Pneu(16, "Pirelli");
            PneuTraseiroDireito   = new Pneu(16, "Pirelli");
            PneuTraseiroEsquerdo = new Pneu(16, "Pirelli");
        }
        public void LigarDesligar()
        {
            Ligado = !Ligado;
            if (!Ligado)
                Frear(VelocidadeAtual);
            else if (Tanque == 0)
                LigarDesligar();
        }
        public void Acelerar(int _impulso)
        {
            if (!Ligado)
                return;

            if (Tanque == 0)
                LigarDesligar();

            GastarCombustivel(_impulso / 100.0);
            if (Ligado)
            {
                VelocidadeAtual += _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);

                if (PneuDianteiroDireito.Estourado || PneuTraseiroEsquerdo.Estourado || PneuTraseiroDireito.Estourado || PneuTraseiroEsquerdo.Estourado)
                { 
                    Frear(VelocidadeAtual);
                }
             }
                      
        }
        public void Frear(int _abatimento)
        {
            VelocidadeAtual -= _abatimento;
            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

            PneuDianteiroDireito.Frear(_abatimento);
            PneuDianteiroEsquerdo.Frear(_abatimento);
            PneuTraseiroDireito.Frear(_abatimento);
            PneuTraseiroEsquerdo.Frear(_abatimento);
        }
        public void GastarCombustivel(double _fracao)
        {
            Tanque -= _fracao;
            if (Tanque < 0)
                Tanque = 0;
        }
        public void Exibir()
        {
            Console.WriteLine("Velocidade atual: " + VelocidadeAtual);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Odometro: " + Odomentro);
            Console.WriteLine("Tanque: " + Tanque);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("Pneu dianteiro esquerdo: ");
            pneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("Pneu dianteiro direito: ");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("Pneu traseiro esquerdo: ");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("Pneu traseiro direito: ");
            PneuTraseiroDireito.Exibir();
        }
        public void Abastecer(double _quantidade)
        {
            Tanque += _quantidade;
        }
    }
}
