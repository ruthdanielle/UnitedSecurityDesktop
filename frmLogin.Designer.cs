namespace UnitedSecurity
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnProxima = new System.Windows.Forms.Button();
            this.lblFazerlogin = new System.Windows.Forms.Label();
            this.panelnextpassword = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNomeusuario = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblpasswordpanel = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelnextpassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(59, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(50, 169);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(212, 22);
            this.txtemail.TabIndex = 2;
            // 
            // btnProxima
            // 
            this.btnProxima.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProxima.Location = new System.Drawing.Point(176, 231);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(86, 29);
            this.btnProxima.TabIndex = 4;
            this.btnProxima.Text = "Proxima";
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            this.btnProxima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnProxima_KeyDown);
            // 
            // lblFazerlogin
            // 
            this.lblFazerlogin.AutoSize = true;
            this.lblFazerlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFazerlogin.Location = new System.Drawing.Point(112, 78);
            this.lblFazerlogin.Name = "lblFazerlogin";
            this.lblFazerlogin.Size = new System.Drawing.Size(86, 18);
            this.lblFazerlogin.TabIndex = 5;
            this.lblFazerlogin.Text = "Fazer Login";
            // 
            // panelnextpassword
            // 
            this.panelnextpassword.AccessibleDescription = "Digite seu email";
            this.panelnextpassword.AccessibleName = "Email";
            this.panelnextpassword.Controls.Add(this.btnVoltar);
            this.panelnextpassword.Controls.Add(this.lblNomeusuario);
            this.panelnextpassword.Controls.Add(this.btnEntrar);
            this.panelnextpassword.Controls.Add(this.lblpasswordpanel);
            this.panelnextpassword.Controls.Add(this.txtpassword);
            this.panelnextpassword.Location = new System.Drawing.Point(18, 118);
            this.panelnextpassword.Name = "panelnextpassword";
            this.panelnextpassword.Size = new System.Drawing.Size(267, 164);
            this.panelnextpassword.TabIndex = 8;
            this.panelnextpassword.Paint += new System.Windows.Forms.PaintEventHandler(this.panelnextpassword_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Location = new System.Drawing.Point(32, 113);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 28);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNomeusuario
            // 
            this.lblNomeusuario.AutoSize = true;
            this.lblNomeusuario.Location = new System.Drawing.Point(83, 3);
            this.lblNomeusuario.Name = "lblNomeusuario";
            this.lblNomeusuario.Size = new System.Drawing.Size(0, 13);
            this.lblNomeusuario.TabIndex = 10;
            this.lblNomeusuario.Click += new System.EventHandler(this.lblNomeusuario_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Location = new System.Drawing.Point(158, 114);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(86, 28);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblpasswordpanel
            // 
            this.lblpasswordpanel.AutoSize = true;
            this.lblpasswordpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswordpanel.Location = new System.Drawing.Point(42, 16);
            this.lblpasswordpanel.Name = "lblpasswordpanel";
            this.lblpasswordpanel.Size = new System.Drawing.Size(55, 18);
            this.lblpasswordpanel.TabIndex = 9;
            this.lblpasswordpanel.Text = "Senha";
            // 
            // txtpassword
            // 
            this.txtpassword.AccessibleDescription = "Digite sua senha";
            this.txtpassword.AccessibleName = "Senha do usuario";
            this.txtpassword.Location = new System.Drawing.Point(32, 51);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(212, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(303, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFazerlogin);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panelnextpassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnProxima_KeyDown);
            this.panelnextpassword.ResumeLayout(false);
            this.panelnextpassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Label lblFazerlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelnextpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpasswordpanel;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNomeusuario;
        private System.Windows.Forms.Button btnVoltar;
    }
}