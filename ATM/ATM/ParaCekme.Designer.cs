namespace ATM
{
    partial class ParaCekme
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
            this.paramiktar = new System.Windows.Forms.TextBox();
            this.paracek = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.kalan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paramiktar
            // 
            this.paramiktar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.paramiktar.Location = new System.Drawing.Point(328, 224);
            this.paramiktar.Name = "paramiktar";
            this.paramiktar.Size = new System.Drawing.Size(191, 33);
            this.paramiktar.TabIndex = 38;
            // 
            // paracek
            // 
            this.paracek.BackColor = System.Drawing.Color.DarkSlateGray;
            this.paracek.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paracek.ForeColor = System.Drawing.Color.Snow;
            this.paracek.Location = new System.Drawing.Point(350, 281);
            this.paracek.Margin = new System.Windows.Forms.Padding(8);
            this.paracek.Name = "paracek";
            this.paracek.Size = new System.Drawing.Size(148, 41);
            this.paracek.TabIndex = 33;
            this.paracek.Text = "Para Çek";
            this.paracek.UseVisualStyleBackColor = false;
            this.paracek.Click += new System.EventHandler(this.paracek_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.Control;
            this.cikis.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cikis.Location = new System.Drawing.Point(350, 399);
            this.cikis.Margin = new System.Windows.Forms.Padding(8);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(101, 34);
            this.cikis.TabIndex = 37;
            this.cikis.Text = "GERİ";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(245, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Miktar:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM YÖNETİM SİSTEMİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(766, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kalan
            // 
            this.kalan.AutoSize = true;
            this.kalan.BackColor = System.Drawing.SystemColors.Control;
            this.kalan.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.kalan.Location = new System.Drawing.Point(345, 176);
            this.kalan.Name = "kalan";
            this.kalan.Size = new System.Drawing.Size(130, 26);
            this.kalan.TabIndex = 39;
            this.kalan.Text = "Kalan Bakiye";
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kalan);
            this.Controls.Add(this.paramiktar);
            this.Controls.Add(this.paracek);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParaCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaCekme";
            this.Load += new System.EventHandler(this.ParaCekme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramiktar;
        private System.Windows.Forms.Button paracek;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kalan;
    }
}