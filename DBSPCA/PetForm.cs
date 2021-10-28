using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBSPCA
{
    public partial class PetForm : Form
    {
        SqlConnection connection;
        string connectionString;

        public PetForm()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBSPCA.Properties.Settings.PetsConnectionString"].ConnectionString;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateConnection();
            FillTypeTable();
        }

        private void PopulateConnection()
        {
            Console.WriteLine(dtpBirth.Value.ToString("MM/dd/yyyy"));

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals", connection))
            {
                connection.Open();

                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                petList.DisplayMember = "Name";
                petList.ValueMember = "ID";
                petList.DataSource = petTable;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dobString = dtpBirth.Value;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO tblAnimals([Name], [Type] ,[DoB]) Values(@petName, @petType, @petDoB)", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@petName", txbName.Text);
                command.Parameters.AddWithValue("@petType", typeDpD.GetItemText(typeDpD.SelectedItem));
                command.Parameters.AddWithValue("@petDoB", dtpBirth.Value.ToString("MM/dd/yyyy"));

                command.ExecuteNonQuery();
                connection.Close();
            }
            PopulateConnection();
        }

        private void FillTypeTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes", connection))
            {
                DataTable typeTable = new DataTable();
                adapter.Fill(typeTable);

                typeDpD.DisplayMember = "Type";
                typeDpD.ValueMember = "Type";
                typeDpD.DataSource = typeTable;
            }
        }

        private void btnFoodPg_Click(object sender, EventArgs e)
        {
            // go to food form page
            this.Hide();
            FoodForm window = new FoodForm(petList.GetItemText(petList.SelectedItem), petList.SelectedIndex+1); // create and run the full graph
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int changeNum = GetId("animalId");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE TblAnimals SET Name = @petName WHERE animalId = @Id", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@petName", txbName.Text);
                command.Parameters.AddWithValue("@Id", changeNum);
                command.ExecuteNonQuery();
            }
            PopulateConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deathNum = GetId("animalId");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM tblAnimals WHERE[animalId] = @Id;", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", deathNum);

                command.ExecuteNonQuery();
            }
            PopulateConnection();
        }

        private int GetId(string row)
        {
            int num = 0;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals", connection))
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                // Get the index of the deleted animal
                num = Convert.ToInt32(petTable.Rows[petList.SelectedIndex]["animalId"].ToString());
            }

            return num;
        }

        private void petList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = GetId("animalId");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [Name] FROM tblAnimals WHERE [animalId] = @Id;", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", num);

                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                txbName.Text = nameTable.Rows[0]["Name"].ToString();
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [Type] FROM tblAnimals WHERE [animalId] = @Id;", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", num);

                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                typeDpD.Text = nameTable.Rows[0]["Type"].ToString();
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [DoB] FROM tblAnimals WHERE [animalId] = @Id;", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", num);

                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                dtpBirth.Text = nameTable.Rows[0]["DoB"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int changeNum = GetId("animalId");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE TblAnimals SET DoB = @petDoB WHERE animalId = @Id", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@petDoB", dtpBirth.Value.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@Id", changeNum);
                command.ExecuteNonQuery();
            }
            PopulateConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int changeNum = GetId("animalId");

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE TblAnimals SET Type = @petType WHERE animalId = @Id", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@petType", typeDpD.GetItemText(typeDpD.SelectedItem));
                command.Parameters.AddWithValue("@Id", changeNum);
                command.ExecuteNonQuery();
            }
            PopulateConnection();
        }
    }
}
