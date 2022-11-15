
namespace FormTester
{
    partial class FormUsers
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
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserPassword,
            this.UserFirstName,
            this.UserLastName});
            this.DataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.Size = new System.Drawing.Size(788, 427);
            this.DataGridViewUsers.TabIndex = 0;
            this.DataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User";
            this.UserID.Name = "UserID";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Username";
            this.UserName.Name = "UserName";
            // 
            // UserPassword
            // 
            this.UserPassword.DataPropertyName = "UserPassword";
            this.UserPassword.HeaderText = "Password";
            this.UserPassword.Name = "UserPassword";
            // 
            // UserFirstName
            // 
            this.UserFirstName.DataPropertyName = "UserFirstName";
            this.UserFirstName.HeaderText = "Name";
            this.UserFirstName.Name = "UserFirstName";
            // 
            // UserLastName
            // 
            this.UserLastName.DataPropertyName = "UserLastName";
            this.UserLastName.HeaderText = "Surname";
            this.UserLastName.Name = "UserLastName";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewUsers);
            this.Name = "FormUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
    }
}

