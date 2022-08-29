using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1_grafos.Models {
	public class Aresta {
		public int[] aresta { get; set; }

		public Aresta(int[] aresta) {
			this.aresta = new int[2];
			this.aresta = aresta;
		}

		public Aresta() {
			aresta = new int[2];
		}
	}
}
