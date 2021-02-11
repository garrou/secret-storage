
namespace SecretStorage.src.forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastConnectionLabel = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(178, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 26);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Nom : ";
            // 
            // LastConnectionLabel
            // 
            this.LastConnectionLabel.AutoSize = true;
            this.LastConnectionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastConnectionLabel.Location = new System.Drawing.Point(178, 47);
            this.LastConnectionLabel.Name = "LastConnectionLabel";
            this.LastConnectionLabel.Size = new System.Drawing.Size(199, 26);
            this.LastConnectionLabel.TabIndex = 4;
            this.LastConnectionLabel.Text = "Dernière connexion : ";
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsLabel.Location = new System.Drawing.Point(78, 265);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(62, 19);
            this.OptionsLabel.TabIndex = 16;
            this.OptionsLabel.Text = "Options";
            this.OptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecretStorage.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(48, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnUpdateProfile
            // 
            this.BtnUpdateProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProfile.Image = global::SecretStorage.Properties.Resources.pen;
            this.BtnUpdateProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateProfile.Location = new System.Drawing.Point(12, 183);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(160, 35);
            this.BtnUpdateProfile.TabIndex = 1;
            this.BtnUpdateProfile.Text = "Modifier le profil";
            this.BtnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdateProfile.UseVisualStyleBackColor = true;
            this.BtnUpdateProfile.Click += new System.EventHandler(this.BtnUpdateProfile_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.Image = global::SecretStorage.Properties.Resources.logout;
            this.DisconnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconnectBtn.Location = new System.Drawing.Point(812, 12);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(160, 35);
            this.DisconnectBtn.TabIndex = 2;
            this.DisconnectBtn.Text = "Se déconnecter";
            this.DisconnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = global::SecretStorage.Properties.Resources.user;
            this.ProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.InitialImage")));
            this.ProfilePicture.Location = new System.Drawing.Point(12, 17);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(160, 160);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.LastConnectionLabel);
            this.Controls.Add(this.BtnUpdateProfile);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Utilisateur";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.UserForm_Closing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Label LastConnectionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OptionsLabel;
    }
}