namespace AirSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer HoraFechar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            HoraFechar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HoraFechar
            // 
            HoraFechar.Enabled = true;
            HoraFechar.Tick += new System.EventHandler(this.HoraFechar_Tick);
            // 
            // btnlogin
            // 
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(497, 383);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // btnencerrar
            // 
            this.btnencerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnencerrar.Location = new System.Drawing.Point(578, 383);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(75, 23);
            this.btnencerrar.TabIndex = 2;
            this.btnencerrar.Text = "Sair";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadastrar.Location = new System.Drawing.Point(688, 383);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(110, 23);
            this.btncadastrar.TabIndex = 3;
            this.btncadastrar.Text = "Novo Usuário";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtpass.Location = new System.Drawing.Point(499, 285);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(299, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.Text = "Digite sua senha...";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inglês EN-US",
            "Português PT-BR"});
            this.comboBox1.Location = new System.Drawing.Point(499, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Selecione";
            // 
            // txtuser
            // 
            this.txtuser.AccessibleName = "usuario";
            this.txtuser.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.txtuser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtuser.Location = new System.Drawing.Point(499, 229);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(299, 20);
            this.txtuser.TabIndex = 6;
            this.txtuser.Text = "Digite seu usuário...";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(497, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(497, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(497, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Idioma";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(500, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.SystemColors.Control;
            this.lblhora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblhora.Location = new System.Drawing.Point(717, 21);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(61, 24);
            this.lblhora.TabIndex = 13;
            this.lblhora.Text = "Hora ";
            this.lblhora.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 385);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.btnlogin);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "frmLogin";
            this.Text = "Login - AirSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

