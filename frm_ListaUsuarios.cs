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

        private static string DBName = "DB_DonacionesSA";
        private static string tableName = "tbl_Usuario";
       

        public frm_ListaUsuarios()
        {
            InitializeComponent();
        }

        //apenas cargue la pagina se carguen los usuarios
        private void frm_ListaUsuarios_Load(object sender, EventArgs e)
        {
            UpdateDgv();

            cbEstado.Items.Add("Habilitar");
            cbEstado.Items.Add("Deshabilitar");

            cbTipoUsuario.Items.Add("Administrador");
            cbTipoUsuario.Items.Add("Empleado");
        }

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
                    string estadoString = estado == 1 ? "Habilitado" : "Desahibilitado";
                    int tipo_usuario = datareader_sqlite.GetInt32(4);
                    string tipo_usuarioString = tipo_usuario == 1 ? "Administrador" : "Empleado";



                    //los colocamos en el dgv
                    dgvUsuarios.Rows.Add(id_Persona, nombre, cedula, estadoString, tipo_usuarioString);

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
            ValidarDgv();
        }


        //obtener un dato (si existe) por su cedula
        public void GetDatoByCedula(int _cedula)
        {
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                //se abre conexionDB (se cierra en UpdateDgv)
                conexionDB.Open();

                string getData = string.Format("SELECT Id_persona, Nombre, Cedula, Estado, Tipo_usuario FROM {0} WHERE Cedula=@Cedula;", tableName);


                SQLiteCommand cmd_getData = new SQLiteCommand(getData, conexionDB);
                cmd_getData.Parameters.AddWithValue("@Cedula", _cedula);

                if (Convert.ToInt32(cmd_getData.ExecuteScalar()) < 1) {
                    MessageBox.Show("Error, cédula no encontrada");
                    return;
                }

                //si la cedula se encuentra se ejecuta de aqui hacia abajo
                SQLiteDataReader datareader_sqlite = cmd_getData.ExecuteReader();


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
                    string estadoString = estado == 1 ? "Habilitado" : "Desahibilitado";
                    int tipo_usuario = datareader_sqlite.GetInt32(4);
                    string tipo_usuarioString = tipo_usuario == 1 ? "Administrador" : "Empleado";



                    //los colocamos en el dgv
                    dgvUsuarios.Rows.Add(id_Persona, nombre, cedula, estadoString, tipo_usuarioString);

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

            ValidarDgv();
        }

     

        // UpdateDato

        public SQLiteCommand UpdateDato()
        {
            string queryActualizar = "";


            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();
            //dependiendo de los datos ingresados se hace un query u otro


            //UPDATE tbl_Usuario SET Tipo_usuario = 0 WHERE Cedula = 741

            if (cbEstado.SelectedIndex != -1 && cbTipoUsuario.SelectedIndex != -1)
            {
                queryActualizar = string.Format("UPDATE {0} SET Tipo_usuario=@Tipo_usuario, Estado=@Estado where Cedula=@Cedula", tableName);
            }
            else if (cbEstado.SelectedIndex != -1 && cbTipoUsuario.SelectedIndex == -1)
            {
                queryActualizar = string.Format("UPDATE {0} SET Estado=@Estado where Cedula=@Cedula", tableName);

            }
            else if (cbEstado.SelectedIndex == -1 && cbTipoUsuario.SelectedIndex != -1)
            {
                queryActualizar = string.Format("UPDATE {0} SET Tipo_usuario=@Tipo_usuario where Cedula=@Cedula", tableName);
            }
            else
            {
                MessageBox.Show("Ingrese el nuevo estado y/o el nuevo tipo de usuario");
                
            }

            //se crea el comando con uno de los querys de arriba
            SQLiteCommand cmd_actualizar = new SQLiteCommand(queryActualizar, conexionDB);

            if (string.IsNullOrEmpty(txtBuscarUsuario.Text))
            {
                MessageBox.Show("Debe de seleccionar un usuario (por su cédula) para actualizarle los datos");
                return null;

            }

            cmd_actualizar.Parameters.AddWithValue("@Cedula", Convert.ToInt32(txtBuscarUsuario.Text));

            // se agrega una u otra o las dos opciones dependiendo de los que ingrese o no el usuario
            if (cbEstado.SelectedIndex != -1)
            {
                cmd_actualizar.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString() == "Habilitar" ? 1 : 0);
            }
            if (cbTipoUsuario.SelectedIndex != -1)
            {
                cmd_actualizar.Parameters.AddWithValue("@Tipo_usuario", cbTipoUsuario.SelectedItem.ToString() == "Administrador" ? 1 : 0);
            }
            

            return cmd_actualizar;
        }

        


        //pa que vaya a la pagina principal
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_Principal Principal = new frm_Principal();
            Principal.Show();
            Hide();
        }

        

        //pa que solo ponga numeros
        private void txtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        //comprueba que no este vacio y llama al metodo GetDatoByCedula con el valor que tiene txtBuscarUsuario.Text
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarUsuario.Text))
            {
                MessageBox.Show("Ingrese la cédula a buscar");
                return;
            }


            GetDatoByCedula(Convert.ToInt32(txtBuscarUsuario.Text));
            //txtBuscarUsuario.Text = string.Empty;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                SQLiteCommand cmd_UpdateDato = UpdateDato();


                if (cmd_UpdateDato != null && cmd_UpdateDato.GetType() == typeof(SQLiteCommand))
                {
                    conexionDB.Open();
                    int filasAfectadas = cmd_UpdateDato.ExecuteNonQuery();
                    //MessageBox.Show("Producto modificado con exito");

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario modificado con exito");
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");

                    }

                    UpdateDgv();
                }
                else
                {

                    MessageBox.Show("Error al modificar al usuario");

                }

                conexionDB.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (sql):\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }

        }


        //mostrar todos los datos por si antes le dio en buscar alguno y ahora quiere volver a ver a todos los users si sabe
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }










        /* navegacion */

        private void ValidarDgv()
        {
            if (dgvUsuarios.RowCount > 0)
            {
                BtnPrincipio.Enabled = true;
                BtnAtras.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnFinal.Enabled = true;
            }
            else
            {
                BtnPrincipio.Enabled = false;
                BtnAtras.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnFinal.Enabled = false;
            }
        }

        private int selectedRowIndex = -1;

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }


        private void BtnPrincipio_Click(object sender, EventArgs e)
        {
            selectedRowIndex = 0;


            dgvUsuarios.Rows[selectedRowIndex].Selected = true;
            dgvUsuarios.CurrentCell = dgvUsuarios.Rows[selectedRowIndex].Cells[0];

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex > 0)
            {
                selectedRowIndex--;
                dgvUsuarios.Rows[selectedRowIndex].Selected = true;
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[selectedRowIndex].Cells[0];
            }
        }


        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < dgvUsuarios.Rows.Count - 1)
            {
                selectedRowIndex++;
                dgvUsuarios.Rows[selectedRowIndex].Selected = true;
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[selectedRowIndex].Cells[0];
            }
        }

        private void BtnFinal_Click(object sender, EventArgs e)
        {

            selectedRowIndex = dgvUsuarios.Rows.Count - 1;
            dgvUsuarios.Rows[selectedRowIndex].Selected = true;
            dgvUsuarios.CurrentCell = dgvUsuarios.Rows[selectedRowIndex].Cells[0];
        }

        
    }
}
