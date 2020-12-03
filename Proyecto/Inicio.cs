using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//LIBRERIAS SQL

using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class Inicio : Form
    {

       //CONEXION AQUI PORQUE NO SUPE EXTRAERLA DE LA CLASE CONEXION
        static string conexionS = "Data Source=.;Initial Catalog=INVENTARIO;Integrated Security=True";
        SqlConnection cone = new SqlConnection(conexionS);
        public Inicio()
        {

            InitializeComponent();






            //CONEXION AQUI PORQUE NO SUPE EXTRAERLA DE LA CLASE CONEXION X2
            Conexion cn = new Conexion();
            cn.conexion();

            



            /*if (txtBusqueda.Text == "")
            {
                
                
                string query = ("SELECT CLAVE,DESCRIPCION,PRECIO,CANTIDAD_DIS,MARCA FROM ARTICULO");
                SqlCommand cmd = new SqlCommand(query,cone);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataTable.DataSource = tabla;

            }*/


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
            Articulos ar = new Articulos();
            if (rdClave.Checked == true)
            {
                try
                {
                    
                    ar.setClvArticulo(Int32.Parse(txtBusqueda.Text));
                    string query = ("SELECT CLAVE,DESCRIPCION,PRECIO,CANTIDAD_DIS,MARCA FROM ARTICULO WHERE CLAVE ="+ ar.getClvArticulo()+"");
                    SqlCommand cmd = new SqlCommand(query, cone);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dataTable.DataSource = tabla;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al llenar la tabla: " + ex.Message);
                }

            }
            if (rdDescripcion.Checked == true)
            {
                try
                {
                ar.setDescripcion(txtBusqueda.Text);
                string query = ("SELECT CLAVE,DESCRIPCION,PRECIO,CANTIDAD_DIS,MARCA FROM ARTICULO WHERE DESCRIPCION ='" + ar.getdescripcion() + "'");
                SqlCommand cmd = new SqlCommand(query, cone);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataTable.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar la tabla: " + ex.Message);
                }

            }







        }

        //Panel agregar/Actualizar
        //elementos txtClave,txtDescripcion,txtPrecio,txtMarca,txtCantidad
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos ar = new Articulos();
            ar.setClvArticulo(Int32.Parse(txtClave.Text));
            ar.setDescripcion(txtDescripcion.Text);
            ar.setMarca(txtMarca.Text);
            ar.setCantDisponible(Int32.Parse(txtCantidad.Text));
            ar.setPrecio(float.Parse(txtPrecio.Text));

            //MessageBox.Show(ar.getClvArticulo() +" "+ar.getdescripcion() + " " + ar.getMarca() + " " + ar.getCantDisponible() + " " + ar.getPrecio());

            Conexion con = new Conexion();
            con.insertar(ar.getClvArticulo(), ar.getdescripcion(), ar.getMarca(), ar.getCantDisponible(), ar.getPrecio());
            
            


        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Articulos ar = new Articulos();
            ar.setClvArticulo(Int32.Parse(txtClave.Text));
            ar.setDescripcion(txtDescripcion.Text);
            ar.setMarca(txtMarca.Text);
            ar.setCantDisponible(Int32.Parse(txtCantidad.Text));
            ar.setPrecio(float.Parse(txtPrecio.Text));
        }

        //salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdBuscar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdClave_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
