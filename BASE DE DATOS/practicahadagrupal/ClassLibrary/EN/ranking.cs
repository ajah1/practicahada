using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
	class ranking{
		
		private string usuario;
		private int puntuacion;
		private string fecha;

		public ranking() { }

		public ranking(string user, int p, int f)
		{
			this.usuario = user;
			this.puntuacion = p;
			this.fecha = f;
		}

		public string user { get; set; }
		public int p { get; set; }
		public int f { get; set; }




		public void saveRanking(string dbname) { }

		public void removeRanking(string dbname) { }

		public void addRanking(string dbname) { }
	}
}
