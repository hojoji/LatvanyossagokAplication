namespace LatvanyossagokAplication
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.varosNevTxt = new System.Windows.Forms.TextBox();
            this.varosLakossagTxt = new System.Windows.Forms.TextBox();
            this.varosFelveszBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.varosokLb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latvFelveszBtn = new System.Windows.Forms.Button();
            this.latvArTxt = new System.Windows.Forms.TextBox();
            this.latvLeirTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.latvNevTxt = new System.Windows.Forms.TextBox();
            this.torolBtn = new System.Windows.Forms.Button();
            this.modositBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.modositNev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modositLakossag = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.latvanyossagLb = new System.Windows.Forms.ListBox();
            this.latvListBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.latvListBtn);
            this.panel1.Controls.Add(this.latvanyossagLb);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.modositBtn);
            this.panel1.Controls.Add(this.torolBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.latvNevTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.latvFelveszBtn);
            this.panel1.Controls.Add(this.latvArTxt);
            this.panel1.Controls.Add(this.latvLeirTxt);
            this.panel1.Controls.Add(this.varosokLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.varosFelveszBtn);
            this.panel1.Controls.Add(this.varosLakossagTxt);
            this.panel1.Controls.Add(this.varosNevTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // varosNevTxt
            // 
            this.varosNevTxt.Location = new System.Drawing.Point(3, 16);
            this.varosNevTxt.Name = "varosNevTxt";
            this.varosNevTxt.Size = new System.Drawing.Size(117, 20);
            this.varosNevTxt.TabIndex = 1;
            // 
            // varosLakossagTxt
            // 
            this.varosLakossagTxt.Location = new System.Drawing.Point(3, 55);
            this.varosLakossagTxt.Name = "varosLakossagTxt";
            this.varosLakossagTxt.Size = new System.Drawing.Size(117, 20);
            this.varosLakossagTxt.TabIndex = 3;
            // 
            // varosFelveszBtn
            // 
            this.varosFelveszBtn.Location = new System.Drawing.Point(3, 81);
            this.varosFelveszBtn.Name = "varosFelveszBtn";
            this.varosFelveszBtn.Size = new System.Drawing.Size(117, 36);
            this.varosFelveszBtn.TabIndex = 4;
            this.varosFelveszBtn.Text = "Város hozzáadása";
            this.varosFelveszBtn.UseVisualStyleBackColor = true;
            this.varosFelveszBtn.Click += new System.EventHandler(this.VarosFelveszBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Város neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Város lakossága:";
            // 
            // varosokLb
            // 
            this.varosokLb.FormattingEnabled = true;
            this.varosokLb.Location = new System.Drawing.Point(3, 123);
            this.varosokLb.Name = "varosokLb";
            this.varosokLb.Size = new System.Drawing.Size(117, 121);
            this.varosokLb.TabIndex = 7;
            this.varosokLb.SelectedIndexChanged += new System.EventHandler(this.VarosokLb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Látványosság ára";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Látványosság leírása:";
            // 
            // latvFelveszBtn
            // 
            this.latvFelveszBtn.Location = new System.Drawing.Point(168, 120);
            this.latvFelveszBtn.Name = "latvFelveszBtn";
            this.latvFelveszBtn.Size = new System.Drawing.Size(150, 36);
            this.latvFelveszBtn.TabIndex = 10;
            this.latvFelveszBtn.Text = "Látványosság hozzáadása";
            this.latvFelveszBtn.UseVisualStyleBackColor = true;
            this.latvFelveszBtn.Click += new System.EventHandler(this.LatvFelveszBtn_Click);
            // 
            // latvArTxt
            // 
            this.latvArTxt.Location = new System.Drawing.Point(168, 94);
            this.latvArTxt.Name = "latvArTxt";
            this.latvArTxt.Size = new System.Drawing.Size(150, 20);
            this.latvArTxt.TabIndex = 9;
            // 
            // latvLeirTxt
            // 
            this.latvLeirTxt.Location = new System.Drawing.Point(168, 55);
            this.latvLeirTxt.Name = "latvLeirTxt";
            this.latvLeirTxt.Size = new System.Drawing.Size(150, 20);
            this.latvLeirTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Látványosság neve:";
            // 
            // latvNevTxt
            // 
            this.latvNevTxt.Location = new System.Drawing.Point(168, 16);
            this.latvNevTxt.Name = "latvNevTxt";
            this.latvNevTxt.Size = new System.Drawing.Size(150, 20);
            this.latvNevTxt.TabIndex = 13;
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(6, 250);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(114, 33);
            this.torolBtn.TabIndex = 15;
            this.torolBtn.Text = "Törlés";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.TorolBtn_Click);
            // 
            // modositBtn
            // 
            this.modositBtn.Location = new System.Drawing.Point(6, 289);
            this.modositBtn.Name = "modositBtn";
            this.modositBtn.Size = new System.Drawing.Size(114, 32);
            this.modositBtn.TabIndex = 16;
            this.modositBtn.Text = "Módosít";
            this.modositBtn.UseVisualStyleBackColor = true;
            this.modositBtn.Click += new System.EventHandler(this.ModositBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.modositNev);
            this.panel2.Controls.Add(this.modositLakossag);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(6, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 111);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Név:";
            // 
            // modositNev
            // 
            this.modositNev.Location = new System.Drawing.Point(2, 17);
            this.modositNev.Name = "modositNev";
            this.modositNev.Size = new System.Drawing.Size(109, 20);
            this.modositNev.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "lakossag";
            // 
            // modositLakossag
            // 
            this.modositLakossag.Location = new System.Drawing.Point(2, 56);
            this.modositLakossag.Name = "modositLakossag";
            this.modositLakossag.Size = new System.Drawing.Size(109, 20);
            this.modositLakossag.TabIndex = 18;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(16, 84);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(66, 24);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "modosít";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // latvanyossagLb
            // 
            this.latvanyossagLb.FormattingEnabled = true;
            this.latvanyossagLb.Location = new System.Drawing.Point(168, 162);
            this.latvanyossagLb.Name = "latvanyossagLb";
            this.latvanyossagLb.Size = new System.Drawing.Size(150, 121);
            this.latvanyossagLb.TabIndex = 18;
            // 
            // latvListBtn
            // 
            this.latvListBtn.Location = new System.Drawing.Point(168, 290);
            this.latvListBtn.Name = "latvListBtn";
            this.latvListBtn.Size = new System.Drawing.Size(149, 31);
            this.latvListBtn.TabIndex = 19;
            this.latvListBtn.Text = "Látványosságokat listáz";
            this.latvListBtn.UseVisualStyleBackColor = true;
            this.latvListBtn.Click += new System.EventHandler(this.LatvListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox varosNevTxt;
        private System.Windows.Forms.TextBox varosLakossagTxt;
        private System.Windows.Forms.Button varosFelveszBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox varosokLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox latvNevTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button latvFelveszBtn;
        private System.Windows.Forms.TextBox latvArTxt;
        private System.Windows.Forms.TextBox latvLeirTxt;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button modositBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modositNev;
        private System.Windows.Forms.TextBox modositLakossag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox latvanyossagLb;
        private System.Windows.Forms.Button latvListBtn;
    }
}

