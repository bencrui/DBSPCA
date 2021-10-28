
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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnimalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitleTxb
            // 
            this.MainTitleTxb.AutoSize = true;
            this.MainTitleTxb.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleTxb.Location = new System.Drawing.Point(232, 9);
            this.MainTitleTxb.Name = "MainTitleTxb";
            this.MainTitleTxb.Size = new System.Drawing.Size(378, 44);
            this.MainTitleTxb.TabIndex = 1;
            this.MainTitleTxb.Text = "The Animal Feeding App";
            // 
            // lblPetList
            // 
            this.lblPetList.AutoSize = true;
            this.lblPetList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPetList.Location = new System.Drawing.Point(553, 84);
            this.lblPetList.Name = "lblPetList";
            this.lblPetList.Size = new System.Drawing.Size(83, 28);
            this.lblPetList.TabIndex = 2;
            this.lblPetList.Text = "Pet List";
            // 
            // petList
            // 
            this.petList.FormattingEnabled = true;
            this.petList.Location = new System.Drawing.Point(513, 115);
            this.petList.Name = "petList";
            this.petList.Size = new System.Drawing.Size(170, 238);
            this.petList.TabIndex = 10;
            this.petList.SelectedIndexChanged += new System.EventHandler(this.petList_SelectedIndexChanged);
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPetName.Location = new System.Drawing.Point(73, 152);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(111, 28);
            this.lblPetName.TabIndex = 11;
            this.lblPetName.Text = "Pet Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(190, 160);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(177, 20);
            this.txbName.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(172, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(373, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Change Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pet DoB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pet Type List:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(190, 201);
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
            this.btnFoodPg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFoodPg.Location = new System.Drawing.Point(547, 359);
            this.btnFoodPg.Name = "btnFoodPg";
            this.btnFoodPg.Size = new System.Drawing.Size(98, 23);
            this.btnFoodPg.TabIndex = 21;
            this.btnFoodPg.Text = "Food Details";
            this.btnFoodPg.UseVisualStyleBackColor = true;
            this.btnFoodPg.Click += new System.EventHandler(this.btnFoodPg_Click);
            // 
            // typeDpD
            // 
            this.typeDpD.FormattingEnabled = true;
            this.typeDpD.Items.AddRange(new object[] {
            "Cat",
            "Cate",
            "Caterer"});
            this.typeDpD.Location = new System.Drawing.Point(222, 241);
            this.typeDpD.Name = "typeDpD";
            this.typeDpD.Size = new System.Drawing.Size(145, 21);
            this.typeDpD.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(272, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Animal";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(373, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Change Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(373, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Change Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PetForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
    }
}

