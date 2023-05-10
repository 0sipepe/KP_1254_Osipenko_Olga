namespace Questions
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DontLikeSpid = new System.Windows.Forms.RadioButton();
            this.LikeSpid = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Gr = new System.Windows.Forms.ComboBox();
            this.Answers = new System.Windows.Forms.ListBox();
            this.saveAnsw = new System.Windows.Forms.Button();
            this.fromFile = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SelfInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DontLikeScorps = new System.Windows.Forms.RadioButton();
            this.LikeScorps = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.Gen = new System.Windows.Forms.DomainUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DontLikeSpid);
            this.groupBox1.Controls.Add(this.LikeSpid);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "6. Любите ли Вы пауков?";
            // 
            // DontLikeSpid
            // 
            this.DontLikeSpid.AutoSize = true;
            this.DontLikeSpid.Location = new System.Drawing.Point(12, 69);
            this.DontLikeSpid.Name = "DontLikeSpid";
            this.DontLikeSpid.Size = new System.Drawing.Size(51, 20);
            this.DontLikeSpid.TabIndex = 14;
            this.DontLikeSpid.TabStop = true;
            this.DontLikeSpid.Text = "нет";
            this.DontLikeSpid.UseVisualStyleBackColor = true;
            // 
            // LikeSpid
            // 
            this.LikeSpid.AutoSize = true;
            this.LikeSpid.Location = new System.Drawing.Point(12, 43);
            this.LikeSpid.Name = "LikeSpid";
            this.LikeSpid.Size = new System.Drawing.Size(44, 20);
            this.LikeSpid.TabIndex = 15;
            this.LikeSpid.TabStop = true;
            this.LikeSpid.Text = "да";
            this.LikeSpid.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(13, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 201);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Какие выиды пауков были Вам известны?";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 175);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(117, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "паук-бродяга";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 136);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "косеножка";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "тарантул";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "черная вдова";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(12, 84);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(189, 22);
            this.Surname.TabIndex = 0;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(12, 32);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(189, 22);
            this.Name1.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(143, 143);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(58, 22);
            this.Age.TabIndex = 80;
            this.Age.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Gr
            // 
            this.Gr.FormattingEnabled = true;
            this.Gr.Items.AddRange(new object[] {
            "1251",
            "1251",
            "1253",
            "1254",
            "1255",
            "1011",
            "1012",
            "1013",
            "1014",
            "1015"});
            this.Gr.Location = new System.Drawing.Point(12, 143);
            this.Gr.Name = "Gr";
            this.Gr.Size = new System.Drawing.Size(105, 24);
            this.Gr.TabIndex = 4;
            // 
            // Answers
            // 
            this.Answers.FormattingEnabled = true;
            this.Answers.ItemHeight = 16;
            this.Answers.Location = new System.Drawing.Point(406, 245);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(327, 196);
            this.Answers.TabIndex = 0;
            this.Answers.SelectedIndexChanged += new System.EventHandler(this.Answers_SelectedIndexChanged_1);
            // 
            // saveAnsw
            // 
            this.saveAnsw.Location = new System.Drawing.Point(227, 247);
            this.saveAnsw.Name = "saveAnsw";
            this.saveAnsw.Size = new System.Drawing.Size(152, 45);
            this.saveAnsw.TabIndex = 9;
            this.saveAnsw.Text = "сохранить результаты";
            this.saveAnsw.UseVisualStyleBackColor = true;
            this.saveAnsw.Click += new System.EventHandler(this.saveAnsw_Click);
            // 
            // fromFile
            // 
            this.fromFile.Location = new System.Drawing.Point(227, 390);
            this.fromFile.Name = "fromFile";
            this.fromFile.Size = new System.Drawing.Size(152, 49);
            this.fromFile.TabIndex = 10;
            this.fromFile.Text = "загрузить из файла";
            this.fromFile.UseVisualStyleBackColor = true;
            this.fromFile.Click += new System.EventHandler(this.fromFile_Click);
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(227, 298);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(152, 46);
            this.auto.TabIndex = 11;
            this.auto.Text = "заполнить  автоматически";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(128, 186);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(73, 42);
            this.reset.TabIndex = 12;
            this.reset.Text = "сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // SelfInfo
            // 
            this.SelfInfo.Location = new System.Drawing.Point(12, 247);
            this.SelfInfo.Name = "SelfInfo";
            this.SelfInfo.Size = new System.Drawing.Size(189, 137);
            this.SelfInfo.TabIndex = 13;
            this.SelfInfo.Text = " ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DontLikeScorps);
            this.groupBox5.Controls.Add(this.LikeScorps);
            this.groupBox5.Location = new System.Drawing.Point(15, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(161, 100);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "7. Любите ли Вы скорпионов?";
            // 
            // DontLikeScorps
            // 
            this.DontLikeScorps.AutoSize = true;
            this.DontLikeScorps.Location = new System.Drawing.Point(6, 74);
            this.DontLikeScorps.Name = "DontLikeScorps";
            this.DontLikeScorps.Size = new System.Drawing.Size(51, 20);
            this.DontLikeScorps.TabIndex = 14;
            this.DontLikeScorps.TabStop = true;
            this.DontLikeScorps.Text = "нет";
            this.DontLikeScorps.UseVisualStyleBackColor = true;
            // 
            // LikeScorps
            // 
            this.LikeScorps.AutoSize = true;
            this.LikeScorps.Location = new System.Drawing.Point(6, 48);
            this.LikeScorps.Name = "LikeScorps";
            this.LikeScorps.Size = new System.Drawing.Size(44, 20);
            this.LikeScorps.TabIndex = 15;
            this.LikeScorps.TabStop = true;
            this.LikeScorps.Text = "да";
            this.LikeScorps.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Location = new System.Drawing.Point(165, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 201);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Какие виды скорпионов были Вам известны?";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 175);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(78, 20);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "желтый";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(6, 136);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(90, 20);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "диктатор";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 101);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(90, 20);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "яванский";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 61);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(131, 20);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "императорский";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // Gen
            // 
            this.Gen.Items.Add("male");
            this.Gen.Items.Add("female");
            this.Gen.Location = new System.Drawing.Point(12, 202);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(98, 22);
            this.Gen.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(218, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 224);
            this.panel1.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(413, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 224);
            this.panel2.TabIndex = 82;
            // 
            // toFile
            // 
            this.toFile.Location = new System.Drawing.Point(227, 345);
            this.toFile.Name = "toFile";
            this.toFile.Size = new System.Drawing.Size(152, 39);
            this.toFile.TabIndex = 83;
            this.toFile.Text = "загрузить в файл";
            this.toFile.UseVisualStyleBackColor = true;
            this.toFile.Click += new System.EventHandler(this.toFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/81W-ySAOUAL" +
    ".jpg";
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(12, 417);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(189, 22);
            this.fileName.TabIndex = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 451);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.toFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.SelfInfo);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.fromFile);
            this.Controls.Add(this.saveAnsw);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.Gr);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Gr;
        private System.Windows.Forms.ListBox Answers;
        private System.Windows.Forms.Button saveAnsw;
        private System.Windows.Forms.Button fromFile;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.RichTextBox SelfInfo;
        private System.Windows.Forms.RadioButton LikeSpid;
        private System.Windows.Forms.RadioButton DontLikeSpid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton DontLikeScorps;
        private System.Windows.Forms.RadioButton LikeScorps;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.DomainUpDown Gen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button toFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fileName;
    }
}

