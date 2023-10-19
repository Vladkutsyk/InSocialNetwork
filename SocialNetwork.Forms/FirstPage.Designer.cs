namespace SocialNetwork.Forms
{
    partial class FirstPage
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
            this.LogIn = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.interestNetwork = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LogIn);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 696);
            this.tabControl1.TabIndex = 0;
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.RosyBrown;
            this.LogIn.Controls.Add(this.label3);
            this.LogIn.Controls.Add(this.label1);
            this.LogIn.Controls.Add(this.interestNetwork);
            this.LogIn.Controls.Add(this.boxPassword);
            this.LogIn.Controls.Add(this.boxLogin);
            this.LogIn.Controls.Add(this.buttonLogIn);
            this.LogIn.Location = new System.Drawing.Point(4, 25);
            this.LogIn.Name = "LogIn";
            this.LogIn.Padding = new System.Windows.Forms.Padding(3);
            this.LogIn.Size = new System.Drawing.Size(1146, 667);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "LogIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(519, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(519, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // interestNetwork
            // 
            this.interestNetwork.AutoSize = true;
            this.interestNetwork.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestNetwork.Location = new System.Drawing.Point(429, 62);
            this.interestNetwork.Name = "interestNetwork";
            this.interestNetwork.Size = new System.Drawing.Size(245, 48);
            this.interestNetwork.TabIndex = 3;
            this.interestNetwork.Text = "Interest Network";
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(437, 210);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(237, 22);
            this.boxPassword.TabIndex = 2;
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(437, 141);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxLogin.Size = new System.Drawing.Size(237, 22);
            this.boxLogin.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Red;
            this.buttonLogIn.Location = new System.Drawing.Point(437, 281);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(237, 37);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 694);
            this.Controls.Add(this.tabControl1);
            this.Name = "FirstPage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LogIn;
        private System.Windows.Forms.Label interestNetwork;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

