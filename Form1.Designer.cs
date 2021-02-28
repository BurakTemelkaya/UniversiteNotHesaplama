
namespace UniversiteNotHesaplama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewNotlar = new System.Windows.Forms.ListView();
            this.dersAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ortalamasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kredisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harfNotu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudFinal = new System.Windows.Forms.NumericUpDown();
            this.nudVize = new System.Windows.Forms.NumericUpDown();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblVize = new System.Windows.Forms.Label();
            this.txtDers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDersOrtalamasi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGirilenDersSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl4uzerinden = new System.Windows.Forms.Label();
            this.lblGenelOrtalama = new System.Windows.Forms.Label();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesaplama";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.listViewNotlar);
            this.groupBox4.Controls.Add(this.btnHepsiniSil);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Location = new System.Drawing.Point(16, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 378);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders Notları";
            // 
            // listViewNotlar
            // 
            this.listViewNotlar.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewNotlar.CheckBoxes = true;
            this.listViewNotlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.Ortalamasi,
            this.Kredisi,
            this.Harf,
            this.harfNotu,
            this.dersAdi});
            this.listViewNotlar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewNotlar.FullRowSelect = true;
            this.listViewNotlar.Location = new System.Drawing.Point(15, 38);
            this.listViewNotlar.Name = "listViewNotlar";
            this.listViewNotlar.Size = new System.Drawing.Size(561, 217);
            this.listViewNotlar.TabIndex = 9;
            this.listViewNotlar.UseCompatibleStateImageBehavior = false;
            this.listViewNotlar.View = System.Windows.Forms.View.Details;
            // 
            // dersAdi
            // 
            this.dersAdi.Text = "Ders Adı";
            this.dersAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dersAdi.Width = 142;
            // 
            // Ortalamasi
            // 
            this.Ortalamasi.Text = "Ortalaması";
            this.Ortalamasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ortalamasi.Width = 115;
            // 
            // Kredisi
            // 
            this.Kredisi.Text = "Kredisi";
            this.Kredisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kredisi.Width = 90;
            // 
            // Harf
            // 
            this.Harf.Text = "Harfi";
            this.Harf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Harf.Width = 64;
            // 
            // harfNotu
            // 
            this.harfNotu.Text = "Harf Notu";
            this.harfNotu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.harfNotu.Width = 101;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(330, 275);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(176, 86);
            this.btnHepsiniSil.TabIndex = 7;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(56, 275);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(179, 86);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Seçilenleri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox3.Controls.Add(this.nudFinal);
            this.groupBox3.Controls.Add(this.nudVize);
            this.groupBox3.Controls.Add(this.nudKredi);
            this.groupBox3.Controls.Add(this.lblFinal);
            this.groupBox3.Controls.Add(this.lblVize);
            this.groupBox3.Controls.Add(this.txtDers);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblDersOrtalamasi);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(56, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(892, 209);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Hesaplama";
            // 
            // nudFinal
            // 
            this.nudFinal.Location = new System.Drawing.Point(434, 82);
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(120, 30);
            this.nudFinal.TabIndex = 3;
            this.nudFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFinal.Click += new System.EventHandler(this.nudFinal_Click);
            // 
            // nudVize
            // 
            this.nudVize.Location = new System.Drawing.Point(229, 82);
            this.nudVize.Name = "nudVize";
            this.nudVize.Size = new System.Drawing.Size(120, 30);
            this.nudVize.TabIndex = 2;
            this.nudVize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudVize.Click += new System.EventHandler(this.nudVize_Click);
            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(26, 81);
            this.nudKredi.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudKredi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(120, 30);
            this.nudKredi.TabIndex = 1;
            this.nudKredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKredi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Click += new System.EventHandler(this.nudKredi_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinal.Location = new System.Drawing.Point(444, 145);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(92, 25);
            this.lblFinal.TabIndex = 13;
            this.lblFinal.Text = "Ortalama";
            // 
            // lblVize
            // 
            this.lblVize.AutoSize = true;
            this.lblVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVize.Location = new System.Drawing.Point(238, 145);
            this.lblVize.Name = "lblVize";
            this.lblVize.Size = new System.Drawing.Size(92, 25);
            this.lblVize.TabIndex = 12;
            this.lblVize.Text = "Ortalama";
            // 
            // txtDers
            // 
            this.txtDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDers.Location = new System.Drawing.Point(620, 81);
            this.txtDers.MaxLength = 100;
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(212, 30);
            this.txtDers.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(622, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ders İsmi (isteğe bağlı)";
            // 
            // lblDersOrtalamasi
            // 
            this.lblDersOrtalamasi.AutoSize = true;
            this.lblDersOrtalamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersOrtalamasi.Location = new System.Drawing.Point(678, 145);
            this.lblDersOrtalamasi.Name = "lblDersOrtalamasi";
            this.lblDersOrtalamasi.Size = new System.Drawing.Size(92, 25);
            this.lblDersOrtalamasi.TabIndex = 10;
            this.lblDersOrtalamasi.Text = "Ortalama";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(26, 128);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(169, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ders Kredisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(444, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Notu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize Notu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblGirilenDersSayisi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl4uzerinden);
            this.groupBox2.Controls.Add(this.lblGenelOrtalama);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(623, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 378);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ders Sayısı :";
            // 
            // lblGirilenDersSayisi
            // 
            this.lblGirilenDersSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirilenDersSayisi.Location = new System.Drawing.Point(235, 288);
            this.lblGirilenDersSayisi.Name = "lblGirilenDersSayisi";
            this.lblGirilenDersSayisi.Size = new System.Drawing.Size(110, 35);
            this.lblGirilenDersSayisi.TabIndex = 19;
            this.lblGirilenDersSayisi.Text = "0";
            this.lblGirilenDersSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "4 Üzerinden :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "100 üzerinden :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Genel Ortalama Notları";
            // 
            // lbl4uzerinden
            // 
            this.lbl4uzerinden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4uzerinden.Location = new System.Drawing.Point(235, 209);
            this.lbl4uzerinden.Name = "lbl4uzerinden";
            this.lbl4uzerinden.Size = new System.Drawing.Size(110, 35);
            this.lbl4uzerinden.TabIndex = 13;
            this.lbl4uzerinden.Text = "Not";
            this.lbl4uzerinden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenelOrtalama
            // 
            this.lblGenelOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelOrtalama.Location = new System.Drawing.Point(235, 134);
            this.lblGenelOrtalama.Name = "lblGenelOrtalama";
            this.lblGenelOrtalama.Size = new System.Drawing.Size(110, 35);
            this.lblGenelOrtalama.TabIndex = 8;
            this.lblGenelOrtalama.Text = "Not";
            this.lblGenelOrtalama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Text = "";
            this.name.Width = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1025, 672);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Üniversite Not Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGenelOrtalama;
        private System.Windows.Forms.Label lblDersOrtalamasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl4uzerinden;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGirilenDersSayisi;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblVize;
        private System.Windows.Forms.ListView listViewNotlar;
        private System.Windows.Forms.ColumnHeader dersAdi;
        private System.Windows.Forms.ColumnHeader Ortalamasi;
        private System.Windows.Forms.ColumnHeader Kredisi;
        private System.Windows.Forms.ColumnHeader Harf;
        private System.Windows.Forms.ColumnHeader harfNotu;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.NumericUpDown nudVize;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.ColumnHeader name;
    }
}

