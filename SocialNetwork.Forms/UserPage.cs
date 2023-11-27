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
using SocialNetwork.Domain.BLL;
using SocialNetwork.UserBLL;

namespace SocialNetwork.Forms
{
    public partial class UserPage : Form
    {
        private string currentId;
        private string currentUsername;
        public UserPage()
        {
            InitializeComponent();
        }
        public void FillInUserInformation(string userId, string usrname)
        {
            currentId = userId;
            currentUsername = usrname;
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
            UserBLL.UserBLL.AddFriend(currentId, boxFriend.Text.ToString());
            //UserDAL.NewFriend(currentId, boxFriend.Text.ToString());
            reload_friends(sender, e);
            //Using UserBLL
        }

        public void reload_friends(object sender, EventArgs e)
        {
            friends.DataSource = UserDAL.GetUsers();
            postsFriends.DataSource = PostDAL.GetSortedPosts();
            friendCheckBox.Clear();
            lengthBox.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // CommentDAL.LikeComment(comments.SelectedRows[0].Cells[0].Value.ToString(), currentId);
            ReactionBLL.CreateReactionComment(currentId, comments.SelectedRows[0].Cells[0].Value.ToString(), currentUsername);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //CommentDAL.LikeBackComment(comments.SelectedRows[0].Cells[0].Value.ToString(), currentId);
            ReactionBLL.DeleteReactionComment(currentId, comments.SelectedRows[0].Cells[0].Value.ToString(), currentUsername);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserBLL.UserBLL.DeleteFriend(currentId, boxFriend.Text.ToString());
            //UserBLL.DeleteFriend(currentId, boxFriend.Text.ToString());
            reload_friends(sender, e);
            //Using UserBLL
        }

        private void friends_SelectionChanged(object sender, EventArgs e)
        {
            var tuple = UserBLL.UserBLL.OnSelectionChanged(currentUsername, 
                postsFriends.SelectedRows[0].Cells[0].Value.ToString(), postsFriends.SelectedRows[0].Cells[3].Value.ToString());
            friendCheckBox.Text = tuple.Item1.ToString();
            lengthBox.Text = tuple.Item2.ToString();
            postsFriends.DataSource = tuple.Item3;
            //postsFriends.DataSource = PostDAL.GetUserPosts(postsFriends.SelectedRows[0].Cells[0].Value.ToString());
            //Using UserBLL
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommentBLL.CreateComment(currentId, posts.SelectedRows[0].Cells[0].Value.ToString(),
               commentBox.Text.ToString(), currentUsername);
            //CommentBLL
            //CommentDAL.AddComment(posts.SelectedRows[0].Cells[0].Value.ToString(), currentId, commentBox.Text.ToString());
        }

        private void addPost_Click(object sender, EventArgs e)
        {
            PostBLL.PostBLL.CreatePost(currentId, postBox.Text.ToString(), currentUsername);
            //PostBLL
            //PostDAL.AddPost(currentId, postBox.Text.ToString());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            reload_friends(sender, e);
        }
    }
}
