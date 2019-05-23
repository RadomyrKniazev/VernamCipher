namespace VernamCipher
{
    partial class Form2
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
            this.CheckFilesButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.OpenDecryptButton = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GoToEncryptButton = new System.Windows.Forms.Button();
            this.OpenEncryptButton = new System.Windows.Forms.Button();
            this.OpenKeyButton = new System.Windows.Forms.Button();
            this.DeleteAllDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckFilesButton
            // 
            this.CheckFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckFilesButton.Location = new System.Drawing.Point(279, 12);
            this.CheckFilesButton.Name = "CheckFilesButton";
            this.CheckFilesButton.Size = new System.Drawing.Size(100, 50);
            this.CheckFilesButton.TabIndex = 0;
            this.CheckFilesButton.Text = "Check files";
            this.CheckFilesButton.UseVisualStyleBackColor = true;
            this.CheckFilesButton.Click += new System.EventHandler(this.CheckFilesButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DecryptButton.Location = new System.Drawing.Point(410, 12);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(100, 50);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // OpenDecryptButton
            // 
            this.OpenDecryptButton.Enabled = false;
            this.OpenDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OpenDecryptButton.Location = new System.Drawing.Point(538, 12);
            this.OpenDecryptButton.Name = "OpenDecryptButton";
            this.OpenDecryptButton.Size = new System.Drawing.Size(100, 50);
            this.OpenDecryptButton.TabIndex = 2;
            this.OpenDecryptButton.Text = "Open decrypt";
            this.OpenDecryptButton.UseVisualStyleBackColor = true;
            this.OpenDecryptButton.Click += new System.EventHandler(this.OpenDecryptButton_Click);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.InstructionButton.Location = new System.Drawing.Point(279, 244);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(100, 50);
            this.InstructionButton.TabIndex = 3;
            this.InstructionButton.Text = "Instruction";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
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
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(588, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 20);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GoToEncryptButton
            // 
            this.GoToEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoToEncryptButton.Location = new System.Drawing.Point(538, 121);
            this.GoToEncryptButton.Name = "GoToEncryptButton";
            this.GoToEncryptButton.Size = new System.Drawing.Size(100, 50);
            this.GoToEncryptButton.TabIndex = 6;
            this.GoToEncryptButton.Text = "Go to encrypt";
            this.GoToEncryptButton.UseVisualStyleBackColor = true;
            this.GoToEncryptButton.Click += new System.EventHandler(this.GoToEncryptButton_Click);
            // 
            // OpenEncryptButton
            // 
            this.OpenEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OpenEncryptButton.Location = new System.Drawing.Point(12, 12);
            this.OpenEncryptButton.Name = "OpenEncryptButton";
            this.OpenEncryptButton.Size = new System.Drawing.Size(100, 50);
            this.OpenEncryptButton.TabIndex = 7;
            this.OpenEncryptButton.Text = "Open encrypt";
            this.OpenEncryptButton.UseVisualStyleBackColor = true;
            this.OpenEncryptButton.Click += new System.EventHandler(this.OpenEncryptButton_Click);
            // 
            // OpenKeyButton
            // 
            this.OpenKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OpenKeyButton.Location = new System.Drawing.Point(146, 12);
            this.OpenKeyButton.Name = "OpenKeyButton";
            this.OpenKeyButton.Size = new System.Drawing.Size(100, 50);
            this.OpenKeyButton.TabIndex = 8;
            this.OpenKeyButton.Text = "Open key";
            this.OpenKeyButton.UseVisualStyleBackColor = true;
            this.OpenKeyButton.Click += new System.EventHandler(this.OpenKeyButton_Click);
            // 
            // DeleteAllDataButton
            // 
            this.DeleteAllDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DeleteAllDataButton.Location = new System.Drawing.Point(279, 121);
            this.DeleteAllDataButton.Name = "DeleteAllDataButton";
            this.DeleteAllDataButton.Size = new System.Drawing.Size(100, 50);
            this.DeleteAllDataButton.TabIndex = 9;
            this.DeleteAllDataButton.Text = "Delete all data";
            this.DeleteAllDataButton.UseVisualStyleBackColor = true;
            this.DeleteAllDataButton.Click += new System.EventHandler(this.DeleteAllDataButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 306);
            this.Controls.Add(this.DeleteAllDataButton);
            this.Controls.Add(this.OpenKeyButton);
            this.Controls.Add(this.OpenEncryptButton);
            this.Controls.Add(this.GoToEncryptButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.OpenDecryptButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.CheckFilesButton);
            this.Name = "Form2";
            this.Text = "Decrypt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckFilesButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button OpenDecryptButton;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button GoToEncryptButton;
        private System.Windows.Forms.Button OpenEncryptButton;
        private System.Windows.Forms.Button OpenKeyButton;
        private System.Windows.Forms.Button DeleteAllDataButton;
    }
}