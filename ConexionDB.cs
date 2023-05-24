using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
   
    public class ConexionDB
    {
        public string CedulaUsuario = "";
        private string nombreDB;
        public ConexionDB(string _nombreDB)
        {
            nombreDB = _nombreDB;
        }


        public SQLiteConnection ConectarDB()
        {
            SQLiteConnection conexion_sqlite = null;

            try
            {
                //creamos la conexion
                conexion_sqlite = new SQLiteConnection(string.Format("Data Source={0}.db;Version=3;Compress=True;", nombreDB));
                //abrimo la wea
                conexion_sqlite.Open();

                // Creación de las tablas por si no existen

                //creacion tabla usuario
                string queryCrearTablaUsuario = @"CREATE TABLE IF NOT EXISTS tbl_Usuario ( 
                                                    Id_persona	INTEGER NOT NULL UNIQUE,
                                                    Nombre	TEXT NOT NULL,
                                                    Cedula	INTEGER NOT NULL CHECK(Cedula > 0) UNIQUE,
                                                    Contraseña	TEXT NOT NULL,
                                                    Estado	INTEGER NOT NULL CHECK(Estado IN (0, 1)),
                                                    Tipo_usuario	INTEGER NOT NULL CHECK(Tipo_usuario IN (0, 1)),
                                                    PRIMARY KEY(Id_persona AUTOINCREMENT)
                                                    );";
                SQLiteCommand cmd_crearTablaUsuario = new SQLiteCommand(queryCrearTablaUsuario, conexion_sqlite);

                //creacion tabla producto
                string queryCrearTablaProducto = @"CREATE TABLE IF NOT EXISTS tbl_Producto (
	                                                Id_producto	INTEGER NOT NULL UNIQUE,
	                                                Nombre_producto	TEXT NOT NULL,
	                                                Cantidad INTEGER NOT NULL CHECK(Cantidad > 0),
	                                                descripcion	TEXT NOT NULL
                                                );";
                SQLiteCommand cmd_crearTablaProducto = new SQLiteCommand(queryCrearTablaProducto, conexion_sqlite);

                //creacion tabla entrega
                string queryCrearTablaEntrega = @"CREATE TABLE IF NOT EXISTS tbl_Entrega (
	                                            Id_entrega	INTEGER NOT NULL UNIQUE,
	                                            Id_empleado	INTEGER NOT NULL,
	                                            Cedula_recibe	INTEGER NOT NULL,
	                                            Id_producto	INTEGER NOT NULL,
	                                            Cantidad INTEGER NOT NULL CHECK(Cantidad > 0),
	                                            Fecha	TEXT NOT NULL,
	                                            FOREIGN KEY(Id_empleado) REFERENCES tbl_Usuario(Id_persona),
	                                            FOREIGN KEY(Id_producto) REFERENCES tbl_Producto(Id_producto),
	                                            PRIMARY KEY(Id_entrega AUTOINCREMENT)
                                            );";
                SQLiteCommand cmd_crearTablaEntrega = new SQLiteCommand(queryCrearTablaEntrega, conexion_sqlite);




                //pa que ejecute los comandos de creacion (no devuelve na importante)
                cmd_crearTablaUsuario.ExecuteNonQuery();
                cmd_crearTablaProducto.ExecuteNonQuery();
                cmd_crearTablaEntrega.ExecuteNonQuery();
;

                //cerramos la wea
                conexion_sqlite.Close();

                //MessageBox.Show("conectado");


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error conectando a la base de datos " + nombreDB + "\nError: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            return conexion_sqlite;
        }


        public void verificarExistenciaTabla()
        {

        }

    }
}
