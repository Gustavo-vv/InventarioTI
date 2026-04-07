namespace InventarioTI.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenuManutencoes = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuFuncionarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuEquipamentos = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.pnlSidebar.Controls.Add(this.btnMenuManutencoes);
            this.pnlSidebar.Controls.Add(this.btnMenuFuncionarios);
            this.pnlSidebar.Controls.Add(this.btnMenuEquipamentos);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnMenuManutencoes
            // 
            this.btnMenuManutencoes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenuManutencoes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnMenuManutencoes.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuManutencoes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMenuManutencoes.ForeColor = System.Drawing.Color.White;
            this.btnMenuManutencoes.Location = new System.Drawing.Point(0, 220);
            this.btnMenuManutencoes.Name = "btnMenuManutencoes";
            this.btnMenuManutencoes.Size = new System.Drawing.Size(250, 50);
            this.btnMenuManutencoes.TabIndex = 3;
            this.btnMenuManutencoes.Text = "Manutenções (OS)";
            this.btnMenuManutencoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenuManutencoes.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenuManutencoes.Click += new System.EventHandler(this.btnMenuManutencoes_Click);
            // 
            // btnMenuFuncionarios
            // 
            this.btnMenuFuncionarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenuFuncionarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnMenuFuncionarios.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuFuncionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMenuFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnMenuFuncionarios.Location = new System.Drawing.Point(0, 170);
            this.btnMenuFuncionarios.Name = "btnMenuFuncionarios";
            this.btnMenuFuncionarios.Size = new System.Drawing.Size(250, 50);
            this.btnMenuFuncionarios.TabIndex = 2;
            this.btnMenuFuncionarios.Text = "Funcionários e Setores";
            this.btnMenuFuncionarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenuFuncionarios.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenuFuncionarios.Click += new System.EventHandler(this.btnMenuFuncionarios_Click);
            // 
            // btnMenuEquipamentos
            // 
            this.btnMenuEquipamentos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenuEquipamentos.Checked = true;
            this.btnMenuEquipamentos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnMenuEquipamentos.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuEquipamentos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMenuEquipamentos.ForeColor = System.Drawing.Color.White;
            this.btnMenuEquipamentos.Location = new System.Drawing.Point(0, 120);
            this.btnMenuEquipamentos.Name = "btnMenuEquipamentos";
            this.btnMenuEquipamentos.Size = new System.Drawing.Size(250, 50);
            this.btnMenuEquipamentos.TabIndex = 1;
            this.btnMenuEquipamentos.Text = "Equipamentos";
            this.btnMenuEquipamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenuEquipamentos.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenuEquipamentos.Click += new System.EventHandler(this.btnMenuEquipamentos_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(25, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(137, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ControlTech";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlTop.Controls.Add(this.btnFechar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(250, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 40);
            this.pnlTop.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FillColor = System.Drawing.Color.Transparent;
            this.btnFechar.IconColor = System.Drawing.Color.Gray;
            this.btnFechar.Location = new System.Drawing.Point(905, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 30);
            this.btnFechar.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(950, 680);
            this.pnlContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITAM System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnMenuManutencoes;
        private Guna.UI2.WinForms.Guna2Button btnMenuFuncionarios;
        private Guna.UI2.WinForms.Guna2Button btnMenuEquipamentos;
        private Guna.UI2.WinForms.Guna2ControlBox btnFechar;
    }
}