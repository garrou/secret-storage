
namespace SecretStorage.src.forms.admin
{
    partial class UpdateAdminForm
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
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UpdateProfilePictureBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(58, 276);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.PasswordChar = '*';
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(324, 27);
            this.ConfirmPassTextBox.TabIndex = 20;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(53, 247);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(240, 26);
            this.ConfirmPassLabel.TabIndex = 19;
            this.ConfirmPassLabel.Text = "Confirmer le mot de passe";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(58, 186);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(324, 27);
            this.PasswordTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(58, 102);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(324, 27);
            this.NameTextBox.TabIndex = 17;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(53, 157);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 26);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(53, 73);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 26);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Nom";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(207, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(266, 42);
            this.TitleLabel.TabIndex = 22;
            this.TitleLabel.Text = "Modifier le profil";
            // 
            // UpdateProfilePictureBtn
            // 
            this.UpdateProfilePictureBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfilePictureBtn.Image = global::SecretStorage.Properties.Resources.pen;
            this.UpdateProfilePictureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProfilePictureBtn.Location = new System.Drawing.Point(458, 268);
            this.UpdateProfilePictureBtn.Name = "UpdateProfilePictureBtn";
            this.UpdateProfilePictureBtn.Size = new System.Drawing.Size(160, 35);
            this.UpdateProfilePictureBtn.TabIndex = 23;
            this.UpdateProfilePictureBtn.Text = "Modifier photo";
            this.UpdateProfilePictureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateProfilePictureBtn.UseVisualStyleBackColor = true;
            this.UpdateProfilePictureBtn.Click += new System.EventHandler(this.UpdateProfileBtn_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = global::SecretStorage.Properties.Resources.user;
            this.ProfilePicture.Location = new System.Drawing.Point(458, 102);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(160, 160);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 21;
            this.ProfilePicture.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Image = global::SecretStorage.Properties.Resources.save;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(286, 364);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 35);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateAdminForm
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
            this.Name = "UpdateAdminForm";
            this.Text = "UpdateAdminForm";
            this.Closed += new System.EventHandler(this.UpdateAdminForm_Closed);
            this.Load += new System.EventHandler(this.UpdateAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfirmPassTextBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button UpdateProfilePictureBtn;
    }
}