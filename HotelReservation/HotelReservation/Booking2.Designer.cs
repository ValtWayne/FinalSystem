namespace HotelReservation
{
    partial class Booking2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking2));
            this.label2 = new System.Windows.Forms.Label();
            this.Avail = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TContact = new System.Windows.Forms.TextBox();
            this.TName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Deluxe = new System.Windows.Forms.RadioButton();
            this.Executive = new System.Windows.Forms.RadioButton();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.reservetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HotelReservation.HRDataSet();
            this.reserve_tableTableAdapter = new HotelReservation.HRDataSetTableAdapters.reserve_tableTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.BOOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check In Date:";
            // 
            // Avail
            // 
            this.Avail.Location = new System.Drawing.Point(170, 49);
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(200, 20);
            this.Avail.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.TEmail);
            this.groupBox1.Controls.Add(this.TContact);
            this.groupBox1.Controls.Add(this.TName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Bisque;
            this.groupBox1.Location = new System.Drawing.Point(39, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(716, 38);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(185, 38);
            this.TEmail.TabIndex = 5;
            // 
            // TContact
            // 
            this.TContact.Location = new System.Drawing.Point(445, 37);
            this.TContact.Name = "TContact";
            this.TContact.Size = new System.Drawing.Size(191, 38);
            this.TContact.TabIndex = 4;
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(88, 38);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(212, 38);
            this.TName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(603, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check Out Date:";
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(751, 50);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(200, 20);
            this.CheckOut.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox2.Controls.Add(this.Deluxe);
            this.groupBox2.Controls.Add(this.Executive);
            this.groupBox2.Controls.Add(this.Classic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Bisque;
            this.groupBox2.Location = new System.Drawing.Point(127, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // Deluxe
            // 
            this.Deluxe.AutoSize = true;
            this.Deluxe.Location = new System.Drawing.Point(292, 37);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deluxe.Size = new System.Drawing.Size(122, 35);
            this.Deluxe.TabIndex = 1;
            this.Deluxe.TabStop = true;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.UseVisualStyleBackColor = true;
            // 
            // Executive
            // 
            this.Executive.AutoSize = true;
            this.Executive.Location = new System.Drawing.Point(526, 37);
            this.Executive.Name = "Executive";
            this.Executive.Size = new System.Drawing.Size(159, 35);
            this.Executive.TabIndex = 0;
            this.Executive.TabStop = true;
            this.Executive.Text = "Executive";
            this.Executive.UseVisualStyleBackColor = true;
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
            // reservetableBindingSource
            // 
            this.reservetableBindingSource.DataMember = "reserve_table";
            this.reservetableBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Search.Location = new System.Drawing.Point(735, 350);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(158, 44);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // BOOK
            // 
            this.BOOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BOOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOK.ForeColor = System.Drawing.Color.Bisque;
            this.BOOK.Location = new System.Drawing.Point(409, 503);
            this.BOOK.Name = "BOOK";
            this.BOOK.Size = new System.Drawing.Size(158, 44);
            this.BOOK.TabIndex = 9;
            this.BOOK.Text = "BOOK";
            this.BOOK.UseVisualStyleBackColor = false;
            this.BOOK.Click += new System.EventHandler(this.BOOK_Click);
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
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(264, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 10;
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
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.ForeColor = System.Drawing.Color.Bisque;
            this.Select.Location = new System.Drawing.Point(735, 413);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(158, 44);
            this.Select.TabIndex = 11;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Booking2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BOOK);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Avail);
            this.Controls.Add(this.label2);
            this.Name = "Booking2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking2";
            this.Load += new System.EventHandler(this.Booking2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Avail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CheckOut;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TContact;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.RadioButton Executive;
        private System.Windows.Forms.RadioButton Classic;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource reservetableBindingSource;
        private HRDataSetTableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button BOOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Select;
    }
}