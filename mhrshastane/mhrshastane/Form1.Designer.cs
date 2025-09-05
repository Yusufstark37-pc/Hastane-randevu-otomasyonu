namespace mhrshastane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbKlinik = new ComboBox();
            cmbDoktor = new ComboBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            txtTelefon = new TextBox();
            dtpRandevu = new DateTimePicker();
            btnRandevuAl = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbKlinik
            // 
            cmbKlinik.FormattingEnabled = true;
            cmbKlinik.Items.AddRange(new object[] { "Kulak Burun Boğaz", "Göz", "Fizyoterapi", "Ultrasyon", "Psikolog", "Diş ve Ağız Bakımı" });
            cmbKlinik.Location = new Point(501, 120);
            cmbKlinik.Name = "cmbKlinik";
            cmbKlinik.Size = new Size(285, 28);
            cmbKlinik.TabIndex = 0;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Items.AddRange(new object[] { "Melike Kılınçsarı", "Baran Tuncel", "Yusuf Uysal" });
            cmbDoktor.Location = new Point(501, 189);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(285, 28);
            cmbDoktor.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(122, 108);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(238, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(122, 228);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(238, 27);
            txtTC.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(122, 165);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(238, 27);
            txtTelefon.TabIndex = 4;
            // 
            // dtpRandevu
            // 
            dtpRandevu.Location = new Point(550, 257);
            dtpRandevu.Name = "dtpRandevu";
            dtpRandevu.Size = new Size(250, 27);
            dtpRandevu.TabIndex = 5;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuAl.Location = new Point(87, 336);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(148, 61);
            btnRandevuAl.TabIndex = 6;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(87, 433);
            button2.Name = "button2";
            button2.Size = new Size(148, 61);
            button2.TabIndex = 7;
            button2.Text = "İptal Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 111);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 8;
            label1.Text = "AD SOYAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 165);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "TELEFON";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(31, 235);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 10;
            label3.Text = "TC NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(413, 120);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = "KLİNİK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(413, 197);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "DOKTOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(413, 257);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 14;
            label6.Text = "RANDEVU SAATİ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(341, 318);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(570, 338);
            dataGridView1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(198, 33);
            label7.Name = "label7";
            label7.Size = new Size(494, 54);
            label7.TabIndex = 16;
            label7.Text = "KILINÇSARI HASTANESİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 668);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnRandevuAl);
            Controls.Add(dtpRandevu);
            Controls.Add(txtTelefon);
            Controls.Add(txtTC);
            Controls.Add(txtAdSoyad);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbKlinik);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKlinik;
        private ComboBox cmbDoktor;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private TextBox txtTelefon;
        private DateTimePicker dtpRandevu;
        private Button btnRandevuAl;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
    }
}
