
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_Inventario
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.btn_Atras = new MaterialSkin.Controls.MaterialButton();
            this.btnImportar = new MaterialSkin.Controls.MaterialButton();
            this.btnExportar = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtCant = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(94, 321);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 253);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.Location = new System.Drawing.Point(178, 147);
            this.lblProName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(150, 18);
            this.lblProName.TabIndex = 26;
            this.lblProName.Text = "Nombre del Producto";
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(387, 177);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(384, 311);
            this.dgvInventario.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(338, 77);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 26);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Inventario";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(189, 254);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 18);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "ID";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(8, 135);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 31;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(60, 135);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreUsuario.TabIndex = 32;
            this.lbl_NombreUsuario.Text = "label2";
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(10, 152);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(28, 13);
            this.lbl_TipoUsuario.TabIndex = 33;
            this.lbl_TipoUsuario.Text = "Tipo";
            // 
            // btn_Atras
            // 
            this.btn_Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Atras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Atras.Depth = 0;
            this.btn_Atras.HighEmphasis = true;
            this.btn_Atras.Icon = null;
            this.btn_Atras.Location = new System.Drawing.Point(7, 75);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Atras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Atras.Size = new System.Drawing.Size(64, 36);
            this.btn_Atras.TabIndex = 39;
            this.btn_Atras.Text = "←";
            this.btn_Atras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Atras.UseAccentColor = false;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImportar.Depth = 0;
            this.btnImportar.HighEmphasis = true;
            this.btnImportar.Icon = null;
            this.btnImportar.Location = new System.Drawing.Point(573, 129);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImportar.Size = new System.Drawing.Size(95, 36);
            this.btnImportar.TabIndex = 40;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportar.UseAccentColor = false;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportar.Depth = 0;
            this.btnExportar.HighEmphasis = true;
            this.btnExportar.Icon = null;
            this.btnExportar.Location = new System.Drawing.Point(676, 129);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportar.Size = new System.Drawing.Size(95, 36);
            this.btnExportar.TabIndex = 41;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportar.UseAccentColor = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
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
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HidePromptOnLeave = false;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(122, 189);
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
            this.txtBuscar.Size = new System.Drawing.Size(147, 36);
            this.txtBuscar.SkipLiterals = true;
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.UseTallSize = false;
            this.txtBuscar.ValidatingType = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(276, 189);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AllowPromptAsInput = true;
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.AsciiOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.BeepOnError = false;
            this.txtNombre.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HidePromptOnLeave = false;
            this.txtNombre.HideSelection = true;
            this.txtNombre.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(40, 274);
            this.txtNombre.Mask = "";
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.PromptChar = '_';
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RejectInputOnFirstFailure = false;
            this.txtNombre.ResetOnPrompt = true;
            this.txtNombre.ResetOnSpace = true;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(134, 36);
            this.txtNombre.SkipLiterals = true;
            this.txtNombre.TabIndex = 44;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.UseTallSize = false;
            this.txtNombre.ValidatingType = null;
            // 
            // txtId
            // 
            this.txtId.AllowPromptAsInput = true;
            this.txtId.AnimateReadOnly = false;
            this.txtId.AsciiOnly = false;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.BeepOnError = false;
            this.txtId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HidePromptOnLeave = false;
            this.txtId.HideSelection = true;
            this.txtId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(180, 275);
            this.txtId.Mask = "";
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.PromptChar = '_';
            this.txtId.ReadOnly = false;
            this.txtId.RejectInputOnFirstFailure = false;
            this.txtId.ResetOnPrompt = true;
            this.txtId.ResetOnSpace = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(36, 36);
            this.txtId.SkipLiterals = true;
            this.txtId.TabIndex = 45;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            this.txtId.UseTallSize = false;
            this.txtId.ValidatingType = null;
            // 
            // txtCant
            // 
            this.txtCant.AllowPromptAsInput = true;
            this.txtCant.AnimateReadOnly = false;
            this.txtCant.AsciiOnly = false;
            this.txtCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant.BeepOnError = false;
            this.txtCant.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCant.Depth = 0;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCant.HidePromptOnLeave = false;
            this.txtCant.HideSelection = true;
            this.txtCant.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCant.LeadingIcon = null;
            this.txtCant.Location = new System.Drawing.Point(63, 342);
            this.txtCant.Mask = "";
            this.txtCant.MaxLength = 32767;
            this.txtCant.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant.Name = "txtCant";
            this.txtCant.PasswordChar = '\0';
            this.txtCant.PrefixSuffixText = null;
            this.txtCant.PromptChar = '_';
            this.txtCant.ReadOnly = false;
            this.txtCant.RejectInputOnFirstFailure = false;
            this.txtCant.ResetOnPrompt = true;
            this.txtCant.ResetOnSpace = true;
            this.txtCant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCant.SelectedText = "";
            this.txtCant.SelectionLength = 0;
            this.txtCant.SelectionStart = 0;
            this.txtCant.ShortcutsEnabled = true;
            this.txtCant.Size = new System.Drawing.Size(134, 36);
            this.txtCant.SkipLiterals = true;
            this.txtCant.TabIndex = 46;
            this.txtCant.TabStop = false;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCant.TrailingIcon = null;
            this.txtCant.UseSystemPasswordChar = false;
            this.txtCant.UseTallSize = false;
            this.txtCant.ValidatingType = null;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(40, 435);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(136, 435);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(253, 435);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frm_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones SA";
            this.Load += new System.EventHandler(this.frm_Inventario_Load);
            this.Click += new System.EventHandler(this.btnEliminar_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private MaterialSkin.Controls.MaterialButton btn_Atras;
        private MaterialSkin.Controls.MaterialButton btnImportar;
        private MaterialSkin.Controls.MaterialButton btnExportar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNombre;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtId;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCant;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
    }
}