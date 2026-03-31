namespace InventarioTI.UI.UserControls
{
    partial class UcFuncionarios
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
            this.dgvFuncionarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Colaboradores (RH) e Centros de Custo";

            this.txtPesquisa.Location = new System.Drawing.Point(490, 20);
            this.txtPesquisa.Size = new System.Drawing.Size(425, 40);
            this.txtPesquisa.BorderRadius = 5;
            this.txtPesquisa.PlaceholderText = "Pesquisar por Nome, Cargo ou Setor...";
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            this.dgvFuncionarios.Location = new System.Drawing.Point(25, 80);
            this.dgvFuncionarios.Size = new System.Drawing.Size(890, 560);
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFuncionarios.ColumnHeadersHeight = 40;
            this.dgvFuncionarios.EnableHeadersVisualStyles = false;
            this.dgvFuncionarios.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 35;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvFuncionarios.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionarios.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvFuncionarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvFuncionarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.dgvFuncionarios.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);


            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionarios);

            this.Size = new System.Drawing.Size(950, 680);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Load += new System.EventHandler(this.UcFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionarios;
    }
}
