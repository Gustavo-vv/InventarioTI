using System;
using System.Windows.Forms;
using InventarioTI.Application.Services;
using InventarioTI.Infrastructure.Repositories;
using InventarioTI.Application;

namespace InventarioTI.UI
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _usuarioService;

        public FormLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioRepository());
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = "";
                var usuario = _usuarioService.Autenticar(txtLogin.Text, txtSenha.Text);
                
                // Armazena na sessão global para o resto do sistema
                Sessao.UsuarioLogado = usuario;

                // Sucesso!
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }
    }
}
