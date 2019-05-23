namespace VernamCipher
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
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.OpenEncryptButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenKeyButton = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.GoToDecryptButton = new System.Windows.Forms.Button();
            this.DeleteAllDataButton = new System.Windows.Forms.Button();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SelectFileButton.Location = new System.Drawing.Point(12, 12);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(100, 50);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Select a file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EncryptButton.Location = new System.Drawing.Point(273, 12);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(100, 50);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AboutButton.Location = new System.Drawing.Point(12, 244);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(100, 50);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // OpenEncryptButton
            // 
            this.OpenEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OpenEncryptButton.Location = new System.Drawing.Point(411, 12);
            this.OpenEncryptButton.Name = "OpenEncryptButton";
            this.OpenEncryptButton.Size = new System.Drawing.Size(100, 50);
            this.OpenEncryptButton.TabIndex = 5;
            this.OpenEncryptButton.Text = "Open encrypt";
            this.OpenEncryptButton.UseVisualStyleBackColor = true;
            this.OpenEncryptButton.Click += new System.EventHandler(this.OpenEncryptButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(588, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 20);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenKeyButton
            // 
            this.OpenKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OpenKeyButton.Location = new System.Drawing.Point(548, 12);
            this.OpenKeyButton.Name = "OpenKeyButton";
            this.OpenKeyButton.Size = new System.Drawing.Size(100, 50);
            this.OpenKeyButton.TabIndex = 7;
            this.OpenKeyButton.Text = "Open key";
            this.OpenKeyButton.UseVisualStyleBackColor = true;
            this.OpenKeyButton.Click += new System.EventHandler(this.OpenKeyButton_Click);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.InstructionButton.Location = new System.Drawing.Point(273, 244);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(100, 50);
            this.InstructionButton.TabIndex = 8;
            this.InstructionButton.Text = "Instruction";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // GoToDecryptButton
            // 
            this.GoToDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoToDecryptButton.Location = new System.Drawing.Point(548, 123);
            this.GoToDecryptButton.Name = "GoToDecryptButton";
            this.GoToDecryptButton.Size = new System.Drawing.Size(100, 50);
            this.GoToDecryptButton.TabIndex = 9;
            this.GoToDecryptButton.Text = "Go to decrypt";
            this.GoToDecryptButton.UseVisualStyleBackColor = true;
            this.GoToDecryptButton.Click += new System.EventHandler(this.GoToDecryptButton_Click);
            // 
            // DeleteAllDataButton
            // 
            this.DeleteAllDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DeleteAllDataButton.Location = new System.Drawing.Point(273, 123);
            this.DeleteAllDataButton.Name = "DeleteAllDataButton";
            this.DeleteAllDataButton.Size = new System.Drawing.Size(100, 50);
            this.DeleteAllDataButton.TabIndex = 10;
            this.DeleteAllDataButton.Text = "Delete all data";
            this.DeleteAllDataButton.UseVisualStyleBackColor = true;
            this.DeleteAllDataButton.Click += new System.EventHandler(this.DeleteAllDataButton_Click);
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GenerateKeyButton.Location = new System.Drawing.Point(145, 12);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(100, 50);
            this.GenerateKeyButton.TabIndex = 11;
            this.GenerateKeyButton.Text = "Generate key";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 306);
            this.Controls.Add(this.GenerateKeyButton);
            this.Controls.Add(this.DeleteAllDataButton);
            this.Controls.Add(this.GoToDecryptButton);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.OpenKeyButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenEncryptButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.SelectFileButton);
            this.Name = "Form1";
            this.Text = "Vernam Cipher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button OpenEncryptButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenKeyButton;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button GoToDecryptButton;
        private System.Windows.Forms.Button DeleteAllDataButton;
        private System.Windows.Forms.Button GenerateKeyButton;
    }
}

