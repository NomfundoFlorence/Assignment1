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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nomfu\Desktop\YEAR2\CMPG212\Assignment1\Assignment1_Mlangeni_37743856\Assignment1_Mlangeni_37743856\Tournament.mdf;Integrated Security=True");
        SqlCommand command;
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public void data()
        {
            connection.Open();

            adapter = new SqlDataAdapter();
            dataSet = new DataSet();

            string sql = "SELECT * FROM Leaderboard";

            command = new SqlCommand(sql, connection);

            adapter.SelectCommand = command;
            adapter.Fill(dataSet, "Leaderboard");

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "Leaderboard";

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            data();

            try
            {
                connection.Open();

                string sql = "SELECT Sport FROM Leaderboard";

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbSport.Items.Add(reader.GetValue(0));
                }

                connection.Close();

                hScrollBar1.Value = 0;
                hScrollBar1.Minimum = 1;
                hScrollBar1.Maximum = 50;
                hScrollBar1.LargeChange = 5;
                hScrollBar1.SmallChange = 1;

                label1.Text = hScrollBar1.Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchUniversity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = @"SELECT * FROM Leaderboard WHERE UniversityName LIKE '%" + txtSearchUniversity.Text + "%'";

                command = new SqlCommand(sql, connection);

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Leaderboard");

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Leaderboard";

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = @"SELECT * FROM Leaderboard WHERE Sport = '" + cmbSport.SelectedItem.ToString() + "'";

                command = new SqlCommand(sql, connection);

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Leaderboard");

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Leaderboard";

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();

            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = @"SELECT * FROM Leaderboard WHERE Points = '" + hScrollBar1.Value.ToString() + "'";

                command = new SqlCommand(sql, connection);

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Leaderboard");

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Leaderboard";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
