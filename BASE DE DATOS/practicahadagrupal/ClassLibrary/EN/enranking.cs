using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
	public class ranking
	{

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


		// borra todas las tuplas de la base de datos
		public void droptable()
		{
			CAD.CADranking aux = new CAD.CADranking();
			aux.drop();
		}

		// actualiza la base de datos
		public void addRanking()
		{
			CAD.CADranking aux = new CAD.CADranking();
			aux.add();
		}


		// hace el nuevo ranking
		public void updateTable()
		{

		}
	}
}
