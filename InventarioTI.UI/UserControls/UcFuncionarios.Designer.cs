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
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestão de Funcionários e Setores";

            this.txtPesquisa.Location = new System.Drawing.Point(450, 20);
            this.txtPesquisa.Size = new System.Drawing.Size(425, 40);
            this.txtPesquisa.PlaceholderText = "Pesquisar por Nome, ID ou Localização...";
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            this.dgvFuncionarios.Location = new System.Drawing.Point(25, 80);
            this.dgvFuncionarios.Size = new System.Drawing.Size(850, 500);
            this.dgvFuncionarios.ReadOnly = true;

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionarios);

            this.Size = new System.Drawing.Size(950, 680);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Load += new System.EventHandler(this.UcFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionarios;
    }
}
