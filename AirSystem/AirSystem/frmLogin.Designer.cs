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
            HoraFechar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.btnlogin.Location = new System.Drawing.Point(12, 380);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnencerrar.Location = new System.Drawing.Point(93, 380);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(75, 23);
            this.btnencerrar.TabIndex = 2;
            this.btnencerrar.Text = "Sair";
            this.btnencerrar.UseVisualStyleBackColor = true;
            // 
            // btncadastrar
            // 
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadastrar.Location = new System.Drawing.Point(203, 380);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(110, 23);
            this.btncadastrar.TabIndex = 3;
            this.btncadastrar.Text = "Novo Usuário";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtpass.Location = new System.Drawing.Point(14, 282);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(299, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.Text = "Digite sua senha...";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inglês EN-US",
            "Português PT-BR"});
            this.comboBox1.Location = new System.Drawing.Point(14, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Selecione";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtuser
            // 
            this.txtuser.AccessibleName = "";
            this.txtuser.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.txtuser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtuser.Location = new System.Drawing.Point(14, 226);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(299, 20);
            this.txtuser.TabIndex = 6;
            this.txtuser.Text = "Digite seu usuário...";
            this.txtuser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Idioma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 62);
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
            this.lblhora.Location = new System.Drawing.Point(232, 18);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(61, 24);
            this.lblhora.TabIndex = 13;
            this.lblhora.Text = "Hora ";
            this.lblhora.UseMnemonic = false;
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 425);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

