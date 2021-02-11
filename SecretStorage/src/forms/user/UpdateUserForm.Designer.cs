
namespace SecretStorage.src.forms.user
{
    partial class UpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UpdateProfilePictureBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(205, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(266, 42);
            this.TitleLabel.TabIndex = 32;
            this.TitleLabel.Text = "Modifier le profil";
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(56, 277);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.PasswordChar = '*';
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(324, 27);
            this.ConfirmPassTextBox.TabIndex = 3;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(51, 248);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(240, 26);
            this.ConfirmPassLabel.TabIndex = 29;
            this.ConfirmPassLabel.Text = "Confirmer le mot de passe";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(56, 187);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(324, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(56, 103);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(324, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(51, 158);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 26);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(51, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 26);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Nom";
            // 
            // UpdateProfilePictureBtn
            // 
            this.UpdateProfilePictureBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfilePictureBtn.Image = global::SecretStorage.Properties.Resources.pen;
            this.UpdateProfilePictureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProfilePictureBtn.Location = new System.Drawing.Point(456, 269);
            this.UpdateProfilePictureBtn.Name = "UpdateProfilePictureBtn";
            this.UpdateProfilePictureBtn.Size = new System.Drawing.Size(160, 35);
            this.UpdateProfilePictureBtn.TabIndex = 4;
            this.UpdateProfilePictureBtn.Text = "Modifier photo";
            this.UpdateProfilePictureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateProfilePictureBtn.UseVisualStyleBackColor = true;
            this.UpdateProfilePictureBtn.Click += new System.EventHandler(this.UpdateProfilePictureBtn_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = global::SecretStorage.Properties.Resources.user;
            this.ProfilePicture.Location = new System.Drawing.Point(456, 103);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(160, 160);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 31;
            this.ProfilePicture.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Image = global::SecretStorage.Properties.Resources.save;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(284, 365);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 35);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.UpdateProfilePictureBtn);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.ConfirmPassTextBox);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateUserForm";
            this.Text = "Modifier votre profil";
            this.Closed += new System.EventHandler(this.UpdateUserForm_Closed);
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateProfilePictureBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.TextBox ConfirmPassTextBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}