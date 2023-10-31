using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIDemo
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr1=MessageBox.Show("Do you want to close the window?","Confirm",MessageBoxButtons.YesNo);
            if(dr1==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameval.Text) &&
                !string.IsNullOrWhiteSpace(sirnameval.Text) &&
                !string.IsNullOrWhiteSpace(telval.Text) &&
                !string.IsNullOrWhiteSpace(addrval.Text) &&
                !string.IsNullOrWhiteSpace(usernameval.Text) &&
                !string.IsNullOrWhiteSpace(pwdval.Text))
            {
                try
                {
                    string connserver = "server=localhost;uid=root;pwd=;database=library";
                    MySqlConnection conn = new MySqlConnection(connserver);
                    conn.ConnectionString = connserver;
                    conn.Open();
                    string name= nameval.Text;
                    string sirname = sirnameval.Text;
                    string std= stdval.Text; 
                    string tel = telval.Text;
                    string addr = addrval.Text;
                    string username = usernameval.Text;
                    string password = pwdval.Text;
                    string query;
                    if (string.IsNullOrEmpty(stdval.Text)) { 
                        query = $"insert into members(name,sirname,tel,addr,lending_books,username,pwd) value('{name}','{sirname}','{tel}','{addr}',0,'{username}','{password}');";
                        
                    }
                    else
                    {
                        query = $"insert into members(name,sirname,student,tel,addr,lending_books,username,pwd) value('{name}','{sirname}','{std}','{tel}','{addr}',0,'{username}','{password}');";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("Account created");
                    conn.Close();
                    books_av bk = new books_av();
                    bk.Show();
                    this.Hide();
                }
                catch (MySqlException ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("All textboxes are required.");
            }

            

            /*
            MessageBox.Show($"Account is created for { textBox1.Text }","completed");
            this.Close(); */
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
            Login frm2 = new Login();
            frm2.Show();
            this.Hide();
        }

       
    }
}
