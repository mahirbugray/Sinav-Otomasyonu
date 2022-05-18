namespace SinavSistemi
{
    partial class SinavSorumlusuGiris
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
            this.btngirisyap = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hsgldnz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngirisyap
            // 
            this.btngirisyap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btngirisyap.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirisyap.Location = new System.Drawing.Point(283, 293);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(210, 63);
            this.btngirisyap.TabIndex = 45;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = false;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(283, 208);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(210, 40);
            this.txtsifre.TabIndex = 42;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "Şifre:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(283, 146);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(210, 40);
            this.txtad.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 35);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // lbl_hsgldnz
            // 
            this.lbl_hsgldnz.AutoSize = true;
            this.lbl_hsgldnz.Font = new System.Drawing.Font("Corbel", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hsgldnz.Location = new System.Drawing.Point(137, 3);
            this.lbl_hsgldnz.Name = "lbl_hsgldnz";
            this.lbl_hsgldnz.Size = new System.Drawing.Size(402, 106);
            this.lbl_hsgldnz.TabIndex = 40;
            this.lbl_hsgldnz.Text = "SINAV SORUMLUSU \r\n               GİRİŞ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(612, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 46);
            this.button1.TabIndex = 46;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinavSorumlusuGiris
            // 
            this.AcceptButton = this.btngirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(662, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_hsgldnz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinavSorumlusuGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinavSorumlusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hsgldnz;
        private System.Windows.Forms.Button button1;
    }
}