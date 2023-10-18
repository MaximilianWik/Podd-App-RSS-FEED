namespace PoddCollectorG26
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
            ComboCat = new ComboBox();
            LaggTillPod = new Button();
            BortPod = new Button();
            AndraPod = new Button();
            URL = new TextBox();
            PodNamn = new TextBox();
            CatNamn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Namn = new Label();
            LaggTillCat = new Button();
            BortCat = new Button();
            AndraCat = new Button();
            PodBox = new ListBox();
            CatBox = new ListBox();
            InfoBox = new ListBox();
            EpBox = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ComboCat
            // 
            ComboCat.FormattingEnabled = true;
            ComboCat.Location = new Point(174, 120);
            ComboCat.Name = "ComboCat";
            ComboCat.Size = new Size(121, 23);
            ComboCat.TabIndex = 0;
            // 
            // LaggTillPod
            // 
            LaggTillPod.Location = new Point(26, 167);
            LaggTillPod.Name = "LaggTillPod";
            LaggTillPod.Size = new Size(75, 23);
            LaggTillPod.TabIndex = 1;
            LaggTillPod.Text = "Lägg Till";
            LaggTillPod.UseVisualStyleBackColor = true;
            LaggTillPod.Click += LaggTillPod_Click;
            // 
            // BortPod
            // 
            BortPod.Location = new Point(120, 167);
            BortPod.Name = "BortPod";
            BortPod.Size = new Size(75, 23);
            BortPod.TabIndex = 2;
            BortPod.Text = "Ta Bort";
            BortPod.UseVisualStyleBackColor = true;
            // 
            // AndraPod
            // 
            AndraPod.Location = new Point(220, 167);
            AndraPod.Name = "AndraPod";
            AndraPod.Size = new Size(75, 23);
            AndraPod.TabIndex = 3;
            AndraPod.Text = "Ändra";
            AndraPod.UseVisualStyleBackColor = true;
            // 
            // URL
            // 
            URL.Location = new Point(26, 120);
            URL.Name = "URL";
            URL.Size = new Size(100, 23);
            URL.TabIndex = 4;
            // 
            // PodNamn
            // 
            PodNamn.Location = new Point(26, 75);
            PodNamn.Name = "PodNamn";
            PodNamn.Size = new Size(100, 23);
            PodNamn.TabIndex = 5;
            // 
            // CatNamn
            // 
            CatNamn.Location = new Point(1289, 75);
            CatNamn.Name = "CatNamn";
            CatNamn.Size = new Size(100, 23);
            CatNamn.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 102);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 57);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Namn";
            // 
            // Namn
            // 
            Namn.AutoSize = true;
            Namn.Location = new Point(1320, 57);
            Namn.Name = "Namn";
            Namn.Size = new Size(40, 15);
            Namn.TabIndex = 9;
            Namn.Text = "Namn";
            // 
            // LaggTillCat
            // 
            LaggTillCat.Location = new Point(1227, 120);
            LaggTillCat.Name = "LaggTillCat";
            LaggTillCat.Size = new Size(75, 23);
            LaggTillCat.TabIndex = 10;
            LaggTillCat.Text = "Lägg Till";
            LaggTillCat.UseVisualStyleBackColor = true;
            LaggTillCat.Click += LaggTillCat_Click;
            // 
            // BortCat
            // 
            BortCat.Location = new Point(1308, 120);
            BortCat.Name = "BortCat";
            BortCat.Size = new Size(75, 23);
            BortCat.TabIndex = 11;
            BortCat.Text = "Ta Bort";
            BortCat.UseVisualStyleBackColor = true;
            BortCat.Click += BortCat_Click;
            // 
            // AndraCat
            // 
            AndraCat.Location = new Point(1389, 120);
            AndraCat.Name = "AndraCat";
            AndraCat.Size = new Size(75, 23);
            AndraCat.TabIndex = 12;
            AndraCat.Text = "Ändra";
            AndraCat.UseVisualStyleBackColor = true;
            AndraCat.Click += AndraCat_Click;
            // 
            // PodBox
            // 
            PodBox.FormattingEnabled = true;
            PodBox.ItemHeight = 15;
            PodBox.Location = new Point(26, 207);
            PodBox.Name = "PodBox";
            PodBox.Size = new Size(527, 424);
            PodBox.TabIndex = 13;
            PodBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CatBox
            // 
            CatBox.FormattingEnabled = true;
            CatBox.ItemHeight = 15;
            CatBox.Location = new Point(1227, 158);
            CatBox.Name = "CatBox";
            CatBox.Size = new Size(237, 124);
            CatBox.TabIndex = 14;
            // 
            // InfoBox
            // 
            InfoBox.FormattingEnabled = true;
            InfoBox.ItemHeight = 15;
            InfoBox.Location = new Point(999, 324);
            InfoBox.Name = "InfoBox";
            InfoBox.Size = new Size(465, 304);
            InfoBox.TabIndex = 15;
            // 
            // EpBox
            // 
            EpBox.FormattingEnabled = true;
            EpBox.ItemHeight = 15;
            EpBox.Location = new Point(589, 207);
            EpBox.Name = "EpBox";
            EpBox.Size = new Size(346, 424);
            EpBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(391, 167);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 17;
            label4.Text = "Podd Lista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(726, 165);
            label5.Name = "label5";
            label5.Size = new Size(69, 27);
            label5.TabIndex = 18;
            label5.Text = "Avsnitt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1004, 286);
            label6.Name = "label6";
            label6.Size = new Size(46, 27);
            label6.TabIndex = 19;
            label6.Text = "Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1296, 22);
            label7.Name = "label7";
            label7.Size = new Size(95, 27);
            label7.TabIndex = 20;
            label7.Text = "Kategorier";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(160, 33);
            label8.TabIndex = 21;
            label8.Text = "PoddCollector";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 102);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 22;
            label3.Text = "Kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 652);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EpBox);
            Controls.Add(InfoBox);
            Controls.Add(CatBox);
            Controls.Add(PodBox);
            Controls.Add(AndraCat);
            Controls.Add(BortCat);
            Controls.Add(LaggTillCat);
            Controls.Add(Namn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CatNamn);
            Controls.Add(PodNamn);
            Controls.Add(URL);
            Controls.Add(AndraPod);
            Controls.Add(BortPod);
            Controls.Add(LaggTillPod);
            Controls.Add(ComboCat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboCat;
        private Button LaggTillPod;
        private Button BortPod;
        private Button AndraPod;
        private TextBox URL;
        private TextBox PodNamn;
        private TextBox CatNamn;
        private Label label1;
        private Label label2;
        private Label Namn;
        private Button LaggTillCat;
        private Button BortCat;
        private Button AndraCat;
        private ListBox PodBox;
        private ListBox CatBox;
        private ListBox InfoBox;
        private ListBox EpBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
    }
}