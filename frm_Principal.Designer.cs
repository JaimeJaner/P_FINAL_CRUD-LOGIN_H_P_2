
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.btn_ListaUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.btn_Inventario = new MaterialSkin.Controls.MaterialButton();
            this.btn_Entregas = new MaterialSkin.Controls.MaterialButton();
            this.btn_CerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(597, 89);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(49, 13);
            this.lbl_Usuario.TabIndex = 4;
            this.lbl_Usuario.Text = "Usuario: ";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(652, 89);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreUsuario.TabIndex = 5;
            this.lbl_NombreUsuario.Text = "label1";
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(652, 113);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_TipoUsuario.TabIndex = 6;
            this.lbl_TipoUsuario.Text = "label1";
            // 
            // btn_ListaUsuarios
            // 
            this.btn_ListaUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ListaUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ListaUsuarios.Depth = 0;
            this.btn_ListaUsuarios.HighEmphasis = true;
            this.btn_ListaUsuarios.Icon = null;
            this.btn_ListaUsuarios.Location = new System.Drawing.Point(280, 161);
            this.btn_ListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ListaUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ListaUsuarios.Name = "btn_ListaUsuarios";
            this.btn_ListaUsuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ListaUsuarios.Size = new System.Drawing.Size(156, 36);
            this.btn_ListaUsuarios.TabIndex = 7;
            this.btn_ListaUsuarios.Text = "LISTA DE USUARIOS";
            this.btn_ListaUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ListaUsuarios.UseAccentColor = false;
            this.btn_ListaUsuarios.UseVisualStyleBackColor = true;
            this.btn_ListaUsuarios.Click += new System.EventHandler(this.btn_ListaUsuarios_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Inventario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Inventario.Depth = 0;
            this.btn_Inventario.HighEmphasis = true;
            this.btn_Inventario.Icon = null;
            this.btn_Inventario.Location = new System.Drawing.Point(305, 220);
            this.btn_Inventario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Inventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Inventario.Size = new System.Drawing.Size(107, 36);
            this.btn_Inventario.TabIndex = 8;
            this.btn_Inventario.Text = "INVENTARIO";
            this.btn_Inventario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Inventario.UseAccentColor = false;
            this.btn_Inventario.UseVisualStyleBackColor = true;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btn_Entregas
            // 
            this.btn_Entregas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Entregas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Entregas.Depth = 0;
            this.btn_Entregas.HighEmphasis = true;
            this.btn_Entregas.Icon = null;
            this.btn_Entregas.Location = new System.Drawing.Point(311, 279);
            this.btn_Entregas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Entregas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Entregas.Name = "btn_Entregas";
            this.btn_Entregas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Entregas.Size = new System.Drawing.Size(95, 36);
            this.btn_Entregas.TabIndex = 9;
            this.btn_Entregas.Text = "ENTREGAS";
            this.btn_Entregas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Entregas.UseAccentColor = false;
            this.btn_Entregas.UseVisualStyleBackColor = true;
            this.btn_Entregas.Click += new System.EventHandler(this.btn_Entregas_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_CerrarSesion.Depth = 0;
            this.btn_CerrarSesion.HighEmphasis = true;
            this.btn_CerrarSesion.Icon = null;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(293, 388);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_CerrarSesion.Size = new System.Drawing.Size(131, 36);
            this.btn_CerrarSesion.TabIndex = 10;
            this.btn_CerrarSesion.Text = "CERRAR SESION";
            this.btn_CerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_CerrarSesion.UseAccentColor = false;
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
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones SA";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private MaterialSkin.Controls.MaterialButton btn_ListaUsuarios;
        private MaterialSkin.Controls.MaterialButton btn_Inventario;
        private MaterialSkin.Controls.MaterialButton btn_Entregas;
        private MaterialSkin.Controls.MaterialButton btn_CerrarSesion;
    }
}