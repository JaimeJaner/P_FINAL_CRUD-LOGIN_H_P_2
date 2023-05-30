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
using System.Data.SqlClient;

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    public partial class frm_Entrega : Form
    {

        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;
        SQLiteDataReader datareader_sqlite;


        private static string DBName = "DB_DonacionesSA";
        private static string tableName = "tbl_Producto";
        public frm_Entrega()
        {
            InitializeComponent();
            lbl_NombreUsuario.Text = Global.UsuarioGlobal;
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_Principal Principal = new frm_Principal();
            Principal.Show();
            Hide();
        }

        private void frm_Entrega_Load(object sender, EventArgs e)
        {
            UpdateDgv();

            lbl_NombreUsuario.Text = Global.UsuarioGlobal;
            lbl_TipoUsuario.Text = Global.TipoUsuario;

            if (lbl_TipoUsuario.Text == "Empleado")
            {
                btnCargar.Enabled = false;
            }
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


                     dgvDisponibles.Rows.Clear();
                     dgvDisponibles.Columns.Clear();


                     dgvDisponibles.Columns.Add("Id_producto", "ID");
                     dgvDisponibles.Columns.Add("Nombre_producto", "Nombre");
                     dgvDisponibles.Columns.Add("Cantidad", "Cantidad");

                    while (datareader_sqlite.Read())
                    {
                        //Obtenemos los datos
                        int Id_producto = datareader_sqlite.GetInt32(0);
                        string Nombre_producto = datareader_sqlite.GetString(1);
                        int Cantidad = datareader_sqlite.GetInt32(2);

                        //los colocamos en el dgv
                         dgvDisponibles.Rows.Add(Id_producto, Nombre_producto, Cantidad);

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


        public void entregas() {

            try
            {

                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                SQLiteCommand cmd_GetDatos = GetDatos();

                //volviendo a abrir la DB

                SQLiteDataReader datareader_sqlite = cmd_GetDatos.ExecuteReader();


                 dgvEntregados.Rows.Clear();
                 dgvEntregados.Columns.Clear();

                 dgvEntregados.Columns.Add("Id_entrega", "id");
                 dgvEntregados.Columns.Add("Id_persona", "Documento empleado");
                 dgvEntregados.Columns.Add("Cedula_recibe", "Documento Beneficiario");
                 dgvEntregados.Columns.Add("Id_producro", "Id producto");
                 dgvEntregados.Columns.Add("Cantidad", "Cantidad producto");
                 dgvEntregados.Columns.Add("Fecha", "Fehca Entrega");

                while (datareader_sqlite.Read())
                {
                    //Obtenemos los datos
                    int Id_producto = datareader_sqlite.GetInt32(0);
                    string Nombre_producto = datareader_sqlite.GetString(1);
                    int Cantidad = datareader_sqlite.GetInt32(2);
                    int Id_persona = Convert.ToInt32(Global.UsuarioGlobal);

                    //los colocamos en el dgv
                     dgvEntregados.Rows.Add(Id_producto, Cantidad, Id_persona);

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

        private void btnActualizarEntrega_Click(object sender, EventArgs e)
        {
            entregas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
           
        }


        private string productoSeleccionado;
        private int cantidadSeleccionada;
        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productoSeleccionado))
            {
                // Agregar los datos a la dgvEntregas
                dgvEntregados.Rows.Add(productoSeleccionado, cantidadSeleccionada);

                // Limpiar las variables para futuras entregas
                productoSeleccionado = null;
                cantidadSeleccionada = 0;

                // Actualizar la interfaz de usuario si es necesario
                // Por ejemplo, limpiar los cuadros de texto
                txtBuscar.Text = string.Empty;
                txtCantidad.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No hay producto seleccionado para la entrega.");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection conexion = new ConexionDB(DBName).ConectarDB();

            string producto = txtBuscar.Text;
            int cantidad = 0;

            if (int.TryParse(txtCantidad.Text, out cantidad))
            {
                // Verificar si el producto existe y la cantidad está disponible
                string consulta = "SELECT Nombre_producto, Cantidad FROM tbl_Producto WHERE Nombre_producto = @producto AND Cantidad >= @cantidad";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@producto", producto);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

                try
                {
                    conexion.Open();
                    SQLiteDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Producto y cantidad válidos, seleccionar el producto
                        string productoSeleccionado = reader["Nombre_producto"].ToString();
                        int cantidadSeleccionada = cantidad;

                        // Actualizar la interfaz de usuario si es necesario
                        // Por ejemplo, mostrar un mensaje de éxito
                        MessageBox.Show("Producto válido. Puede realizar la entrega.");
                    }
                    else
                    {
                        // El producto no existe o la cantidad no está disponible
                        MessageBox.Show("El producto no existe o la cantidad no está disponible.");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error en la consulta SQL: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }
    }
} 
