using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBSPCA
{
    public partial class FoodForm : Form
    {
        List<DataPoint> yValues = new List<DataPoint>();
        SqlConnection connection;
        string connectionString = ConfigurationManager.ConnectionStrings["DBSPCA.Properties.Settings.PetsConnectionString"].ConnectionString;
        int animalId;
        public FoodForm(string petName, int Id)
        {
            InitializeComponent();

            animalId = Id;
            MainTitleTxb.Text = petName + "'s Weekly Food";

            FormGraph(animalId);
        }

        private void FormGraph(int Id)
        {
            string query = "SELECT tblFeed.Consumption FROM tblFeed INNER JOIN tblAnimals ON tblFeed.FeedId = tblAnimals.animalId WHERE tblAnimals.animalId = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", Id);

                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                // Creating graph

                foreach (DataRow row in foodTable.Rows)
                {
                    DataPoint Dp = new DataPoint();
                    Dp.SetValueY(Convert.ToInt32(row["Consumption"]));
                    yValues.Add(Dp);
                    Console.WriteLine(Convert.ToInt32(row["Consumption"]));
                }
            }

            // adding points, sorting series names, and making it a line
            miniChart.Series.Clear();
            miniChart.Series.Add("Food");
            miniChart.Series["Food"].MarkerStyle = MarkerStyle.Circle;
            foreach (DataPoint dP in yValues)
                miniChart.Series["Food"].Points.Add(dP);
            miniChart.Series["Food"].ChartType = SeriesChartType.Line;
            // finished creating graph
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO tblFeed VALUES (@animalId, @Date, @Consumption);", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@animalId", animalId);
                command.Parameters.AddWithValue("@Date", DateTime.Today);
                command.Parameters.AddWithValue("@Consumption", Day1Nud.Value + Day2Nud.Value + Day3Nud.Value + Day4Nud.Value + Day5Nud.Value + Day6Nud.Value + Day7Nud.Value);

                command.ExecuteNonQuery();
                connection.Close();
            }

            FormGraph(animalId);
        }
    }
}
