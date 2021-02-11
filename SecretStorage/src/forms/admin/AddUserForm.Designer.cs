
namespace SecretStorage.src.forms.admin
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(79, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(331, 42);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Ajouter un utilisateur";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(77, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 26);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nom";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(77, 145);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 26);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::SecretStorage.Properties.Resources.add;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(190, 314);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 35);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(82, 103);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(324, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(82, 174);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(324, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(82, 257);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.PasswordChar = '*';
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(324, 27);
            this.ConfirmPassTextBox.TabIndex = 3;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(77, 228);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(240, 26);
            this.ConfirmPassLabel.TabIndex = 12;
            this.ConfirmPassLabel.Text = "Confirmer le mot de passe";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ConfirmPassTextBox);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.Text = "Ajouter un utilsateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPassTextBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
    }
}