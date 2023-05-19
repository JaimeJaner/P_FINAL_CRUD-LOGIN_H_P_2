
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ListaUsuarios = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Entregas = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ListaUsuarios
            // 
            this.btn_ListaUsuarios.Location = new System.Drawing.Point(288, 113);
            this.btn_ListaUsuarios.Name = "btn_ListaUsuarios";
            this.btn_ListaUsuarios.Size = new System.Drawing.Size(184, 71);
            this.btn_ListaUsuarios.TabIndex = 0;
            this.btn_ListaUsuarios.Text = "LISTA DE USUARIOS";
            this.btn_ListaUsuarios.UseVisualStyleBackColor = true;
            this.btn_ListaUsuarios.Click += new System.EventHandler(this.btn_ListaUsuarios_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Location = new System.Drawing.Point(288, 190);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(184, 71);
            this.btn_Inventario.TabIndex = 1;
            this.btn_Inventario.Text = "INVENTARIO";
            this.btn_Inventario.UseVisualStyleBackColor = true;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btn_Entregas
            // 
            this.btn_Entregas.Location = new System.Drawing.Point(288, 267);
            this.btn_Entregas.Name = "btn_Entregas";
            this.btn_Entregas.Size = new System.Drawing.Size(184, 71);
            this.btn_Entregas.TabIndex = 2;
            this.btn_Entregas.Text = "ENTREGAS";
            this.btn_Entregas.UseVisualStyleBackColor = true;
            this.btn_Entregas.Click += new System.EventHandler(this.btn_Entregas_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(334, 385);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(91, 37);
            this.btn_CerrarSesion.TabIndex = 3;
            this.btn_CerrarSesion.Text = "CERRAR SESION";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Entregas);
            this.Controls.Add(this.btn_Inventario);
            this.Controls.Add(this.btn_ListaUsuarios);
            this.Name = "frm_Principal";
            this.Text = "frm_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListaUsuarios;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Entregas;
        private System.Windows.Forms.Button btn_CerrarSesion;
    }
}