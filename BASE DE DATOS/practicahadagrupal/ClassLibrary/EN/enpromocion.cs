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

        public int Id_producto{ get { return id_producto; } set { id_producto = value; } }
        public int Id_promocion { get { return id_promocion; } set { id_promocion = value; } }
        public double Descuento { get { return descuento; } set { descuento = value; } }
        public DateTime F_Inicio { get { return f_inicio; } set { f_inicio = value; } }
        public DateTime F_limite { get { return f_limite; } set { f_limite = value; } }

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
