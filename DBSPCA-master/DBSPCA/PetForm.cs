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
        bool TChange = false;
        bool AChange = true;
        public PetForm()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBSPCA.Properties.Settings.PetsConnectionString"].ConnectionString;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateConnection();
            FillTypeTable();

            if (petList.Items.Count == 0)
            {
                NChangeBtn.Text = "";
                BChangeBtn.Text = "";
                btnFoodPg.Text = "";
                ADeleteBtn.Text = "";
                AChange = false;
            }
            AChangeCheck();
            TChangeCheck();
        }

        private void PopulateConnection()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals ORDER BY Name", connection))
            {
                connection.Open();

                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                petList.DisplayMember = "Name";
                petList.ValueMember = "Name";
                petList.DataSource = petTable;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txbName.Text.Equals("") && TChange)
            {
                DateTime dobString = dtpBirth.Value;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO tblAnimals([Name], [Type] ,[DoB]) Values('"+txbName.Text+"', '"+typeDpD.Text+"', '"+dtpBirth.Value.ToString("MM/dd/yyyy")+"')", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
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
            if (AChange)
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
            if (AChange)
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
                MessageBox.Show("Details Changed!", "Success!", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AChange)
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
                MessageBox.Show("Pet Successfully Deleted", "Success!", MessageBoxButtons.OK);
            }
            AChangeCheck();
        }

        private int GetId()
        {
            int num = 0;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblAnimals ORDER BY Name", connection))
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

            AChangeCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AChange)
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
                MessageBox.Show("Details Changed!", "Success!", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TChange)
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
                MessageBox.Show("Details Changed!", "Success!", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TChange)
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
                MessageBox.Show("Details Changed!", "Success!", MessageBoxButtons.OK);
            }
        }

        private void typeDpD_TextChanged(object sender, EventArgs e)
        {
            TChangeCheck();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!TChange && !TAddBtn.Text.Equals(""))
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

            AChangeCheck();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text.Equals(""))
            {
                NChangeBtn.Text = "";
                BChangeBtn.Text = "";
                AAddBtn.Text = "";
            }
            else if (!txbName.Text.Equals("") && AChange)
            {
                NChangeBtn.Text = "Change Details";
                BChangeBtn.Text = "Change Details";
            }
            if (!txbName.Text.Equals("")&&!typeDpD.Text.Equals(""))
                AAddBtn.Text = "Add Animal";
            else
                AAddBtn.Text = "";
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (TChange)
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE[Type] = @Type;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@Type", typeDpD.Text);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        DialogResult deletion = MessageBox.Show("Pets within this type exist\nContinue to delete the pets from the program", "Error", MessageBoxButtons.OKCancel);
                        
                        if (deletion == DialogResult.OK)
                        {
                            using (connection = new SqlConnection(connectionString))
                            using (SqlCommand commnd = new SqlCommand("DELETE FROM tblAnimals WHERE[Type] = @Type;", connection))
                            using (SqlDataAdapter adaptr = new SqlDataAdapter(command))
                            {
                                connection.Open();
                                commnd.Parameters.AddWithValue("@Type", typeDpD.Text);

                                commnd.ExecuteNonQuery();
                            }

                            using (connection = new SqlConnection(connectionString))
                            using (SqlCommand commnd = new SqlCommand("DELETE FROM tblTypes WHERE[Type] = @Type;", connection))
                            using (SqlDataAdapter adaptr = new SqlDataAdapter(command))
                            {
                                connection.Open();
                                commnd.Parameters.AddWithValue("@Type", typeDpD.Text);

                                commnd.ExecuteNonQuery();
                            }
                            PopulateConnection();
                            FillTypeTable();
                            MessageBox.Show("Pet(s) Successfully Deleted", "Success!", MessageBoxButtons.OK);
                        }
                    
                    }
                    else
                    {
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand commnd = new SqlCommand("DELETE FROM tblTypes WHERE[Type] = @Type;", connection))
                        using (SqlDataAdapter adaptr = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            commnd.Parameters.AddWithValue("@Type", typeDpD.Text);

                            commnd.ExecuteNonQuery();
                        }
                        FillTypeTable();

                        MessageBox.Show("Pet Type Successfully Deleted", "Success!", MessageBoxButtons.OK);
                    }
                }
            }

            TChangeCheck();
        }

        private void TChangeCheck()
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
                WChangeBtn.Text = "";
                PChangeBtn.Text = "";
                TDeleteBtn.Text = "";
                TChange = false;
                AAddBtn.Text = "";
                TAddBtn.Text = "Add Type";
            }
            else
            {
                WChangeBtn.Text = "Change Details";
                PChangeBtn.Text = "Change Details";
                TDeleteBtn.Text = "Delete Type";
                if (!txbName.Text.Equals("") && !typeDpD.Text.Equals(""))
                    AAddBtn.Text = "Add Animal";
                TChange = true;
                TAddBtn.Text = "";
            }
            if (typeDpD.Text.Equals("") || weightNuD.Value == 0 || priceNuD.Value == 0)
                TAddBtn.Text = "";
            else
                TAddBtn.Text = "Add Type";
        }
        private void AChangeCheck()
        {
            if (petList.Items.Count != 0)
            {
                NChangeBtn.Text = "Change Details";
                BChangeBtn.Text = "Change Details";
                btnFoodPg.Text = "Food Details";
                ADeleteBtn.Text = "Delete Animal";
                AChange = true;
            }
            if (petList.Items.Count == 0)
            {
                NChangeBtn.Text = "";
                BChangeBtn.Text = "";
                btnFoodPg.Text = "";
                ADeleteBtn.Text = "";
                AChange = false;
            }
        }

        private void priceNuD_ValueChanged(object sender, EventArgs e)
        {
            if (typeDpD.Text.Equals("") || weightNuD.Value == 0 || priceNuD.Value == 0)
                TAddBtn.Text = "";
            else
                TAddBtn.Text = "Add Type";
        }
    }
}
