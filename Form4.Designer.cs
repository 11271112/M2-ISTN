namespace M2
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPassportNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst3DataSet = new M2.GroupWst3DataSet();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPassportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new M2.GroupWst3DataSetTableAdapters.CustomerTableAdapter();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customer1TableAdapter = new M2.GroupWst3DataSetTableAdapters.Customer1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerIDNumberDataGridViewTextBoxColumn,
            this.customerPassportNumberDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerGenderDataGridViewTextBoxColumn,
            this.customerContactNumberDataGridViewTextBoxColumn,
            this.customerEmailAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1402, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Customer FirstName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1402, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Customer Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerFirstNameDataGridViewTextBoxColumn1,
            this.customerSurnameDataGridViewTextBoxColumn1,
            this.customerIDNumberDataGridViewTextBoxColumn1,
            this.customerPassportNumberDataGridViewTextBoxColumn1,
            this.customerAddressDataGridViewTextBoxColumn1,
            this.customerDOBDataGridViewTextBoxColumn1,
            this.customerGenderDataGridViewTextBoxColumn1,
            this.customerContactNumberDataGridViewTextBoxColumn1,
            this.customerEmailAddressDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.customer1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1362, 109);
            this.dataGridView2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update Email Address";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update Contact Number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerFirstNameDataGridViewTextBoxColumn1
            // 
            this.customerFirstNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn1.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn1.Name = "customerFirstNameDataGridViewTextBoxColumn1";
            // 
            // customerSurnameDataGridViewTextBoxColumn1
            // 
            this.customerSurnameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn1.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn1.Name = "customerSurnameDataGridViewTextBoxColumn1";
            // 
            // customerIDNumberDataGridViewTextBoxColumn1
            // 
            this.customerIDNumberDataGridViewTextBoxColumn1.DataPropertyName = "CustomerIDNumber";
            this.customerIDNumberDataGridViewTextBoxColumn1.HeaderText = "CustomerIDNumber";
            this.customerIDNumberDataGridViewTextBoxColumn1.Name = "customerIDNumberDataGridViewTextBoxColumn1";
            // 
            // customerPassportNumberDataGridViewTextBoxColumn1
            // 
            this.customerPassportNumberDataGridViewTextBoxColumn1.DataPropertyName = "CustomerPassportNumber";
            this.customerPassportNumberDataGridViewTextBoxColumn1.HeaderText = "CustomerPassportNumber";
            this.customerPassportNumberDataGridViewTextBoxColumn1.Name = "customerPassportNumberDataGridViewTextBoxColumn1";
            // 
            // customerAddressDataGridViewTextBoxColumn1
            // 
            this.customerAddressDataGridViewTextBoxColumn1.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn1.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn1.Name = "customerAddressDataGridViewTextBoxColumn1";
            // 
            // customerDOBDataGridViewTextBoxColumn1
            // 
            this.customerDOBDataGridViewTextBoxColumn1.DataPropertyName = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn1.HeaderText = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn1.Name = "customerDOBDataGridViewTextBoxColumn1";
            // 
            // customerGenderDataGridViewTextBoxColumn1
            // 
            this.customerGenderDataGridViewTextBoxColumn1.DataPropertyName = "CustomerGender";
            this.customerGenderDataGridViewTextBoxColumn1.HeaderText = "CustomerGender";
            this.customerGenderDataGridViewTextBoxColumn1.Name = "customerGenderDataGridViewTextBoxColumn1";
            // 
            // customerContactNumberDataGridViewTextBoxColumn1
            // 
            this.customerContactNumberDataGridViewTextBoxColumn1.DataPropertyName = "CustomerContactNumber";
            this.customerContactNumberDataGridViewTextBoxColumn1.HeaderText = "CustomerContactNumber";
            this.customerContactNumberDataGridViewTextBoxColumn1.Name = "customerContactNumberDataGridViewTextBoxColumn1";
            // 
            // customerEmailAddressDataGridViewTextBoxColumn1
            // 
            this.customerEmailAddressDataGridViewTextBoxColumn1.DataPropertyName = "CustomerEmailAddress";
            this.customerEmailAddressDataGridViewTextBoxColumn1.HeaderText = "CustomerEmailAddress";
            this.customerEmailAddressDataGridViewTextBoxColumn1.Name = "customerEmailAddressDataGridViewTextBoxColumn1";
            // 
            // customer1BindingSource
            // 
            this.customer1BindingSource.DataMember = "Customer1";
            this.customer1BindingSource.DataSource = this.groupWst3DataSet;
            // 
            // groupWst3DataSet
            // 
            this.groupWst3DataSet.DataSetName = "GroupWst3DataSet";
            this.groupWst3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDNumberDataGridViewTextBoxColumn
            // 
            this.customerIDNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerIDNumber";
            this.customerIDNumberDataGridViewTextBoxColumn.HeaderText = "CustomerIDNumber";
            this.customerIDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDNumberDataGridViewTextBoxColumn.Name = "customerIDNumberDataGridViewTextBoxColumn";
            this.customerIDNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerPassportNumberDataGridViewTextBoxColumn
            // 
            this.customerPassportNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerPassportNumber";
            this.customerPassportNumberDataGridViewTextBoxColumn.HeaderText = "CustomerPassportNumber";
            this.customerPassportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPassportNumberDataGridViewTextBoxColumn.Name = "customerPassportNumberDataGridViewTextBoxColumn";
            this.customerPassportNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDOBDataGridViewTextBoxColumn
            // 
            this.customerDOBDataGridViewTextBoxColumn.DataPropertyName = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.HeaderText = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDOBDataGridViewTextBoxColumn.Name = "customerDOBDataGridViewTextBoxColumn";
            this.customerDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerGenderDataGridViewTextBoxColumn
            // 
            this.customerGenderDataGridViewTextBoxColumn.DataPropertyName = "CustomerGender";
            this.customerGenderDataGridViewTextBoxColumn.HeaderText = "CustomerGender";
            this.customerGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerGenderDataGridViewTextBoxColumn.Name = "customerGenderDataGridViewTextBoxColumn";
            this.customerGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerContactNumberDataGridViewTextBoxColumn
            // 
            this.customerContactNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerContactNumber";
            this.customerContactNumberDataGridViewTextBoxColumn.HeaderText = "CustomerContactNumber";
            this.customerContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerContactNumberDataGridViewTextBoxColumn.Name = "customerContactNumberDataGridViewTextBoxColumn";
            this.customerContactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerEmailAddressDataGridViewTextBoxColumn
            // 
            this.customerEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmailAddress";
            this.customerEmailAddressDataGridViewTextBoxColumn.HeaderText = "CustomerEmailAddress";
            this.customerEmailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerEmailAddressDataGridViewTextBoxColumn.Name = "customerEmailAddressDataGridViewTextBoxColumn";
            this.customerEmailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.groupWst3DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.groupWst3DataSet;
            // 
            // customer1TableAdapter
            // 
            this.customer1TableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 791);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupWst3DataSet groupWst3DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GroupWst3DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPassportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPassportNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGenderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customer1BindingSource;
        private GroupWst3DataSetTableAdapters.Customer1TableAdapter customer1TableAdapter;
    }
}