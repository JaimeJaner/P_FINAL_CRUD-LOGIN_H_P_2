using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    public partial class frm_Inventario : Form
    {
        //Algunos comandos necesarios para la conexion
        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;
        SQLiteDataReader datareader_sqlite;


        private static string DBName = "DB_DonacionesSA";
        private static string tableName = "tbl_Producto";
        public frm_Inventario()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_Principal Principal = new frm_Principal();
            Principal.Show();
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Para verificar campos vacios
            if (txtNombre.Text.Trim() != "" && txtCant.Text.Trim() != "")
            {
                try
                {
                    //Conexion a la base de datos
                    conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;");

                    //Abrimos la conexion
                    conexion_sqlite.Open();

                    cmd_sqlite = conexion_sqlite.CreateCommand();


                    //Insertando valores, no se inserta el id ya que es auto incrementable
                    cmd_sqlite.CommandText = string.Format("INSERT INTO tbl_Producto (Nombre_producto, Cantidad) VALUES ('" + txtNombre.Text + "', " + txtCant.Text + ")");

                    MessageBox.Show("Registrado Correctamente");

                }
                catch (Exception iu)
                {

                    MessageBox.Show("Error al intentar registrarse" + iu.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
            UpdateDgv();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && txtCant.Text.Trim() != "")
            {

                //Codigo para actualizar los datos

                conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;");
                conexion_sqlite.Open();

                try
                {
                    //Conexion a la base de datos
                    conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;");

                    //Abrimos la conexion
                    conexion_sqlite.Open();

                    cmd_sqlite = conexion_sqlite.CreateCommand();


                    //Insertando valores, no se inserta el id ya que es auto incrementable
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE tbl_Producto SET Nombre_producto=@Nombre WHERE Nombre_producto=@Nombre", conexion_sqlite);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                    cmd.ExecuteNonQuery();
                    conexion_sqlite.Close();

                    MessageBox.Show("Actualizado correctamente");

                }
                catch (Exception iu)
                {

                    MessageBox.Show("Error al intentar registrarse" + iu.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
            UpdateDgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Codigo para eliminar datos de la tabla

            conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;");
            conexion_sqlite.Open();

            if (txtNombre.Text.Trim() != "")
            {
                try
                {
                    //lanzamos el comando delete from table que normalmente se usa en las DBS
                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM tbl_Producto WHERE Nombre_producto=@Nombre", conexion_sqlite);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.ExecuteNonQuery();
                    conexion_sqlite.Close();

                    MessageBox.Show("Se ha eliminado correctamente por favor lea los datos de nuevo");
                }
                catch (Exception l)
                {

                    MessageBox.Show("Error al borrar los datos " + l.Message);

                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
            UpdateDgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;");
            conexion_sqlite.Open();

            if (txtBuscar.Text.Trim() != "")
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tbl_Producto WHERE Id_producto=@ID", conexion_sqlite);
                cmd.Parameters.AddWithValue("@ID", txtBuscar);
                cmd.ExecuteNonQuery();
                conexion_sqlite.Close();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
            UpdateDgv();
        }

        private void frm_Inventario_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        //se obtienen los datos de la DB
        public SQLiteCommand GetDatos()
        {
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                //se abre conexionDB (se cierra en UpdateDgv)
                conexionDB.Open();

                string getProductos = string.Format("SELECT Id_producto, Nombre_producto, Cantidad FROM {0};", tableName);

                SQLiteCommand cmd_getProducts = new SQLiteCommand(getProductos, conexionDB);

                //cada vez que obtengamos los datos tambien actualizamos los combo box

                //LlenarCombobox(cbProdAEliminar);
                //LlenarCombobox(cbIdAEditar);


                return cmd_getProducts;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error obteniendo los datos desde la base de datos\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            return null;

        }
        public void UpdateDgv()
        {
            try
            {

                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                SQLiteCommand cmd_GetDatos = GetDatos();

                //volviendo a abrir la DB

                SQLiteDataReader datareader_sqlite = cmd_GetDatos.ExecuteReader();


                dgvInventario.Rows.Clear();
                dgvInventario.Columns.Clear();


                dgvInventario.Columns.Add("Id_producto", "ID");
                dgvInventario.Columns.Add("Nombre_producto", "Nombre");
                dgvInventario.Columns.Add("Cantidad", "Cantidad");    

                while (datareader_sqlite.Read())
                {
                    //Obtenemos los datos
                    int Id_producto = datareader_sqlite.GetInt32(0);
                    string Nombre_producto = datareader_sqlite.GetString(1);
                    int Cantidad = datareader_sqlite.GetInt32(2);

                    //los colocamos en el dgv
                    dgvInventario.Rows.Add(Id_producto, Nombre_producto, Cantidad);

                }
                datareader_sqlite.Close();
                conexionDB.Close();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (DB - mostrando los datos en el dgv):\n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (mostrando los datos en el dgv):\n" + ex);
            }


        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }
        //para actualizar/mostrar los datos de la DB por si hay algun cambio, ya sea un create, update, delete o solo si se quiere obtener los elementos
        //este metodo muestra los datos en el dgv ya sea la primera vez o si hay alguna actualizacion
    }
}