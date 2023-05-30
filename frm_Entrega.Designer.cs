
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
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.dgvEntregados = new System.Windows.Forms.DataGridView();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Atras = new MaterialSkin.Controls.MaterialButton();
            this.btnCargar = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtDoc = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnEntregar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(18, 139);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.Size = new System.Drawing.Size(285, 273);
            this.dgvDisponibles.TabIndex = 2;
            // 
            // dgvEntregados
            // 
            this.dgvEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregados.Location = new System.Drawing.Point(451, 145);
            this.dgvEntregados.Name = "dgvEntregados";
            this.dgvEntregados.Size = new System.Drawing.Size(343, 267);
            this.dgvEntregados.TabIndex = 3;
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(82, 97);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(28, 13);
            this.lbl_TipoUsuario.TabIndex = 36;
            this.lbl_TipoUsuario.Text = "Tipo";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(132, 80);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreUsuario.TabIndex = 35;
            this.lbl_NombreUsuario.Text = "label2";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(80, 80);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 34;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // btn_Atras
            // 
            this.btn_Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Atras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Atras.Depth = 0;
            this.btn_Atras.HighEmphasis = true;
            this.btn_Atras.Icon = null;
            this.btn_Atras.Location = new System.Drawing.Point(11, 80);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Atras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Atras.Size = new System.Drawing.Size(64, 36);
            this.btn_Atras.TabIndex = 38;
            this.btn_Atras.Text = "←";
            this.btn_Atras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Atras.UseAccentColor = false;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargar.Depth = 0;
            this.btnCargar.HighEmphasis = true;
            this.btnCargar.Icon = null;
            this.btnCargar.Location = new System.Drawing.Point(18, 421);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargar.Size = new System.Drawing.Size(79, 36);
            this.btnCargar.TabIndex = 39;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargar.UseAccentColor = false;
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AllowPromptAsInput = true;
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.AsciiOnly = false;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscar.BeepOnError = false;
            this.txtBuscar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HidePromptOnLeave = false;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(309, 129);
            this.txtBuscar.Mask = "";
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PrefixSuffixText = null;
            this.txtBuscar.PromptChar = '_';
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.RejectInputOnFirstFailure = false;
            this.txtBuscar.ResetOnPrompt = true;
            this.txtBuscar.ResetOnSpace = true;
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(123, 36);
            this.txtBuscar.SkipLiterals = true;
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.Text = "Nombre del producto";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.UseTallSize = false;
            this.txtBuscar.ValidatingType = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AllowPromptAsInput = true;
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.AsciiOnly = false;
            this.txtCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCantidad.BeepOnError = false;
            this.txtCantidad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.HidePromptOnLeave = false;
            this.txtCantidad.HideSelection = true;
            this.txtCantidad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(309, 171);
            this.txtCantidad.Mask = "";
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PrefixSuffixText = null;
            this.txtCantidad.PromptChar = '_';
            this.txtCantidad.ReadOnly = false;
            this.txtCantidad.RejectInputOnFirstFailure = false;
            this.txtCantidad.ResetOnPrompt = true;
            this.txtCantidad.ResetOnSpace = true;
            this.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(54, 36);
            this.txtCantidad.SkipLiterals = true;
            this.txtCantidad.TabIndex = 41;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCantidad.TrailingIcon = null;
            this.txtCantidad.UseSystemPasswordChar = false;
            this.txtCantidad.UseTallSize = false;
            this.txtCantidad.ValidatingType = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(368, 174);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.AllowPromptAsInput = true;
            this.txtDoc.AnimateReadOnly = false;
            this.txtDoc.AsciiOnly = false;
            this.txtDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDoc.BeepOnError = false;
            this.txtDoc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDoc.Depth = 0;
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDoc.HidePromptOnLeave = false;
            this.txtDoc.HideSelection = true;
            this.txtDoc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDoc.LeadingIcon = null;
            this.txtDoc.Location = new System.Drawing.Point(309, 241);
            this.txtDoc.Mask = "";
            this.txtDoc.MaxLength = 32767;
            this.txtDoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.PasswordChar = '\0';
            this.txtDoc.PrefixSuffixText = null;
            this.txtDoc.PromptChar = '_';
            this.txtDoc.ReadOnly = false;
            this.txtDoc.RejectInputOnFirstFailure = false;
            this.txtDoc.ResetOnPrompt = true;
            this.txtDoc.ResetOnSpace = true;
            this.txtDoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDoc.SelectedText = "";
            this.txtDoc.SelectionLength = 0;
            this.txtDoc.SelectionStart = 0;
            this.txtDoc.ShortcutsEnabled = true;
            this.txtDoc.Size = new System.Drawing.Size(123, 36);
            this.txtDoc.SkipLiterals = true;
            this.txtDoc.TabIndex = 43;
            this.txtDoc.TabStop = false;
            this.txtDoc.Text = "Documento ";
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDoc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDoc.TrailingIcon = null;
            this.txtDoc.UseSystemPasswordChar = false;
            this.txtDoc.UseTallSize = false;
            this.txtDoc.ValidatingType = null;
            // 
            // btnEntregar
            // 
            this.btnEntregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntregar.Depth = 0;
            this.btnEntregar.HighEmphasis = true;
            this.btnEntregar.Icon = null;
            this.btnEntregar.Location = new System.Drawing.Point(328, 296);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntregar.Size = new System.Drawing.Size(96, 36);
            this.btnEntregar.TabIndex = 44;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntregar.UseAccentColor = false;
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(451, 421);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(109, 36);
            this.materialButton1.TabIndex = 45;
            this.materialButton1.Text = "Actualizar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.btnActualizarEntrega_Click);
            // 
            // frm_Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.dgvEntregados);
            this.Controls.Add(this.dgvDisponibles);
            this.Name = "frm_Entrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.frm_Entrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.DataGridView dgvEntregados;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private MaterialSkin.Controls.MaterialButton btn_Atras;
        private MaterialSkin.Controls.MaterialButton btnCargar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDoc;
        private MaterialSkin.Controls.MaterialButton btnEntregar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}