using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{

    class usuario{

        // parte privada

        private string user;
        private string direccion;
        private string contrasena;
        private string ciudad;
        private string pais;
        private string descripcion;
        private string email;
        private int edad;

        //********************************************
        // constructores

        public usuario() {  }

        public usuario(string usuario, string direccion, string contrasena, string ciudad, string pais, string descripcion, string email, int edad) {
            this.user = usuario;
            this.direccion = direccion;
            this.contrasena = contrasena;
            ciudad = "";
            pais = "";
            descripcion = "";
            email = "";
            edad = 0;
          //puntuacion = new puntuacion();
        }

        /*
        public ~usuario(){

        }
        */

        //********************************************
        // get set

        public string Usuario {
            get { return user; }
            set { user = value; }
        }

        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Contrasena {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Ciudad {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Pais {
            get { return pais; }
            set { pais = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public int Edad {
            get { return edad; }
            set { edad = value; }
        }

        //********************************************
        // metodos

        public void registrarUsuario(string usuario, string direccion, string contrasena, string ciudad, string pais, string descripcion, string email, int edad) {
            CAD.CADusuario cli = new CAD.CADusuario();
            cli.create(this);
        }

        public void borrarUsuario(string usuario){
            CAD.CADusuario cli = new CAD.CADusuario();
            cli.delete(usuario);
        }

        public void entrarWeb(string usuario, string contrasena){

        }

        // aun no se sabe si se hace aqui, salir de la web
        public void salirWeb(){

        }

        public void modificarUsuario(string usuario, string direccion, string contrasena, string ciudad, string pais, string descripcion, string email, int edad){
            CAD.CADusuario cli = new CAD.CADusuario();
            cli.update(this);
        }

        public void leerUsuario(string usuario) {
            CAD.CADusuario cli = new CAD.CADusuario();
            cli.read(usuario);
        }
    }
}
