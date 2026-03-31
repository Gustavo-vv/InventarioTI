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

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Text = "Gestão de Equipamentos Ativos";

            this.txtId.Location = new System.Drawing.Point(25, 70);
            this.txtId.Size = new System.Drawing.Size(80, 40);
            this.txtId.Enabled = false;
            this.txtId.PlaceholderText = "ID";
            this.txtId.BorderRadius = 5;

            this.txtNome.Location = new System.Drawing.Point(120, 70);
            this.txtNome.Size = new System.Drawing.Size(250, 40);
            this.txtNome.PlaceholderText = "Ex: Dell Latitude 5420";
            this.txtNome.BorderRadius = 5;

            this.txtTipo.Location = new System.Drawing.Point(385, 70);
            this.txtTipo.Size = new System.Drawing.Size(150, 40);
            this.txtTipo.PlaceholderText = "Ex: Notebook";
            this.txtTipo.BorderRadius = 5;

            this.txtMarca.Location = new System.Drawing.Point(550, 70);
            this.txtMarca.Size = new System.Drawing.Size(150, 40);
            this.txtMarca.PlaceholderText = "Fabricante";
            this.txtMarca.BorderRadius = 5;

            this.dtpData.Location = new System.Drawing.Point(25, 125);
            this.dtpData.Size = new System.Drawing.Size(200, 40);
            this.dtpData.FillColor = System.Drawing.Color.White;
            this.dtpData.BorderRadius = 5;

            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(240, 137);
            this.lblFuncionario.Text = "Atribuído a:";
            
            this.cmbFuncionario.Location = new System.Drawing.Point(320, 125);
            this.cmbFuncionario.Size = new System.Drawing.Size(380, 40);
            this.cmbFuncionario.BorderRadius = 5;

            // -- BOTÕES --
            this.btnFiltrarUsuario.Location = new System.Drawing.Point(715, 125);
            this.btnFiltrarUsuario.Size = new System.Drawing.Size(200, 40);
            this.btnFiltrarUsuario.Text = "🔍 Filtrar Desse Func.";
            this.btnFiltrarUsuario.BorderRadius = 5;
            this.btnFiltrarUsuario.FillColor = System.Drawing.Color.White;
            this.btnFiltrarUsuario.ForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.btnFiltrarUsuario.BorderColor = System.Drawing.Color.LightGray;
            this.btnFiltrarUsuario.BorderThickness = 1;
            this.btnFiltrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarUsuario.Click += new System.EventHandler(this.btnFiltrarUsuario_Click);

            this.btnAdicionar.Location = new System.Drawing.Point(25, 185);
            this.btnAdicionar.Size = new System.Drawing.Size(120, 40);
            this.btnAdicionar.Text = "Cadastrar";
            this.btnAdicionar.BorderRadius = 5;
            this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdicionar.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.btnAtualizar.Location = new System.Drawing.Point(155, 185);
            this.btnAtualizar.Size = new System.Drawing.Size(120, 40);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.FillColor = System.Drawing.Color.FromArgb(217, 119, 6); // Yellow/Orange
            this.btnAtualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(180, 83, 9);
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            this.btnRemover.Location = new System.Drawing.Point(285, 185);
            this.btnRemover.Size = new System.Drawing.Size(120, 40);
            this.btnRemover.Text = "Remover";
            this.btnRemover.BorderRadius = 5;
            this.btnRemover.FillColor = System.Drawing.Color.FromArgb(220, 38, 38); // Red
            this.btnRemover.HoverState.FillColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.btnLimpar.Location = new System.Drawing.Point(415, 185);
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.BorderRadius = 5;
            this.btnLimpar.FillColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // -- DATAGRIDVIEW ZEBRADO GUNA2 --
            this.dgvEquipamentos.Location = new System.Drawing.Point(25, 245);
            this.dgvEquipamentos.Size = new System.Drawing.Size(890, 410);
            this.dgvEquipamentos.ReadOnly = true;
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToResizeRows = false;
            this.dgvEquipamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquipamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipamentos.ColumnHeadersHeight = 40;
            this.dgvEquipamentos.EnableHeadersVisualStyles = false;
            this.dgvEquipamentos.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvEquipamentos.RowHeadersVisible = false;
            this.dgvEquipamentos.RowTemplate.Height = 35;
            this.dgvEquipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            
            // Estilos DataGridView
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvEquipamentos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquipamentos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvEquipamentos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvEquipamentos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvEquipamentos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvEquipamentos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            this.dgvEquipamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellDoubleClick);

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

            this.Size = new System.Drawing.Size(950, 680);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Load += new System.EventHandler(this.UcEquipamentos_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
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
