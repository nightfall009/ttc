namespace ttc
{
    partial class telacha
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
            System.Windows.Forms.Panel panel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telacha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imagefunc = new ttc.Circulaimage();
            this.lblensa = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagefunc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel3.CausesValidation = false;
            panel3.Location = new System.Drawing.Point(224, 188);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(37, 18);
            panel3.TabIndex = 1;
            panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.imagefunc);
            this.panel1.Controls.Add(this.lblensa);
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 316);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnome.Location = new System.Drawing.Point(12, 161);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.ShortcutsEnabled = false;
            this.txtnome.Size = new System.Drawing.Size(460, 22);
            this.txtnome.TabIndex = 10;
            this.txtnome.TabStop = false;
            this.txtnome.Text = "nome funcionario";
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(140, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entrada Confirmada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imagefunc
            // 
            this.imagefunc.BackColor = System.Drawing.Color.Lavender;
            this.imagefunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagefunc.ErrorImage = global::ttc.Properties.Resources.WhatsApp__low;
            this.imagefunc.Image = ((System.Drawing.Image)(resources.GetObject("imagefunc.Image")));
            this.imagefunc.Location = new System.Drawing.Point(185, 40);
            this.imagefunc.Name = "imagefunc";
            this.imagefunc.Size = new System.Drawing.Size(100, 100);
            this.imagefunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagefunc.TabIndex = 1;
            this.imagefunc.TabStop = false;
            this.imagefunc.Click += new System.EventHandler(this.imagefunc_Click);
            // 
            // lblensa
            // 
            this.lblensa.AutoSize = true;
            this.lblensa.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblensa.ForeColor = System.Drawing.Color.Red;
            this.lblensa.Location = new System.Drawing.Point(152, 233);
            this.lblensa.Name = "lblensa";
            this.lblensa.Size = new System.Drawing.Size(180, 30);
            this.lblensa.TabIndex = 8;
            this.lblensa.Text = "saida Confirmada";
            this.lblensa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblensa.Visible = false;
            this.lblensa.Click += new System.EventHandler(this.lblensa_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhora.Location = new System.Drawing.Point(314, 186);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(44, 20);
            this.lblhora.TabIndex = 7;
            this.lblhora.Text = "00:00";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(261, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldata.Location = new System.Drawing.Point(140, 186);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(85, 20);
            this.lbldata.TabIndex = 5;
            this.lbldata.Text = "00/00/0000";
            this.lbldata.Click += new System.EventHandler(this.lbldata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "data:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(-16, -24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 127);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // telacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "telacha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tchama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagefunc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        public Label lblensa;
        public Label lblhora;
        public Label lbldata;
        public Circulaimage imagefunc;
        public Label label2;
        private Panel panel3;
        private TextBox txtnome;
    }
}