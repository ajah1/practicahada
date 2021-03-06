﻿using ClassLibrary.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
    public class Producto{
        private int id;
        private string nombre;
        private string descripcion;
        private string imagen;
        private int precio;
        
        //Metodos que devuelven el valor de los atributos privados.
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public int Precio { get { return precio; } set { precio = value; } }

        //Metodo que da los valores pasados por parametro al producto
        public Producto (int id, int precio, string nombre = "", string descripcion = "", string imagen = ""){
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.precio = precio;
            
        } 
        //Metodo que da valores al producto que contenga el id pasado por parametro.
        public Producto(int id)
        {

            EN.Producto p = mostrarProducto(id);

            this.id = p.id;
            this.nombre = p.nombre;
            this.descripcion = p.descripcion;
            this.imagen = p.imagen;
            this.precio = p.precio;
            


        }
        //Metodo que da valores iniciales al producto
        public Producto() {
            this.id = 0;
            this.nombre = "";
            this.descripcion = "";
            this.imagen = "";
            this.precio = 0;
        }

        //Metodo que copia los valores de otro producto en este producto
        public Producto(Producto producto) {
            this.id = producto.id;
            this.nombre = producto.nombre;
            this.descripcion = producto.descripcion;
            this.imagen = producto.imagen;
            this.precio = producto.precio;
            

        }

        //Metodo que llama al cad para guardar un producto
        public void saveProducto() {
            CAD.CADproducto p = new CAD.CADproducto();
            p.create(this);

        }
        //Metodo que llama al cad para borrar un producto
        public void removeProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.remove(this.id);

        }
        //Metodo que llama al cad para añadir un producto
        public void addProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.create(this);

        }
        //Metodo que llama al cad para modificar un producto
        public void updateProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.update(this);

        }
        //Metodo que llama al cad para mostrar un producto
        public Producto mostrarProducto(int id) {
            EN.Producto p = new EN.Producto();
            CAD.CADproducto prod = new CADproducto();
            p = prod.consultarProducto(id);

            return p;

        }
        //Metodo que llama al cad para mostrar todos los producto
        public static List<Producto> mostrarTodos() {

            CAD.CADproducto a = new CAD.CADproducto();

            List<EN.Producto> p = a.PeticionConsultar();

            return p;
        }

    }
}
