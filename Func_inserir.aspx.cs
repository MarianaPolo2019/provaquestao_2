using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova_Questao2
{
    public partial class Func_inserir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
                
        protected void btnCadastrar_Click1(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into funcionario

                                    (nome_f, sexo_f, dataNasc_f, carTrab_f,
                                    tel_fix_f, tel_cel_f, email_f, log_f,
                                    num_f, bair_f, cid_f, uf_f, comp_f) 

                                    values

                                    (@nome_f, @sex_f, @dat_f, @cart_f,
                                    @tel_f, @cel_f, @email_f, @log_f, @num_f,
                                    @bair_f, @cidade_f, @uf_f, @comp_f);";

                cmd.Parameters.AddWithValue("nome_f", txtNome.Text);
                cmd.Parameters.AddWithValue("sex_f", ddlSexo.SelectedValue);
                cmd.Parameters.AddWithValue("dat_f", txtDataNasc.Text);
                cmd.Parameters.AddWithValue("cart_f", txtCarteiraTrab.Text);
                cmd.Parameters.AddWithValue("tel_f", txtTelFixo.Text);
                cmd.Parameters.AddWithValue("cel_f", txtTelCel.Text);
                cmd.Parameters.AddWithValue("email_f", txtEmail.Text);
                cmd.Parameters.AddWithValue("log_f", txtLog.Text);
                cmd.Parameters.AddWithValue("num_f", txtNum.Text);
                cmd.Parameters.AddWithValue("bair_f", txtBairro.Text);
                cmd.Parameters.AddWithValue("cidade_f", txtCidade.Text);
                cmd.Parameters.AddWithValue("uf_f", txtUF.Text);
                cmd.Parameters.AddWithValue("comp_f", txtComple.Text);

                Conexao.Conectar();

                cmd.ExecuteNonQuery();
                lblResultado.Text = "Cadastrado!";
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Falha: {ex.Message}";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}