using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UnitedSecurity
{
    public partial class frmCadastroFuncionario : Form
    {
        frmLogin frmlogin = new frmLogin();

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void habilitar()
        {
            txtCodigoFuncionario.Enabled = false;
            txtEmail.Enabled = true;
            mskCpfFuncionario.Enabled = true;
            mskDataAdmissao.Enabled = true;
            txtNome.Enabled = true;
        }

        private void limparControles()
        {
            txtCodigoFuncionario.Enabled = false;
            txtEmail.Clear();
            mskCpfFuncionario.Clear();
            mskDataAdmissao.Clear();
            txtNome.Clear();
            txtCodigoFuncionario.Clear();
            txtEmail.Focus();
        }

        private bool validaDados()
        {
            if (string.IsNullOrEmpty(mskCpfFuncionario.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCpfFuncionario.Clear();
                mskCpfFuncionario.Focus();
                return false;
            }

            DateTime auxData;
            if (!(DateTime.TryParse(mskDataAdmissao.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento de campo obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDataAdmissao.Clear();
                mskDataAdmissao.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "UNITED SECURITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limparControles();
                    return;
                }
            }

            if (validaDados() == false)
            {
                return;
            }

            string Sql;
            SqlConnection confuncionario = Conexao.GetConnection();
            Sql = "INSERT INTO funcionario(Nome, CPF, Data_Admissao, Email) VALUES (@Nome, @CPF, @Data_Admissao, @Email)";

            try
            {
                confuncionario.Open();
                SqlCommand cmd = new SqlCommand(Sql, confuncionario);


                cmd.Parameters.Add(new SqlParameter("@Nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@CPF", mskCpfFuncionario.Text));
                cmd.Parameters.Add(new SqlParameter("@Data_Admissao", Convert.ToDateTime(mskDataAdmissao.Text)));
                cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário incluído com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparControles();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir funcionário" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally
            {
                if (confuncionario != null)
                {
                    confuncionario.Close();
                }
            }
        
    }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                MessageBox.Show("Consulte o funcionário que deseja excluir clicando no botão consultar", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "UNITED SECURITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;
                SqlConnection confuncionario = Conexao.GetConnection();
                sqlQuery = "DELETE FROM funcionario WHERE Codigo=@Codigo";

                try
                {
                    confuncionario.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, confuncionario);
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigoFuncionario.Text)));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário excluído com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparControles();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir funcionário" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                finally
                {
                    if (confuncionario != null)
                    {
                        confuncionario.Close();

                    }
                }

            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario frmFuncionario = new ConsultaFuncionario(this);
            frmFuncionario.Show();


        }

        private void btnFecharFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados() == false)
            {
                return;
            }


            if (string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                MessageBox.Show("Código não consta na base de dados", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sqlQuery;
            SqlConnection confuncionario = Conexao.GetConnection();
            sqlQuery = "UPDATE funcionario SET nome = @nome, CPF = @CPF, Data_Admissao = @Data_Admissao, Email = @Email WHERE Codigo = @Codigo";

            try
            {
                confuncionario.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, confuncionario);

                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@CPF", mskCpfFuncionario.Text));
                cmd.Parameters.Add(new SqlParameter("@Data_Admissao", Convert.ToDateTime(mskDataAdmissao.Text)));
                cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigoFuncionario.Text)));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alteração feita com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparControles();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao fazer alteração de informações do funcionário" + ex, "UNITED SECURITY", MessageBoxButtons.OK);

            }

            finally
            {
                if(confuncionario != null)
                {
                    confuncionario.Close();
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskDataAdmissao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblDataAdmissao_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeFuncionário_Click(object sender, EventArgs e)
        {

        }

        private void mskCpfFuncionario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCpfFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
