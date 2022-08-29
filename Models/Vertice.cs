using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1_grafos.Models {
	public class Vertice {
		public int Id { get; set; }
		public List<int> Sucessores { get; set; }
		public List<int> Predecessores { get; set; }
		public int GrauSaida { get; set; }
		public int GrauEntrada { get; set; }

		public Vertice(int id, List<int> sucessores, List<int> predecessores, int grauSaida, int grauEntrada) {
			Id = id;
			Sucessores = sucessores;
			Predecessores = predecessores;
			GrauSaida = grauSaida;
			GrauEntrada = grauEntrada;
		}

		public Vertice() {
			Sucessores = new List<int>();
			Predecessores = new List<int>();
		}

		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			Sucessores.Sort();
			Predecessores.Sort();
			sb.AppendLine("Vertice: " + Id);
			sb.AppendLine($"Sucessores: [{String.Join(", ", Sucessores)}]");
			sb.AppendLine($"Predecessores: [{String.Join(", ", Predecessores)}]");
			sb.AppendLine("Grau de saida: " + GrauSaida);
			sb.AppendLine("Grau de entrada: " + GrauEntrada);
			return sb.ToString();
		}
	}
}
