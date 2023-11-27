namespace SocialNetwork.Forms
{
    partial class UserPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.postBox = new System.Windows.Forms.TextBox();
            this.addPost = new System.Windows.Forms.Button();
            this.comments = new System.Windows.Forms.DataGridView();
            this.posts = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.friendCheckBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postsFriends = new System.Windows.Forms.DataGridView();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.friends = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.boxFriend = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posts)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.comments);
            this.tabPage1.Controls.Add(this.posts);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1274, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Posts";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.postBox);
            this.panel5.Controls.Add(this.addPost);
            this.panel5.Location = new System.Drawing.Point(760, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 125);
            this.panel5.TabIndex = 10;
            // 
            // postBox
            // 
            this.postBox.Location = new System.Drawing.Point(33, 23);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(271, 22);
            this.postBox.TabIndex = 2;
            // 
            // addPost
            // 
            this.addPost.BackColor = System.Drawing.Color.MistyRose;
            this.addPost.Location = new System.Drawing.Point(101, 84);
            this.addPost.Name = "addPost";
            this.addPost.Size = new System.Drawing.Size(145, 23);
            this.addPost.TabIndex = 0;
            this.addPost.Text = "Add Post";
            this.addPost.UseVisualStyleBackColor = false;
            this.addPost.Click += new System.EventHandler(this.addPost_Click);
            // 
            // comments
            // 
            this.comments.BackgroundColor = System.Drawing.SystemColors.Info;
            this.comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comments.Location = new System.Drawing.Point(39, 447);
            this.comments.Name = "comments";
            this.comments.RowHeadersWidth = 51;
            this.comments.RowTemplate.Height = 24;
            this.comments.Size = new System.Drawing.Size(549, 150);
            this.comments.TabIndex = 9;
            // 
            // posts
            // 
            this.posts.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posts.Location = new System.Drawing.Point(39, 63);
            this.posts.Name = "posts";
            this.posts.RowHeadersWidth = 51;
            this.posts.RowTemplate.Height = 24;
            this.posts.Size = new System.Drawing.Size(549, 307);
            this.posts.TabIndex = 8;
            this.posts.SelectionChanged += new System.EventHandler(this.posts_SelectionChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Location = new System.Drawing.Point(855, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Get Like back";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Location = new System.Drawing.Point(855, 559);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "Get Like back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(855, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Get Like to Comment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(855, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Like Post";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.commentBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(760, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 125);
            this.panel1.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteButton.Location = new System.Drawing.Point(101, 90);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Comment";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.MistyRose;
            this.UpdateButton.Location = new System.Drawing.Point(177, 61);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update Comment";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(33, 23);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(271, 22);
            this.commentBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(33, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add Comment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posts";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.Controls.Add(this.backButton);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.postsFriends);
            this.tabPage2.Controls.Add(this.buttonFriends);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.friends);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1274, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RosyBrown;
            this.backButton.Location = new System.Drawing.Point(679, 317);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(279, 52);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back to Users";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.lengthBox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(683, 513);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 92);
            this.panel4.TabIndex = 10;
            // 
            // lengthBox
            // 
            this.lengthBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lengthBox.Location = new System.Drawing.Point(161, 34);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.ReadOnly = true;
            this.lengthBox.Size = new System.Drawing.Size(100, 22);
            this.lengthBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Check Length\r\nVia Neo4J\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.friendCheckBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(683, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 92);
            this.panel3.TabIndex = 9;
            // 
            // friendCheckBox
            // 
            this.friendCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.friendCheckBox.Location = new System.Drawing.Point(161, 34);
            this.friendCheckBox.Name = "friendCheckBox";
            this.friendCheckBox.ReadOnly = true;
            this.friendCheckBox.Size = new System.Drawing.Size(100, 22);
            this.friendCheckBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 56);
            this.label6.TabIndex = 0;
            this.label6.Text = "Check Friend\r\nVia Neo4J\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tomato;
            this.label5.Font = new System.Drawing.Font("NSimSun", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Friends Posts";
            // 
            // postsFriends
            // 
            this.postsFriends.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.postsFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsFriends.Location = new System.Drawing.Point(44, 426);
            this.postsFriends.Name = "postsFriends";
            this.postsFriends.RowHeadersWidth = 51;
            this.postsFriends.RowTemplate.Height = 24;
            this.postsFriends.Size = new System.Drawing.Size(443, 162);
            this.postsFriends.TabIndex = 7;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFriends.Location = new System.Drawing.Point(679, 244);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(279, 52);
            this.buttonFriends.TabIndex = 6;
            this.buttonFriends.Text = "Find Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "Users/Friends";
            // 
            // friends
            // 
            this.friends.BackgroundColor = System.Drawing.SystemColors.Info;
            this.friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friends.Location = new System.Drawing.Point(44, 62);
            this.friends.Name = "friends";
            this.friends.RowHeadersWidth = 51;
            this.friends.RowTemplate.Height = 24;
            this.friends.Size = new System.Drawing.Size(443, 277);
            this.friends.TabIndex = 4;
            this.friends.SelectionChanged += new System.EventHandler(this.friends_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.boxFriend);
            this.panel2.Location = new System.Drawing.Point(679, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 166);
            this.panel2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button8.Location = new System.Drawing.Point(137, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 39);
            this.button8.TabIndex = 3;
            this.button8.Text = "Delete Friend";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Username";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.Location = new System.Drawing.Point(14, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add Friend";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxFriend
            // 
            this.boxFriend.Location = new System.Drawing.Point(38, 63);
            this.boxFriend.Name = "boxFriend";
            this.boxFriend.Size = new System.Drawing.Size(195, 22);
            this.boxFriend.TabIndex = 1;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 679);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserPage";
            this.Text = "User Page";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox boxFriend;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.DataGridView comments;
        private System.Windows.Forms.DataGridView posts;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView friends;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView postsFriends;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox friendCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox postBox;
        private System.Windows.Forms.Button addPost;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}