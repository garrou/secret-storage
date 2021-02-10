
namespace SecretStorage.src.forms
{
    /// <summary>
    /// Admin windows form
    /// </summary>
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Title = new System.Windows.Forms.Label();
            this.UserListView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.LastConnectionLabel = new System.Windows.Forms.Label();
            this.UpdateProfileBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateUserBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.Disconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(374, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 42);
            this.Title.TabIndex = 2;
            this.Title.Text = "Administrateur";
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NameColumn});
            this.UserListView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(672, 150);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(300, 400);
            this.UserListView.TabIndex = 6;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 150;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nom";
            this.NameColumn.Width = 150;
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersLabel.Location = new System.Drawing.Point(788, 121);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(110, 26);
            this.UsersLabel.TabIndex = 7;
            this.UsersLabel.Text = "Utilisateurs";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(183, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 26);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Nom : ";
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsLabel.Location = new System.Drawing.Point(79, 304);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(62, 19);
            this.OptionsLabel.TabIndex = 12;
            this.OptionsLabel.Text = "Options";
            this.OptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastConnectionLabel
            // 
            this.LastConnectionLabel.AutoSize = true;
            this.LastConnectionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastConnectionLabel.Location = new System.Drawing.Point(183, 107);
            this.LastConnectionLabel.Name = "LastConnectionLabel";
            this.LastConnectionLabel.Size = new System.Drawing.Size(199, 26);
            this.LastConnectionLabel.TabIndex = 18;
            this.LastConnectionLabel.Text = "Dernière connexion : ";
            // 
            // UpdateProfileBtn
            // 
            this.UpdateProfileBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfileBtn.Image = global::SecretStorage.Properties.Resources.pen;
            this.UpdateProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProfileBtn.Location = new System.Drawing.Point(17, 236);
            this.UpdateProfileBtn.Name = "UpdateProfileBtn";
            this.UpdateProfileBtn.Size = new System.Drawing.Size(160, 35);
            this.UpdateProfileBtn.TabIndex = 19;
            this.UpdateProfileBtn.Text = "Modifier profil";
            this.UpdateProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateProfileBtn.UseVisualStyleBackColor = true;
            this.UpdateProfileBtn.Click += new System.EventHandler(this.UpdatProfileBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecretStorage.Properties.Resources.users;
            this.pictureBox2.Location = new System.Drawing.Point(758, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecretStorage.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(49, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateUserBtn
            // 
            this.UpdateUserBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserBtn.Image = global::SecretStorage.Properties.Resources.pen;
            this.UpdateUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateUserBtn.Location = new System.Drawing.Point(17, 437);
            this.UpdateUserBtn.Name = "UpdateUserBtn";
            this.UpdateUserBtn.Size = new System.Drawing.Size(160, 35);
            this.UpdateUserBtn.TabIndex = 14;
            this.UpdateUserBtn.Text = "Modifier utilisateur";
            this.UpdateUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateUserBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.Image = global::SecretStorage.Properties.Resources.delete;
            this.DeleteUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUserBtn.Location = new System.Drawing.Point(17, 384);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(160, 35);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Supprimer utilisateur";
            this.DeleteUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddUserBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddUserBtn.Image")));
            this.AddUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserBtn.Location = new System.Drawing.Point(17, 337);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(160, 35);
            this.AddUserBtn.TabIndex = 11;
            this.AddUserBtn.Text = "Ajouter utilisateur";
            this.AddUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.InitialImage = null;
            this.ProfilePicture.Location = new System.Drawing.Point(17, 70);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(160, 160);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 9;
            this.ProfilePicture.TabStop = false;
            // 
            // Disconnect
            // 
            this.Disconnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.Image = global::SecretStorage.Properties.Resources.logout;
            this.Disconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Disconnect.Location = new System.Drawing.Point(826, 12);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(150, 35);
            this.Disconnect.TabIndex = 0;
            this.Disconnect.Text = "Se déconnecter";
            this.Disconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.UpdateProfileBtn);
            this.Controls.Add(this.LastConnectionLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateUserBtn);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Disconnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.AdminForm_Closing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Button UpdateUserBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LastConnectionLabel;
        private System.Windows.Forms.Button UpdateProfileBtn;
    }
}