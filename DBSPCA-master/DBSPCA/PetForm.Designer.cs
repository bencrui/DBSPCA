
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
            this.AAddBtn = new System.Windows.Forms.Button();
            this.NChangeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new DBSPCA.DataSet1();
            this.tblAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAnimalsTableAdapter = new DBSPCA.DataSet1TableAdapters.tblAnimalsTableAdapter();
            this.tableAdapterManager = new DBSPCA.DataSet1TableAdapters.TableAdapterManager();
            this.btnFoodPg = new System.Windows.Forms.Button();
            this.typeDpD = new System.Windows.Forms.ComboBox();
            this.ADeleteBtn = new System.Windows.Forms.Button();
            this.BChangeBtn = new System.Windows.Forms.Button();
            this.weightNuD = new System.Windows.Forms.NumericUpDown();
            this.priceNuD = new System.Windows.Forms.NumericUpDown();
            this.PChangeBtn = new System.Windows.Forms.Button();
            this.WChangeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TAddBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.typeSearch = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TDeleteBtn = new System.Windows.Forms.Button();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // AAddBtn
            // 
            this.AAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.AAddBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.AAddBtn.Location = new System.Drawing.Point(376, 217);
            this.AAddBtn.Name = "AAddBtn";
            this.AAddBtn.Size = new System.Drawing.Size(94, 23);
            this.AAddBtn.TabIndex = 14;
            this.AAddBtn.Text = "Add Animal";
            this.AAddBtn.UseVisualStyleBackColor = false;
            this.AAddBtn.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NChangeBtn
            // 
            this.NChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.NChangeBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.NChangeBtn.Location = new System.Drawing.Point(372, 137);
            this.NChangeBtn.Name = "NChangeBtn";
            this.NChangeBtn.Size = new System.Drawing.Size(98, 23);
            this.NChangeBtn.TabIndex = 16;
            this.NChangeBtn.Text = "Change Details";
            this.NChangeBtn.UseVisualStyleBackColor = false;
            this.NChangeBtn.Click += new System.EventHandler(this.button1_Click);
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
            // ADeleteBtn
            // 
            this.ADeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ADeleteBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.ADeleteBtn.ForeColor = System.Drawing.Color.White;
            this.ADeleteBtn.Location = new System.Drawing.Point(523, 373);
            this.ADeleteBtn.Name = "ADeleteBtn";
            this.ADeleteBtn.Size = new System.Drawing.Size(95, 23);
            this.ADeleteBtn.TabIndex = 13;
            this.ADeleteBtn.Text = "Delete Animal";
            this.ADeleteBtn.UseVisualStyleBackColor = false;
            this.ADeleteBtn.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BChangeBtn
            // 
            this.BChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.BChangeBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.BChangeBtn.Location = new System.Drawing.Point(372, 175);
            this.BChangeBtn.Name = "BChangeBtn";
            this.BChangeBtn.Size = new System.Drawing.Size(98, 23);
            this.BChangeBtn.TabIndex = 23;
            this.BChangeBtn.Text = "Change Details";
            this.BChangeBtn.UseVisualStyleBackColor = false;
            this.BChangeBtn.Click += new System.EventHandler(this.button2_Click);
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
            this.weightNuD.ValueChanged += new System.EventHandler(this.weightNuD_ValueChanged);
            // 
            // priceNuD
            // 
            this.priceNuD.Location = new System.Drawing.Point(234, 259);
            this.priceNuD.Name = "priceNuD";
            this.priceNuD.Size = new System.Drawing.Size(132, 20);
            this.priceNuD.TabIndex = 44;
            this.priceNuD.ValueChanged += new System.EventHandler(this.priceNuD_ValueChanged);
            // 
            // PChangeBtn
            // 
            this.PChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.PChangeBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.PChangeBtn.Location = new System.Drawing.Point(372, 259);
            this.PChangeBtn.Name = "PChangeBtn";
            this.PChangeBtn.Size = new System.Drawing.Size(98, 23);
            this.PChangeBtn.TabIndex = 41;
            this.PChangeBtn.Text = "Change Details";
            this.PChangeBtn.UseVisualStyleBackColor = false;
            this.PChangeBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // WChangeBtn
            // 
            this.WChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.WChangeBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.WChangeBtn.Location = new System.Drawing.Point(372, 299);
            this.WChangeBtn.Name = "WChangeBtn";
            this.WChangeBtn.Size = new System.Drawing.Size(98, 23);
            this.WChangeBtn.TabIndex = 43;
            this.WChangeBtn.Text = "Change Details";
            this.WChangeBtn.UseVisualStyleBackColor = false;
            this.WChangeBtn.Click += new System.EventHandler(this.button5_Click);
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
            // TAddBtn
            // 
            this.TAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.TAddBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.TAddBtn.Location = new System.Drawing.Point(272, 328);
            this.TAddBtn.Name = "TAddBtn";
            this.TAddBtn.Size = new System.Drawing.Size(94, 23);
            this.TAddBtn.TabIndex = 46;
            this.TAddBtn.Text = "Add Type";
            this.TAddBtn.UseVisualStyleBackColor = false;
            this.TAddBtn.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.searchBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(717, 103);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(22, 23);
            this.searchBtn.TabIndex = 47;
            this.searchBtn.Text = "🔍";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(572, 103);
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
            this.typeSearch.Location = new System.Drawing.Point(572, 129);
            this.typeSearch.Name = "typeSearch";
            this.typeSearch.Size = new System.Drawing.Size(139, 21);
            this.typeSearch.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(717, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "🔍";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TDeleteBtn
            // 
            this.TDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.TDeleteBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.TDeleteBtn.Location = new System.Drawing.Point(172, 328);
            this.TDeleteBtn.Name = "TDeleteBtn";
            this.TDeleteBtn.Size = new System.Drawing.Size(94, 23);
            this.TDeleteBtn.TabIndex = 51;
            this.TDeleteBtn.Text = "Delete Type";
            this.TDeleteBtn.UseVisualStyleBackColor = false;
            this.TDeleteBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(189, 175);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(177, 20);
            this.dtpBirth.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(508, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(508, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Type:";
            // 
            // PetForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.TDeleteBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.typeSearch);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.TAddBtn);
            this.Controls.Add(this.weightNuD);
            this.Controls.Add(this.priceNuD);
            this.Controls.Add(this.WChangeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PChangeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BChangeBtn);
            this.Controls.Add(this.typeDpD);
            this.Controls.Add(this.btnFoodPg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NChangeBtn);
            this.Controls.Add(this.AAddBtn);
            this.Controls.Add(this.ADeleteBtn);
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
        private System.Windows.Forms.Button AAddBtn;
        private System.Windows.Forms.Button NChangeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFoodPg;
        private System.Windows.Forms.ComboBox typeDpD;
        private System.Windows.Forms.Button ADeleteBtn;
        private System.Windows.Forms.Button BChangeBtn;
        private System.Windows.Forms.NumericUpDown weightNuD;
        private System.Windows.Forms.NumericUpDown priceNuD;
        private System.Windows.Forms.Button PChangeBtn;
        private System.Windows.Forms.Button WChangeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TAddBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.ComboBox typeSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button TDeleteBtn;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

