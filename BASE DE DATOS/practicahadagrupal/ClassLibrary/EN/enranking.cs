using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
	public class ranking{
		
		private string usuario;
		private int puntuacion;
		private string fecha;

		public ranking() { }

		public ranking(string user, int pt, string f)
		{
			usuario = user;
			puntuacion = pt;
			fecha = f;
		}

		public string user { get; set; }
		public int p { get; set; }
		public string f { get; set; }




		public void addRanking(string dbname) {
			CAD.CADranking aux = new CAD.CADranking();
			aux.add(this);
		}

	}
}
