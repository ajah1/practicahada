using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
	class puntuacion{
		
		private string username;
		private int record;
		private int vidas;
		private int puntos;

		public puntuacion() { }

		public puntuacion(string user, int r, int v, int p)
		{
			this.username = user;
			this.record = r;
			this.vidas = v;
			this.puntos = p;
		}

		public string user { get; set; }
		public int r { get; set; }
		public int v { get; set; }
		public int p { get; set; }



		public void saveRanking(string dbname) { }

		public void removeRanking(string dbname) { }

		public void addRanking(string dbname) { }
	}
}
