using InventarioTI.Application.Services;
using InventarioTI.Domain.Entities;
using InventarioTI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceInventario
{
    public partial class Form1 : Form
    {
        private readonly EquipamentoService _equipamentoService;
        private readonly ManutencaoService _manutencaoService;

        public Form1()
        {
            InitializeComponent();
            _equipamentoService = new EquipamentoService(new EquipamentoRepository());
            _manutencaoService = new ManutencaoService(new ManutencaoRepository());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarEquipamentosCombo();
        }

        /* -------------------------------------------------------------
           ABA DE EQUIPAMENTOS
        ------------------------------------------------------------- */

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEquipamentos.DataSource = _equipamentoService.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipamentos.SelectedRows.Count > 0)
                {
                    // Obtendo o "Id" pela coluna do banco. Note que mapeamos o modelo como "Id"
                    int id = Convert.ToInt32(dgvEquipamentos.SelectedRows[0].Cells["Id"].Value);
                    
                    DialogResult resultado = MessageBox.Show(
                        "Tem certeza que deseja deletar o equipamento selecionado?", 
                        "Confirmação", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        _equipamentoService.Remover(id);
                        MessageBox.Show("Equipamento removido com sucesso!");
                        
                        btnListar_Click(null, null); // Força atualização da grid
                        CarregarEquipamentosCombo(); // Atualiza a aba manutenções também
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione a linha do equipamento na tabela que deseja remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível remover o equipamento. Verifique se ele não possui histórico de manutenção vinculado. \nErro: " + ex.Message);
            }
        }

        /* -------------------------------------------------------------
           ABA DE MANUTENÇÕES
        ------------------------------------------------------------- */
        private void CarregarEquipamentosCombo()
        {
            try
            {
                var equipamentos = _equipamentoService.Listar();
                cbEquipamentos.DataSource = equipamentos;
                cbEquipamentos.DisplayMember = "Nome";
                cbEquipamentos.ValueMember = "Id";
                cbEquipamentos.SelectedIndex = -1;
            }
            catch (Exception)
            {
                // Ignorar erro se o db ainda nao estiver pronto ao iniciar a tela
            }
        }

        private void btnSalvarManutencao_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEquipamentos.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um equipamento da lista.");
                    return;
                }

                Manutencao nova = new Manutencao
                {
                    ID_Equipamento = (int)cbEquipamentos.SelectedValue,
                    Descricao = txtDescricao.Text,
                    Data_Manutencao = dtDataManutencao.Value
                    // ID_Funcionario = Não mandamos nada, logo o _manutencaoService vai colocar o Técnico automático (ID=4)
                };

                _manutencaoService.Adicionar(nova);
                MessageBox.Show("Manutenção registrada com sucesso pelo Técnico responsável!");
                
                txtDescricao.Clear();
                cbEquipamentos.SelectedIndex = -1;
                dtDataManutencao.Value = DateTime.Now;

                btnListarManutencoes_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnListarManutencoes_Click(object sender, EventArgs e)
        {
            try
            {
                dgvManutencoes.DataSource = _manutencaoService.ListarTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar manutenções: " + ex.Message);
            }
        }
    }
}
