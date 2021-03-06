﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{

    public class enlinped{

        // parte privada (propiedades de linea de pedido)
        private int numPedido;
        private int linea;
        private int producto;
        private float precio;
        private int cantidad;

        //********************************************
        // constructores

        // constructor por defecto
        public enlinped() { }

        //constructor parametrizado
        public enlinped(Producto pro, pedido ped) {
            numPedido = ped.NumPedido;
            producto = pro.Id;
            precio = pro.Precio;
            //cantidad = ped.Cantidad;
            //linea = 
        }

        //********************************************
        // get set

        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }

        public int Linea
        {
            get { return linea; }
            set { linea = value; }
        }

        public int Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //********************************************
        // metodos

            // añade una linea de pedido
        public void addLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            lin.create(this);
        }

        // borra una linea de pedido
        public void deleteLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            lin.delete(this);

        }

        // modifica una linea de pedido
        public void updateLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            //lin.update();
        }

        // lee, muestra los datos de una linea de pedido
        public string leerLinped(Producto pro, pedido ped)
        {
            string salida = "";

            CAD.CADlinped lin = new CAD.CADlinped();
            salida = salida + lin.read(this);
            return salida;
        }

    }
}
