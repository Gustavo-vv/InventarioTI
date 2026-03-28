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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestão de Equipamentos";

            this.txtId.Location = new System.Drawing.Point(25, 70);
            this.txtId.Size = new System.Drawing.Size(80, 36);
            this.txtId.Enabled = false;
            this.txtId.PlaceholderText = "ID";

            this.txtNome.Location = new System.Drawing.Point(120, 70);
            this.txtNome.Size = new System.Drawing.Size(250, 36);
            this.txtNome.PlaceholderText = "Nome do Equipamento";

            this.txtTipo.Location = new System.Drawing.Point(385, 70);
            this.txtTipo.Size = new System.Drawing.Size(150, 36);
            this.txtTipo.PlaceholderText = "Tipo/Categoria";

            this.txtMarca.Location = new System.Drawing.Point(550, 70);
            this.txtMarca.Size = new System.Drawing.Size(150, 36);
            this.txtMarca.PlaceholderText = "Marca";

            this.dtpData.Location = new System.Drawing.Point(25, 120);
            this.dtpData.Size = new System.Drawing.Size(200, 36);
            this.dtpData.FillColor = System.Drawing.Color.White;

            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(240, 130);
            this.lblFuncionario.Text = "Atribuído a:";
            
            this.cmbFuncionario.Location = new System.Drawing.Point(320, 120);
            this.cmbFuncionario.Size = new System.Drawing.Size(380, 36);

            this.btnFiltrarUsuario = new Guna.UI2.WinForms.Guna2Button();

            this.btnFiltrarUsuario.Location = new System.Drawing.Point(710, 120);
            this.btnFiltrarUsuario.Size = new System.Drawing.Size(200, 36);
            this.btnFiltrarUsuario.Text = "🔍 Ver Bens deste Funcionário";
            this.btnFiltrarUsuario.Click += new System.EventHandler(this.btnFiltrarUsuario_Click);

            this.btnAdicionar.Location = new System.Drawing.Point(25, 180);
            this.btnAdicionar.Size = new System.Drawing.Size(120, 40);
            this.btnAdicionar.Text = "Cadastrar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.btnAtualizar.Location = new System.Drawing.Point(160, 180);
            this.btnAtualizar.Size = new System.Drawing.Size(120, 40);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            this.btnRemover.Location = new System.Drawing.Point(295, 180);
            this.btnRemover.Size = new System.Drawing.Size(120, 40);
            this.btnRemover.FillColor = System.Drawing.Color.IndianRed;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.btnLimpar.Location = new System.Drawing.Point(430, 180);
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.FillColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            this.dgvEquipamentos.Location = new System.Drawing.Point(25, 240);
            this.dgvEquipamentos.Size = new System.Drawing.Size(850, 380);
            this.dgvEquipamentos.ReadOnly = true;
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
