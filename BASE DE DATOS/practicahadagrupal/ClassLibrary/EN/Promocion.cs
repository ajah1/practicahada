using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class Promocion
    {

        private int id_promocion;
        private double descuento;
        private string f_inicio;
        private string f_limite;
        // private Producto producto;

        public Promocion() { }

        public 
            Promocion(int id,
                         double descuento,
                         string f_inicio,
                         string f_limite)
                       //Producto producto
        {
            this.id_promocion = id;
            this.descuento = descuento;
            this.f_inicio = f_inicio;
            this.f_limite = f_limite;
            //this.producto = producto;
        }

        public int Id{ get; set;}
        public double Descuento { get; set; }
        public string Fecha_Inicio { get; set; }
        public string F_limite { get; set; }

        public 
            void save(string dbname)
        {
            // esto depende de como funcione
            // el gestor de la bd
        }

        public
            void addPromocion(string dbname)
        {

        }

        public
            void removePromocion(string dbname)
        {

        }
    }
}
