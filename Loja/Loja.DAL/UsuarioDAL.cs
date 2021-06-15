using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                /*Conexão com BD
                 Seleciona todos os dados da tb_usuario*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_usuario";
                CM.Connection = CON;

                SqlDataReader ER;
                IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if(ER.HasRows)
                {
                    while (ER.Read())
                    {
                        usuario_DTO usu = new usuario_DTO();

                        /*nome dos objetos criados na DTO
                         Cada objeto criado é enviado para a lista, possibilitando
                        que no final vc tenha uma lista com vários usuários*/
                        usu.Cod_usuario = Convert.ToInt32(ER["cod_usuario"]);
                        usu.perfil = Convert.ToInt32(ER["perfil"]);
                        usu.Cadatro = Convert.ToDateTime(ER["cadastro"]);
                        usu.Nome = Convert.ToString(ER["nome"]);
                        usu.Email = Convert.ToString(ER["email"]);
                        usu.Login = Convert.ToString(ER["cadastro"]);
                        usu.Senha = Convert.ToString(ER["senha"]);
                        usu.Situacao = Convert.ToString(ER["situacao"]);
                        listUsuarioDTO.Add(usu);
                    }
                }

                return listUsuarioDTO;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int inserirUsuario(usuario_DTO USU)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_usuario (nome, login, email, senha, cadastro, situacao, perfil)" +
                    "VALUES (@nome, @login, @email, @senha, @cadastro, @situacao, @perfil)";

                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("cadastro", System.Data.SqlDbType.DateTime).Value = USU.Cadatro;
                CM.Parameters.Add("situacao", System.Data.SqlDbType.VarChar).Value = USU.Situacao;
                CM.Parameters.Add("perfil", System.Data.SqlDbType.Int).Value = USU.perfil;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int editaUsuario(usuario_DTO USU)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = "UPDATE tb_usuario SET perfil = @perfil, nome=@nome, login=@login, email=@email, senha=@senha,"+
                    "cadastro=@cadastro, situacao=@situacao WHERE cod_usuario=cod_usuario";

                CM.Parameters.Add("perfil", System.Data.SqlDbType.Int).Value = USU.perfil;
                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("cadastro", System.Data.SqlDbType.DateTime).Value = USU.Cadatro;
                CM.Parameters.Add("situacao", System.Data.SqlDbType.VarChar).Value = USU.Situacao;
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = USU.Cod_usuario;
                CM.Connection = CON;

                //abre a conexao
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int deletaUsuario(usuario_DTO USU)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = "DELETE FROM tb_usuario WHERE cod_usuario=@cod_usuario";

                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.Int).Value = USU.Cod_usuario;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();

                return qtd;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
