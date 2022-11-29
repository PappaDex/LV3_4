using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace FormTester
{
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {

            InitializeComponent();
        }

        private void lblEditUserName_Click(object sender, EventArgs e)
        {
            
        }

        private void lblEditLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserID = Int32.Parse(lblEditUserId.Text);
            user.UserFirstName = inptEditName.Text;
            user.UserLastName = inptEditSurname.Text;
            user.UserPassword = inptEditPassword.Text;
            user.UserName = lblEditUserName.Text;
            this.Hide();
            user.UpdateUsers(user);
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblEditUserId_Click(object sender, EventArgs e)
        {

        }
    }
}
