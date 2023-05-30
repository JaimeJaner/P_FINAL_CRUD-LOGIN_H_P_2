
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_Entrega
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
            this.btn_Atras = new System.Windows.Forms.Button();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.dgvEntregados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btnActualizarEntrega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(12, 12);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(54, 49);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(12, 71);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.Size = new System.Drawing.Size(285, 273);
            this.dgvDisponibles.TabIndex = 2;
            // 
            // dgvEntregados
            // 
            this.dgvEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregados.Location = new System.Drawing.Point(445, 77);
            this.dgvEntregados.Name = "dgvEntregados";
            this.dgvEntregados.Size = new System.Drawing.Size(343, 267);
            this.dgvEntregados.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "ATRÁS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(3, 350);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(63, 31);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(303, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(123, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Nombre del producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(363, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 31);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(303, 189);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(123, 20);
            this.txtDoc.TabIndex = 8;
            this.txtDoc.Text = "Cedula beneficiario";
            // 
            // btnEntregar
            // 
            this.btnEntregar.Location = new System.Drawing.Point(332, 215);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(63, 31);
            this.btnEntregar.TabIndex = 9;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(303, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(54, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Text = "Cantidad";
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(76, 29);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(28, 13);
            this.lbl_TipoUsuario.TabIndex = 36;
            this.lbl_TipoUsuario.Text = "Tipo";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(126, 12);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreUsuario.TabIndex = 35;
            this.lbl_NombreUsuario.Text = "label2";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(74, 12);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 34;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // btnActualizarEntrega
            // 
            this.btnActualizarEntrega.Location = new System.Drawing.Point(445, 350);
            this.btnActualizarEntrega.Name = "btnActualizarEntrega";
            this.btnActualizarEntrega.Size = new System.Drawing.Size(63, 31);
            this.btnActualizarEntrega.TabIndex = 37;
            this.btnActualizarEntrega.Text = "Actualizar";
            this.btnActualizarEntrega.UseVisualStyleBackColor = true;
            this.btnActualizarEntrega.Click += new System.EventHandler(this.btnActualizarEntrega_Click);
            // 
            // frm_Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarEntrega);
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEntregados);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.btn_Atras);
            this.Name = "frm_Entrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Entrega";
            this.Load += new System.EventHandler(this.frm_Entrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.DataGridView dgvEntregados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Button btnActualizarEntrega;
    }
}