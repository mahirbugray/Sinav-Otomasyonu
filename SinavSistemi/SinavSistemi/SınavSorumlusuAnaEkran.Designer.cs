namespace SinavSistemi
{
    partial class SınavSorumlusuAnaEkran
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
            this.sorutxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cevaptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.derstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.soruIDtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Atxtbox = new System.Windows.Forms.TextBox();
            this.Btxtbox = new System.Windows.Forms.TextBox();
            this.Ctxtbox = new System.Windows.Forms.TextBox();
            this.Dtxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sorutxt
            // 
            this.sorutxt.Location = new System.Drawing.Point(120, 47);
            this.sorutxt.Multiline = true;
            this.sorutxt.Name = "sorutxt";
            this.sorutxt.Size = new System.Drawing.Size(1018, 136);
            this.sorutxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 44;
            this.label3.Text = "Soru:";
            // 
            // cevaptxt
            // 
            this.cevaptxt.Location = new System.Drawing.Point(120, 253);
            this.cevaptxt.Multiline = true;
            this.cevaptxt.Name = "cevaptxt";
            this.cevaptxt.Size = new System.Drawing.Size(1018, 89);
            this.cevaptxt.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cevap:";
            // 
            // derstxt
            // 
            this.derstxt.Location = new System.Drawing.Point(120, 348);
            this.derstxt.Multiline = true;
            this.derstxt.Name = "derstxt";
            this.derstxt.Size = new System.Drawing.Size(1018, 33);
            this.derstxt.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ders ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 298);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnekle.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(191, 715);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(371, 63);
            this.btnekle.TabIndex = 50;
            this.btnekle.Text = "Soruyu Admin\'e gönder";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsil.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(624, 715);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(210, 63);
            this.btnsil.TabIndex = 51;
            this.btnsil.Text = "Soru sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnguncelle.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(895, 715);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(210, 63);
            this.btnguncelle.TabIndex = 52;
            this.btnguncelle.Text = "Soru Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 54;
            this.label4.Text = "Soru ID:";
            // 
            // soruIDtxt
            // 
            this.soruIDtxt.Enabled = false;
            this.soruIDtxt.Location = new System.Drawing.Point(120, 8);
            this.soruIDtxt.Multiline = true;
            this.soruIDtxt.Name = "soruIDtxt";
            this.soruIDtxt.Size = new System.Drawing.Size(1018, 33);
            this.soruIDtxt.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 35);
            this.label5.TabIndex = 55;
            this.label5.Text = "A Şıkkı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(685, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 35);
            this.label7.TabIndex = 57;
            this.label7.Text = "D Şıkkı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(461, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 35);
            this.label8.TabIndex = 58;
            this.label8.Text = "C Şıkkı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(239, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 35);
            this.label9.TabIndex = 59;
            this.label9.Text = "B Şıkkı:";
            // 
            // Atxtbox
            // 
            this.Atxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Atxtbox.Location = new System.Drawing.Point(120, 199);
            this.Atxtbox.Name = "Atxtbox";
            this.Atxtbox.Size = new System.Drawing.Size(112, 34);
            this.Atxtbox.TabIndex = 60;
            // 
            // Btxtbox
            // 
            this.Btxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btxtbox.Location = new System.Drawing.Point(346, 197);
            this.Btxtbox.Name = "Btxtbox";
            this.Btxtbox.Size = new System.Drawing.Size(110, 34);
            this.Btxtbox.TabIndex = 61;
            // 
            // Ctxtbox
            // 
            this.Ctxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ctxtbox.Location = new System.Drawing.Point(568, 197);
            this.Ctxtbox.Name = "Ctxtbox";
            this.Ctxtbox.Size = new System.Drawing.Size(106, 34);
            this.Ctxtbox.TabIndex = 62;
            // 
            // Dtxtbox
            // 
            this.Dtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dtxtbox.Location = new System.Drawing.Point(794, 197);
            this.Dtxtbox.Name = "Dtxtbox";
            this.Dtxtbox.Size = new System.Drawing.Size(113, 34);
            this.Dtxtbox.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1169, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 46);
            this.button1.TabIndex = 64;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(916, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 35);
            this.label6.TabIndex = 65;
            this.label6.Text = "Durum:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(1021, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 39);
            this.comboBox1.TabIndex = 66;
            // 
            // SınavSorumlusuAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1218, 786);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dtxtbox);
            this.Controls.Add(this.Ctxtbox);
            this.Controls.Add(this.Btxtbox);
            this.Controls.Add(this.Atxtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soruIDtxt);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cevaptxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sorutxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SınavSorumlusuAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SınavSorumlusuAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sorutxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cevaptxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox derstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soruIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Atxtbox;
        private System.Windows.Forms.TextBox Btxtbox;
        private System.Windows.Forms.TextBox Ctxtbox;
        private System.Windows.Forms.TextBox Dtxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}