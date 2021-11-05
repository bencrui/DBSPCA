
namespace DBSPCA
{
    partial class PetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTitleTxb = new System.Windows.Forms.Label();
            this.lblPetList = new System.Windows.Forms.Label();
            this.petList = new System.Windows.Forms.ListBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.dataSet1 = new DBSPCA.DataSet1();
            this.tblAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAnimalsTableAdapter = new DBSPCA.DataSet1TableAdapters.tblAnimalsTableAdapter();
            this.tableAdapterManager = new DBSPCA.DataSet1TableAdapters.TableAdapterManager();
            this.btnFoodPg = new System.Windows.Forms.Button();
            this.typeDpD = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.weightNuD = new System.Windows.Forms.NumericUpDown();
            this.priceNuD = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.typeSearch = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnimalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNuD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNuD)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitleTxb
            // 
            this.MainTitleTxb.AutoSize = true;
            this.MainTitleTxb.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleTxb.Location = new System.Drawing.Point(133, 39);
            this.MainTitleTxb.Name = "MainTitleTxb";
            this.MainTitleTxb.Size = new System.Drawing.Size(378, 44);
            this.MainTitleTxb.TabIndex = 1;
            this.MainTitleTxb.Text = "The Animal Feeding App";
            // 
            // lblPetList
            // 
            this.lblPetList.AutoSize = true;
            this.lblPetList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPetList.Location = new System.Drawing.Point(578, 71);
            this.lblPetList.Name = "lblPetList";
            this.lblPetList.Size = new System.Drawing.Size(83, 28);
            this.lblPetList.TabIndex = 2;
            this.lblPetList.Text = "Pet List";
            // 
            // petList
            // 
            this.petList.FormattingEnabled = true;
            this.petList.Location = new System.Drawing.Point(526, 156);
            this.petList.Name = "petList";
            this.petList.Size = new System.Drawing.Size(196, 212);
            this.petList.TabIndex = 10;
            this.petList.SelectedIndexChanged += new System.EventHandler(this.petList_SelectedIndexChanged);
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPetName.Location = new System.Drawing.Point(72, 129);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(111, 28);
            this.lblPetName.TabIndex = 11;
            this.lblPetName.Text = "Pet Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(189, 137);
            this.txbName.MaxLength = 20;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(177, 20);
            this.txbName.TabIndex = 12;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(272, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(372, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Change Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pet DoB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(72, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pet Type List:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(189, 178);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(177, 20);
            this.dtpBirth.TabIndex = 20;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAnimalsBindingSource
            // 
            this.tblAnimalsBindingSource.DataMember = "tblAnimals";
            this.tblAnimalsBindingSource.DataSource = this.dataSet1;
            // 
            // tblAnimalsTableAdapter
            // 
            this.tblAnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAnimalsTableAdapter = this.tblAnimalsTableAdapter;
            this.tableAdapterManager.tblFeedTableAdapter = null;
            this.tableAdapterManager.tblTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBSPCA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnFoodPg
            // 
            this.btnFoodPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnFoodPg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFoodPg.ForeColor = System.Drawing.Color.White;
            this.btnFoodPg.Location = new System.Drawing.Point(624, 373);
            this.btnFoodPg.Name = "btnFoodPg";
            this.btnFoodPg.Size = new System.Drawing.Size(98, 23);
            this.btnFoodPg.TabIndex = 21;
            this.btnFoodPg.Text = "Food Details";
            this.btnFoodPg.UseVisualStyleBackColor = false;
            this.btnFoodPg.Click += new System.EventHandler(this.btnFoodPg_Click);
            // 
            // typeDpD
            // 
            this.typeDpD.FormattingEnabled = true;
            this.typeDpD.Items.AddRange(new object[] {
            "Cat",
            "Cate",
            "Caterer"});
            this.typeDpD.Location = new System.Drawing.Point(221, 218);
            this.typeDpD.Name = "typeDpD";
            this.typeDpD.Size = new System.Drawing.Size(145, 21);
            this.typeDpD.TabIndex = 22;
            this.typeDpD.SelectedIndexChanged += new System.EventHandler(this.typeDpD_SelectedIndexChanged);
            this.typeDpD.TextChanged += new System.EventHandler(this.typeDpD_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(523, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Animal";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(372, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Change Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // weightNuD
            // 
            this.weightNuD.Location = new System.Drawing.Point(257, 299);
            this.weightNuD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.weightNuD.Name = "weightNuD";
            this.weightNuD.Size = new System.Drawing.Size(109, 20);
            this.weightNuD.TabIndex = 45;
            // 
            // priceNuD
            // 
            this.priceNuD.Location = new System.Drawing.Point(234, 259);
            this.priceNuD.Name = "priceNuD";
            this.priceNuD.Size = new System.Drawing.Size(132, 20);
            this.priceNuD.TabIndex = 44;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(372, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "Change Details";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(372, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 43;
            this.button5.Text = "Change Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Food Price ($):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Food Weight (g):";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(172, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Add Type";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.searchBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(684, 102);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(22, 23);
            this.searchBtn.TabIndex = 47;
            this.searchBtn.Text = "🔍";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(539, 102);
            this.nameSearch.MaxLength = 20;
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(139, 20);
            this.nameSearch.TabIndex = 48;
            // 
            // typeSearch
            // 
            this.typeSearch.FormattingEnabled = true;
            this.typeSearch.Items.AddRange(new object[] {
            "Cat",
            "Cate",
            "Caterer"});
            this.typeSearch.Location = new System.Drawing.Point(539, 128);
            this.typeSearch.Name = "typeSearch";
            this.typeSearch.Size = new System.Drawing.Size(139, 21);
            this.typeSearch.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(684, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "🔍";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PetForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.typeSearch);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.weightNuD);
            this.Controls.Add(this.priceNuD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typeDpD);
            this.Controls.Add(this.btnFoodPg);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.petList);
            this.Controls.Add(this.lblPetList);
            this.Controls.Add(this.MainTitleTxb);
            this.Name = "PetForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnimalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNuD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNuD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleTxb;
        private System.Windows.Forms.Label lblPetList;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblAnimalsBindingSource;
        private DataSet1TableAdapters.tblAnimalsTableAdapter tblAnimalsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox petList;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnFoodPg;
        private System.Windows.Forms.ComboBox typeDpD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown weightNuD;
        private System.Windows.Forms.NumericUpDown priceNuD;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.ComboBox typeSearch;
        private System.Windows.Forms.Button button3;
    }
}

