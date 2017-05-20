using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class datosbancarios
    {
        // atributos de instancia 
        private ulong numeroTarjeta;
        public ulong NumeroTarjeta { get { return numeroTarjeta; } set { numeroTarjeta = value; } }
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        private string apellido;
        public string Apellido { get { return apellido; } set { apellido = value; } }
        private DateTime fechaVencimiento;
        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }
        private ushort cvc;
        public ushort CVC { get { return cvc; } set { cvc = value; } }
        private usuario usuario;
        public usuario Usuario { get { return usuario; } set { usuario = value; } }
        public static string aux;

        // constructor por defecto
        public datosbancarios() { }

        // constructor parametrizado
        public datosbancarios(ulong numeroTarjeta, string nombre, string apellido, DateTime fechaVencimiento, ushort CVC, EN.usuario usuario)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaVencimiento = fechaVencimiento;
            this.CVC = CVC;
            this.usuario = usuario;

        }

        // manda los atributos de instancia al cad para ser insertados en la BBDD
        public void createDatos()
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.create(this);
        }

        // manda los atributos de instancia al cad para ser buscados en la BBDD
        public void readDatos()
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.read(this);
        }

        // manda los atributos de instancia al cad para ser encontrados en la BBDD y actualizados
        public void updateDatos(ulong numerotarjeta)
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.update(this, numerotarjeta);
        }

        // manda los atributos de instancia al cad para ser borrados de la BBDD
        public void deleteDatos()
        {
            CAD.CADdatosbancarios datosbancarios = new CAD.CADdatosbancarios();
            datosbancarios.delete(this);
        }
    }
}
