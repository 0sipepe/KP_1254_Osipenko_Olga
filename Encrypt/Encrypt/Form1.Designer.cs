namespace Encrypt
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lbEncryptors = new System.Windows.Forms.ListBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbCommand = new System.Windows.Forms.ListBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(16, 183);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(437, 41);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "button1";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lbEncryptors
            // 
            this.lbEncryptors.FormattingEnabled = true;
            this.lbEncryptors.ItemHeight = 16;
            this.lbEncryptors.Items.AddRange(new object[] {
            "increment",
            "decrement",
            "zero",
            "negative"});
            this.lbEncryptors.Location = new System.Drawing.Point(16, 77);
            this.lbEncryptors.Name = "lbEncryptors";
            this.lbEncryptors.Size = new System.Drawing.Size(181, 100);
            this.lbEncryptors.TabIndex = 1;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(16, 29);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(437, 42);
            this.tbText.TabIndex = 2;
            // 
            // lbCommand
            // 
            this.lbCommand.FormattingEnabled = true;
            this.lbCommand.ItemHeight = 16;
            this.lbCommand.Location = new System.Drawing.Point(272, 77);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(181, 100);
            this.lbCommand.TabIndex = 3;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(16, 326);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(437, 41);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "button2";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.Location = new System.Drawing.Point(16, 230);
            this.tbEncrypted.Multiline = true;
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(437, 42);
            this.tbEncrypted.TabIndex = 5;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(16, 278);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(437, 42);
            this.tbKey.TabIndex = 6;
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(16, 373);
            this.tbDecrypted.Multiline = true;
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(437, 42);
            this.tbDecrypted.TabIndex = 7;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Location = new System.Drawing.Point(203, 77);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(63, 44);
            this.btnAddCommand.TabIndex = 8;
            this.btnAddCommand.Text = "button3";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Location = new System.Drawing.Point(203, 137);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(63, 40);
            this.btnRemoveCommand.TabIndex = 9;
            this.btnRemoveCommand.Text = "button4";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            this.btnRemoveCommand.Click += new System.EventHandler(this.btnRemoveCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 439);
            this.Controls.Add(this.btnRemoveCommand);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.tbDecrypted);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbEncrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbCommand);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lbEncryptors);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.ListBox lbEncryptors;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox lbCommand;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbEncrypted;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Button btnRemoveCommand;
    }
}

