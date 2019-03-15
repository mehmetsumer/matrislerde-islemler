namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.satirm = new System.Windows.Forms.Label();
            this.birimm = new System.Windows.Forms.Label();
            this.sifirm = new System.Windows.Forms.Label();
            this.kosegenm = new System.Windows.Forms.Label();
            this.karem = new System.Windows.Forms.Label();
            this.simm = new System.Windows.Forms.Label();
            this.terssimm = new System.Windows.Forms.Label();
            this.altm = new System.Windows.Forms.Label();
            this.skalerm = new System.Windows.Forms.Label();
            this.ustm = new System.Windows.Forms.Label();
            this.sutunm = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(316, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Girişe Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satır Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(162, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sütun Sayısı:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(99, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox2.Location = new System.Drawing.Point(254, 16);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(4, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 196);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(4, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Matrisin Çeşidi, Transpozesi ve Determinantı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // satirm
            // 
            this.satirm.AutoSize = true;
            this.satirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satirm.Location = new System.Drawing.Point(429, 53);
            this.satirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.satirm.Name = "satirm";
            this.satirm.Size = new System.Drawing.Size(77, 16);
            this.satirm.TabIndex = 10;
            this.satirm.Text = "Satır Matrisi";
            // 
            // birimm
            // 
            this.birimm.AutoSize = true;
            this.birimm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimm.Location = new System.Drawing.Point(429, 158);
            this.birimm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birimm.Name = "birimm";
            this.birimm.Size = new System.Drawing.Size(77, 16);
            this.birimm.TabIndex = 10;
            this.birimm.Text = "Birim matris";
            // 
            // sifirm
            // 
            this.sifirm.AutoSize = true;
            this.sifirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirm.Location = new System.Drawing.Point(429, 116);
            this.sifirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifirm.Name = "sifirm";
            this.sifirm.Size = new System.Drawing.Size(71, 16);
            this.sifirm.TabIndex = 10;
            this.sifirm.Text = "Sıfır matris";
            // 
            // kosegenm
            // 
            this.kosegenm.AutoSize = true;
            this.kosegenm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kosegenm.Location = new System.Drawing.Point(429, 137);
            this.kosegenm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kosegenm.Name = "kosegenm";
            this.kosegenm.Size = new System.Drawing.Size(95, 16);
            this.kosegenm.TabIndex = 10;
            this.kosegenm.Text = "Köşegen matris";
            // 
            // karem
            // 
            this.karem.AutoSize = true;
            this.karem.BackColor = System.Drawing.Color.Transparent;
            this.karem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karem.ForeColor = System.Drawing.Color.Black;
            this.karem.Location = new System.Drawing.Point(430, 95);
            this.karem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karem.Name = "karem";
            this.karem.Size = new System.Drawing.Size(73, 16);
            this.karem.TabIndex = 10;
            this.karem.Text = "Kare matris";
            // 
            // simm
            // 
            this.simm.AutoSize = true;
            this.simm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simm.Location = new System.Drawing.Point(429, 199);
            this.simm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simm.Name = "simm";
            this.simm.Size = new System.Drawing.Size(94, 16);
            this.simm.TabIndex = 10;
            this.simm.Text = "Simetrik matris";
            // 
            // terssimm
            // 
            this.terssimm.AutoSize = true;
            this.terssimm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terssimm.Location = new System.Drawing.Point(429, 220);
            this.terssimm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.terssimm.Name = "terssimm";
            this.terssimm.Size = new System.Drawing.Size(121, 16);
            this.terssimm.TabIndex = 10;
            this.terssimm.Text = "Ters simetrik matris";
            // 
            // altm
            // 
            this.altm.AutoSize = true;
            this.altm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altm.Location = new System.Drawing.Point(429, 241);
            this.altm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.altm.Name = "altm";
            this.altm.Size = new System.Drawing.Size(111, 16);
            this.altm.TabIndex = 10;
            this.altm.Text = "Altüçgensel matris";
            // 
            // skalerm
            // 
            this.skalerm.AutoSize = true;
            this.skalerm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skalerm.Location = new System.Drawing.Point(429, 179);
            this.skalerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skalerm.Name = "skalerm";
            this.skalerm.Size = new System.Drawing.Size(82, 16);
            this.skalerm.TabIndex = 10;
            this.skalerm.Text = "Skaler matris";
            // 
            // ustm
            // 
            this.ustm.AutoSize = true;
            this.ustm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ustm.Location = new System.Drawing.Point(429, 262);
            this.ustm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ustm.Name = "ustm";
            this.ustm.Size = new System.Drawing.Size(115, 16);
            this.ustm.TabIndex = 10;
            this.ustm.Text = "Üstüçgensel matris";
            // 
            // sutunm
            // 
            this.sutunm.AutoSize = true;
            this.sutunm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sutunm.Location = new System.Drawing.Point(429, 74);
            this.sutunm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sutunm.Name = "sutunm";
            this.sutunm.Size = new System.Drawing.Size(83, 16);
            this.sutunm.TabIndex = 10;
            this.sutunm.Text = "Sütun matrisi";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(215, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 196);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(429, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Determinant =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(517, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 296);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sutunm);
            this.Controls.Add(this.ustm);
            this.Controls.Add(this.skalerm);
            this.Controls.Add(this.altm);
            this.Controls.Add(this.terssimm);
            this.Controls.Add(this.simm);
            this.Controls.Add(this.karem);
            this.Controls.Add(this.kosegenm);
            this.Controls.Add(this.sifirm);
            this.Controls.Add(this.birimm);
            this.Controls.Add(this.satirm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label satirm;
        private System.Windows.Forms.Label birimm;
        private System.Windows.Forms.Label sifirm;
        private System.Windows.Forms.Label kosegenm;
        private System.Windows.Forms.Label karem;
        private System.Windows.Forms.Label simm;
        private System.Windows.Forms.Label terssimm;
        private System.Windows.Forms.Label altm;
        private System.Windows.Forms.Label skalerm;
        private System.Windows.Forms.Label ustm;
        private System.Windows.Forms.Label sutunm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

