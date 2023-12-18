namespace HotelReservation
{
    partial class ManageSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HotelReservation.HRDataSet();
            this.customer_tableTableAdapter = new HotelReservation.HRDataSetTableAdapters.customer_tableTableAdapter();
            this.customertableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managementtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_tableTableAdapter = new HotelReservation.HRDataSetTableAdapters.management_tableTableAdapter();
            this.customertableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRDataSet1 = new HotelReservation.HRDataSet1();
            this.customertableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customer_tableTableAdapter1 = new HotelReservation.HRDataSet1TableAdapters.customer_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Reservation Info";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.roomClassDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerContactDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn,
            this.checkOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customertableBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(24, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(837, 539);
            this.dataGridView1.TabIndex = 7;
            // 
            // customertableBindingSource
            // 
            this.customertableBindingSource.DataMember = "customer_table";
            this.customertableBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_tableTableAdapter
            // 
            this.customer_tableTableAdapter.ClearBeforeFill = true;
            // 
            // customertableBindingSource1
            // 
            this.customertableBindingSource1.DataMember = "customer_table";
            this.customertableBindingSource1.DataSource = this.hRDataSet;
            // 
            // managementtableBindingSource
            // 
            this.managementtableBindingSource.DataMember = "management_table";
            this.managementtableBindingSource.DataSource = this.hRDataSet;
            // 
            // management_tableTableAdapter
            // 
            this.management_tableTableAdapter.ClearBeforeFill = true;
            // 
            // customertableBindingSource2
            // 
            this.customertableBindingSource2.DataMember = "customer_table";
            this.customertableBindingSource2.DataSource = this.hRDataSet;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomClassDataGridViewTextBoxColumn
            // 
            this.roomClassDataGridViewTextBoxColumn.DataPropertyName = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.HeaderText = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.Name = "roomClassDataGridViewTextBoxColumn";
            this.roomClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerContactDataGridViewTextBoxColumn
            // 
            this.customerContactDataGridViewTextBoxColumn.DataPropertyName = "Customer_Contact";
            this.customerContactDataGridViewTextBoxColumn.HeaderText = "Customer_Contact";
            this.customerContactDataGridViewTextBoxColumn.Name = "customerContactDataGridViewTextBoxColumn";
            this.customerContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            this.checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            this.checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRDataSet1
            // 
            this.hRDataSet1.DataSetName = "HRDataSet1";
            this.hRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customertableBindingSource3
            // 
            this.customertableBindingSource3.DataMember = "customer_table";
            this.customertableBindingSource3.DataSource = this.hRDataSet1;
            // 
            // customer_tableTableAdapter1
            // 
            this.customer_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // ManageSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 716);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ManageSide";
            this.Text = "ManageSide";
            this.Load += new System.EventHandler(this.ManageSide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource customertableBindingSource;
        private HRDataSetTableAdapters.customer_tableTableAdapter customer_tableTableAdapter;
        private System.Windows.Forms.BindingSource customertableBindingSource1;
        private System.Windows.Forms.BindingSource managementtableBindingSource;
        private HRDataSetTableAdapters.management_tableTableAdapter management_tableTableAdapter;
        private System.Windows.Forms.BindingSource customertableBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private HRDataSet1 hRDataSet1;
        private System.Windows.Forms.BindingSource customertableBindingSource3;
        private HRDataSet1TableAdapters.customer_tableTableAdapter customer_tableTableAdapter1;
    }
}