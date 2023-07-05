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
    public partial class View_All : Form
    {
        public View_All()
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_All_Load(object sender, EventArgs e)
        {
            data();
            dataGridView1.Hide();

            try
            {
                connection.Open();

                string sql = "SELECT * FROM Leaderboard";

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                listBox1.Items.Add("University Name " + "\t" + "Sport " + "\t" + "Team " + "\t" + "Points");
                listBox1.Items.Add("------------------------------------------------------------------------------------------------");
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetValue(0) + "\t\t" +  reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminate_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();

                string sql = "DELETE FROM Leaderboard WHERE UniversityName LIKE '" + txtUni.Text + "' AND Points LIKE '" + txtPoints.Text + "'";

                command = new SqlCommand(sql, connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                int index = listBox1.SelectedIndex;
                if (listBox1.SelectedIndex >= 0)
                {
                    listBox1.Items.RemoveAt(index);
                }

                data();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = @"SELECT * FROM Leaderboard WHERE UniversityName LIKE '%" + txtUni.Text + "%'";

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

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = @"SELECT * FROM Leaderboard WHERE Points LIKE '%" + txtPoints.Text + "%'";

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
