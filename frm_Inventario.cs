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
using CsvHelper;
using System.Globalization;
using System.IO;
using MaterialSkin.Controls;

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    public partial class frm_Inventario : MaterialForm
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

                    string nombreProducto = txtNombre.Text.Trim();
                    SQLiteCommand cmd_verificar = new SQLiteCommand("SELECT COUNT(*) FROM tbl_Producto WHERE Nombre_producto = @Nombre", conexion_sqlite);
                    cmd_verificar.Parameters.AddWithValue("@Nombre", nombreProducto);
                    int count = Convert.ToInt32(cmd_verificar.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("El nombre del producto ya existe");
                        return;
                    }

                    //Insertando valores, no se inserta el id ya que es auto incrementable
                    cmd_sqlite.CommandText = string.Format("INSERT INTO tbl_Producto (Nombre_producto, Cantidad) VALUES ('" + txtNombre.Text + "', " + txtCant.Text + ")");
                    cmd_sqlite.ExecuteNonQuery();   
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
            txtCant.Clear();
            txtNombre.Clear();
            UpdateDgv();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
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
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE tbl_Producto SET Nombre_producto=@Nombre, Cantidad=@Cantidad WHERE Id_producto=@ID", conexion_sqlite);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ID", txtId.Text);

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
            txtCant.Clear();
            txtNombre.Clear();
            txtId.Clear();
            UpdateDgv();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
            txtNombre.Clear();
            txtCant.Clear();
            UpdateDgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese la cédula a buscar");
                return;
            }
            GetDatoByCedula(txtBuscar.Text);
            txtBuscar.Clear();
        }

        public void GetDatoByCedula(string _nom)
        {
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                //se abre conexionDB (se cierra en UpdateDgv)
                conexionDB.Open();

                string getData = string.Format("SELECT Id_producto, Nombre_producto, Cantidad FROM {0} WHERE Nombre_producto=@Nombre;", tableName);


                SQLiteCommand cmd_getData = new SQLiteCommand(getData, conexionDB);
                cmd_getData.Parameters.AddWithValue("@Nombre", _nom);

                if (Convert.ToInt32(cmd_getData.ExecuteScalar()) < 1)
                {
                    MessageBox.Show("Error, producto no encontrado");
                    return;
                }

                //si la cedula se encuentra se ejecuta de aqui hacia abajo
                SQLiteDataReader datareader_sqlite = cmd_getData.ExecuteReader();


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
                MessageBox.Show("Error obteniendo los datos desde la base de datos\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void frm_Inventario_Load(object sender, EventArgs e)
        {
            //Al entrar al form inmediatamente muestra los datos de la DB
            UpdateDgv();
            lbl_NombreUsuario.Text = Global.UsuarioGlobal;
            lbl_TipoUsuario.Text = Global.TipoUsuario;

            if(lbl_TipoUsuario.Text=="Empleado")
            {
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
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
            //para actualizar/mostrar los datos de la DB por si hay algun cambio, ya sea un create, update, delete o solo si se quiere obtener los elementos
            //este metodo muestra los datos en el dgv ya sea la primera vez o si hay alguna actualizacion
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos CSV (*.csv)|*.csv";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ofd.FileName;
                    ImportarDatos(ruta);
                }
            }
            UpdateDgv();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.Title = "Guardar archivo CSV";
                sfd.FileName = "tbl_Producto.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportarDatos(sfd.FileName);
                }
            }
        }
        public static void ImportarDatos(string ruta)
        {
            try
            {
                using (StreamReader reader = new StreamReader(ruta))
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB())
                    {
                        conexionDB.Open();

                        // una lista pa los datos que estamos importando
                        List<Usuario> records = new List<Usuario>();

                        //Registros malos
                        List<Usuario> ErrorRecords = new List<Usuario>();

                        //leer csv
                        while (csv.Read())
                        {
                            bool emptycamps = false;

                            //Ver que este vacio y si lo esta el registro no sirve
                            for (int i = 0; i < csv.Parser.Record.Length; i++)
                            {
                                if (string.IsNullOrEmpty(csv.Parser.Record[i]))
                                {
                                    emptycamps = true;
                                    break;
                                }
                            }

                            // si tiene algun campo vacio entra aqui y lo agrega a esta lista de registros fallidos
                            if (emptycamps)
                            {
                                ErrorRecords.Add(csv.GetRecord<Usuario>());
                            }

                            Usuario usuario = csv.GetRecord<Usuario>();
                            records.Add(usuario);
                        }

                        foreach (var record in records)
                        {
                            // Verificar si el Id_persona o la cedula ya existe en la tabla, si existe no lo agrega 
                            using (SQLiteCommand check = new SQLiteCommand("SELECT COUNT(*) FROM tbl_Producto where Id_producto = @ID", conexionDB))
                            {
                                check.Parameters.AddWithValue("@ID", record.Id_producto);
                                int count = Convert.ToInt32(check.ExecuteScalar());

                                if (count > 0)
                                {
                                    using (SQLiteCommand cm = new SQLiteCommand(conexionDB))
                                    {
                                        cm.CommandText = "INSERT INTO tbl_Producto (Id_producto, Nombre_producto, cantidad) VALUES (@ID, @nombre, @cantidad)";
                                        cm.Parameters.AddWithValue("@ID", record.Id_producto);
                                        cm.Parameters.AddWithValue("@nombre", record.Nombre_producto);
                                        cm.Parameters.AddWithValue("@cantidad", record.Cantidad);

                                        cm.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // El Id_producto ya existe, realizar alguna acción o mostrar un mensaje de error
                                    Console.WriteLine($"El Id_prodcuto {record.Id_producto} ya existe en la tabla");
                                }
                            }
                        }
                        MessageBox.Show("Se importó correctamente los datos a la base de datos");
                    }
                }
            }
            catch (SQLiteException lol)
            {
                MessageBox.Show("Erro (sql): \n" + lol.Message);
                Console.WriteLine("Erro (sql): \n" + lol.Message);
            }
            catch (Exception u)
            {
                MessageBox.Show("Error al importar:\n" +
                   "Revise que el archivo CSV cuente con todos sus valores y con sus respectivos tipos de datos\n" +
                   "Revise que no haya otra aplicación haciendo uso del archivo CSV");
                Console.WriteLine("Error:\n" + u.Message);
            }
        }

        public static void ExportarDatos(string ruta)
        {
            try
            {
                using (var write = new StreamWriter(ruta))
                using (var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
                {
                    using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB())
                    {
                        conexionDB.Open();
                        // Recupera los datos de la tabla de SQLite
                        using (var cm = new SQLiteCommand("SELECT * FROM tbl_Producto", conexionDB))
                        {
                            using (var reader = cm.ExecuteReader())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    csv.WriteField(reader.GetName(i));
                                }
                                csv.NextRecord();

                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        csv.WriteField(reader[i]);
                                    }
                                    csv.NextRecord();
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Se exportó correctamente los datos a un archivo csv");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (sql):" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public class Usuario
        {
            public int Id_producto { get; set; }
            public string Nombre_producto { get; set; }
            public int Cantidad { get; set; }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sirve para ignorar el carácter ingresado (número)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sirve para ignorar el carácter ingresado (letras)
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sirve para ignorar el carácter ingresado (número)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}