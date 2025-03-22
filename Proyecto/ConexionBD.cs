using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto
{
    class ConexionBD
    {
        public SqlConnection conectar = new SqlConnection("Data Source=USUARIO\\SQLEXPRESS;Initial Catalog=Examen;Integrated Security=True");

        public void Abrir()
        {
            try
            {
                if (conectar.State == System.Data.ConnectionState.Closed)
                {
                    conectar.Open();
                    Console.WriteLine(" Conexión abierta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al abrir base de datos: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                if (conectar.State == System.Data.ConnectionState.Open)
                {
                    conectar.Close();
                    Console.WriteLine(" Conexión cerrada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al cerrar base de datos: " + ex.Message);
            }
        }
    }
}
