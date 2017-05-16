using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    // falta lo que herede de la clase Producto
    // actualizar automaticamente desde la base de datos a todas las tuplas

    public class Popular : Producto
    {
        // atributos
        private int numero_ventas;

        // constructores
        public Popular() { }

        public Popular(int id)
        {
            this.Id = id;
        }
        

        // propiedades
        public int Numero_ventas
        {
            get { return numero_ventas; }
            set { numero_ventas = value; }
        }


        //--------------------------------
        // llamar a la funcion updateTable
        //--------------------------------

        // funcion que devuelve una lista con los 3 productos mas comprados
        public List<int> productosPopulares()
        {
            List<int> populares = new List<int>();
            CAD.CADpopular aux = new CAD.CADpopular();

            populares = aux.productosPopulares();

            return populares;
        }

        // drop table productoPopular
        public void dropPopular()
        {
            CAD.CADpopular aux = new CAD.CADpopular();

            aux.dropPopular();
        }

        // añadir 1 producto popular
        public void addPopular ()
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.add(this);
        }

        // update table productoPopular
        public void updateTable()
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.updateTable();
        }

        // borrar 1 productoPopular
        public void deletePopular()
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.delete(Id);
        }

        // actualizar las ventas de un popular
        public void updatePopular()
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.update(this);
        }

        // PROVISIONAL: devuelve el numero de ventas de un productoPopular
        public string readPopular()
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            return aux.read(Id);
        }
    }
}
