
namespace SecretStorage.src.forms.user
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(81, 258);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.PasswordChar = '*';
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(324, 27);
            this.ConfirmPassTextBox.TabIndex = 3;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(76, 229);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(240, 26);
            this.ConfirmPassLabel.TabIndex = 20;
            this.ConfirmPassLabel.Text = "Confirmer le mot de passe";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(81, 175);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(324, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(81, 104);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(324, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(76, 146);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 26);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(76, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 26);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Nom";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(116, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(262, 42);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Créer un compte";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Image = global::SecretStorage.Properties.Resources.save;
            this.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBtn.Location = new System.Drawing.Point(154, 314);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(162, 35);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Créer un compte";
            this.CreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ConfirmPassTextBox);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.Text = "Ajouter un utilisateur";
            this.Closed += new System.EventHandler(this.NewUserForm_Closed);
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfirmPassTextBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}