using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
	public class puntuacion{
		
		private string username;
		private int record;
		private int vidas;
		private int puntosTotales;

		public puntuacion() { }

		public puntuacion(string user, int r, int v, int pt)
		{
			this.username = user;
			this.record = r;
			this.vidas = v;
			this.puntosTotales = pt;
		}

		public string user { get; set; }
		public int r { get; set; }
		public int v { get; set; }
		public int p { get; set; }

		public void removePuntuacion(){
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.remove(username);
		}

		public void readPuntuacion() {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.read(username);
		}

        public int obtenerPuntuacion(string usuario)
        {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
            return aux.obtenerPuntuacion(username);

		}

		public void updatePuntuacion() {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.updatePuntuacion(this);
		}

	}
}
