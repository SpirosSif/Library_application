﻿namespace GUIDemo
{
    partial class Signup
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameval = new System.Windows.Forms.TextBox();
            this.pwdval = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.nameval = new System.Windows.Forms.TextBox();
            this.sirnameval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addrval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stdval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(472, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(194, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "username *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(198, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "password *";
            // 
            // usernameval
            // 
            this.usernameval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usernameval.Location = new System.Drawing.Point(324, 221);
            this.usernameval.Name = "usernameval";
            this.usernameval.Size = new System.Drawing.Size(257, 28);
            this.usernameval.TabIndex = 25;
            // 
            // pwdval
            // 
            this.pwdval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwdval.Location = new System.Drawing.Point(324, 268);
            this.pwdval.Name = "pwdval";
            this.pwdval.Size = new System.Drawing.Size(257, 28);
            this.pwdval.TabIndex = 27;
            this.pwdval.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(313, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(211, 391);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "I agree and accept the terms";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(205, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.name.Location = new System.Drawing.Point(231, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 24);
            this.name.TabIndex = 16;
            this.name.Text = "name *";
            // 
            // nameval
            // 
            this.nameval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameval.Location = new System.Drawing.Point(324, 25);
            this.nameval.Name = "nameval";
            this.nameval.Size = new System.Drawing.Size(257, 28);
            this.nameval.TabIndex = 17;
            // 
            // sirnameval
            // 
            this.sirnameval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sirnameval.Location = new System.Drawing.Point(324, 68);
            this.sirnameval.Name = "sirnameval";
            this.sirnameval.Size = new System.Drawing.Size(257, 28);
            this.sirnameval.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(212, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "sirname *";
            // 
            // telval
            // 
            this.telval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telval.Location = new System.Drawing.Point(322, 119);
            this.telval.Name = "telval";
            this.telval.Size = new System.Drawing.Size(257, 28);
            this.telval.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(194, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "telephone *";
            // 
            // addrval
            // 
            this.addrval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addrval.Location = new System.Drawing.Point(322, 172);
            this.addrval.Name = "addrval";
            this.addrval.Size = new System.Drawing.Size(257, 28);
            this.addrval.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(212, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "address *";
            // 
            // stdval
            // 
            this.stdval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.stdval.Location = new System.Drawing.Point(324, 312);
            this.stdval.Name = "stdval";
            this.stdval.Size = new System.Drawing.Size(257, 28);
            this.stdval.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(174, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "student pass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "if exists";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stdval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addrval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sirnameval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameval);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwdval);
            this.Controls.Add(this.usernameval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Signup";
            this.Text = "Signup Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameval;
        private System.Windows.Forms.TextBox pwdval;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameval;
        private System.Windows.Forms.TextBox sirnameval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addrval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stdval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

