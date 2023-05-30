
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_SignIn
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
            this.lbl_IniciarSesion = new System.Windows.Forms.Label();
            this.lbl_SiContraseña = new System.Windows.Forms.Label();
            this.lbl_SiUsuario = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_IniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.btn_Atras = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_IniciarSesion
            // 
            this.lbl_IniciarSesion.AutoSize = true;
            this.lbl_IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IniciarSesion.Location = new System.Drawing.Point(200, 81);
            this.lbl_IniciarSesion.Name = "lbl_IniciarSesion";
            this.lbl_IniciarSesion.Size = new System.Drawing.Size(409, 73);
            this.lbl_IniciarSesion.TabIndex = 47;
            this.lbl_IniciarSesion.Text = "Inicia Sesión";
            // 
            // lbl_SiContraseña
            // 
            this.lbl_SiContraseña.AutoSize = true;
            this.lbl_SiContraseña.Location = new System.Drawing.Point(315, 245);
            this.lbl_SiContraseña.Name = "lbl_SiContraseña";
            this.lbl_SiContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_SiContraseña.TabIndex = 46;
            this.lbl_SiContraseña.Text = "Contraseña";
            // 
            // lbl_SiUsuario
            // 
            this.lbl_SiUsuario.AutoSize = true;
            this.lbl_SiUsuario.Location = new System.Drawing.Point(315, 206);
            this.lbl_SiUsuario.Name = "lbl_SiUsuario";
            this.lbl_SiUsuario.Size = new System.Drawing.Size(94, 13);
            this.lbl_SiUsuario.TabIndex = 45;
            this.lbl_SiUsuario.Text = "Cédula de Usuario";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(316, 261);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(165, 20);
            this.txt_Contraseña.TabIndex = 44;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(316, 222);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(165, 20);
            this.txt_Usuario.TabIndex = 43;
            this.txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Usuario_KeyPress);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_IniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_IniciarSesion.Depth = 0;
            this.btn_IniciarSesion.HighEmphasis = true;
            this.btn_IniciarSesion.Icon = null;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(334, 314);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_IniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_IniciarSesion.Size = new System.Drawing.Size(128, 36);
            this.btn_IniciarSesion.TabIndex = 48;
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_IniciarSesion.UseAccentColor = false;
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Atras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Atras.Depth = 0;
            this.btn_Atras.HighEmphasis = true;
            this.btn_Atras.Icon = null;
            this.btn_Atras.Location = new System.Drawing.Point(365, 362);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Atras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Atras.Size = new System.Drawing.Size(67, 36);
            this.btn_Atras.TabIndex = 49;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Atras.UseAccentColor = false;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // frm_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_IniciarSesion);
            this.Controls.Add(this.lbl_SiContraseña);
            this.Controls.Add(this.lbl_SiUsuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Name = "frm_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SignIn";
            this.Load += new System.EventHandler(this.frm_SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IniciarSesion;
        private System.Windows.Forms.Label lbl_SiContraseña;
        private System.Windows.Forms.Label lbl_SiUsuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private MaterialSkin.Controls.MaterialButton btn_IniciarSesion;
        private MaterialSkin.Controls.MaterialButton btn_Atras;
    }
}