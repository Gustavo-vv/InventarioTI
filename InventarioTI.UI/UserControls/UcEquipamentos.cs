using System;
using System.Windows.Forms;
using InventarioTI.Application.Services;
using InventarioTI.Domain.Entities;
using InventarioTI.Infrastructure.Repositories;

namespace InventarioTI.UI.UserControls
{
    public partial class UcEquipamentos : UserControl
    {
        private EquipamentoService _equipService;
        private FuncionarioService _funcService;

        public UcEquipamentos()
        {
            InitializeComponent();
            _equipService = new EquipamentoService(new EquipamentoRepository());
            _funcService = new FuncionarioService(new FuncionarioRepository());
        }

        private void UcEquipamentos_Load(object sender, EventArgs e)
        {
            CarregarComboboxFuncionarios();
            CarregarDados();
        }

        private void CarregarComboboxFuncionarios()
        {
            try
            {
                var funcs = _funcService.Listar();
                
                // Boneco fantasma para devolver ao estoque
                funcs.Insert(0, new Funcionario { ID_Funcionario = 0, Nome = "--- ESTOQUE (Sem Atribuição) ---", SetorNome = "" });
                
                cmbFuncionario.DataSource = funcs;
                cmbFuncionario.DisplayMember = "NomeComSetor";
                cmbFuncionario.ValueMember = "ID_Funcionario";
            }
            catch { }
        }

        private void CarregarDados()
        {
            try
            {
                dgvEquipamentos.DataSource = _equipService.Listar();
                
                if (dgvEquipamentos.Columns.Count > 0)
                {
                    dgvEquipamentos.Columns["Id"].HeaderText = "ID";
                    dgvEquipamentos.Columns["Id"].Width = 50;
                    dgvEquipamentos.Columns["Nome"].HeaderText = "Equipamento";
                    dgvEquipamentos.Columns["NomeFuncionarioResponsavel"].HeaderText = "Resp. Atual";
                    dgvEquipamentos.Columns["Data_Aquisicao"].HeaderText = "Aquisição";
                    dgvEquipamentos.Columns["ID_Funcionario"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int? idTarget = null;
                if (cmbFuncionario.SelectedValue != null && (int)cmbFuncionario.SelectedValue != 0) 
                     idTarget = (int)cmbFuncionario.SelectedValue;

                var equip = new Equipamento
                {
                    Nome = txtNome.Text,
                    Tipo = txtTipo.Text,
                    Marca = txtMarca.Text,
                    Data_Aquisicao = dtpData.Value,
                    ID_Funcionario = idTarget
                };
                _equipService.Adicionar(equip);
                CarregarDados();
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    int? idTarget = null;
                    if (cmbFuncionario.SelectedValue != null && (int)cmbFuncionario.SelectedValue != 0) 
                         idTarget = (int)cmbFuncionario.SelectedValue;

                    var equip = new Equipamento
                    {
                        Id = id,
                        Nome = txtNome.Text,
                        Tipo = txtTipo.Text,
                        Marca = txtMarca.Text,
                        Data_Aquisicao = dtpData.Value,
                        ID_Funcionario = idTarget
                    };
                    _equipService.Atualizar(equip);
                    CarregarDados();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    _equipService.Remover(id);
                    CarregarDados();
                    Limpar();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvEquipamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvEquipamentos.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtNome.Text = row.Cells["Nome"].Value?.ToString();
                txtTipo.Text = row.Cells["Tipo"].Value?.ToString();
                txtMarca.Text = row.Cells["Marca"].Value?.ToString();
                if (row.Cells["Data_Aquisicao"].Value != null)
                    dtpData.Value = (DateTime)row.Cells["Data_Aquisicao"].Value;
                
                if (row.Cells["ID_Funcionario"].Value != null)
                    cmbFuncionario.SelectedValue = row.Cells["ID_Funcionario"].Value;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Limpar();

        private void Limpar()
        {
            txtId.Clear(); txtNome.Clear(); txtTipo.Clear(); txtMarca.Clear();
            if (cmbFuncionario.Items.Count > 0) cmbFuncionario.SelectedIndex = 0;
            dtpData.Value = DateTime.Now;
            CarregarDados(); // Volta a exibir todos os equipamentos
        }

        private void btnFiltrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFuncionario.SelectedValue != null)
                {
                    int idFunc = (int)cmbFuncionario.SelectedValue;
                    var todos = _equipService.Listar();
                    var filtrados = todos.FindAll(eq => eq.ID_Funcionario == idFunc);
                    dgvEquipamentos.DataSource = filtrados;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
