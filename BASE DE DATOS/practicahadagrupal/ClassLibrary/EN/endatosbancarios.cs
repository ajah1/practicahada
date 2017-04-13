using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class DatosBancarios
    {

        private string titular { get; set; }
        private ulong numTarjeta { get; set; }
        private DateTime fechaVencimiento { get; set; }
        private ushort cvc { get; set; }
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

        public void addDatosBancarios(string dbname)
        {
            CAD.CADdatosbancarios aux = new CAD.CADdatosbancarios();
            aux.add(this);
        }

        public void deleteDatosBancarios(string dbname)
        {
            CAD.CADdatosbancarios aux = new CAD.CADdatosbancarios();
            aux.delete(titular);
        }

        public void updateDatosBancarios(string dbname)
        {
            CAD.CADdatosbancarios aux = new CAD.CADdatosbancarios();
            aux.update(this);
        }

        public void readDatosBancarios(string dbname)
        {
            CAD.CADdatosbancarios aux = new CAD.CADdatosbancarios();
            aux.read(titular);
        }
    }
}
