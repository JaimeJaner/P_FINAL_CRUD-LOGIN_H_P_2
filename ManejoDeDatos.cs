using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    public class ManejoDeDatos
    {

        private static readonly string DBName = "DB_DonacionesSA";
        /*
        private static readonly string tablaUsuario = "tbl_Usuario";
        private static readonly string tablaProducto = "tbl_Producto";
        private static readonly string tablaEntrega = "tbl_Entrega";
        */

        public ManejoDeDatos()
        {
            

        }



        public static void ImportarDatos(string ruta, string nombreModelo)
        {
            /*
            using (StreamReader reader = new StreamReader(ruta))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB())
                {
                    conexionDB.Open();

                    string nombreTabla = nombreModelo;
                
                    if (nombreTabla == tablaUsuario)
                    {
                        var records = csv.GetRecord<Usuario>();

                    }else if (nombreModelo == tablaProducto)
                    {
                        var records = csv.GetRecord<Producto>();

                    }
                    else if (nombreModelo == tablaEntrega)
                    {
                        var records = csv.GetRecord<Entrega>();

                    }
                    else
                    {
                        MessageBox.Show("Error, nombre modelo incorrecto");
                        return;
                    }

                }
            }
            */

        }


        public static void ImportarDatos(string ruta, string nombreModelo, string a, string b)
        {

        }



    }



    

    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public int Cantidad { get; set; }
    }

    public class Entrega
    {
        public int Id_entrega { get; set; }
        public int Id_empleado { get; set; }
        public int Cedula_recibe { get; set; }
        public int Id_producto { get; set; }
        public string Fecha { get; set; }
    }
}


