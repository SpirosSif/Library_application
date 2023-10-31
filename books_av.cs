using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIDemo
{
    public partial class books_av : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        string LoggedInUsername;
        public books_av()
        {
            InitializeComponent();
        }

        public books_av(string username) : this()
        {
            LoggedInUsername = username;
        }

        private void books_av_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=library;user=root;password=";
            connection = new MySqlConnection(connectionString);

            dataAdapter = new MySqlDataAdapter("SELECT * FROM books", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Lending"; 
            buttonColumn.Text = "Borrow me"; 
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);


            dataGridView1.DataSource = dataTable;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            string search = searchbar.Text;
            dataTable.DefaultView.RowFilter = $"Title LIKE '%{search}%' OR Author LIKE '%{search}%'"; ;
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=library;user=root;password=";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Lending"].Index)
            {

                int rowIndex = e.RowIndex;
                // Εξασφαλίζουμε ότι το κελί με την στήλη "available" υπάρχει
                if (dataGridView1.Rows[rowIndex].Cells["available"].Value != null)
                {
                    int availableValue = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["available"].Value);

                    if (availableValue > 0)
                    {
                        availableValue--;
                        string query = $"update books set available={availableValue} where ISBN = {dataGridView1.Rows[rowIndex].Cells["ISBN"].Value}";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int bookaffectedRows = cmd.ExecuteNonQuery();

                        if (bookaffectedRows > 0)
                        {
                            dataGridView1.Rows[rowIndex].Cells["available"].Value = availableValue;
                            query = $"update members set lending_books=lending_books+1 where username='{LoggedInUsername}'";
                            MySqlCommand cmd1 = new MySqlCommand(query, connection);
                            int affectedRows = cmd1.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is not available.");
                    }
                }
            }
        }

        private void returnb_Click(object sender, EventArgs e)
        {
            return_book r1 = new return_book();
            r1.Show();
            //this.Hide();
        }
    }
}
