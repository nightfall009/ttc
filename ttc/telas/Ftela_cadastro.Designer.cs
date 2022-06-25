namespace ttc
{
    partial class Ftela_cadastro
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
            this.btnsalva = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbfun = new System.Windows.Forms.ComboBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfone = new System.Windows.Forms.MaskedTextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtfuncio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imagefunc = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.btnovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagefunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalva
            // 
            this.btnsalva.Location = new System.Drawing.Point(521, 301);
            this.btnsalva.Name = "btnsalva";
            this.btnsalva.Size = new System.Drawing.Size(75, 23);
            this.btnsalva.TabIndex = 38;
            this.btnsalva.Text = "salvar";
            this.btnsalva.UseVisualStyleBackColor = true;
            this.btnsalva.Click += new System.EventHandler(this.btnsalva_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(361, 301);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 37;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "cargo funcionario";
            // 
            // cmbfun
            // 
            this.cmbfun.FormattingEnabled = true;
            this.cmbfun.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbfun.Items.AddRange(new object[] {
            "Professor",
            "coordenação",
            "limpeza",
            "cozinha"});
            this.cmbfun.Location = new System.Drawing.Point(188, 301);
            this.cmbfun.Name = "cmbfun";
            this.cmbfun.Size = new System.Drawing.Size(121, 23);
            this.cmbfun.TabIndex = 35;
            // 
            // txtsex
            // 
            this.txtsex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsex.Location = new System.Drawing.Point(315, 221);
            this.txtsex.MaxLength = 1;
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(21, 23);
            this.txtsex.TabIndex = 34;
            this.txtsex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "data de nascimento";
            // 
            // txtfone
            // 
            this.txtfone.Location = new System.Drawing.Point(501, 221);
            this.txtfone.Mask = "(99) 00000-0000";
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(91, 23);
            this.txtfone.TabIndex = 30;
            // 
            // txtdata
            // 
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdata.Location = new System.Drawing.Point(374, 221);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(82, 23);
            this.txtdata.TabIndex = 29;
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(188, 221);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 23);
            this.txtcpf.TabIndex = 28;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(311, 148);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(281, 23);
            this.txtnome.TabIndex = 27;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(456, 90);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 23);
            this.txtcodigo.TabIndex = 26;
            // 
            // txtfuncio
            // 
            this.txtfuncio.Enabled = false;
            this.txtfuncio.Location = new System.Drawing.Point(311, 90);
            this.txtfuncio.Name = "txtfuncio";
            this.txtfuncio.Size = new System.Drawing.Size(112, 23);
            this.txtfuncio.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "codigo de barra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "codigo funcionario";
            // 
            // imagefunc
            // 
            this.imagefunc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imagefunc.Location = new System.Drawing.Point(188, 76);
            this.imagefunc.Name = "imagefunc";
            this.imagefunc.Size = new System.Drawing.Size(110, 100);
            this.imagefunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagefunc.TabIndex = 20;
            this.imagefunc.TabStop = false;
            this.imagefunc.Click += new System.EventHandler(this.imagefunc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(224, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Foto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnovo
            // 
            this.btnovo.Enabled = false;
            this.btnovo.Location = new System.Drawing.Point(442, 301);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(75, 23);
            this.btnovo.TabIndex = 40;
            this.btnovo.Text = "novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // Ftela_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(804, 431);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsalva);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbfun);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfone);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtfuncio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagefunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ftela_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ftela_cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.imagefunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsalva;
        private Button btnlimpar;
        private Label label8;
        private ComboBox cmbfun;
        private TextBox txtsex;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox txtfone;
        private MaskedTextBox txtdata;
        private MaskedTextBox txtcpf;
        private TextBox txtnome;
        private TextBox txtcodigo;
        private TextBox txtfuncio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imagefunc;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private Button btnovo;
    }
}