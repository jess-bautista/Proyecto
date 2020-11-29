using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Articulos
    {
        private float precio;
        private String descripcion;
        private int clvArticulo;
        private int cantDisponible;
        private String marca;


        public float Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public int ClvArticulo
        {
            get { return clvArticulo; }
            set { clvArticulo = value; }
        }

        public int CantDisponible
        {
            get { return cantDisponible; }
            set { cantDisponible = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
            
   



    }
}
