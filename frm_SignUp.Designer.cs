﻿
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_SignUp
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
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_Confirmar = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Registro = new MaterialSkin.Controls.MaterialButton();
            this.btn_Atras = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registro.Location = new System.Drawing.Point(255, 67);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(279, 73);
            this.lbl_Registro.TabIndex = 52;
            this.lbl_Registro.Text = "Registro";
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Location = new System.Drawing.Point(282, 276);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(108, 13);
            this.lbl_confirmar.TabIndex = 50;
            this.lbl_confirmar.Text = "Confirmar Contraseña";
            // 
            // txt_Confirmar
            // 
            this.txt_Confirmar.Location = new System.Drawing.Point(284, 292);
            this.txt_Confirmar.Name = "txt_Confirmar";
            this.txt_Confirmar.PasswordChar = '*';
            this.txt_Confirmar.Size = new System.Drawing.Size(210, 20);
            this.txt_Confirmar.TabIndex = 49;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(282, 237);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(61, 13);
            this.lbl_Password.TabIndex = 48;
            this.lbl_Password.Text = "Contraseña";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(282, 198);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(79, 13);
            this.lbl_User.TabIndex = 47;
            this.lbl_User.Text = "Cedula Usuario";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(284, 253);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(210, 20);
            this.txt_Password.TabIndex = 46;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(284, 214);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(210, 20);
            this.txt_User.TabIndex = 45;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(282, 160);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 55;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(284, 176);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(210, 20);
            this.txt_Nombre.TabIndex = 53;
            // 
            // btn_Registro
            // 
            this.btn_Registro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Registro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Registro.Depth = 0;
            this.btn_Registro.HighEmphasis = true;
            this.btn_Registro.Icon = null;
            this.btn_Registro.Location = new System.Drawing.Point(331, 332);
            this.btn_Registro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Registro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Registro.Size = new System.Drawing.Size(116, 36);
            this.btn_Registro.TabIndex = 56;
            this.btn_Registro.Text = "REGISTRARSE";
            this.btn_Registro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Registro.UseAccentColor = false;
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click_1);
            // 
            // btn_Atras
            // 
            this.btn_Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Atras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Atras.Depth = 0;
            this.btn_Atras.HighEmphasis = true;
            this.btn_Atras.Icon = null;
            this.btn_Atras.Location = new System.Drawing.Point(356, 398);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Atras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Atras.Size = new System.Drawing.Size(67, 36);
            this.btn_Atras.TabIndex = 57;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Atras.UseAccentColor = false;
            this.btn_Atras.UseVisualStyleBackColor = true;
<<<<<<< HEAD
          
=======
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click_1);
>>>>>>> 76e2c1ef94be452893ab7c500c1c520bd4e84901
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_Registro);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Registro);
            this.Controls.Add(this.lbl_confirmar);
            this.Controls.Add(this.txt_Confirmar);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Name = "frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones SA";
            this.Load += new System.EventHandler(this.frm_SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.TextBox txt_Confirmar;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private MaterialSkin.Controls.MaterialButton btn_Registro;
        private MaterialSkin.Controls.MaterialButton btn_Atras;
    }
}