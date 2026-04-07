using System;
using System.Windows.Forms;
using InventarioTI.UI.UserControls;

namespace InventarioTI.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirControle(new UcEquipamentos());

            // --- CONTROLE DE ACESSO ---
            if (!InventarioTI.Application.Sessao.IsAdmin)
            {
                btnMenuFuncionarios.Visible = false;
                // Exemplo: O usuário comum não acessa o "Painel de RH"
            }
            
        }

        private void btnMenuEquipamentos_Click(object sender, EventArgs e)
        {
            AbrirControle(new UcEquipamentos());
        }

        private void btnMenuFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirControle(new UcFuncionarios());
        }

        private void btnMenuManutencoes_Click(object sender, EventArgs e)
        {
            AbrirControle(new UcManutencoes());
        }

        private void AbrirControle(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }
    }
}
