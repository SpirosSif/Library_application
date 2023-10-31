using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemo
{
    public partial class return_book : Form
    {
        public return_book()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (monday.Checked)
                MessageBox.Show("You can come to the library at monday to return it");
            else if(tuesday.Checked)
                MessageBox.Show("You can come to the library at tuesday to return it");
            else if(wednesday.Checked)
                MessageBox.Show("You can come to the library at wednesday to return it");
            else if(thursday.Checked)
                MessageBox.Show("You can come to the library at thurstday to return it");
            else if(friday.Checked)
                MessageBox.Show("You can come to the library at friday to return it");
        }
    }
}
