namespace UnitedSecurity
{
    partial class frmCadastroFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpfFuncionario = new System.Windows.Forms.Label();
            this.mskCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFuncionário = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.mskDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dB_UnitedSecurity1 = new UnitedSecurity.DB_UnitedSecurity();
            this.dBUnitedSecurity1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFecharFuncionario = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UnitedSecurity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUnitedSecurity1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(127, 112);
            this.lblCodigoFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(60, 18);
            this.lblCodigoFuncionario.TabIndex = 0;
            this.lblCodigoFuncionario.Text = "Código:";
            this.lblCodigoFuncionario.Click += new System.EventHandler(this.lblCodigoFuncionario_Click);
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoFuncionario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtCodigoFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoFuncionario.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(200, 108);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.ReadOnly = true;
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(62, 24);
            this.txtCodigoFuncionario.TabIndex = 0;
            this.txtCodigoFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoFuncionario.TextChanged += new System.EventHandler(this.txtCodigoFuncionario_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(357, 110);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblCpfFuncionario
            // 
            this.lblCpfFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfFuncionario.AutoSize = true;
            this.lblCpfFuncionario.Location = new System.Drawing.Point(127, 179);
            this.lblCpfFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfFuncionario.Name = "lblCpfFuncionario";
            this.lblCpfFuncionario.Size = new System.Drawing.Size(42, 18);
            this.lblCpfFuncionario.TabIndex = 4;
            this.lblCpfFuncionario.Text = "CPF:";
            this.lblCpfFuncionario.Click += new System.EventHandler(this.lblCpfFuncionario_Click);
            // 
            // mskCpfFuncionario
            // 
            this.mskCpfFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskCpfFuncionario.Location = new System.Drawing.Point(191, 176);
            this.mskCpfFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.mskCpfFuncionario.Mask = "999.999.999-99";
            this.mskCpfFuncionario.Name = "mskCpfFuncionario";
            this.mskCpfFuncionario.Size = new System.Drawing.Size(109, 24);
            this.mskCpfFuncionario.TabIndex = 2;
            this.mskCpfFuncionario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCpfFuncionario_MaskInputRejected);
            // 
            // lblNomeFuncionário
            // 
            this.lblNomeFuncionário.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeFuncionário.AutoSize = true;
            this.lblNomeFuncionário.Location = new System.Drawing.Point(127, 255);
            this.lblNomeFuncionário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFuncionário.Name = "lblNomeFuncionário";
            this.lblNomeFuncionário.Size = new System.Drawing.Size(53, 18);
            this.lblNomeFuncionário.TabIndex = 6;
            this.lblNomeFuncionário.Text = "Nome:";
            this.lblNomeFuncionário.Click += new System.EventHandler(this.lblNomeFuncionário_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(189, 252);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 24);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(348, 182);
            this.lblDataAdmissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(133, 18);
            this.lblDataAdmissao.TabIndex = 8;
            this.lblDataAdmissao.Text = "Data de Admissão:";
            this.lblDataAdmissao.Click += new System.EventHandler(this.lblDataAdmissao_Click);
            // 
            // mskDataAdmissao
            // 
            this.mskDataAdmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskDataAdmissao.Location = new System.Drawing.Point(489, 179);
            this.mskDataAdmissao.Margin = new System.Windows.Forms.Padding(4);
            this.mskDataAdmissao.Mask = "99/99/9999";
            this.mskDataAdmissao.Name = "mskDataAdmissao";
            this.mskDataAdmissao.Size = new System.Drawing.Size(72, 24);
            this.mskDataAdmissao.TabIndex = 3;
            this.mskDataAdmissao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDataAdmissao_MaskInputRejected);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Location = new System.Drawing.Point(184, 353);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(90, 41);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.Blue;
            this.btnConsultar.Location = new System.Drawing.Point(299, 431);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 41);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(299, 353);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 41);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dB_UnitedSecurity1
            // 
            this.dB_UnitedSecurity1.DataSetName = "DB_UnitedSecurity";
            this.dB_UnitedSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBUnitedSecurity1BindingSource
            // 
            this.dBUnitedSecurity1BindingSource.DataSource = this.dB_UnitedSecurity1;
            this.dBUnitedSecurity1BindingSource.Position = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(886, 721);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 32);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFecharFuncionario
            // 
            this.btnFecharFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharFuncionario.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFecharFuncionario.Location = new System.Drawing.Point(587, 534);
            this.btnFecharFuncionario.Name = "btnFecharFuncionario";
            this.btnFecharFuncionario.Size = new System.Drawing.Size(90, 41);
            this.btnFecharFuncionario.TabIndex = 9;
            this.btnFecharFuncionario.Text = "Fechar";
            this.btnFecharFuncionario.UseVisualStyleBackColor = true;
            this.btnFecharFuncionario.Click += new System.EventHandler(this.btnFecharFuncionario_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(414, 353);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 41);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(414, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 24);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(689, 587);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFecharFuncionario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.mskDataAdmissao);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeFuncionário);
            this.Controls.Add(this.mskCpfFuncionario);
            this.Controls.Add(this.lblCpfFuncionario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Controls.Add(this.lblCodigoFuncionario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.Text = "Cadastro do Funcionário";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_UnitedSecurity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUnitedSecurity1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpfFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionário;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private DB_UnitedSecurity dB_UnitedSecurity1;
        private System.Windows.Forms.BindingSource dBUnitedSecurity1BindingSource;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.MaskedTextBox mskCpfFuncionario;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox mskDataAdmissao;
        private System.Windows.Forms.Button btnFecharFuncionario;
        private System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.TextBox txtCodigoFuncionario;
        internal System.Windows.Forms.TextBox txtEmail;
    }
}