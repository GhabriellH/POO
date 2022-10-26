﻿namespace Models
{
    public class Caderno
    {
		private string marca;
		private int quantidadeFolha;
		private int quantidadeMateria;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		public int QuantidadeFolha
		{
			get { return quantidadeFolha; }
			set { quantidadeFolha = value; }
		}

		public int QuantidadeMateria
		{
			get { return quantidadeMateria; }
			set { quantidadeMateria = value; }
		}

		public Caderno(string _marca)
		{
			marca = _marca;
			QuantidadeFolha = 200;
			QuantidadeMateria = 12;
		}

		public void ArrancarFolha()
		{
			if(QuantidadeFolha > 0)
			{
				QuantidadeFolha -= 1;
			}

		}


	}
}
