using System;
using System.Windows.Forms;
using InventarioTI.Application.Services;
using InventarioTI.Infrastructure.Repositories;

namespace InventarioTI.UI.UserControls
{
    public partial class UcFuncionarios : UserControl
    {
        private System.Collections.Generic.List<InventarioTI.Domain.Entities.Funcionario> _listaOriginal;

        public UcFuncionarios()
        {
            InitializeComponent();
        }

        private void UcFuncionarios_Load(object sender, EventArgs e)
        {
            try { 
                _listaOriginal = new FuncionarioService(new FuncionarioRepository()).Listar();
                dgvFuncionarios.DataSource = _listaOriginal; 
                
                if (dgvFuncionarios.Columns.Count > 0)
                {
                    dgvFuncionarios.Columns["NomeComSetor"].Visible = false;
                    dgvFuncionarios.Columns["SetorNome"].Visible = false;
                    dgvFuncionarios.Columns["Localizacao"].Visible = false;
                    dgvFuncionarios.Columns["ResumoSetor"].HeaderText = "Setor (Andar)";
                    dgvFuncionarios.Columns["ResumoSetor"].Width = 200;
                }
            } catch { }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (_listaOriginal == null) return;
            
            var text = txtPesquisa.Text.ToLower();
            if (string.IsNullOrWhiteSpace(text))
            {
                dgvFuncionarios.DataSource = _listaOriginal;
                return;
            }

            var filtrada = _listaOriginal.FindAll(f => 
                f.Nome.ToLower().Contains(text) || 
                f.ID_Funcionario.ToString().Contains(text) || 
                f.ResumoSetor.ToLower().Contains(text)
            );
            dgvFuncionarios.DataSource = filtrada;
        }
    }
}
