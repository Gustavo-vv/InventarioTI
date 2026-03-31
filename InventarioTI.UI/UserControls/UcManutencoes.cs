using System;
using System.Windows.Forms;
using InventarioTI.Application.Services;
using InventarioTI.Infrastructure.Repositories;
using InventarioTI.Domain.Entities;
using InventarioTI.Application;

namespace InventarioTI.UI.UserControls
{
    public partial class UcManutencoes : UserControl
    {
        private ManutencaoService _manutencaoService;
        private EquipamentoService _equipamentoService;
        private FuncionarioService _funcService;
        private System.Collections.Generic.List<Manutencao> _listaOriginal;

        public UcManutencoes()
        {
            InitializeComponent();
            _manutencaoService = new ManutencaoService(new ManutencaoRepository());
            _equipamentoService = new EquipamentoService(new EquipamentoRepository());
            _funcService = new FuncionarioService(new FuncionarioRepository());
        }

        private void UcManutencoes_Load(object sender, EventArgs e)
        {
            try 
            {
                CarregarEquipamentos();
                CarregarTecnicos();
                CarregarTabela();
                
                // Controle de Acesso (RBAC):
                if (!Sessao.IsAdmin)
                {
                    btnSalvar.Visible = false;
                    txtNovaDescricao.Enabled = false;
                    cmbEquipamentos.Enabled = false;
                    cmbTecnico.Enabled = false;
                    dtNovaData.Enabled = false;
                }
            } 
            catch { }
        }

        private void CarregarEquipamentos()
        {
            var equip = _equipamentoService.Listar();
            cmbEquipamentos.DataSource = equip;
            cmbEquipamentos.DisplayMember = "Nome";
            cmbEquipamentos.ValueMember = "Id";
            if (cmbEquipamentos.Items.Count > 0) cmbEquipamentos.SelectedIndex = -1;
        }

        private void CarregarTecnicos()
        {
            var tecs = _funcService.Listar();
            cmbTecnico.DataSource = tecs;
            cmbTecnico.DisplayMember = "NomeComSetor";
            cmbTecnico.ValueMember = "ID_Funcionario";
            
            // Auto selecionar o usuário logado para facilitar!
            if (Sessao.UsuarioLogado != null) 
            {
                cmbTecnico.SelectedValue = Sessao.UsuarioLogado.ID_Funcionario;
            }
        }

        private void CarregarTabela()
        {
            _listaOriginal = _manutencaoService.Listar(); 
            dgvManutencoes.DataSource = _listaOriginal;
            
            if (dgvManutencoes.Columns.Count > 0)
            {
                dgvManutencoes.Columns["Registro_Manutencao"].HeaderText = "ID";
                dgvManutencoes.Columns["NomeEquipamento"].HeaderText = "Máquina";
                dgvManutencoes.Columns["NomeFuncionario"].HeaderText = "Técnico";
                dgvManutencoes.Columns["ID_Funcionario"].Visible = false;
                dgvManutencoes.Columns["ID_Equipamento"].Visible = false;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (_listaOriginal == null) return;
            var text = txtPesquisa.Text.ToLower();
            if (string.IsNullOrWhiteSpace(text)) { dgvManutencoes.DataSource = _listaOriginal; return; }

            var filtrada = _listaOriginal.FindAll(m => 
                (m.Descricao?.ToLower().Contains(text) ?? false) || 
                (m.NomeFuncionario?.ToLower().Contains(text) ?? false) || 
                (m.NomeEquipamento?.ToLower().Contains(text) ?? false)
            );
            dgvManutencoes.DataSource = filtrada;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquipamentos.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um Equipamento!");
                    return;
                }
                
                if (cmbTecnico.SelectedValue == null)
                {
                    MessageBox.Show("Selecione o Técnico Responsável!");
                    return;
                }

                Manutencao nova = new Manutencao
                {
                    ID_Equipamento = (int)cmbEquipamentos.SelectedValue,
                    Descricao = txtNovaDescricao.Text,
                    Data_Manutencao = dtNovaData.Value,
                    ID_Funcionario = (int)cmbTecnico.SelectedValue 
                };

                _manutencaoService.Adicionar(nova);
                MessageBox.Show("Manutenção OS Registrada com sucesso!");
                
                txtNovaDescricao.Clear();
                CarregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar: " + ex.Message);
            }
        }
    }
}
