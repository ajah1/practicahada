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

		public string user { get { return username; } set { username = value; } }
		public int r { get { return record; } set { record = value; } }
		public int v { get { return vidas; } set { vidas = value; } }
		public int p { get { return puntosTotales; } set { puntosTotales = value; } }

		public void removePuntuacion(){
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.remove(username);
		}

		public string readPuntuacion()
		{
			string salida = "";
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			salida = aux.read(username);
			return salida;
		}

        public int obtenerPuntuacion(string usuario)
        {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
            return aux.obtenerPuntuacion(username);

		}

		public void updatePuntuacion() {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			//aux.updatePuntuacion(this);
		}

	}
}
