using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
     public class Articulos
    {
        private float precio;
        private String descripcion;
        private int clvArticulo;
        private int cantDisponible;
        private String marca;


        public float getPrecio()
        {
            return precio;
        }

        public void setPrecio(float pFPrecio)
        {
            this.precio = pFPrecio;
        }

        public String getdescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String pSDescripcion)
        {
            this.descripcion = pSDescripcion;
        }

        public int getClvArticulo()
        {
            return clvArticulo;
        }

        public void setClvArticulo(int piClvArticulo)
        {
            this.clvArticulo = piClvArticulo;
        }

        public int getCantDisponible()
        {
            return cantDisponible;
        }

        public void setCantDisponible(int piCantDisponible)
        {
            this.cantDisponible = piCantDisponible;
        }

        public String getMarca()
        {
            return marca;
        }

        public void setMarca(String pSMarca)
        {
            this.marca = pSMarca;
        }





    }
}
