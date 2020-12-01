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
        
        

        public Conexion()
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
        
     

        

    }
}
