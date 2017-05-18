using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class datosbancarios
    {

        private string numeroTarjeta;
        public string NumeroTarjeta { get { return numeroTarjeta; } set { numeroTarjeta = value; } }
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        private string apellido;
        public string Apellido { get { return apellido } set { apellido = value; } }
        private DateTime fechaVencimiento;
        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }
        private ushort cvc;
        public ushort CVC { get { return cvc; } set { cvc = value; } }
        private usuario usuario;
        public usuario Usuario { get { return usuario; } set { usuario = value; } }


        public datosbancarios() { }
        public datosbancarios(string numeroTarjeta, string nombre, string apellido, DateTime fechaVencimiento, ushort CVC, EN.usuario usuario)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaVencimiento = fechaVencimiento;
            this.CVC = CVC;
            this.usuario = usuario;

        }

        public void saveDatos()
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.create(this);
        }

        public void removeDatos()
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.delete(this);
        }
    }
}
