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

        }
    } 
