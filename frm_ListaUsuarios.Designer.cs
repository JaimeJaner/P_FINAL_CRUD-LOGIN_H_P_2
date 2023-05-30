
namespace P_FINAL_CRUD_LOGIN_H_P_2
{
    partial class frm_ListaUsuarios
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
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.lblBucarUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Atras = new MaterialSkin.Controls.MaterialButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnImportar = new MaterialSkin.Controls.MaterialButton();
            this.btnExportar = new MaterialSkin.Controls.MaterialButton();
            this.btnVerTodo = new MaterialSkin.Controls.MaterialButton();
            this.BtnAtras = new MaterialSkin.Controls.MaterialButton();
            this.BtnPrincipio = new MaterialSkin.Controls.MaterialButton();
            this.BtnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.BtnFinal = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarUsuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(258, 70);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(296, 39);
            this.lblListaUsuarios.TabIndex = 1;
            this.lblListaUsuarios.Text = "Lista de usuarios";
            // 
            // lblBucarUsuario
            // 
            this.lblBucarUsuario.AutoSize = true;
            this.lblBucarUsuario.Location = new System.Drawing.Point(17, 184);
            this.lblBucarUsuario.Name = "lblBucarUsuario";
            this.lblBucarUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblBucarUsuario.TabIndex = 5;
            this.lblBucarUsuario.Text = "Buscar cedula";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 248);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(17, 309);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(65, 13);
            this.lblTipoUsuario.TabIndex = 7;
            this.lblTipoUsuario.Text = "Tipo usuario";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(231, 169);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(570, 288);
            this.dgvUsuarios.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(258, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 39);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de usuarios";
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(107, 87);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(28, 13);
            this.lbl_TipoUsuario.TabIndex = 36;
            this.lbl_TipoUsuario.Text = "Tipo";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(157, 70);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreUsuario.TabIndex = 35;
            this.lbl_NombreUsuario.Text = "label2";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(105, 70);
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
            this.btn_Atras.Location = new System.Drawing.Point(15, 73);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Atras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Atras.Size = new System.Drawing.Size(67, 36);
            this.btn_Atras.TabIndex = 37;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Atras.UseAccentColor = false;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(147, 200);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.ClientSizeChanged += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(26, 388);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImportar.Depth = 0;
            this.btnImportar.HighEmphasis = true;
            this.btnImportar.Icon = null;
            this.btnImportar.Location = new System.Drawing.Point(597, 79);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImportar.Size = new System.Drawing.Size(95, 36);
            this.btnImportar.TabIndex = 40;
            this.btnImportar.Text = "IMPORTAR";
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
            this.btnExportar.Location = new System.Drawing.Point(700, 79);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportar.Size = new System.Drawing.Size(95, 36);
            this.btnExportar.TabIndex = 41;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportar.UseAccentColor = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerTodo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerTodo.Depth = 0;
            this.btnVerTodo.HighEmphasis = true;
            this.btnVerTodo.Icon = null;
            this.btnVerTodo.Location = new System.Drawing.Point(470, 462);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerTodo.Size = new System.Drawing.Size(91, 36);
            this.btnVerTodo.TabIndex = 42;
            this.btnVerTodo.Text = "VER TODO";
            this.btnVerTodo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerTodo.UseAccentColor = false;
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAtras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAtras.Depth = 0;
            this.BtnAtras.HighEmphasis = true;
            this.BtnAtras.Icon = null;
            this.BtnAtras.Location = new System.Drawing.Point(398, 462);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAtras.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAtras.Size = new System.Drawing.Size(64, 36);
            this.BtnAtras.TabIndex = 43;
            this.BtnAtras.Text = "<";
            this.BtnAtras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAtras.UseAccentColor = false;
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnPrincipio
            // 
            this.BtnPrincipio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrincipio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnPrincipio.Depth = 0;
            this.BtnPrincipio.HighEmphasis = true;
            this.BtnPrincipio.Icon = null;
            this.BtnPrincipio.Location = new System.Drawing.Point(326, 462);
            this.BtnPrincipio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnPrincipio.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPrincipio.Name = "BtnPrincipio";
            this.BtnPrincipio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnPrincipio.Size = new System.Drawing.Size(64, 36);
            this.BtnPrincipio.TabIndex = 44;
            this.BtnPrincipio.Text = "<<";
            this.BtnPrincipio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnPrincipio.UseAccentColor = false;
            this.BtnPrincipio.UseVisualStyleBackColor = true;
            this.BtnPrincipio.Click += new System.EventHandler(this.BtnPrincipio_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSiguiente.Depth = 0;
            this.BtnSiguiente.HighEmphasis = true;
            this.BtnSiguiente.Icon = null;
            this.BtnSiguiente.Location = new System.Drawing.Point(569, 462);
            this.BtnSiguiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSiguiente.Size = new System.Drawing.Size(64, 36);
            this.BtnSiguiente.TabIndex = 45;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSiguiente.UseAccentColor = false;
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnFinal
            // 
            this.BtnFinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFinal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnFinal.Depth = 0;
            this.BtnFinal.HighEmphasis = true;
            this.BtnFinal.Icon = null;
            this.BtnFinal.Location = new System.Drawing.Point(641, 462);
            this.BtnFinal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFinal.Name = "BtnFinal";
            this.BtnFinal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnFinal.Size = new System.Drawing.Size(64, 36);
            this.BtnFinal.TabIndex = 46;
            this.BtnFinal.Text = ">>";
            this.BtnFinal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnFinal.UseAccentColor = false;
            this.BtnFinal.UseVisualStyleBackColor = true;
            this.BtnFinal.Click += new System.EventHandler(this.BtnFinal_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.AllowPromptAsInput = true;
            this.txtBuscarUsuario.AnimateReadOnly = false;
            this.txtBuscarUsuario.AsciiOnly = false;
            this.txtBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscarUsuario.BeepOnError = false;
            this.txtBuscarUsuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscarUsuario.Depth = 0;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarUsuario.HidePromptOnLeave = false;
            this.txtBuscarUsuario.HideSelection = true;
            this.txtBuscarUsuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBuscarUsuario.LeadingIcon = null;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(20, 200);
            this.txtBuscarUsuario.Mask = "";
            this.txtBuscarUsuario.MaxLength = 32767;
            this.txtBuscarUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.PasswordChar = '\0';
            this.txtBuscarUsuario.PrefixSuffixText = null;
            this.txtBuscarUsuario.PromptChar = '_';
            this.txtBuscarUsuario.ReadOnly = false;
            this.txtBuscarUsuario.RejectInputOnFirstFailure = false;
            this.txtBuscarUsuario.ResetOnPrompt = true;
            this.txtBuscarUsuario.ResetOnSpace = true;
            this.txtBuscarUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscarUsuario.SelectedText = "";
            this.txtBuscarUsuario.SelectionLength = 0;
            this.txtBuscarUsuario.SelectionStart = 0;
            this.txtBuscarUsuario.ShortcutsEnabled = true;
            this.txtBuscarUsuario.Size = new System.Drawing.Size(121, 36);
            this.txtBuscarUsuario.SkipLiterals = true;
            this.txtBuscarUsuario.TabIndex = 47;
            this.txtBuscarUsuario.TabStop = false;
            this.txtBuscarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscarUsuario.TrailingIcon = null;
            this.txtBuscarUsuario.UseSystemPasswordChar = false;
            this.txtBuscarUsuario.UseTallSize = false;
            this.txtBuscarUsuario.ValidatingType = null;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoResize = false;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado.Depth = 0;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado.DropDownHeight = 118;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.DropDownWidth = 121;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.ItemHeight = 29;
            this.cbEstado.Location = new System.Drawing.Point(20, 264);
            this.cbEstado.MaxDropDownItems = 4;
            this.cbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 35);
            this.cbEstado.StartIndex = 0;
            this.cbEstado.TabIndex = 48;
            this.cbEstado.UseTallSize = false;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.AutoResize = false;
            this.cbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoUsuario.Depth = 0;
            this.cbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoUsuario.DropDownHeight = 118;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.DropDownWidth = 121;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.IntegralHeight = false;
            this.cbTipoUsuario.ItemHeight = 29;
            this.cbTipoUsuario.Location = new System.Drawing.Point(20, 325);
            this.cbTipoUsuario.MaxDropDownItems = 4;
            this.cbTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(121, 35);
            this.cbTipoUsuario.StartIndex = 0;
            this.cbTipoUsuario.TabIndex = 49;
            this.cbTipoUsuario.UseTallSize = false;
            // 
            // frm_ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 513);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.BtnFinal);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.BtnPrincipio);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblBucarUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblListaUsuarios);
            this.Name = "frm_ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONACIONES SA";
            this.Load += new System.EventHandler(this.frm_ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Label lblBucarUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private MaterialSkin.Controls.MaterialButton btn_Atras;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnImportar;
        private MaterialSkin.Controls.MaterialButton btnExportar;
        private MaterialSkin.Controls.MaterialButton btnVerTodo;
        private MaterialSkin.Controls.MaterialButton BtnAtras;
        private MaterialSkin.Controls.MaterialButton BtnPrincipio;
        private MaterialSkin.Controls.MaterialButton BtnSiguiente;
        private MaterialSkin.Controls.MaterialButton BtnFinal;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbEstado;
        private MaterialSkin.Controls.MaterialComboBox cbTipoUsuario;
    }
}