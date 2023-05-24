
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
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_Confirmar = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
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
            // btn_Atras
            // 
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Atras.Location = new System.Drawing.Point(285, 372);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(210, 21);
            this.btn_Atras.TabIndex = 51;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
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
            this.txt_Confirmar.Location = new System.Drawing.Point(285, 292);
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
            this.txt_Password.Location = new System.Drawing.Point(285, 253);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(210, 20);
            this.txt_Password.TabIndex = 46;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(285, 214);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(210, 20);
            this.txt_User.TabIndex = 45;
            // 
            // btn_Registro
            // 
            this.btn_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registro.Location = new System.Drawing.Point(285, 333);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(210, 21);
            this.btn_Registro.TabIndex = 44;
            this.btn_Registro.Text = "Registrarse";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
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
            this.txt_Nombre.Location = new System.Drawing.Point(285, 176);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(210, 20);
            this.txt_Nombre.TabIndex = 53;
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Registro);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_confirmar);
            this.Controls.Add(this.txt_Confirmar);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.btn_Registro);
            this.Name = "frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.TextBox txt_Confirmar;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Registro;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
    }
}