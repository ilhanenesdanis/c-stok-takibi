namespace StokTakibi
{
    partial class frmmusteriekle
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
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(148, 28);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(193, 30);
            this.txttc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(148, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(193, 30);
            this.txtad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(148, 100);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(193, 30);
            this.txttel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(148, 136);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(193, 30);
            this.txtadres.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(148, 172);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(193, 30);
            this.txtmail.TabIndex = 8;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(148, 209);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(193, 34);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // frmmusteriekle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 302);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmusteriekle";
            this.Text = "Müşteri Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmmusteriekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnekle;
    }
}