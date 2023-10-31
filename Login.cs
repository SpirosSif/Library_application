using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace GUIDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Signup frm1 = new Signup();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Do you want to close the window?", "Confirm", MessageBoxButtons.YesNo);
            if (dr2 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connserver = "server=localhost;uid=root;pwd=;database=library";
                MySqlConnection conn = new MySqlConnection(connserver);
                conn.ConnectionString = connserver;
                conn.Open();
                
                string username = usernameval.Text;
                string password = pwdval.Text;
                string query = $"select count(*) from members where username='{username}' and pwd='{password}';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                if (count > 0)
                {
                    books_av bk = new books_av(username);
                    bk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password is invalid");
                }
                conn.Close();
            }catch (MySqlException ex) { MessageBox.Show(ex.Message); }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
