using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialNetwork.DAL;

namespace SocialNetwork.Forms
{
    public partial class UserPage : Form
    {
        private string currentId;
        public UserPage()
        {
            InitializeComponent();
        }
        public void FillInUserInformation(string userId)
        {
            currentId = userId;
        }
        private void posts_SelectionChanged(object sender, EventArgs e)
        {
            var comms = posts.SelectedRows[0];
            comments.DataSource = CommentDAL.GetPostComments(comms.Cells[0].Value.ToString());
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            reload_data(sender, e);
            reload_friends(sender, e);
            friends.DataSource = UserDAL.GetUsers();
        }

        private void reload_data(object sender, EventArgs e)
        {
            posts.DataSource = PostDAL.GetSortedPosts();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            friends.DataSource = UserDAL.GetFriends(currentId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDAL.NewFriend(currentId, boxFriend.Text.ToString());
            reload_friends(sender, e);
        }

        public void reload_friends(object sender, EventArgs e)
        {
            friends.DataSource = UserDAL.GetUsers();
            postsFriends.DataSource = PostDAL.GetSortedPosts();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CommentDAL.LikeComment(comments.SelectedRows[0].Cells[0].Value.ToString(), currentId);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            CommentDAL.LikeBackComment(comments.SelectedRows[0].Cells[0].Value.ToString(), currentId);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserDAL.DeleteFriend(currentId, boxFriend.Text.ToString());
            reload_friends(sender, e);
        }

        private void friends_SelectionChanged(object sender, EventArgs e)
        {
            postsFriends.DataSource = PostDAL.GetUserPosts(postsFriends.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommentDAL.AddComment(posts.SelectedRows[0].Cells[0].Value.ToString(), currentId, commentBox.Text.ToString());
        }
    }
}
