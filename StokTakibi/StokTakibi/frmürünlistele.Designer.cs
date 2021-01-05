namespace StokTakibi
{
    partial class frmürünlistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtürün = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsatış = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtalış = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.lblara = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkatgüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Location = new System.Drawing.Point(50, 247);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(0, 17);
            this.lblmiktar.TabIndex = 31;
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(135, 247);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(166, 40);
            this.btngüncelle.TabIndex = 30;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kategori";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Marka";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(135, 146);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(166, 22);
            this.txtmiktar.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ürün Adı";
            // 
            // txtürün
            // 
            this.txtürün.Location = new System.Drawing.Point(135, 113);
            this.txtürün.Name = "txtürün";
            this.txtürün.Size = new System.Drawing.Size(166, 22);
            this.txtürün.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Miktar";
            // 
            // txtsatış
            // 
            this.txtsatış.Location = new System.Drawing.Point(135, 212);
            this.txtsatış.Name = "txtsatış";
            this.txtsatış.Size = new System.Drawing.Size(166, 22);
            this.txtsatış.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Alış fiyatı";
            // 
            // txtalış
            // 
            this.txtalış.Location = new System.Drawing.Point(135, 179);
            this.txtalış.Name = "txtalış";
            this.txtalış.Size = new System.Drawing.Size(166, 22);
            this.txtalış.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Satış fiyatı";
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(135, 14);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(166, 22);
            this.txtbarkod.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Barkod No";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(135, 47);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.ReadOnly = true;
            this.txtkategori.Size = new System.Drawing.Size(166, 22);
            this.txtkategori.TabIndex = 32;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(135, 80);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.ReadOnly = true;
            this.txtmarka.Size = new System.Drawing.Size(166, 22);
            this.txtmarka.TabIndex = 33;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(135, 293);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(166, 40);
            this.btnsil.TabIndex = 34;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(135, 339);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(166, 22);
            this.txtara.TabIndex = 36;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // lblara
            // 
            this.lblara.AutoSize = true;
            this.lblara.Location = new System.Drawing.Point(39, 344);
            this.lblara.Name = "lblara";
            this.lblara.Size = new System.Drawing.Size(79, 17);
            this.lblara.TabIndex = 35;
            this.lblara.Text = "Barkod Ara";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 430);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 24);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Marka";
            // 
            // btnkatgüncelle
            // 
            this.btnkatgüncelle.Location = new System.Drawing.Point(135, 460);
            this.btnkatgüncelle.Name = "btnkatgüncelle";
            this.btnkatgüncelle.Size = new System.Drawing.Size(166, 40);
            this.btnkatgüncelle.TabIndex = 41;
            this.btnkatgüncelle.Text = "Güncelle";
            this.btnkatgüncelle.UseVisualStyleBackColor = true;
            this.btnkatgüncelle.Click += new System.EventHandler(this.btnkatgüncelle_Click);
            // 
            // frmürünlistele
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.btnkatgüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.lblara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtürün);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsatış);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtalış);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmürünlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme";
            this.Load += new System.EventHandler(this.frmürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtürün;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsatış;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtalış;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label lblara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkatgüncelle;
    }
}