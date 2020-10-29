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
    public partial class ConsultaCliente : Form

    {
        frmCadastroCliente frmCliente;

        public ConsultaCliente(frmCadastroCliente frmcliente)
        {
            InitializeComponent();
            frmCliente = frmcliente;
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            string sqlQuery;
            SqlConnection concliente = Conexao.GetConnection();
            concliente.Open();
            sqlQuery = "SELECT AA.Codigo, AA.Nome, AA.Data_Nascimento, AA.CPF," +
"MAX(CASE WHEN ISNULL(BB.Codigo_Servico, 0) = 1 THEN 'SIM' ELSE 'NÃO' END) AS Biometria," +
 "MAX(CASE WHEN ISNULL(BB.Codigo_Servico, 0) = 2 THEN 'SIM' ELSE 'NÃO' END) AS [Analise de Riscos]," +
"MAX(CASE WHEN ISNULL(BB.Codigo_Servico, 0) = 3 THEN 'SIM' ELSE 'NÃO' END) AS Workshop," +
 "MAX(CASE WHEN ISNULL(BB.Codigo_Servico, 0) = 4 THEN 'SIM' ELSE 'NÃO' END) AS [Serviços de Segurança]" +
"FROM cliente AA LEFT OUTER JOIN Servicos_Contratados BB ON(BB.Codigo = AA.Codigo) GROUP BY AA.Codigo, AA.Nome, AA.Data_Nascimento, AA.CPF ORDER BY Nome";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, concliente);
            DataTable dt = new DataTable();
            try
            {

                dta.Fill(dt);
                dgvCliente.DataSource = dt;
                dgvCliente.RowsDefaultCellStyle.BackColor = Color.White;
                dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvCliente.Columns[0].HeaderCell.Value = "Código do Cliente";
                dgvCliente.Columns[1].HeaderCell.Value = "Nome";
                dgvCliente.Columns[2].HeaderCell.Value = "Dt. Nasc.";
                dgvCliente.Columns[3].HeaderCell.Value = "CPF";
                dgvCliente.Columns[4].HeaderCell.Value = "Biometria";
                dgvCliente.Columns[5].HeaderCell.Value = "Analise de Riscos";
                dgvCliente.Columns[6].HeaderCell.Value = "Workshop";
                dgvCliente.Columns[7].HeaderCell.Value = "Serviços de Segurança";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar Clientes" + ex, "UNITED SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (concliente != null)
                {
                    concliente.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string codigoCliente;
            codigoCliente = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            string sqlQuery;
            SqlConnection conClienteConsulta = Conexao.GetConnection();
            SqlDataReader dtr = null;
            sqlQuery = "SELECT Codigo, Nome, Data_Nascimento, CPF FROM cliente WHERE Codigo=@Codigo";
            try
            {
                conClienteConsulta.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);
                cmd.Parameters.Add(new SqlParameter("@Codigo", Convert.ToInt32(codigoCliente)));
                dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    frmCliente.txtCodigo.Text = dtr["Codigo"].ToString();
                    frmCliente.txtNome.Text = dtr["Nome"].ToString();
                    frmCliente.mskNascimento.Text = dtr["Data_Nascimento"].ToString();
                    frmCliente.mskCpf.Text = dtr["CPF"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            finally
            {
                if (dtr != null)
                {
                    dtr.Close();
                }

                if (conClienteConsulta != null)
                {
                    conClienteConsulta.Close();
                }
            }

            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

