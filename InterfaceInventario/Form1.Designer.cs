namespace InterfaceInventario
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

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEquipamentos = new System.Windows.Forms.TabPage();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.tabPageManutencoes = new System.Windows.Forms.TabPage();
            this.btnSalvarManutencao = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.dtDataManutencao = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.cbEquipamentos = new System.Windows.Forms.ComboBox();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.dgvManutencoes = new System.Windows.Forms.DataGridView();
            this.btnListarManutencoes = new System.Windows.Forms.Button();
            
            this.tabControl1.SuspendLayout();
            this.tabPageEquipamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.tabPageManutencoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).BeginInit();
            this.SuspendLayout();
            
            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageEquipamentos);
            this.tabControl1.Controls.Add(this.tabPageManutencoes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 500);
            this.tabControl1.TabIndex = 0;
            
            // tabPageEquipamentos
            this.tabPageEquipamentos.Controls.Add(this.btnRemover);
            this.tabPageEquipamentos.Controls.Add(this.dgvEquipamentos);
            this.tabPageEquipamentos.Controls.Add(this.btnListar);
            this.tabPageEquipamentos.Location = new System.Drawing.Point(4, 22);
            this.tabPageEquipamentos.Name = "tabPageEquipamentos";
            this.tabPageEquipamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipamentos.Size = new System.Drawing.Size(892, 474);
            this.tabPageEquipamentos.TabIndex = 0;
            this.tabPageEquipamentos.Text = "Equipamentos";
            this.tabPageEquipamentos.UseVisualStyleBackColor = true;
            
            // btnListar
            this.btnListar.Location = new System.Drawing.Point(20, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 30);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Equipamentos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // btnRemover
            this.btnRemover.Location = new System.Drawing.Point(150, 20);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 30);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Deletar Selecionado";
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            
            // dgvEquipamentos
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamentos.Location = new System.Drawing.Point(20, 60);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.Size = new System.Drawing.Size(840, 390);
            this.dgvEquipamentos.TabIndex = 1;
            this.dgvEquipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipamentos.MultiSelect = false;
            
            // tabPageManutencoes
            this.tabPageManutencoes.Controls.Add(this.btnListarManutencoes);
            this.tabPageManutencoes.Controls.Add(this.dgvManutencoes);
            this.tabPageManutencoes.Controls.Add(this.btnSalvarManutencao);
            this.tabPageManutencoes.Controls.Add(this.txtDescricao);
            this.tabPageManutencoes.Controls.Add(this.labelDescricao);
            this.tabPageManutencoes.Controls.Add(this.dtDataManutencao);
            this.tabPageManutencoes.Controls.Add(this.labelData);
            this.tabPageManutencoes.Controls.Add(this.cbEquipamentos);
            this.tabPageManutencoes.Controls.Add(this.labelEquipamento);
            this.tabPageManutencoes.Location = new System.Drawing.Point(4, 22);
            this.tabPageManutencoes.Name = "tabPageManutencoes";
            this.tabPageManutencoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManutencoes.Size = new System.Drawing.Size(892, 474);
            this.tabPageManutencoes.TabIndex = 1;
            this.tabPageManutencoes.Text = "Registro de Manutenções";
            this.tabPageManutencoes.UseVisualStyleBackColor = true;
            
            // labelEquipamento
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.Location = new System.Drawing.Point(20, 20);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(72, 13);
            this.labelEquipamento.TabIndex = 0;
            this.labelEquipamento.Text = "Equipamento:";
            
            // cbEquipamentos
            this.cbEquipamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipamentos.FormattingEnabled = true;
            this.cbEquipamentos.Location = new System.Drawing.Point(20, 40);
            this.cbEquipamentos.Name = "cbEquipamentos";
            this.cbEquipamentos.Size = new System.Drawing.Size(200, 21);
            this.cbEquipamentos.TabIndex = 1;

            // labelData
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(240, 20);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            
            // dtDataManutencao
            this.dtDataManutencao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataManutencao.Location = new System.Drawing.Point(240, 40);
            this.dtDataManutencao.Name = "dtDataManutencao";
            this.dtDataManutencao.Size = new System.Drawing.Size(120, 20);
            this.dtDataManutencao.TabIndex = 3;

            // labelDescricao
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(20, 70);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição:";
            
            // txtDescricao
            this.txtDescricao.Location = new System.Drawing.Point(20, 90);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(340, 60);
            this.txtDescricao.TabIndex = 5;

            // btnSalvarManutencao
            this.btnSalvarManutencao.Location = new System.Drawing.Point(20, 160);
            this.btnSalvarManutencao.Name = "btnSalvarManutencao";
            this.btnSalvarManutencao.Size = new System.Drawing.Size(150, 30);
            this.btnSalvarManutencao.TabIndex = 6;
            this.btnSalvarManutencao.Text = "Registrar Manutenção";
            this.btnSalvarManutencao.UseVisualStyleBackColor = true;
            this.btnSalvarManutencao.Click += new System.EventHandler(this.btnSalvarManutencao_Click);
            
            // btnListarManutencoes
            this.btnListarManutencoes.Location = new System.Drawing.Point(210, 160);
            this.btnListarManutencoes.Name = "btnListarManutencoes";
            this.btnListarManutencoes.Size = new System.Drawing.Size(150, 30);
            this.btnListarManutencoes.TabIndex = 7;
            this.btnListarManutencoes.Text = "Listar Manutenções";
            this.btnListarManutencoes.UseVisualStyleBackColor = true;
            this.btnListarManutencoes.Click += new System.EventHandler(this.btnListarManutencoes_Click);

            // dgvManutencoes
            this.dgvManutencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManutencoes.Location = new System.Drawing.Point(20, 210);
            this.dgvManutencoes.Name = "dgvManutencoes";
            this.dgvManutencoes.Size = new System.Drawing.Size(840, 240);
            this.dgvManutencoes.TabIndex = 8;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inventário TI - Manutenções";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            this.tabControl1.ResumeLayout(false);
            this.tabPageEquipamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.tabPageManutencoes.ResumeLayout(false);
            this.tabPageManutencoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManutencoes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEquipamentos;
        private System.Windows.Forms.TabPage tabPageManutencoes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.ComboBox cbEquipamentos;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dtDataManutencao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvarManutencao;
        private System.Windows.Forms.Button btnListarManutencoes;
        private System.Windows.Forms.DataGridView dgvManutencoes;
    }
}
