using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Loja.DTO;
using Loja.BLL;

namespace Loja
{
    public partial class Form_Cadastro_Usuario : Form
    {
        string modo = "";
        public Form_Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Usuario_Load(object sender, EventArgs e)
        {

            carregarGrid();
        }

        private void carregarGrid()
        {
            try
            {
                IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();

                /*preencher dados no DataGridView*/
                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridView1.CurrentRow.Index;
            tb_nome.Text = dataGridView1["nome", sel].Value.ToString();
            tb_login.Text = dataGridView1["login", sel].Value.ToString();
            tb_email.Text = dataGridView1["email", sel].Value.ToString();
            tb_senha.Text = dataGridView1["senha", sel].Value.ToString();
            tb_cadastro.Text = dataGridView1["cadatro", sel].Value.ToString();

            if (dataGridView1["situacao", sel].Value.ToString() == "A")
            {
                cbx_situacao.Text = "Ativo";
            }
            else
            {
                cbx_situacao.Text = "Inativo";

            }
            switch (dataGridView1["perfil", sel].Value.ToString())
            {
                case "1":
                    cbx_perfil.Text = "Administrador";
                    break;
                case "2":
                    cbx_perfil.Text = "Operador";
                    break;
                case "3":
                    cbx_perfil.Text = "Gerente";
                    break;

            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tb_cadastro.Text = DateTime.Now.ToString();
            modo = "novo";
        }

        private void LimparCampos()
        {
            tb_nome.Text = string.Empty;
            tb_login.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_senha.Text = string.Empty;
            tb_cadastro.Text = string.Empty;
            cbx_perfil.Text = string.Empty;
            cbx_situacao.Text = string.Empty;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                try
                {
                    usuario_DTO USU = new usuario_DTO();
                    USU.Nome = tb_nome.Text;
                    USU.Login = tb_login.Text;
                    USU.Email = tb_email.Text;
                    USU.Cadatro = DateTime.Now;
                    USU.Senha = tb_senha.Text;

                    if (cbx_situacao.Text == "Ativo")
                    {
                        USU.Situacao = "A";
                    }
                    else
                    {
                        USU.Situacao = "I";
                    }

                    switch (cbx_situacao.Text)
                    {
                        case "admnistrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    int result = new UsuarioBLL().inserirUsuario(USU);

                    if (result > 0)
                    {
                        MessageBox.Show("Usuário inserido com sucesso");
                        carregarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Falha na inserção ");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            modo = "altera";
        }
    }
}
