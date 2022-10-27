namespace Models
{
    public class Carro
    {
        private int velocidadeAtual;
        private string marca;
        private string modelo;
        private int odomentro;
        private int tanque;
        private bool ligao;
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
        public int Tanque
        {
            get { return tanque; }
            set { tanque = value; }
        }

        public bool Ligado
        {
            get { return ligao; }
            set { ligao = value; }
        }

        public Pneu PneuDianteiroDireito
        {
            get { return pneuDianteiroDireito; }
            set { pneuDianteiroDireito = value; }
        }
        public Pneu PneuDianteiroEsquerdo   
        {
            get { return pneuDianteiroEsquerdo; }
            set { pneuDianteiroEsquerdo = value; }
        }
        public Pneu PneuTraseiroDireito
        {
            get { return pneuTraseiroDireito; }
            set { pneuTraseiroDireito = value; }
        }
        public Pneu PneuTraseiroEsquerdo
        {
            get { return pneuTraseiroEsquerdo; }
            set { pneuTraseiroEsquerdo = value; }
        }
        public Carro(string marca, string modelo)
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Marca: " + Marca);
        }


    }
    public void LigarDesligar()
    {
        Ligado = !Ligado;
        if(!Ligado)
        {
            Frear(VelocidadeAtual);
        }
    }
    public void Acelerar(int _impulso)
    {
        if(!Ligado)
            return;

        if(Tanque < 0)
        GastarCombustivel(_impulso / 100)
        PneuDianteiroDireito.Girar(_impulso);
        PneuDianteiroEsquerdo.Girar(_impulso);
        PneuTraseiroDireito.Girar(_impulso);
        PneuTraseiroEsquerdo.Girar(_impulso);
        VelociadeAtual += _impulso
    }

    public void Frear(int _abatimento)
    {
        VelocidadeAtual -= _abatimento;
        if(VelocidadeAtual < 0)
    }
    public void GastarCombustivel(double _fracao)
    {
        Tanque -= _fracao;
    }
    public void Exibir()
    {

    }
}
