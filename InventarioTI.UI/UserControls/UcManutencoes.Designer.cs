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
            this.dgvManutencoes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Ordens de Manutenção (Chamados)";

            this.txtPesquisa.Location = new System.Drawing.Point(450, 20);
            this.txtPesquisa.Size = new System.Drawing.Size(425, 40);
            this.txtPesquisa.PlaceholderText = "Pesquisar OS por Descrição, Empregado ou Máquina...";
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            this.dgvManutencoes.Location = new System.Drawing.Point(25, 80);
            this.dgvManutencoes.Size = new System.Drawing.Size(850, 500);
            this.dgvManutencoes.ReadOnly = true;

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvManutencoes);

            this.Size = new System.Drawing.Size(950, 680);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Load += new System.EventHandler(this.UcManutencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManutencoes;
    }
}
