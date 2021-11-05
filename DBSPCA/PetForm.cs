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
        bool ableToChange = false;
        bool ableToAdd = true;
        bool changeBool = true;
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
            if (changeBool && !txbName.Text.Equals(""))
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

                MessageBox.Show("Pet Successfully Added", "Success!", MessageBoxButtons.OK);
            }
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
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes", connection))
            {
                DataTable typeTable = new DataTable();
                adapter.Fill(typeTable);
                DataRow all = typeTable.NewRow();
                all["Type"] = "All";
                typeTable.Rows.Add(all);

                typeSearch.DisplayMember = "Type";
                typeSearch.ValueMember = "Type";
                typeSearch.DataSource = typeTable;
            }
        }

        private void btnFoodPg_Click(object sender, EventArgs e)
        {
            if (changeBool)
            {
                // go to food form page
                this.Hide();
                FoodForm window = new FoodForm(petList.GetItemText(petList.SelectedItem), GetId()); // create and run the full graph
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ableToAdd && changeBool)
            {
                int changeNum = GetId();

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deathNum = GetId();

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

        private int GetId()
        {
            int num = 0;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals", connection))
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                // Get the index of the animal
                num = Convert.ToInt32(petTable.Rows[petList.SelectedIndex]["animalId"].ToString());
            }

            return num;
        }

        private void petList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = GetId();

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

            string type = "";

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals", connection))
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                type = petTable.Rows[petList.SelectedIndex]["Type"].ToString();
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodCost] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", type);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                priceNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodCost"].ToString());
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodWeight] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", type);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                weightNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodWeight"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (changeBool)
            {
                int changeNum = GetId();

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
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (ableToChange)
            {
                string type = typeDpD.Text;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("UPDATE TblTypes SET FoodCost = @TypeCost WHERE Type = @Type", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TypeCost", priceNuD.Value);
                    command.Parameters.AddWithValue("@Type", type);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ableToChange)
            {
                string type = typeDpD.Text;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("UPDATE TblTypes SET FoodWeight = @TypeWeight WHERE Type = @Type", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@TypeWeight", weightNuD.Value);
                    command.Parameters.AddWithValue("@Type", type);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void typeDpD_TextChanged(object sender, EventArgs e)
        {
            bool alreadyAdded = false;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes", connection))
            {
                DataTable typeTable = new DataTable();
                adapter.Fill(typeTable);

                foreach (DataRow row in typeTable.Rows)
                {
                    if (typeDpD.Text == row["Type"].ToString())
                    {
                        alreadyAdded = true;
                        break;
                    }
                }
            }
            if (!alreadyAdded)
            {
                button5.Text = "";
                button6.Text = "";
                ableToChange = false;
                button4.Text = "Add Type";
            }
            else
            {
                button5.Text = "Change Details";
                button6.Text = "Change Details";
                ableToChange = true;
                button4.Text = "";
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!ableToChange)
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO tblTypes([Type], [FoodCost] ,[FoodWeight]) Values(@type, @cost, @weight)", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@type", typeDpD.Text);
                    command.Parameters.AddWithValue("@cost", priceNuD.Value);
                    command.Parameters.AddWithValue("@weight", weightNuD.Value);
                    command.ExecuteNonQuery();
                }
                FillTypeTable();

                MessageBox.Show("Type Successfully Added", "Success!", MessageBoxButtons.OK);
            }
        }

        private void typeDpD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = typeDpD.Text;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodCost] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", type);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                priceNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodCost"].ToString());
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodWeight] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", type);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                weightNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodWeight"].ToString());
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Name LIKE (@search+'%');", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@search", nameSearch.Text);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                petList.DisplayMember = "Name";
                petList.ValueMember = "Name";
                petList.DataSource = dt;
            }

            if (petList.Items.Count == 0)
            {
                button1.Text = "";
                button2.Text = "";
                btnAdd.Text = "";
                btnFoodPg.Text = "";
                changeBool = false;
            }
            else
            {
                button1.Text = "Change Details";
                button2.Text = "Change Details";
                btnAdd.Text = "Add Animal";
                btnAdd.Text = "Add Animal";
                btnFoodPg.Text = "Food Details";
                changeBool = true;
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text.Equals(""))
            {
                button1.Text = "";
                btnAdd.Text = "";
            }
            else
            {
                btnAdd.Text = "Add Animal";
                button1.Text = "Change Details";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (typeSearch.Text.Equals("All"))
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petList.DisplayMember = "Name";
                    petList.ValueMember = "Name";
                    petList.DataSource = dt;
                }
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Type LIKE @search;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@search", typeSearch.Text);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petList.DisplayMember = "Name";
                    petList.ValueMember = "Name";
                    petList.DataSource = dt;
                }
            }
        }
    }
}
