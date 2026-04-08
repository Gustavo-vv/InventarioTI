namespace InventarioTI.UI.UserControls
{
    partial class UcEquipamentos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpData = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbFuncionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemover = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEquipamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFiltrarUsuario = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestão de Equipamentos e Ativos";
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 5;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(25, 70);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "ID";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(80, 40);
            this.txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 5;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(120, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "Ex: Dell Latitude 5420";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(250, 40);
            this.txtNome.TabIndex = 2;
            // 
            // txtTipo
            // 
            this.txtTipo.BorderRadius = 5;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.DefaultText = "";
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipo.Location = new System.Drawing.Point(385, 70);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.PlaceholderText = "Ex: Notebook";
            this.txtTipo.SelectedText = "";
            this.txtTipo.Size = new System.Drawing.Size(150, 40);
            this.txtTipo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.BorderRadius = 5;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.DefaultText = "";
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMarca.Location = new System.Drawing.Point(550, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "Fabricante";
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(150, 40);
            this.txtMarca.TabIndex = 4;
            // 
            // dtpData
            // 
            this.dtpData.BorderRadius = 5;
            this.dtpData.Checked = true;
            this.dtpData.FillColor = System.Drawing.Color.White;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpData.Location = new System.Drawing.Point(25, 125);
            this.dtpData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(234, 40);
            this.dtpData.TabIndex = 5;
            this.dtpData.Value = new System.DateTime(2026, 4, 7, 20, 10, 18, 24);
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.cmbFuncionario.BorderRadius = 5;
            this.cmbFuncionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFuncionario.ItemHeight = 30;
            this.cmbFuncionario.Location = new System.Drawing.Point(333, 125);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(380, 36);
            this.cmbFuncionario.TabIndex = 7;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(265, 136);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 6;
            this.lblFuncionario.Text = "Atribuído a:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BorderRadius = 5;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAdicionar.Location = new System.Drawing.Point(25, 185);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 40);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Cadastrar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnAtualizar.Location = new System.Drawing.Point(155, 185);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 40);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BorderRadius = 5;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRemover.Location = new System.Drawing.Point(285, 185);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 40);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BorderRadius = 5;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FillColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(415, 185);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvEquipamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEquipamentos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipamentos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEquipamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEquipamentos.Location = new System.Drawing.Point(25, 245);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.ReadOnly = true;
            this.dgvEquipamentos.RowHeadersVisible = false;
            this.dgvEquipamentos.RowTemplate.Height = 35;
            this.dgvEquipamentos.Size = new System.Drawing.Size(890, 410);
            this.dgvEquipamentos.TabIndex = 13;
            this.dgvEquipamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvEquipamentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEquipamentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEquipamentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEquipamentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEquipamentos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquipamentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipamentos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvEquipamentos.ThemeStyle.ReadOnly = true;
            this.dgvEquipamentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquipamentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquipamentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvEquipamentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEquipamentos.ThemeStyle.RowsStyle.Height = 35;
            this.dgvEquipamentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvEquipamentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.dgvEquipamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellDoubleClick);
            // 
            // btnFiltrarUsuario
            // 
            this.btnFiltrarUsuario.BorderColor = System.Drawing.Color.LightGray;
            this.btnFiltrarUsuario.BorderRadius = 5;
            this.btnFiltrarUsuario.BorderThickness = 1;
            this.btnFiltrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarUsuario.FillColor = System.Drawing.Color.White;
            this.btnFiltrarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.btnFiltrarUsuario.Location = new System.Drawing.Point(728, 125);
            this.btnFiltrarUsuario.Name = "btnFiltrarUsuario";
            this.btnFiltrarUsuario.Size = new System.Drawing.Size(200, 40);
            this.btnFiltrarUsuario.TabIndex = 12;
            this.btnFiltrarUsuario.Text = "🔍 Filtrar Desse Func.";
            this.btnFiltrarUsuario.Click += new System.EventHandler(this.btnFiltrarUsuario_Click);
            // 
            // UcEquipamentos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFiltrarUsuario);
            this.Controls.Add(this.dgvEquipamentos);
            this.Name = "UcEquipamentos";
            this.Size = new System.Drawing.Size(950, 680);
            this.Load += new System.EventHandler(this.UcEquipamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtTipo;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpData;
        private System.Windows.Forms.Label lblFuncionario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnFiltrarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnRemover;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEquipamentos;
    }
}
