namespace UnitedSecurity
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mskNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.gpbServicos = new System.Windows.Forms.GroupBox();
            this.ckbServicoSeguranca = new System.Windows.Forms.CheckBox();
            this.ckbWorkshop = new System.Windows.Forms.CheckBox();
            this.ckbAnaliseRiscos = new System.Windows.Forms.CheckBox();
            this.ckbBiometria = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbServicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFechar.Location = new System.Drawing.Point(586, 533);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 41);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(88, 44);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(99, 87);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 18);
            this.lblCpf.TabIndex = 11;
            this.lblCpf.Text = "CPF";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(314, 84);
            this.lblDtNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(143, 18);
            this.lblDtNasc.TabIndex = 12;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(288, 44);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(154, 44);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(66, 24);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(345, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 24);
            this.txtNome.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Location = new System.Drawing.Point(183, 437);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(90, 41);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(305, 436);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 41);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.Blue;
            this.btnConsultar.Location = new System.Drawing.Point(305, 512);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 41);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mskNascimento
            // 
            this.mskNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskNascimento.Location = new System.Drawing.Point(465, 81);
            this.mskNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.mskNascimento.Mask = "99/99/9999";
            this.mskNascimento.Name = "mskNascimento";
            this.mskNascimento.Size = new System.Drawing.Size(79, 24);
            this.mskNascimento.TabIndex = 3;
            // 
            // mskCpf
            // 
            this.mskCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskCpf.Location = new System.Drawing.Point(154, 84);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(108, 24);
            this.mskCpf.TabIndex = 2;
            // 
            // gpbServicos
            // 
            this.gpbServicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbServicos.Controls.Add(this.ckbServicoSeguranca);
            this.gpbServicos.Controls.Add(this.ckbWorkshop);
            this.gpbServicos.Controls.Add(this.ckbAnaliseRiscos);
            this.gpbServicos.Controls.Add(this.ckbBiometria);
            this.gpbServicos.Location = new System.Drawing.Point(145, 146);
            this.gpbServicos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbServicos.Name = "gpbServicos";
            this.gpbServicos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbServicos.Size = new System.Drawing.Size(398, 267);
            this.gpbServicos.TabIndex = 4;
            this.gpbServicos.TabStop = false;
            this.gpbServicos.Text = "Serviços Contratados";
            // 
            // ckbServicoSeguranca
            // 
            this.ckbServicoSeguranca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbServicoSeguranca.AutoSize = true;
            this.ckbServicoSeguranca.Location = new System.Drawing.Point(16, 218);
            this.ckbServicoSeguranca.Margin = new System.Windows.Forms.Padding(4);
            this.ckbServicoSeguranca.Name = "ckbServicoSeguranca";
            this.ckbServicoSeguranca.Size = new System.Drawing.Size(180, 22);
            this.ckbServicoSeguranca.TabIndex = 8;
            this.ckbServicoSeguranca.Text = "Serviços de Segurança";
            this.ckbServicoSeguranca.UseVisualStyleBackColor = true;
            this.ckbServicoSeguranca.CheckedChanged += new System.EventHandler(this.ckbServicoSeguranca_CheckedChanged);
            // 
            // ckbWorkshop
            // 
            this.ckbWorkshop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbWorkshop.AutoSize = true;
            this.ckbWorkshop.Location = new System.Drawing.Point(16, 163);
            this.ckbWorkshop.Margin = new System.Windows.Forms.Padding(4);
            this.ckbWorkshop.Name = "ckbWorkshop";
            this.ckbWorkshop.Size = new System.Drawing.Size(97, 22);
            this.ckbWorkshop.TabIndex = 7;
            this.ckbWorkshop.Text = "Workshop";
            this.ckbWorkshop.UseVisualStyleBackColor = true;
            // 
            // ckbAnaliseRiscos
            // 
            this.ckbAnaliseRiscos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbAnaliseRiscos.AutoSize = true;
            this.ckbAnaliseRiscos.Location = new System.Drawing.Point(16, 107);
            this.ckbAnaliseRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAnaliseRiscos.Name = "ckbAnaliseRiscos";
            this.ckbAnaliseRiscos.Size = new System.Drawing.Size(145, 22);
            this.ckbAnaliseRiscos.TabIndex = 6;
            this.ckbAnaliseRiscos.Text = "Análise de Riscos";
            this.ckbAnaliseRiscos.UseVisualStyleBackColor = true;
            // 
            // ckbBiometria
            // 
            this.ckbBiometria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbBiometria.AutoSize = true;
            this.ckbBiometria.Location = new System.Drawing.Point(16, 53);
            this.ckbBiometria.Margin = new System.Windows.Forms.Padding(4);
            this.ckbBiometria.Name = "ckbBiometria";
            this.ckbBiometria.Size = new System.Drawing.Size(90, 22);
            this.ckbBiometria.TabIndex = 5;
            this.ckbBiometria.Text = "Biometria";
            this.ckbBiometria.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(426, 436);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 41);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(689, 587);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.mskNascimento);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbServicos);
            this.Controls.Add(this.btnIncluir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro do Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load_1);
            this.gpbServicos.ResumeLayout(false);
            this.gpbServicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.MaskedTextBox mskNascimento;
        internal System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.GroupBox gpbServicos;
        private System.Windows.Forms.CheckBox ckbServicoSeguranca;
        private System.Windows.Forms.CheckBox ckbWorkshop;
        private System.Windows.Forms.CheckBox ckbAnaliseRiscos;
        private System.Windows.Forms.CheckBox ckbBiometria;
        private System.Windows.Forms.Button btnAlterar;
    }
}