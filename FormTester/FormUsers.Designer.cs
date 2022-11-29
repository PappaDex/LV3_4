
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
            this.components = new System.ComponentModel.Container();
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIzlaz = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripPomoc = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripHelp = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripAddUser = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.DataGridViewUsers.Location = new System.Drawing.Point(0, 30);
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
            // toolStripIzbornik
            // 
            this.toolStripIzbornik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripIzbornik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIzlaz,
            this.toolStripPomoc,
            this.toolStripHelp});
            this.toolStripIzbornik.Name = "toolStripIzbornik";
            this.toolStripIzbornik.Size = new System.Drawing.Size(61, 23);
            this.toolStripIzbornik.Text = "Izbornik";
            // 
            // toolStripIzlaz
            // 
            this.toolStripIzlaz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripIzlaz.Name = "toolStripIzlaz";
            this.toolStripIzlaz.Size = new System.Drawing.Size(100, 23);
            this.toolStripIzlaz.Text = "Izlaz";
            this.toolStripIzlaz.Click += new System.EventHandler(this.toolStripIzlaz_Click);
            // 
            // toolStripPomoc
            // 
            this.toolStripPomoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPomoc.Name = "toolStripPomoc";
            this.toolStripPomoc.Size = new System.Drawing.Size(100, 23);
            this.toolStripPomoc.Text = "Pomoc";
            this.toolStripPomoc.Click += new System.EventHandler(this.toolStripPomoc_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(100, 23);
            this.toolStripHelp.Text = "O programu";
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIzbornik,
            this.toolStripAddUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripAddUser
            // 
            this.toolStripAddUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripAddUser.Name = "toolStripAddUser";
            this.toolStripAddUser.Size = new System.Drawing.Size(100, 23);
            this.toolStripAddUser.Text = "Dodaj Korisnika";
            this.toolStripAddUser.Click += new System.EventHandler(this.toolStripAddUser_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 51);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Dodaj Korisnika";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click_1);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DataGridViewUsers);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.ToolStripMenuItem toolStripIzbornik;
        private System.Windows.Forms.ToolStripTextBox toolStripIzlaz;
        private System.Windows.Forms.ToolStripTextBox toolStripPomoc;
        private System.Windows.Forms.ToolStripTextBox toolStripHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripAddUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

