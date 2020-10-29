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
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "usuario@united.com.br")
            {
                panelnextpassword.BringToFront();
                btnVoltar.Visible = true;
            }
            else
            {
                MessageBox.Show("E-mail incorreto tente novamente");
            }


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text == "admin")
            {   
                frmUnited frmUnited = new frmUnited();
                frmUnited.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Senha incorreta tente novamente");
            }
           
        }

        private void lblNomeusuario_Click(object sender, EventArgs e)
        {
   

        }

        private void panelnextpassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelnextpassword.SendToBack();
            btnVoltar.Visible = false;
        }

        private void btnProxima_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
