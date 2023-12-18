namespace HotelReservation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBOOK = new System.Windows.Forms.Button();
            this.BTNADMIN = new System.Windows.Forms.Button();
            this.BTNMANAGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manuel Hotel Reservation";
            // 
            // BTNBOOK
            // 
            this.BTNBOOK.BackColor = System.Drawing.Color.SlateGray;
            this.BTNBOOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBOOK.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNBOOK.Location = new System.Drawing.Point(297, 276);
            this.BTNBOOK.Name = "BTNBOOK";
            this.BTNBOOK.Size = new System.Drawing.Size(186, 59);
            this.BTNBOOK.TabIndex = 1;
            this.BTNBOOK.Text = "BOOK NOW!";
            this.BTNBOOK.UseVisualStyleBackColor = false;
            this.BTNBOOK.Click += new System.EventHandler(this.BTNBOOK_Click);
            // 
            // BTNADMIN
            // 
            this.BTNADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADMIN.Location = new System.Drawing.Point(709, 380);
            this.BTNADMIN.Name = "BTNADMIN";
            this.BTNADMIN.Size = new System.Drawing.Size(73, 30);
            this.BTNADMIN.TabIndex = 2;
            this.BTNADMIN.Text = "Admin";
            this.BTNADMIN.UseVisualStyleBackColor = true;
            this.BTNADMIN.Click += new System.EventHandler(this.BTNADMIN_Click);
            // 
            // BTNMANAGE
            // 
            this.BTNMANAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMANAGE.Location = new System.Drawing.Point(709, 416);
            this.BTNMANAGE.Name = "BTNMANAGE";
            this.BTNMANAGE.Size = new System.Drawing.Size(73, 30);
            this.BTNMANAGE.TabIndex = 3;
            this.BTNMANAGE.Text = "Manage";
            this.BTNMANAGE.UseVisualStyleBackColor = true;
            this.BTNMANAGE.Click += new System.EventHandler(this.BTNMANAGE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNMANAGE);
            this.Controls.Add(this.BTNADMIN);
            this.Controls.Add(this.BTNBOOK);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBOOK;
        private System.Windows.Forms.Button BTNADMIN;
        private System.Windows.Forms.Button BTNMANAGE;
    }
}

