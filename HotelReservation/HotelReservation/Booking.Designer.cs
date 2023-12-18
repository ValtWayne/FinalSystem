namespace HotelReservation
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Avail = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.Executive = new System.Windows.Forms.RadioButton();
            this.Deluxe = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hRDataSet = new HotelReservation.HRDataSet();
            this.reservetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter = new HotelReservation.HRDataSetTableAdapters.reserve_tableTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckAvailablility = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check In Date:";
            // 
            // Avail
            // 
            this.Avail.Location = new System.Drawing.Point(167, 110);
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(200, 20);
            this.Avail.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.Deluxe);
            this.groupBox1.Controls.Add(this.Executive);
            this.groupBox1.Controls.Add(this.Classic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Bisque;
            this.groupBox1.Location = new System.Drawing.Point(36, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.Location = new System.Drawing.Point(49, 37);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(128, 35);
            this.Classic.TabIndex = 0;
            this.Classic.TabStop = true;
            this.Classic.Text = "Classic";
            this.Classic.UseVisualStyleBackColor = true;
            // 
            // Executive
            // 
            this.Executive.AutoSize = true;
            this.Executive.Location = new System.Drawing.Point(481, 37);
            this.Executive.Name = "Executive";
            this.Executive.Size = new System.Drawing.Size(159, 35);
            this.Executive.TabIndex = 0;
            this.Executive.TabStop = true;
            this.Executive.Text = "Executive";
            this.Executive.UseVisualStyleBackColor = true;
            // 
            // Deluxe
            // 
            this.Deluxe.AutoSize = true;
            this.Deluxe.Location = new System.Drawing.Point(262, 37);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.Size = new System.Drawing.Size(122, 35);
            this.Deluxe.TabIndex = 1;
            this.Deluxe.TabStop = true;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomClassDataGridViewTextBoxColumn,
            this.availableDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.CheckAvailablility});
            this.dataGridView1.DataSource = this.reservetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservetableBindingSource
            // 
            this.reservetableBindingSource.DataMember = "reserve_table";
            this.reservetableBindingSource.DataSource = this.hRDataSet;
            // 
            // reserve_tableTableAdapter
            // 
            this.reserve_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Bisque;
            this.Search.Location = new System.Drawing.Point(315, 398);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(158, 44);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomClassDataGridViewTextBoxColumn
            // 
            this.roomClassDataGridViewTextBoxColumn.DataPropertyName = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.HeaderText = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.Name = "roomClassDataGridViewTextBoxColumn";
            this.roomClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableDateDataGridViewTextBoxColumn
            // 
            this.availableDateDataGridViewTextBoxColumn.DataPropertyName = "Available_Date";
            this.availableDateDataGridViewTextBoxColumn.HeaderText = "Available_Date";
            this.availableDateDataGridViewTextBoxColumn.Name = "availableDateDataGridViewTextBoxColumn";
            this.availableDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CheckAvailablility
            // 
            this.CheckAvailablility.DataPropertyName = "Room_ID";
            this.CheckAvailablility.HeaderText = "Availability";
            this.CheckAvailablility.Name = "CheckAvailablility";
            this.CheckAvailablility.ReadOnly = true;
            this.CheckAvailablility.Text = "Book";
            this.CheckAvailablility.UseColumnTextForButtonValue = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Avail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Avail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.RadioButton Executive;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource reservetableBindingSource;
        private HRDataSetTableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CheckAvailablility;
    }
}