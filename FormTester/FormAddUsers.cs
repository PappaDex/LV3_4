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
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName !=null && textBoxLastName !=null && textBoxPassword!=null &&textBoxUsername!= null)
            {

                User newuser = new User();
                newuser.UserFirstName = textBoxFirstName.Text;
                newuser.UserLastName = textBoxLastName.Text;
                newuser.UserName = textBoxUsername.Text;
                newuser.UserPassword = textBoxPassword.Text;
                newuser.UserID = Int32.Parse(lblidNumber.Text);
                newuser.AddUser(newuser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the data!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
