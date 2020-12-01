using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Conexion con = new Conexion();
            
            
            
        }

        private void rdBuscar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = true;
            panelAgregar.Visible = false;
            panelDesactivar.Visible = false;
        }

        private void rdnAgregar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
            panelAgregar.Visible = true;
            panelDesactivar.Visible = false;
            btnActualizar.Visible = false;
            btnAgregar.Visible = true;
            lblTitulo.Text = "Agregar";
        }
        private void rdActualizar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
            panelAgregar.Visible = true;
            panelDesactivar.Visible = false;
            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
            lblTitulo.Text = "Actualizar";

        }
        private void rdDesactivar_Click(object sender, EventArgs e)
        {
            panelDesactivar.Visible = true;
            panelBusqueda.Visible = false;
            panelAgregar.Visible = false;
           

        }


        //Clic boton busqueda
        //elementos txtBusqueda, dataBusqueda
        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        //Panel agregar/Actualizar
        //elementos txtClave,txtDescripcion,txtPrecio,txtMarca,txtCantidad
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {

        }

        //salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdBuscar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
