using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SocialNetwork.DAL;

namespace SocialNetwork.Forms
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private readonly UserPage newPage = new UserPage();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {

                string userId = ReturnUserId();//UsersDAL.CheckLogin(tbLogin.Text, tbPassword.Text);
                MessageBox.Show($"login was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newPage.FillInUserInformation(userId);
                newPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxLogin.Clear(); boxPassword.Clear();
            }
        }

        public string ReturnUserId()
        {
            return UserDAL.CheckLogin(boxLogin.Text, boxPassword.Text);
        }
    }
}
