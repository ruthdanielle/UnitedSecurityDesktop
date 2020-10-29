using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace UnitedSecurity
{
    public partial class frmUnited : Form
    {
        public frmUnited()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void HideSubMenu()
        {
            if (panelCadastroSubMenu.Visible == true)
                panelCadastroSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void CustomizeDesign()
        {
            panelCadastroSubMenu.Visible = false;
        }

        private void frmUnited_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCadastroSubMenu);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCadastroCliente());
            HideSubMenu();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCadastroFuncionario());
            HideSubMenu();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
           
            startInfo.FileName = @"file:///C:/UnitedSecurity/ajuda.html";
            System.Diagnostics.Process.Start(startInfo);

           
        }
    }
}
