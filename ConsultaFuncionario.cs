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
    public partial class ConsultaFuncionario : Form

    {
        frmCadastroFuncionario frmfuncionario;


        public ConsultaFuncionario(frmCadastroFuncionario frmFuncionario)
        {

            InitializeComponent();

            frmfuncionario = frmFuncionario;
            
        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            string sqlQuery;
            SqlConnection confuncionario = Conexao.GetConnection();
            confuncionario.Open();
            sqlQuery = "SELECT Codigo, Nome, CPF, Data_Admissao, Email FROM funcionario ORDER BY Nome";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, confuncionario);
            DataTable dt = new DataTable();
            try
            {

                dta.Fill(dt);
                dgvFuncionario.DataSource = dt;
                dgvFuncionario.RowsDefaultCellStyle.BackColor = Color.White;
                dgvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvFuncionario.Columns[0].HeaderCell.Value = "Código do Funcionário";
                dgvFuncionario.Columns[1].HeaderCell.Value = "Nome";
                dgvFuncionario.Columns[2].HeaderCell.Value = "CPF";
                dgvFuncionario.Columns[3].HeaderCell.Value = "Data_Admissao";
                dgvFuncionario.Columns[4].HeaderCell.Value = "Email";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar Funcionários" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (confuncionario != null)
                {
                    confuncionario.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string codigoFuncionario;
            codigoFuncionario = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            string sqlQuery;
            SqlConnection conFuncionarioConsulta = Conexao.GetConnection();
            SqlDataReader dtr = null;
            sqlQuery = "SELECT Codigo, Nome, CPF, Data_Admissao, Email FROM funcionario WHERE Codigo=@Codigo";
            try
            {
                conFuncionarioConsulta.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conFuncionarioConsulta);
                cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(codigoFuncionario)));
                dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    frmfuncionario.txtCodigoFuncionario.Text = dtr["Codigo"].ToString();
                    frmfuncionario.txtNome.Text = dtr["Nome"].ToString();
                    frmfuncionario.mskCpfFuncionario.Text = dtr["CPF"].ToString();
                    frmfuncionario.mskDataAdmissao.Text = dtr["Data_Admissao"].ToString();
                    frmfuncionario.txtEmail.Text = dtr["Email"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            finally
            {
                if (dtr!=null){
                    dtr.Close();
                }

                if(conFuncionarioConsulta != null)
                {
                    conFuncionarioConsulta.Close();
                }
            }

            this.Close();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
