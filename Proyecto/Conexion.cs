using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias para la conexion con SQL
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
       
    class Conexion
    {
       
        SqlConnection cn;
        SqlCommand comando;



        public void conexion()
        {
            try
            {
                
                cn = new SqlConnection("Data Source=.;Initial Catalog=INVENTARIO;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }

            catch (Exception Ex)
            {
                MessageBox.Show("No se pudo conectar" + Ex.ToString());
            }

        }



        public void conexion1()
        {
            try
            {

                cn = new SqlConnection("Data Source=.;Initial Catalog=INVENTARIO;Integrated Security=True");
                cn.Open();
               

            }

            catch (Exception Ex)
            {
                MessageBox.Show("No se pudo conectar" + Ex.ToString());
            }

        }



        public String insertar(int clave, String descripcion, String marca, int cantidad, float precio )
        {
            
            String Salida = ("Se ha insertado");
            int estado = 1;
            try
            {

                //COMANDO QUE INSERTA EL DATO EN SQL CUANDO ES NUMERO "+ CUANDO ES UN STRING '"+
                conexion1();
                //MessageBox.Show(clave + " " + descripcion + " " + marca + " " + cantidad + " " + precio);
                 comando = new SqlCommand("INSERT INTO ARTICULO (CLAVE, DESCRIPCION, PRECIO, CANTIDAD_DIS, MARCA, ESTADO) " +
                    "Values (" + clave + ",'" + descripcion + "'," + precio + "," + cantidad +",'"+ marca+"',"+estado+");",cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("El registro ha sido exitoso!");


            }
            catch(Exception Ex)
            {
                Salida = "No se conecto: " + Ex.ToString();
                MessageBox.Show("Tenemos un problema con el registro");
            }

            return Salida;

        }

        /*public String actualizar(int clave, String descripcion, String marca, int cantidad, float precio)
        {
            String Salida = ("Se ha modificado");
            int estado = 1;
            try
            {

                
                conexion1();
            
                comando = new SqlCommand("UPDATE ARTICULO SET ");
                comando.ExecuteNonQuery();
                MessageBox.Show("La actualizacion ha sido exitosa!");


            }
            catch (Exception Ex)
            {
                Salida = "No se conecto: " + Ex.ToString();
                MessageBox.Show("Tenemos un problema con la actualizacion");
            }

            return Salida;

        }*/
        
     

        

    }
}
