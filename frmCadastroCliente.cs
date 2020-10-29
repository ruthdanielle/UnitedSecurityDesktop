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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            
        }

        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            mskNascimento.Enabled = true;

        }

       

        private void limparControles()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtCodigo.Clear();
            mskCpf.Clear();
            mskNascimento.Clear();
            txtCodigo.Focus();
            
        }


        private bool validaDados()
        {
            if (string.IsNullOrEmpty(mskCpf.Text))
            {
                MessageBox.Show("Preenchimento obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCpf.Clear();
                mskCpf.Focus();
                return false;
            }

            DateTime auxData;
            if (!(DateTime.TryParse(mskNascimento.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskNascimento.Clear();
                mskNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatório!!", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            habilitar();
        }


        private void customizeDesign()
        {

        }
        private void hideSubMenu()
        {

        }

        private void showSubMenu(Panel subMenu)
        {

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnopenlist_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (MessageBox.Show("Deseja incluir um registro novo?", "UNITED SECURITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            SqlConnection concliente = Conexao.GetConnection();
            Sql = "INSERT INTO cliente(Nome, Data_Nascimento, CPF) VALUES (@Nome, @Data_Nascimento, @CPF)";

            try
            {
                concliente.Open();
                SqlCommand cmd = new SqlCommand(Sql, concliente);

                cmd.Parameters.Add(new SqlParameter("@Codigo", txtCodigo.Text));
                cmd.Parameters.Add(new SqlParameter("@Nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@Data_Nascimento", Convert.ToDateTime(mskNascimento.Text)));
                cmd.Parameters.Add(new SqlParameter("@CPF", mskCpf.Text));
                cmd.ExecuteNonQuery();

                Sql = "SELECT @@IDENTITY";

                if (ckbBiometria.Checked == true)
                {
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES ((SELECT MAX(Codigo) FROM cliente), 1)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.ExecuteNonQuery();
                }

                if(ckbAnaliseRiscos.Checked == true)
                {
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES ((SELECT MAX(Codigo) FROM cliente), 2)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.ExecuteNonQuery();
                }

                if(ckbWorkshop.Checked == true)
                {
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES ((SELECT MAX(Codigo) FROM cliente), 3)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.ExecuteNonQuery();
                }

                if(ckbServicoSeguranca.Checked == true)
                {
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES ((SELECT MAX(Codigo) FROM cliente), 4)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.ExecuteNonQuery();
                }


                

                MessageBox.Show("Cliente incluído com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparControles();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally
            {
                if (concliente != null)
                {
                    concliente.Close();
                }
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione o cliente a ser excluído no botão consultar", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Deseja excluir o registro?", "UNITED SECURITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                sqlQuery = "DELETE FROM Servicos_Contratados WHERE Codigo = @Codigo";
                SqlConnection conCliente = Conexao.GetConnection();

                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                SqlConnection conCliente2 = Conexao.GetConnection();
                sqlQuery = "DELETE FROM cliente WHERE Codigo=@Codigo";
                    

                try
                {
                    conCliente2.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente2);
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparControles();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                finally
                {
                    if (conCliente2 != null)
                    {
                        conCliente2.Close();

                    }
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaCliente frmCliente = new ConsultaCliente(this);
            frmCliente.Show();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            

        }

        private void frmCadastroCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            if (validaDados() == false)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Código não consta na base de dados", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sqlQuery;
            SqlConnection concliente = Conexao.GetConnection();

            try
            {
                concliente.Open();
                sqlQuery = "DELETE FROM Servicos_Contratados WHERE Codigo = "+txtCodigo.Text;
                SqlCommand cmd = new SqlCommand(sqlQuery, concliente);

                cmd.ExecuteNonQuery();

                concliente.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao fazer alteração de informações do cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK);

            }


            sqlQuery = "UPDATE cliente SET Nome = @nome, Data_Nascimento = @Data_Nascimento, CPF=@CPF WHERE Codigo=@Codigo";

            try
            {
                concliente.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, concliente);

                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@Data_Nascimento", Convert.ToDateTime(mskNascimento.Text)));
                cmd.Parameters.Add(new SqlParameter("@CPF", mskCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));

                cmd.ExecuteNonQuery();
                concliente.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show("Problema ao fazer alteração de informações do cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK);

            }

            try
            {

                string Sql;
                

                if (ckbBiometria.Checked == true)
                {
                    concliente.Open();
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES (@Codigo, 1)";
                    
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd2.ExecuteNonQuery();
                    concliente.Close();
                }

                if (ckbAnaliseRiscos.Checked == true)
                {
                    concliente.Open();
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES (@Codigo, 2)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd2.ExecuteNonQuery();
                    concliente.Close();
                }

                if (ckbWorkshop.Checked == true)
                {
                    concliente.Open();
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES (@Codigo, 3)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd2.ExecuteNonQuery();
                    concliente.Close();
                }

                if (ckbServicoSeguranca.Checked == true)
                {
                    concliente.Open();
                    Sql = "INSERT INTO Servicos_Contratados (Codigo, Codigo_Servico) VALUES (@Codigo, 4)";
                    SqlCommand cmd2 = new SqlCommand(Sql, concliente);
                    cmd2.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(txtCodigo.Text)));
                    cmd2.ExecuteNonQuery();

                    concliente.Close();
                }

                


            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao fazer alteração de informações do cliente" + ex, "UNITED SECURITY", MessageBoxButtons.OK);

            }



            finally
            {
                MessageBox.Show("Alteração feita com sucesso", "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparControles();
               
                
            }


        }

        private void ckbServicoSeguranca_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}