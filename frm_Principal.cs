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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            lbl_NombreUsuario.Text = Global.UsuarioGlobal;
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            frm_InicioApp Inicio = new frm_InicioApp();
            Inicio.Show();
            Hide();
        }

        private void btn_Entregas_Click(object sender, EventArgs e)
        {
            frm_Entrega Ent = new frm_Entrega();
            Ent.Show();
            Hide();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            frm_Inventario Inv = new frm_Inventario();
            Inv.Show();
            Hide();
        }

        private void btn_ListaUsuarios_Click(object sender, EventArgs e)
        {
            frm_ListaUsuarios LU = new frm_ListaUsuarios();
            LU.Show();
            Hide();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                //Creamos los objetos necesarios para la conexión y ejecución de la base de datos.
                SQLiteConnection conexion_sqlite;
                SQLiteCommand cmd_sqlite;
                SQLiteDataReader datareader_sqlite;

                //Crear una nueva conexión de la base de datos
                conexion_sqlite = new SQLiteConnection("Data Source=DB_DonacionesSA.db;Version=3;Compress=True;");

                //Abriremos la conexión
                conexion_sqlite.Open();

                //Creando el comando SQL
                cmd_sqlite = conexion_sqlite.CreateCommand();
                //En ésta línea, creamos un comando que recibe un string.

                cmd_sqlite.CommandText = string.Format("SELECT Tipo_usuario FROM tbl_Usuario WHERE Cedula = {0}", lbl_NombreUsuario.Text);
                object result = cmd_sqlite.ExecuteScalar();
                int estado = Convert.ToInt32(result);

                if (estado == 0)
                {
                    btn_ListaUsuarios.Enabled = false;
                    lbl_TipoUsuario.Text = "Empleado";
                    Global.TipoUsuario = "Empleado";
                }
                else
                {
                    lbl_TipoUsuario.Text = "Administrador";
                    Global.TipoUsuario = "Administrador";
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
