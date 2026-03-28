using System;
using System.Windows.Forms;
using InventarioTI.Application.Services;
using InventarioTI.Infrastructure.Repositories;

namespace InventarioTI.UI.UserControls
{
    public partial class UcManutencoes : UserControl
    {
        private System.Collections.Generic.List<InventarioTI.Domain.Entities.Manutencao> _listaOriginal;

        public UcManutencoes()
        {
            InitializeComponent();
        }

        private void UcManutencoes_Load(object sender, EventArgs e)
        {
            try { 
                _listaOriginal = new ManutencaoService(new ManutencaoRepository()).Listar(); 
                dgvManutencoes.DataSource = _listaOriginal;
            } catch { }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (_listaOriginal == null) return;
            
            var text = txtPesquisa.Text.ToLower();
            if (string.IsNullOrWhiteSpace(text))
            {
                dgvManutencoes.DataSource = _listaOriginal;
                return;
            }

            var filtrada = _listaOriginal.FindAll(m => 
                m.Descricao.ToLower().Contains(text) || 
                m.NomeFuncionario.ToLower().Contains(text) || 
                m.NomeEquipamento.ToLower().Contains(text)
            );
            dgvManutencoes.DataSource = filtrada;
        }
    }
}
