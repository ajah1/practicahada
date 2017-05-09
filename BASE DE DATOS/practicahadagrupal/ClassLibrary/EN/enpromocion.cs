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
        private int id_producto;
        private double descuento;
        private DateTime f_inicio;
        private DateTime f_limite;

        public Promocion() { }

        public
            Promocion(  int id_promocion,
                        int id_producto,
                        double descuento,
                        DateTime f_inicio,
                        DateTime f_limite)
        {
            this.id_promocion = id_promocion;
            this.id_producto = id_producto;
            this.descuento = descuento;
            this.f_inicio = f_inicio;
            this.f_limite = f_limite;
        }

        public Promocion(int id)
        {
            id_producto = id;
        }

        public int Id_producto{ get; set;}
        public int Id_promocion { get; set; }
        public double Descuento { get; set; }
        public string F_Inicio { get; set; }
        public string F_limite { get; set; }

        public void addPromocion()
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.add(this);
        }
        public void removePromocion()
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.remove(id_producto);
        }
        // PROVISIONAL
        public string readPromocion()
        {
            string salida = "empty";
            CAD.CADpromocion aux = new CAD.CADpromocion();
            salida += aux.read(id_producto);
            return salida;
        }
        public void updatePromocion()
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.update(this);
        }
    }
}
