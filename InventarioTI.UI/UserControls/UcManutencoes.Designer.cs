namespace InventarioTI.UI.UserControls
{
    partial class UcManutencoes
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
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbEquipamentos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTecnico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNovaDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNovaData = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvManutencoes = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Controle de Manutenção (OS)";

            this.txtPesquisa.Location = new System.Drawing.Point(490, 20);
            this.txtPesquisa.Size = new System.Drawing.Size(425, 40);
            this.txtPesquisa.PlaceholderText = "Pesquisar OS por Descrição, Técnico ou Máquina...";
            this.txtPesquisa.BorderRadius = 5;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            this.cmbEquipamentos.Location = new System.Drawing.Point(25, 75);
            this.cmbEquipamentos.Size = new System.Drawing.Size(250, 40);
            this.cmbEquipamentos.BorderRadius = 5;
            
            this.dtNovaData.Location = new System.Drawing.Point(290, 75);
            this.dtNovaData.Size = new System.Drawing.Size(200, 40);
            this.dtNovaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNovaData.BorderRadius = 5;
            this.dtNovaData.FillColor = System.Drawing.Color.White;

            this.cmbTecnico.Location = new System.Drawing.Point(510, 75);
            this.cmbTecnico.Size = new System.Drawing.Size(250, 40);
            this.cmbTecnico.BorderRadius = 5;

            this.txtNovaDescricao.Location = new System.Drawing.Point(25, 125);
            this.txtNovaDescricao.Size = new System.Drawing.Size(465, 40);
            this.txtNovaDescricao.BorderRadius = 5;
            this.txtNovaDescricao.PlaceholderText = "Descreva as ações, falhas diagnosticadas e peças trocadas...";

            this.btnSalvar.Location = new System.Drawing.Point(510, 125);
            this.btnSalvar.Size = new System.Drawing.Size(150, 40);
            this.btnSalvar.Text = "Registrar OS";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.BorderRadius = 5;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(16, 185, 129); // Green Success Base
            this.btnSalvar.HoverState.FillColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // GRID
            this.dgvManutencoes.Location = new System.Drawing.Point(25, 185);
            this.dgvManutencoes.Size = new System.Drawing.Size(890, 470);
            this.dgvManutencoes.ReadOnly = true;
            this.dgvManutencoes.AllowUserToAddRows = false;
            this.dgvManutencoes.AllowUserToDeleteRows = false;
            this.dgvManutencoes.AllowUserToResizeRows = false;
            this.dgvManutencoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManutencoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvManutencoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManutencoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManutencoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvManutencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManutencoes.ColumnHeadersHeight = 40;
            this.dgvManutencoes.EnableHeadersVisualStyles = false;
            this.dgvManutencoes.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvManutencoes.RowHeadersVisible = false;
            this.dgvManutencoes.RowTemplate.Height = 35;
            this.dgvManutencoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            
            this.dgvManutencoes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvManutencoes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManutencoes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvManutencoes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvManutencoes.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvManutencoes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvManutencoes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvManutencoes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvManutencoes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvManutencoes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbEquipamentos);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.dtNovaData);
            this.Controls.Add(this.txtNovaDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvManutencoes);

            this.Size = new System.Drawing.Size(950, 680);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Load += new System.EventHandler(this.UcManutencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManutencoes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEquipamentos;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTecnico;
        private Guna.UI2.WinForms.Guna2TextBox txtNovaDescricao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNovaData;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
    }
}
