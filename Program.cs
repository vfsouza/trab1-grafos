using System.Collections;
using System.Text.RegularExpressions;
using trab1_grafos.Models;

namespace trab1_grafos {
	class Program {
		private static String projectPath = "C:\\Users\\vinif\\source\\repos\\trab1-grafos\\";
		static void Main(string[] args) {
			Vertice v = new Vertice();

			v.Id = int.Parse(args[1]);

			List<Aresta> arestas = lerArquivo(args[0]);

			foreach (Aresta a in arestas) {
				if (a.aresta[0] == v.Id) {
					v.Sucessores.Add(a.aresta[1]);
					v.GrauSaida++;
				} else if (a.aresta[1] == v.Id) {
					v.Predecessores.Add(a.aresta[0]);
					v.GrauEntrada++;
				}
			}

			Console.WriteLine(v.ToString());
		}

		private static List<Aresta> lerArquivo(String path) {
			StreamReader sr = new StreamReader(Path.Combine(projectPath, path));
			List<Aresta> lista = new List<Aresta>();
			sr.ReadLine();
			Regex rx = new Regex(@" +");
			while (sr.Peek() != -1) {
				String line = sr.ReadLine().Trim();
				String[] arestaLine = Regex.Replace(line, @" +", " ").Split(" ");
				Aresta a = new Aresta(arestaLine.Select(s => int.Parse(s)).ToArray());
				lista.Add(a);
			}
			return lista;
		}
	}
}