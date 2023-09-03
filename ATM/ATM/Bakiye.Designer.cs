namespace ATM
{
    partial class Bakiye
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.baklbl2 = new System.Windows.Forms.Label();
            this.hesnolbl2 = new System.Windows.Forms.Label();
            this.baklbl = new System.Windows.Forms.Label();
            this.hesnolbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
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
            // baklbl2
            // 
            this.baklbl2.AutoSize = true;
            this.baklbl2.BackColor = System.Drawing.SystemColors.Control;
            this.baklbl2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baklbl2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.baklbl2.Location = new System.Drawing.Point(345, 251);
            this.baklbl2.Name = "baklbl2";
            this.baklbl2.Size = new System.Drawing.Size(53, 26);
            this.baklbl2.TabIndex = 15;
            this.baklbl2.Text = "Bak.";
            this.baklbl2.Click += new System.EventHandler(this.baklbl2_Click);
            // 
            // hesnolbl2
            // 
            this.hesnolbl2.AutoSize = true;
            this.hesnolbl2.BackColor = System.Drawing.SystemColors.Control;
            this.hesnolbl2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesnolbl2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hesnolbl2.Location = new System.Drawing.Point(345, 180);
            this.hesnolbl2.Name = "hesnolbl2";
            this.hesnolbl2.Size = new System.Drawing.Size(64, 26);
            this.hesnolbl2.TabIndex = 14;
            this.hesnolbl2.Text = "H. No";
            this.hesnolbl2.Click += new System.EventHandler(this.hesnolbl2_Click);
            // 
            // baklbl
            // 
            this.baklbl.AutoSize = true;
            this.baklbl.BackColor = System.Drawing.SystemColors.Control;
            this.baklbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baklbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.baklbl.Location = new System.Drawing.Point(167, 251);
            this.baklbl.Name = "baklbl";
            this.baklbl.Size = new System.Drawing.Size(107, 26);
            this.baklbl.TabIndex = 13;
            this.baklbl.Text = "Bakiyeniz:";
            // 
            // hesnolbl
            // 
            this.hesnolbl.AutoSize = true;
            this.hesnolbl.BackColor = System.Drawing.SystemColors.Control;
            this.hesnolbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesnolbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hesnolbl.Location = new System.Drawing.Point(167, 180);
            this.hesnolbl.Name = "hesnolbl";
            this.hesnolbl.Size = new System.Drawing.Size(107, 26);
            this.hesnolbl.TabIndex = 12;
            this.hesnolbl.Text = "Hesap No:";
            this.hesnolbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button8.Location = new System.Drawing.Point(350, 399);
            this.button8.Margin = new System.Windows.Forms.Padding(8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 34);
            this.button8.TabIndex = 18;
            this.button8.Text = "GERİ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Bakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.baklbl2);
            this.Controls.Add(this.hesnolbl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baklbl);
            this.Controls.Add(this.hesnolbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Bakiye_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label baklbl2;
        private System.Windows.Forms.Label hesnolbl2;
        private System.Windows.Forms.Label baklbl;
        private System.Windows.Forms.Label hesnolbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
    }
}