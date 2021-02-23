
namespace SecretStorage.src.forms.admin
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
            this.UsersLabel = new System.Windows.Forms.Label();
            this.UsersListView = new System.Windows.Forms.ListView();
            this.ComboBoxId = new System.Windows.Forms.ComboBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfPassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.ConfPassTextBox = new System.Windows.Forms.TextBox();
            this.ValidBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersLabel.Location = new System.Drawing.Point(87, 35);
            this.UsersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(110, 26);
            this.UsersLabel.TabIndex = 1;
            this.UsersLabel.Text = "Utilisateurs";
            // 
            // UsersListView
            // 
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName});
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(25, 75);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(250, 320);
            this.UsersListView.TabIndex = 2;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            // 
            // ComboBoxId
            // 
            this.ComboBoxId.FormattingEnabled = true;
            this.ComboBoxId.Location = new System.Drawing.Point(601, 152);
            this.ComboBoxId.Name = "ComboBoxId";
            this.ComboBoxId.Size = new System.Drawing.Size(130, 31);
            this.ComboBoxId.TabIndex = 3;
            this.ComboBoxId.Text = "1";
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelId.Location = new System.Drawing.Point(342, 157);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(103, 26);
            this.LabelId.TabIndex = 4;
            this.LabelId.Text = "Identifiant";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(342, 221);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 26);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // ConfPassLabel
            // 
            this.ConfPassLabel.AutoSize = true;
            this.ConfPassLabel.Location = new System.Drawing.Point(343, 286);
            this.ConfPassLabel.Name = "ConfPassLabel";
            this.ConfPassLabel.Size = new System.Drawing.Size(218, 23);
            this.ConfPassLabel.TabIndex = 8;
            this.ConfPassLabel.Text = "Confirmer le mot de passe";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Enabled = false;
            this.PassTextBox.Location = new System.Drawing.Point(601, 216);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(277, 31);
            this.PassTextBox.TabIndex = 9;
            // 
            // ConfPassTextBox
            // 
            this.ConfPassTextBox.Enabled = false;
            this.ConfPassTextBox.Location = new System.Drawing.Point(601, 278);
            this.ConfPassTextBox.Name = "ConfPassTextBox";
            this.ConfPassTextBox.PasswordChar = '*';
            this.ConfPassTextBox.Size = new System.Drawing.Size(277, 31);
            this.ConfPassTextBox.TabIndex = 10;
            // 
            // ValidBtn
            // 
            this.ValidBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ValidBtn.Enabled = false;
            this.ValidBtn.ForeColor = System.Drawing.Color.White;
            this.ValidBtn.Image = global::SecretStorage.Properties.Resources.check_mark;
            this.ValidBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValidBtn.Location = new System.Drawing.Point(778, 355);
            this.ValidBtn.Name = "ValidBtn";
            this.ValidBtn.Size = new System.Drawing.Size(100, 40);
            this.ValidBtn.TabIndex = 11;
            this.ValidBtn.Text = "Valider";
            this.ValidBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidBtn.UseVisualStyleBackColor = false;
            this.ValidBtn.Click += new System.EventHandler(this.ValidBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Image = global::SecretStorage.Properties.Resources.delete;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.Location = new System.Drawing.Point(347, 75);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 40);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Image = global::SecretStorage.Properties.Resources.pen;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(601, 75);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 40);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(487, 364);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(74, 23);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Action : ";
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 125;
            // 
            // columnName
            // 
            this.columnName.Text = "Nom";
            this.columnName.Width = 125;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ValidBtn);
            this.Controls.Add(this.ConfPassTextBox);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.ConfPassLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.ComboBoxId);
            this.Controls.Add(this.UsersListView);
            this.Controls.Add(this.UsersLabel);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "UpdateUserForm";
            this.Text = "Modifier les utilisateurs";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ComboBox ComboBoxId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfPassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox ConfPassTextBox;
        private System.Windows.Forms.Button ValidBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}