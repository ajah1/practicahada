using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class DatosBancarios
    {

        private string titular;
        private ulong numTarjeta;
        private DateTime fechaVencimiento;
        private ushort cvc;
        // private Usuario usuario;

        public DatosBancarios()
        {
            titular = "";
            numTarjeta = 0;
            fechaVencimiento = new DateTime(1, 1, 1);
            cvc = 0;
        }

        public DatosBancarios(string titular, ulong numTarjeta, DateTime fechaVencimiento, ushort cvc)
        //DatosBancarios datosbancarios
        {
            this.titular = titular;
            this.numTarjeta = numTarjeta;
            this.fechaVencimiento = fechaVencimiento;
            this.cvc = cvc;
            //this.usuario = usuario;
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
   
        public ulong NumTarjeta
        {
            get { return numTarjeta; }
            set { numTarjeta = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public ushort CVC
        {
            get { return cvc; }
            set { cvc = value; }
        }


        public void saveDatosBancarios(string dbname)
        {

        }

        public void addDatosBancarios(string dbname)
        {

        }

        public void removeDatosBancarios(string dbname)
        {

        }
    }
}
