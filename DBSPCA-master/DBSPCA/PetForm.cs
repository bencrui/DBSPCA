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
        bool alreadyAdded = false;
        string searching = "";
        string typeSearching = "";
        public PetForm()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBSPCA.Properties.Settings.PetsConnectionString"].ConnectionString;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateConnection();
            FillTypeTable();
            RefilVars();

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
            searching = "";
            typeSearching = "";
            RefilVars();
        }

        private void FillTypeTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes ORDER BY Type", connection))
            {
                DataTable typeTable = new DataTable();
                adapter.Fill(typeTable);

                typeDpD.DisplayMember = "Type";
                typeDpD.ValueMember = "Type";
                typeDpD.DataSource = typeTable;
            }
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes ORDER BY Type", connection))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txbName.Text.Equals("") && TChange)
            {
                DateTime dobString = dtpBirth.Value;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO tblAnimals([Name], [Type] ,[DoB]) Values('" + txbName.Text + "', '" + typeDpD.Text + "', '" + dtpBirth.Value.ToString("MM/dd/yyyy") + "')", connection))
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

                if (searching == "" && typeSearching == "")
                    PopulateConnection();
                else if (searching == "")
                    SearchType();
                else
                    SearchName();
                MessageBox.Show("Pet Successfully Deleted", "Success!", MessageBoxButtons.OK);
            }
            RefilVars();
            AChangeCheck();
        }

        private int GetId()
        {
            int num = 0;

            if (petList.Items.Count == 0)
            { }
            else if (typeSearching.Equals(""))
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Name LIKE (@search+'%') ORDER BY Name", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@search", searching);
                    DataTable petTable = new DataTable();
                    adapter.Fill(petTable);

                    // Get the index of the animal
                    num = Convert.ToInt32(petTable.Rows[petList.SelectedIndex]["animalId"].ToString());
                }
            }
            else
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Name LIKE (@search+'%') AND Type LIKE (@typeSearch) ORDER BY Name", connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@search", searching);
                        command.Parameters.AddWithValue("@typeSearch", typeSearching);
                        DataTable petTable = new DataTable();
                        adapter.Fill(petTable);

                        // Get the index of the animal
                        num = Convert.ToInt32(petTable.Rows[petList.SelectedIndex]["animalId"].ToString());
                    }
                }
                catch(Exception e)
                {
                    num = 0;
                }
            }

            return num;
        }

        private string GetT()
        {
            try
            {
                string type = "";

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes ORDER BY Type", connection))
                {
                    DataTable petTable = new DataTable();
                    adapter.Fill(petTable);

                    // Get the index of the animal
                    type = petTable.Rows[typeDpD.SelectedIndex]["Type"].ToString();
                }

                return type;
            }
            catch (Exception)
            {
                return typeDpD.Text;
            }
        }

        private void petList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefilVars();

            AChangeCheck();
        }

        private void RefilVars()
        {
            txbName.Text = StringGathering("Name");
            typeDpD.Text = StringGathering("Type");
            dtpBirth.Text = StringGathering("DoB");
            priceNuD.Value = IntGathering("FoodCost");
            weightNuD.Value = IntGathering("FoodWeight");
        }

        private string StringGathering(string selecType)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT [" + selecType + "] FROM tblAnimals WHERE [animalId] = @Id;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", GetId());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt.Rows[0][selecType].ToString();
                }
            }
            catch
            { return ""; }
        }
        private int IntGathering(string selecType)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT [" + selecType + "] FROM tblTypes WHERE [Type] = @Type;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Type", GetT());

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return Convert.ToInt32(dt.Rows[0][selecType].ToString());
                }
            }
            catch
            { return 0; }
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

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodCost] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", GetT());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                priceNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodCost"].ToString());
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT [FoodWeight] FROM tblTypes WHERE Type = @Type", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Type", GetT());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                weightNuD.Value = Convert.ToInt32(dt.Rows[0]["FoodWeight"].ToString());
            }

            TChangeCheck();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchName();
        }
        private void SearchName()
        {

            searching = nameSearch.Text;
            typeSearching = "";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Name LIKE (@search+'%') ORDER BY Name;", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@search", searching);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                petList.DisplayMember = "Name";
                petList.ValueMember = "Name";
                petList.DataSource = dt;
            }

            RefilVars();
            AChangeCheck();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text.Equals(""))
            {
                NChangeBtn.Text = "";
                AAddBtn.Text = "";
            }
            else if (!txbName.Text.Equals("") && AChange)
            {
                NChangeBtn.Text = "Change Details";
                BChangeBtn.Text = "Change Details";
            }
            if (AChange)
            {
                BChangeBtn.Text.Equals("Change Details");
            }

            if (!txbName.Text.Equals("")&&!typeDpD.Text.Equals(""))
                AAddBtn.Text = "Add Animal";
            else
                AAddBtn.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchType();
        }
        private void SearchType()
        {
            searching = "";
            if (typeSearch.Text.Equals("All"))
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals ORDER BY Name;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petList.DisplayMember = "Name";
                    petList.ValueMember = "Name";
                    petList.DataSource = dt;
                }
                typeSearching = "";
            }
            else
            {
                typeSearching = typeSearch.Text;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM tblAnimals WHERE Type LIKE @search ORDER BY Name;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@search", typeSearching);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    petList.DisplayMember = "Name";
                    petList.ValueMember = "Name";
                    petList.DataSource = dt;
                }
            }
            RefilVars();
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

            RefilVars();
            TChangeCheck();
        }

        private void TChangeCheck()
        {
            alreadyAdded = false;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblTypes ORDER BY Type", connection))
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
            }
            else
            {
                WChangeBtn.Text = "Change Details";
                PChangeBtn.Text = "Change Details";
                TDeleteBtn.Text = "Delete Type";
                if (!txbName.Text.Equals("") && !typeDpD.Text.Equals(""))
                    AAddBtn.Text = "Add Animal";
                TChange = true;
            }

            if (typeDpD.Text.Equals("") || weightNuD.Value == 0 || priceNuD.Value == 0 || alreadyAdded)
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
            TChangeCheck();
            if (typeDpD.Text.Equals("") || weightNuD.Value == 0 || priceNuD.Value == 0 || alreadyAdded)
                TAddBtn.Text = "";
            else
                TAddBtn.Text = "Add Type";
        }

        private void weightNuD_ValueChanged(object sender, EventArgs e)
        {
            TChangeCheck();
            if (typeDpD.Text.Equals("") || weightNuD.Value == 0 || priceNuD.Value == 0 || alreadyAdded)
                TAddBtn.Text = "";
            else
                TAddBtn.Text = "Add Type";
        }
    }
}
