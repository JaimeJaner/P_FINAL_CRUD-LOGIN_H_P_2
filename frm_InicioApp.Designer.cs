
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_InicioApp
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
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.btn_IniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.btn_Registrarse = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenido.Location = new System.Drawing.Point(204, 93);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(361, 73);
            this.lbl_Bienvenido.TabIndex = 11;
            this.lbl_Bienvenido.Text = "Bienvenido";
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_IniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_IniciarSesion.Depth = 0;
            this.btn_IniciarSesion.HighEmphasis = true;
            this.btn_IniciarSesion.Icon = null;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(217, 243);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_IniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_IniciarSesion.Size = new System.Drawing.Size(141, 36);
            this.btn_IniciarSesion.TabIndex = 14;
            this.btn_IniciarSesion.Text = "Inicio de Sesión";
            this.btn_IniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_IniciarSesion.UseAccentColor = false;
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click_1);
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Registrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Registrarse.Depth = 0;
            this.btn_Registrarse.HighEmphasis = true;
            this.btn_Registrarse.Icon = null;
            this.btn_Registrarse.Location = new System.Drawing.Point(424, 243);
            this.btn_Registrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Registrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Registrarse.Size = new System.Drawing.Size(141, 36);
            this.btn_Registrarse.TabIndex = 15;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Registrarse.UseAccentColor = false;
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click_1);
            // 
            // frm_InicioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Name = "frm_InicioApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones SA";
            this.Load += new System.EventHandler(this.frm_InicioApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Bienvenido;
        private MaterialSkin.Controls.MaterialButton btn_IniciarSesion;
        private MaterialSkin.Controls.MaterialButton btn_Registrarse;
    }
}