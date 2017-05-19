using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{

    public class usuario{

        // parte privada (propiedades del usuario)

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

        // constructor por defecto
        public usuario() {  }

        //constructor parametrizado
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

        // borra un usuario de la base de datos
        public void borrarUsuario(string usuario)
        {
            CAD.CADusuario cli = new CAD.CADusuario();

            cli.delete(usuario);
        }

        // inserta un usuario en la base de datos
        public void registrarUsuario() {

            CAD.CADusuario cli = new CAD.CADusuario();
            cli.create(this);
        }

        // lee, muestra los datos de un usuario
        public List<string> leerUsuario()
        {
            List<string> lista = new List<string>();
            lista = null;

            CAD.CADusuario cli = new CAD.CADusuario();
            lista = cli.read(this.Usuario);

            return lista;
        }

        // modifica los datos de un usuario
        public void modificarUsuario(){
            CAD.CADusuario cli = new CAD.CADusuario();
            cli.update(this);
        }
        /*
        public bool existe()
        {
            bool existe;

            CAD.CADusuario aux = new CAD.CADusuario();

            //existe = aux.existe(Usuario);

            return existe;
        }
    */
    }
}
