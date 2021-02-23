
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
            this.PasswordListView = new System.Windows.Forms.ListView();
            this.SecretName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecretPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SavedPasswordLabel = new System.Windows.Forms.Label();
            this.BtnAddPassword = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
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
            // PasswordListView
            // 
            this.PasswordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SecretName,
            this.SecretPassword});
            this.PasswordListView.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordListView.GridLines = true;
            this.PasswordListView.HideSelection = false;
            this.PasswordListView.Location = new System.Drawing.Point(183, 279);
            this.PasswordListView.Name = "PasswordListView";
            this.PasswordListView.Size = new System.Drawing.Size(790, 270);
            this.PasswordListView.TabIndex = 5;
            this.PasswordListView.UseCompatibleStateImageBehavior = false;
            // 
            // SecretName
            // 
            this.SecretName.Text = "Nom du secret";
            this.SecretName.Width = 390;
            // 
            // SecretPassword
            // 
            this.SecretPassword.Text = "Mot de passe du secret";
            this.SecretPassword.Width = 390;
            // 
            // SavedPasswordLabel
            // 
            this.SavedPasswordLabel.AutoSize = true;
            this.SavedPasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedPasswordLabel.Location = new System.Drawing.Point(465, 239);
            this.SavedPasswordLabel.Name = "SavedPasswordLabel";
            this.SavedPasswordLabel.Size = new System.Drawing.Size(237, 26);
            this.SavedPasswordLabel.TabIndex = 6;
            this.SavedPasswordLabel.Text = "Mots de passe enregistrés";
            // 
            // BtnAddPassword
            // 
            this.BtnAddPassword.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAddPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPassword.ForeColor = System.Drawing.Color.White;
            this.BtnAddPassword.Image = global::SecretStorage.Properties.Resources.add;
            this.BtnAddPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddPassword.Location = new System.Drawing.Point(12, 230);
            this.BtnAddPassword.Name = "BtnAddPassword";
            this.BtnAddPassword.Size = new System.Drawing.Size(160, 35);
            this.BtnAddPassword.TabIndex = 7;
            this.BtnAddPassword.Text = "Ajouter un secret";
            this.BtnAddPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddPassword.UseVisualStyleBackColor = false;
            this.BtnAddPassword.Click += new System.EventHandler(this.BtnAddPassword_Click);
            // 
            // BtnUpdateProfile
            // 
            this.BtnUpdateProfile.BackColor = System.Drawing.Color.Gray;
            this.BtnUpdateProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateProfile.Image = global::SecretStorage.Properties.Resources.pen;
            this.BtnUpdateProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateProfile.Location = new System.Drawing.Point(12, 183);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(160, 35);
            this.BtnUpdateProfile.TabIndex = 1;
            this.BtnUpdateProfile.Text = "Modifier le profil";
            this.BtnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdateProfile.UseVisualStyleBackColor = false;
            this.BtnUpdateProfile.Click += new System.EventHandler(this.BtnUpdateProfile_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackColor = System.Drawing.Color.Gray;
            this.DisconnectBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.White;
            this.DisconnectBtn.Image = global::SecretStorage.Properties.Resources.logout;
            this.DisconnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconnectBtn.Location = new System.Drawing.Point(812, 12);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(160, 35);
            this.DisconnectBtn.TabIndex = 2;
            this.DisconnectBtn.Text = "Se déconnecter";
            this.DisconnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisconnectBtn.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.BtnAddPassword);
            this.Controls.Add(this.SavedPasswordLabel);
            this.Controls.Add(this.PasswordListView);
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
        private System.Windows.Forms.ListView PasswordListView;
        private System.Windows.Forms.Label SavedPasswordLabel;
        private System.Windows.Forms.Button BtnAddPassword;
        private System.Windows.Forms.ColumnHeader SecretName;
        private System.Windows.Forms.ColumnHeader SecretPassword;
    }
}