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

       
        static string conexionS = "Data Source=.;Initial Catalog=INVENTARIO;Integrated Security=True";
        SqlConnection cone = new SqlConnection(conexionS);
        public Inicio()
        {


            InitializeComponent();


            Conexion cn = new Conexion();
            cn.conexion();

            if (txtBusqueda.Text == "")
            {

                recarga();
            }


        }
        public void recarga()
        {

            string query = ("SELECT CLAVE,DESCRIPCION,PRECIO,CANTIDAD_DIS,MARCA FROM ARTICULO WHERE ESTADO = 1");
            SqlCommand cmd = new SqlCommand(query, cone);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataTable.DataSource = tabla;
        }
        public void recargaA()
        {
            string query = ("SELECT CLAVE,DESCRIPCION,PRECIO,CANTIDAD_DIS,MARCA FROM ARTICULO WHERE ESTADO = 1");
            SqlCommand cmd = new SqlCommand(query, cone);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgvA.DataSource = tabla;
        }

        private void rdBuscar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = true;
            panelAgregar.Visible = false;
            panelDesactivar.Visible = false;
            recarga();
            
        }

        private void rdnAgregar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
            panelAgregar.Visible = true;
            panelDesactivar.Visible = false;
            btnActualizar.Visible = false;
            btnAgregar.Visible = true;
            lblTitulo.Text = "Agregar";
            recargaA();
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
        public void recargarD()
        {
            string query = ("SELECT CLAVE,DESCRIPCION,MARCA,PRECIO,CANTIDAD_DIS FROM ARTICULO WHERE ESTADO = 1");
            SqlCommand cmd = new SqlCommand(query, cone);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            table1.DataSource = tabla;

            string query1 = ("SELECT * FROM ARTICULO WHERE ESTADO = 0");
            SqlCommand cmd1 = new SqlCommand(query1, cone);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable tabla1 = new DataTable();
            data1.Fill(tabla1);
            table2.DataSource = tabla1;
        }
        private void rdDesactivar_Click(object sender, EventArgs e)
        {
            panelDesactivar.Visible = true;
            panelBusqueda.Visible = false;
            panelAgregar.Visible = false;

            recargarD();

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
                    txtBusqueda.Text = "";
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
                txtBusqueda.Text = "";
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

            Conexion con = new Conexion();
            con.insertar(ar.getClvArticulo(), ar.getdescripcion(), ar.getMarca(), ar.getCantDisponible(), ar.getPrecio());
            recargaA();
            txtClave.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            

        }

        //BOTON DE ACTUALIZAR
        private void Actualizar_Click(object sender, EventArgs e)
        {
            Articulos ar = new Articulos();
            ar.setClvArticulo(Int32.Parse(txtClave.Text));
            ar.setDescripcion(txtDescripcion.Text);
            ar.setMarca(txtMarca.Text);
            ar.setCantDisponible(Int32.Parse(txtCantidad.Text));
            ar.setPrecio(float.Parse(txtPrecio.Text));
            Conexion con1 = new Conexion();
            con1.actualizar(ar.getClvArticulo(), ar.getdescripcion(),ar.getMarca(),ar.getCantDisponible(),ar.getPrecio());
            if(con1.correcto == 1)
            {
                panelBusqueda.Visible = true;
                panelAgregar.Visible = false;
                panelDesactivar.Visible = false;
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }
        }

        //salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


        //Tabla actualizar y eliminar
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //accion del boton de actualizar
            if(table1.Columns[e.ColumnIndex].Name == "update")
            {
                String clave = table1.CurrentRow.Cells[2].Value.ToString();
                Articulos ar = new Articulos();
                ar.setClvArticulo(Int32.Parse(table1.CurrentRow.Cells[2].Value.ToString()));
                ar.setDescripcion(table1.CurrentRow.Cells[3].Value.ToString());
                ar.setMarca(table1.CurrentRow.Cells[4].Value.ToString());
                ar.setPrecio(float.Parse(table1.CurrentRow.Cells[5].Value.ToString()));
                ar.setCantDisponible(Int32.Parse(table1.CurrentRow.Cells[6].Value.ToString()));
                if(ar.getClvArticulo() > 0){
                    panelAgregar.Visible = true;
                    panelDesactivar.Visible = false;
                    panelBusqueda.Visible = false;
                    dgvA.Visible = false;
                    btnAgregar.Visible = false;
                    btnActualizar.Visible = true;
                    lblTitulo.Text = "Actualizar";
                    txtClave.Text = ar.getClvArticulo().ToString();
                    txtClave.Enabled = false;
                    txtDescripcion.Text = ar.getdescripcion().ToString();
                    txtMarca.Text = ar.getMarca().ToString();
                    txtPrecio.Text = ar.getPrecio().ToString();
                    txtCantidad.Text = ar.getCantDisponible().ToString();
                }
            }
            else if (table1.Columns[e.ColumnIndex].Name == "delete")
             {
                    String clave = table1.CurrentRow.Cells[2].Value.ToString();
                    Articulos ar = new Articulos();
                    ar.setClvArticulo(Int32.Parse(table1.CurrentRow.Cells[2].Value.ToString()));
                    if (ar.getClvArticulo() > 0)
                    {
                        Conexion con2 = new Conexion();
                        con2.desactivar(ar.getClvArticulo());
                        recargarD();
                }
            }
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (table2.Columns[e.ColumnIndex].Name == "activar")
            {
                String clave = table2.CurrentRow.Cells[2].Value.ToString();
                Articulos ar = new Articulos();
                ar.setClvArticulo(Int32.Parse(table2.CurrentRow.Cells[2].Value.ToString()));
                if (ar.getClvArticulo() > 0)
                {
                    Conexion con2 = new Conexion();
                    con2.activar(ar.getClvArticulo());
                    recargarD();
                }
            } else if (table2.Columns[e.ColumnIndex].Name == "eliminarD")
            {
                String clave = table2.CurrentRow.Cells[2].Value.ToString();
                Articulos ar = new Articulos();
                ar.setClvArticulo(Int32.Parse(table2.CurrentRow.Cells[2].Value.ToString()));
                if (ar.getClvArticulo() > 0)
                {
                    Conexion con2 = new Conexion();
                    con2.eliminar(ar.getClvArticulo());
                    recargarD();
                }
            }
        }
    }
}
