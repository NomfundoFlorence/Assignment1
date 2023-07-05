using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment1_Mlangeni_37743856
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            View_All all = new View_All();
            all.Show();
            all.MdiParent = this;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            search.MdiParent = this;
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            insert.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
           
        }
    }
}
