namespace Models
{
    public class Apontador
    {
		private string cor;
		private string marca;
		private string material;
		private int percentualLamina;
		private bool apontarLapis;
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

		public	string Material
		{
			get { return material; }	
			set { material = value; }
		}

		public int PercentualLamina
		{
			get { return percentualLamina; }
            set { percentualLamina = value; }
        }

		public bool ApontarLapis
		{
			get { return apontarLapis; }
			set { apontarLapis = value; }
		}

        public Apontador(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            Material = _material;
            PercentualLamina = 100;
        }

		public void Exibir()
		{
			Console.WriteLine("Cor: " + Cor);
			Console.WriteLine("Marca: " + Marca);
			Console.WriteLine("Material: " + Material);
			Console.WriteLine("% Lamina: " + PercentualLamina);
		}

		public void Apontar()
		{
			if(percentualLamina < 1)
			{
				Console.WriteLine("Compre outro apontador");
				return;	
			}
			apontarLapis = true;
			DesgasteLamina(1);
		}
		private void DesgasteLamina(int _percentual)
		{
			percentualLamina -= _percentual;
			if (percentualLamina < 1)
				percentualLamina = 0;
		}

		public void Escrever(string _texto)
		{
			if(percentualLamina < 1)
			{
				Console.WriteLine("Compre outro apontador");
				return ;
			}
            Console.WriteLine(_texto);
            DesgasteLamina(1);
        }


    }
}
