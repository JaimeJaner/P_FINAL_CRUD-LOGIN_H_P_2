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
    public partial class frm_InicioApp : Form
    {

        /// <summary>
        /// Proyecto final herramientas de programacion 2
        /// 2023
        /// Juan Pablo Roldan
        /// Jaime Janer
        /// Alejandro Rodriguez 
        /// Emmanuel Baena
        /// </summary>

        public frm_InicioApp()
        {
            InitializeComponent();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            frm_SignUp SU = new frm_SignUp();
            SU.Show();
            Hide();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            frm_SignIn SI = new frm_SignIn();
            SI.Show();
            Hide();
        }
    }
}
