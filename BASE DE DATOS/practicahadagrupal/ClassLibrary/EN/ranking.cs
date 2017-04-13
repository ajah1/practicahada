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

		public ranking(string user, int pt, string f, puntuacion p)
		{
			this.usuario = user;
			this.puntuacion = pt;
			this.fecha = f;
			puntuacion.username = p.username;
			puntuacion.record = p.record;
			puntuacion.vidas = p.vidas;
			puntuacion.puntosTotales = p.puntosTotales;


		}

		public string user { get; set; }
		public int p { get; set; }
		public string f { get; set; }




		public void addRanking(string dbname) {
			CAD.CADranking aux = new CAD.CADranking();
			aux.add(this);
		}

		public void removeRanking(string dbname)
		{
			CAD.CADranking aux = new CAD.CADranking();
			aux.remove(usuario);
		}
		public void readRanking(string dbname)
		{
			CAD.CADranking aux = new CAD.CADranking();
			aux.read(this);
		}
		public void updateRanking(string dbname)
		{
			CAD.CADranking aux = new CAD.CADranking();
			aux.update(this);
		}
	}
}
