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
    
    public partial class frm_SignIn : Form
    {
        public int intentos;
        public frm_SignIn()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_InicioApp Inicio = new frm_InicioApp();
            Inicio.Show();
            Hide();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            //Verificamos que los campos estén completos.
            if (txt_Usuario.Text.Trim()=="" || txt_Contraseña.Text.Trim()=="")
            {
                MessageBox.Show("Por favor rellene todos los campos.");
            }
            //En caso de que sí...
            else
            {

                //Lanzamos un trycatch para atrapar cualquier error que se manifieste en medio de la conexión a la base de datos.
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

                    cmd_sqlite.CommandText = string.Format("SELECT COUNT(*) FROM tbl_Usuario WHERE Cedula= {0} AND Contraseña='{1}'", txt_Usuario.Text, txt_Contraseña.Text);

                    //Recibimos el número de filas afectada, 1 si existe, 0 si no existe el loggin.

                    int count = Convert.ToInt32(cmd_sqlite.ExecuteScalar());

                    if (count > 0)
                    {
                        //Una vez verificado el loggin existente, verificamos si su cuenta está o no activa.

                        cmd_sqlite.CommandText = string.Format("SELECT Estado FROM tbl_Usuario WHERE Cedula = {0}", txt_Usuario.Text);
                        object result = cmd_sqlite.ExecuteScalar();
                        int estado = Convert.ToInt32(result);

                        if(estado == 0)
                        {
                                MessageBox.Show("Su cuenta se encuentra desactivada, comuníquese con el administrador");
                        }
                        else 
                        {
                            //En caso de estar activa, (Estado ==1), inicia sesión correctamente.

                           //MessageBox.Show("El estado es: " + estado);
                            MessageBox.Show("Bienvenido " + txt_Usuario.Text + ".");
                            Global.UsuarioGlobal = txt_Usuario.Text;
                            frm_Principal Principal = new frm_Principal();
                            Principal.Show();
                            Hide();
                        }  
                    }
                    else
                    {
                        //En caso de no, se inicia el contador de intentos posibles.
                        intentos++;

                        if (intentos >= 3)
                        {
                            MessageBox.Show("Ha superado el límite de intentos.");
                            Application.Exit();
                        }

                        MessageBox.Show("El usuario o la contraseña estan incorrectas");
                    }

                    //Bien sea que iniciemos sesión o no, finalizamos cerrando la base de datos y limpiamos los campos de texto.
                    conexion_sqlite.Close();
                    txt_Usuario.Clear();
                    txt_Contraseña.Clear();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al registrar al usuario " + err);
                }
            }
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
