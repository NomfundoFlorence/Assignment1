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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nomfu\Desktop\YEAR2\CMPG212\Assignment1\Assignment1_Mlangeni_37743856\Assignment1_Mlangeni_37743856\Tournament.mdf;Integrated Security=True");
        SqlCommand command;
        DataSet dataSet;
        SqlDataAdapter adapter;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sql = "INSERT INTO Leaderboard(UniversityName, Sport, Team, Points) VALUES(@UniversityName, @Sport, @Team, @Points)";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@UniversityName", txtUniversity.Text);
                command.Parameters.AddWithValue("@Sport", txtSport.Text);
                command.Parameters.AddWithValue("@Team", txtTeam.Text);
                command.Parameters.AddWithValue("@Points", int.Parse(txtPoints.Text));

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
