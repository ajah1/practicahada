using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{

    class UsuarioEn{

        // parte privada

        private string usuario;
        private string direccion;
        private string contraseña;
        private string ciudad;
        private string pais;
        private string descripcion;
        private string email;
        private int edad;

        //********************************************
        // constructores

        public UsuarioEn() {
            usuario = "";
            direccion = "";
            contraseña = "";
            ciudad = "";
            pais = "";
            descripcion = "";
            email = "";
            edad = 0;
        }
        /*
        public UsuarioEn() {
            usuario = "";
            direccion = "";
            contraseña = "";
            ciudad = "";
            pais = "";
            descripcion = "";
            email = "";
            edad = 0;
        }
        */

        //********************************************
        // get set

        private string Usuario {
            get { return usuario; }
            set { usuario = value; }
        }

        private string Direccion {
            get { return usuario; }
            set { usuario = value; }
        }

        private string Contraseña {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private string Ciudad {
            get { return ciudad; }
            set { ciudad = value; }
        }

        private string Pais {
            get { return pais; }
            set { pais = value; }
        }

        private string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string Email {
            get { return email; }
            set { email = value; }
        }

        private int Edad {
            get { return edad; }
            set { edad = value; }
        }

        //********************************************
        // metodos
    }
}
