namespace Radyator_Kasabasi_Otel
{
    partial class FrmMusteriler
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            TxtUcret = new TextBox();
            TxtOdaNo = new TextBox();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            TxtKimlikNo = new TextBox();
            TxtMail = new TextBox();
            TxtSoyadi = new TextBox();
            MskTxtTelefon = new MaskedTextBox();
            TxtAdi = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1285, 342);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 3;
            label1.Text = "MÜŞTERİ LİSTESİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(925, 229);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 4;
            label2.Text = "Müşteri adı arama:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(1111, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 34);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.GhostWhite;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(108, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 36);
            comboBox1.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(7, 148);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 58;
            label10.Text = "Cinsiyet:";
            // 
            // TxtUcret
            // 
            TxtUcret.BackColor = Color.GhostWhite;
            TxtUcret.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUcret.Location = new Point(554, 143);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(268, 30);
            TxtUcret.TabIndex = 57;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.GhostWhite;
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(554, 107);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(268, 30);
            TxtOdaNo.TabIndex = 56;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpCikisTarihi.Location = new Point(554, 216);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(268, 31);
            DtpCikisTarihi.TabIndex = 55;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(554, 179);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(268, 31);
            DtpGirisTarihi.TabIndex = 54;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.BackColor = Color.GhostWhite;
            TxtKimlikNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKimlikNo.Location = new Point(554, 71);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(268, 30);
            TxtKimlikNo.TabIndex = 53;
            // 
            // TxtMail
            // 
            TxtMail.BackColor = Color.GhostWhite;
            TxtMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMail.Location = new Point(108, 224);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(268, 30);
            TxtMail.TabIndex = 52;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.BackColor = Color.GhostWhite;
            TxtSoyadi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSoyadi.Location = new Point(108, 107);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(268, 30);
            TxtSoyadi.TabIndex = 51;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(108, 187);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(268, 31);
            MskTxtTelefon.TabIndex = 50;
            // 
            // TxtAdi
            // 
            TxtAdi.BackColor = Color.GhostWhite;
            TxtAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAdi.Location = new Point(108, 69);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(268, 30);
            TxtAdi.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(476, 145);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 48;
            label9.Text = "Ücret:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(428, 219);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 47;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(430, 182);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 46;
            label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(395, 109);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 45;
            label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(398, 71);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 44;
            label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 226);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 43;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 190);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 42;
            label3.Text = "Telefon:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(18, 107);
            label11.Name = "label11";
            label11.Size = new Size(77, 28);
            label11.TabIndex = 41;
            label11.Text = "Soyadı:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(48, 69);
            label12.Name = "label12";
            label12.Size = new Size(47, 28);
            label12.TabIndex = 40;
            label12.Text = "Adı:";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(1159, 39);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(116, 44);
            BtnGuncelle.TabIndex = 60;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.Location = new Point(1159, 97);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(116, 44);
            BtnSil.TabIndex = 61;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTemizle.Location = new Point(1159, 166);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(116, 44);
            BtnTemizle.TabIndex = 62;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1287, 627);
            Controls.Add(BtnTemizle);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(TxtUcret);
            Controls.Add(TxtOdaNo);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(TxtKimlikNo);
            Controls.Add(TxtMail);
            Controls.Add(TxtSoyadi);
            Controls.Add(MskTxtTelefon);
            Controls.Add(TxtAdi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = "Müşteri Bilgileri";
            Load += FrmMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label10;
        private TextBox TxtUcret;
        private TextBox TxtOdaNo;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private MaskedTextBox MskTxtTelefon;
        private TextBox TxtAdi;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label12;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnTemizle;
    }
}