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
    public partial class FormUsers : Form
    {
        private User _user = new User();
        private BindingSource _databindingsource = new BindingSource();
        public FormUsers()
        {
      
            InitializeComponent();
            _databindingsource.DataSource = _user.GetUsers();
         
        }

     
        private void FormUsers_Load(object sender, EventArgs e)
        {
           
            DataGridViewUsers.DataSource = _databindingsource;
            DataGridViewImageColumn deletebutton = new DataGridViewImageColumn();
            DataGridViewImageColumn updatebutton = new DataGridViewImageColumn();
            deletebutton.Image = Image.FromFile(@"C:\Users\astudent\Desktop\delete.png");
            updatebutton.Image = Image.FromFile(@"C:\Users\astudent\Desktop\refresh.png");
            deletebutton.Width = 20;
            updatebutton.Width = 20;
            deletebutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            updatebutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
            DataGridViewUsers.Columns.Add(deletebutton);
            DataGridViewUsers.Columns.Add(updatebutton);
        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex!= -1)
            {
                FormEditUser FormEditUser = new FormEditUser();
                FormEditUser.lblEditUserId.Text =DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = 
        DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text =
        DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text =
        DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text =
        DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();
            }
        }
    }
}
