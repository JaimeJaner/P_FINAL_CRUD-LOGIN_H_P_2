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

namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    public partial class frm_ListaUsuarios : Form
    {

       

        public frm_ListaUsuarios()
        {
            InitializeComponent();
        }

        private static string DBName = "DB_DonacionesSA";
        private static string tableName = "tbl_Usuario";

        //se obtienen los datos de la DB
        public SQLiteCommand GetDatos()
        {
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                //se abre conexionDB (se cierra en UpdateDgv)
                conexionDB.Open();

                string getProductos = string.Format("SELECT Id_persona, Nombre, Cedula, Estado, Tipo_usuario FROM {0};", tableName);

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


        //para actualizar/mostrar los datos de la DB por si hay algun cambio, ya sea un create, update, delete o solo si se quiere obtener los elementos
        //este metodo muestra los datos en el dgv ya sea la primera vez o si hay alguna actualizacion
        public void UpdateDgv()
        {

            try
            {

                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                SQLiteCommand cmd_GetDatos = GetDatos();

                //volviendo a abrir la DB

                SQLiteDataReader datareader_sqlite = cmd_GetDatos.ExecuteReader();


                dgvUsuarios.Rows.Clear();
                dgvUsuarios.Columns.Clear();


                dgvUsuarios.Columns.Add("id_Persona", "ID");
                dgvUsuarios.Columns.Add("Nombre", "Nombre");
                dgvUsuarios.Columns.Add("Cedula", "Cedula");
                dgvUsuarios.Columns.Add("Estado", "Estado");
                dgvUsuarios.Columns.Add("Tipo usuario", "Tipo usuario");

                while (datareader_sqlite.Read())
                {
                    //Obtenemos los datos
                    int id_Persona = datareader_sqlite.GetInt32(0);
                    string nombre = datareader_sqlite.GetString(1);
                    int cedula = datareader_sqlite.GetInt32(2);
                    int estado = datareader_sqlite.GetInt32(3);
                    string estadoString = estado == 1 ? "Habilitado" : "desahibilitado";
                    
                    int tipo_usuario = datareader_sqlite.GetInt32(4);



                    //los colocamos en el dgv
                    dgvUsuarios.Rows.Add(id_Persona, nombre, cedula, estado, tipo_usuario);

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


            //ValidarDgv();

        }



        /*
        //creando un dato
        public SQLiteCommand CreateDato()
        {

            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                conexionDB.Open();

                float precio;

                if (!string.IsNullOrEmpty(txtPrecioProducto.Text) && !float.TryParse(txtPrecioProducto.Text, out precio))
                {
                    MessageBox.Show("Error: el precio debe de ser un valor numerico");
                    return null;
                }

                if (txtPrecioProducto.Text.Contains(","))
                {
                    MessageBox.Show("Error, no ingrese ',' en el precio");
                    return null;

                }

                if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtPrecioProducto.Text))
                {


                    //verificamos que el nombre no se repita
                    string checkUniqueName = string.Format("SELECT COUNT(name) FROM {0} WHERE name=@name", tableName);

                    SQLiteCommand cmd_checkName = new SQLiteCommand(checkUniqueName, conexionDB);
                    cmd_checkName.Parameters.AddWithValue("@name", txtNombreProducto.Text);

                    if (Convert.ToInt32(cmd_checkName.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Error el nombre del producto ya existe");
                        return null;
                    }

                    //si no se repite entonces creamos el prod
                    int id = VerificarIDUnico();

                    string createProducto = string.Format("INSERT INTO tbl_product (id, name, price) VALUES(@id, @nombre, @precio);", tableName);

                    SQLiteCommand cmd_createProduct = new SQLiteCommand(createProducto, conexionDB);
                    cmd_createProduct.Parameters.AddWithValue("@id", id);
                    cmd_createProduct.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                    cmd_createProduct.Parameters.AddWithValue("@precio", txtPrecioProducto.Text);

                    MessageBox.Show("Producto creado con exito");


                    return cmd_createProduct;
                }
                else
                {

                    MessageBox.Show("Por favor ingrese el nombre del producto y su precio");


                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error creando el producto\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }


            return null;

        }


        
        //llenar comboBox y UpdateDato

        //se llena los comboBox con los ids (sirve para el metodo de actualizar y eliminar)

        public void LlenarCombobox(ComboBox comboBox)
        {
            //llenamos los combobox con los ids disponibles
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                conexionDB.Open();
                string getIDs = string.Format("SELECT id FROM {0}", tableName);

                SQLiteCommand cmd_getIDs = new SQLiteCommand(getIDs, conexionDB);

                SQLiteDataReader datareader_sqlite = cmd_getIDs.ExecuteReader();

                comboBox.Items.Clear();


                while (datareader_sqlite.Read())
                {
                    //Obtenemos los ids
                    int idProd = datareader_sqlite.GetInt32(0);

                    //los colocamos en el comboBox
                    comboBox.Items.Add(idProd);

                }



                //MessageBox.Show("El combo box ha sido llenado");
                datareader_sqlite.Close();

                conexionDB.Close();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (sql): " + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


        }

        // UpdateDato

        public SQLiteCommand UpdateDato()
        {
            string queryActualizar;


            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();
            //dependiendo de los datos ingresados se hace un query u otro

            float nuevoPrecio;
            if (!string.IsNullOrEmpty(txtNuevoPrecio.Text) && !float.TryParse(txtNuevoPrecio.Text, out nuevoPrecio))
            {
                MessageBox.Show("Error: el precio debe de ser un valor numerico");
                return null;
            }

            if (txtNuevoPrecio.Text.Contains(","))
            {
                MessageBox.Show("Error, no ingrese ',' en el nuevo precio");
                return null;

            }

            if (cbIdAEditar.SelectedIndex == -1)
            {
                MessageBox.Show("Error: debes de seleccionar un id de un producto para modificar\n" +
                    "Prueba con traer los productos para ver los ids disponibles");
                return null;
            }


            if (!string.IsNullOrEmpty(txtNuevoNombre.Text) && !string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set name=@name, price=@price where id=@id", tableName);
            }
            else if (!string.IsNullOrEmpty(txtNuevoNombre.Text) && string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set name=@name where id=@id", tableName);

            }
            else if (string.IsNullOrEmpty(txtNuevoNombre.Text) && !string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set price=@price where id=@id", tableName);
            }
            else
            {
                MessageBox.Show("Ingrese al menos un nuevo nombre o precio");
                return null;
            }

            //se crea el comando con uno de los querys de arriba
            SQLiteCommand cmd_actualizar = new SQLiteCommand(queryActualizar, conexionDB);


            if (cbIdAEditar.SelectedIndex != -1)
            {
                cmd_actualizar.Parameters.AddWithValue("@id", Convert.ToInt32(cbIdAEditar.SelectedItem.ToString()));

                // se agrega una u otra o las dos opciones dependiendo de los que ingrese o no el usuario
                if (!string.IsNullOrEmpty(txtNuevoNombre.Text))
                {
                    cmd_actualizar.Parameters.AddWithValue("@name", txtNuevoNombre.Text);
                }
                if (!string.IsNullOrEmpty(txtNuevoPrecio.Text))
                {
                    cmd_actualizar.Parameters.AddWithValue("@price", txtNuevoPrecio.Text);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un ID");
                return null;
            }

            return cmd_actualizar;
        }

        //delete dato
        public int DeleteDato()
        {
            string queryEliminarProducto = string.Format("delete from {0} where id=@id", tableName);

            using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB())
            {
                conexionDB.Open();
                using (SQLiteCommand cmd_DeleteDato = new SQLiteCommand(queryEliminarProducto, conexionDB))
                {
                    if (cbProdAEliminar.SelectedIndex == -1)
                    {
                        MessageBox.Show("Error, selecciona un ID para eliminar un producto");
                        return 0;
                    }

                    cmd_DeleteDato.Parameters.AddWithValue("@id", Convert.ToInt32(cbProdAEliminar.SelectedItem.ToString()));
                    int filasAfectadas = cmd_DeleteDato.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        */


        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_Principal Principal = new frm_Principal();
            Principal.Show();
            Hide();
        }


        private void frm_ListaUsuarios_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }
    }
}
