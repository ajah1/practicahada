﻿using System;
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
        private string f_inicio;
        private string f_limite;

        public Promocion() { }

        public
            Promocion(  int id_promocion,
                        int id_producto,
                        double descuento,
                        string f_inicio,
                        string f_limite)
        {
            this.id_promocion = id_promocion;
            this.id_producto = id_producto;
            this.descuento = descuento;
            this.f_inicio = f_inicio;
            this.f_limite = f_limite;
        }

        public int Id_producto{ get; set;}
        public int Id_promocion { get; set; }
        public double Descuento { get; set; }
        public string F_Inicio { get; set; }
        public string F_limite { get; set; }

        //public void save(string dbname)
        //{
        //}

        public void addPromocion(string dbname)
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.add(this);
        }
        public void removePromocion(string dbname)
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.remove(id_promocion);
        }
        public void readPromocion(string dbname)
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.read(id_promocion);
        }
        public void updatePromocion(string dbname)
        {
            CAD.CADpromocion aux = new CAD.CADpromocion();
            aux.update(this);
        }
    }
}