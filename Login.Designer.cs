namespace GUIDemo
{
    partial class Login
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pwdval = new System.Windows.Forms.TextBox();
            this.usernameval = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(317, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 60);
            this.button3.TabIndex = 27;
            this.button3.Text = "login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(337, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pwdval
            // 
            this.pwdval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwdval.Location = new System.Drawing.Point(306, 185);
            this.pwdval.Name = "pwdval";
            this.pwdval.Size = new System.Drawing.Size(219, 28);
            this.pwdval.TabIndex = 20;
            this.pwdval.UseSystemPasswordChar = true;
            // 
            // usernameval
            // 
            this.usernameval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usernameval.Location = new System.Drawing.Point(306, 123);
            this.usernameval.Name = "usernameval";
            this.usernameval.Size = new System.Drawing.Size(219, 28);
            this.usernameval.TabIndex = 19;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwd.Location = new System.Drawing.Point(187, 188);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(91, 24);
            this.pwd.TabIndex = 18;
            this.pwd.Text = "password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.username.Location = new System.Drawing.Point(187, 126);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(95, 24);
            this.username.TabIndex = 17;
            this.username.Text = "username";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(666, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwdval);
            this.Controls.Add(this.usernameval);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Text = "Login Page";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pwdval;
        private System.Windows.Forms.TextBox usernameval;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button button1;
    }
}