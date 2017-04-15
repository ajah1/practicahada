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
		private int puntosTotales;

		public puntuacion() { }

		public puntuacion(string user, int r, int v, int pt, usuario u)
		{
			this.username = user;
			this.record = r;
			this.vidas = v;
			this.puntosTotales = pt;
			usuario.username = u.username;
			usuario.ciudad = u.ciudad;
			usuario.pais = u.ciudad;
			usuario.descripcion = u.descripcion;
			usuario.edad = u.edad;
			usuario.email = u.email;
			usuario.direccion = u.direccion;
			usuario.contrasenya = u.contrasenya;
		}

		public string user { get; set; }
		public int r { get; set; }
		public int v { get; set; }
		public int p { get; set; }

		public void addPuntuacion(string dbname) {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.add(this);
		}

		public void removePuntuacion(string dbname){
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.remove(username);
		}

		public void readPuntuacion(string dbname) {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.read(username);
		}

		public void updatePuntuacion(string dbname) {
			CAD.CADpuntuacion aux = new CAD.CADpuntuacion();
			aux.update(this)
		}

	}
}
