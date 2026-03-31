namespace InventarioTI.UI
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlShadow = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.formDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);

            this.pnlShadow.SuspendLayout();
            this.SuspendLayout();

            // pnlShadow
            this.pnlShadow.BackColor = System.Drawing.Color.Transparent;
            this.pnlShadow.FillColor = System.Drawing.Color.White;
            this.pnlShadow.Radius = 10;
            this.pnlShadow.ShadowColor = System.Drawing.Color.Black;
            this.pnlShadow.ShadowShift = 8;
            this.pnlShadow.ShadowDepth = 50;
            this.pnlShadow.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlShadow.Size = new System.Drawing.Size(350, 420);
            this.pnlShadow.Location = new System.Drawing.Point(50, 40);
            
            this.pnlShadow.Controls.Add(this.lblTitulo);
            this.pnlShadow.Controls.Add(this.lblSubTitulo);
            this.pnlShadow.Controls.Add(this.txtLogin);
            this.pnlShadow.Controls.Add(this.txtSenha);
            this.pnlShadow.Controls.Add(this.btnEntrar);
            this.pnlShadow.Controls.Add(this.lblErro);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(17, 34, 60);
            this.lblTitulo.Location = new System.Drawing.Point(20, 30);
            this.lblTitulo.Text = "ITAM System";

            // lblSubTitulo
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitulo.Location = new System.Drawing.Point(23, 75);
            this.lblSubTitulo.Text = "Autorização Corporativa.";

            // txtLogin
            this.txtLogin.Location = new System.Drawing.Point(25, 120);
            this.txtLogin.Size = new System.Drawing.Size(300, 45);
            this.txtLogin.PlaceholderText = "Seu Login...";
            this.txtLogin.BorderRadius = 8;
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);

            // txtSenha
            this.txtSenha.Location = new System.Drawing.Point(25, 185);
            this.txtSenha.Size = new System.Drawing.Size(300, 45);
            this.txtSenha.PlaceholderText = "Sua Senha...";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.BorderRadius = 8;
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);

            // btnEntrar
            this.btnEntrar.Location = new System.Drawing.Point(25, 260);
            this.btnEntrar.Size = new System.Drawing.Size(300, 50);
            this.btnEntrar.Text = "Acessar Plataforma";
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.BorderRadius = 8;
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(37, 99, 235); // Blue Primary
            this.btnEntrar.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216); // Darker Blue
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            // lblErro
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Crimson;
            this.lblErro.Location = new System.Drawing.Point(25, 320);
            this.lblErro.Text = "";

            // formDrag
            this.formDrag.TargetControl = this;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.BorderRadius = 15;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Controls.Add(this.pnlShadow);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Login - ITAM";
            
            this.pnlShadow.ResumeLayout(false);
            this.pnlShadow.PerformLayout();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlShadow;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private System.Windows.Forms.Label lblErro;
        private Guna.UI2.WinForms.Guna2DragControl formDrag;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
