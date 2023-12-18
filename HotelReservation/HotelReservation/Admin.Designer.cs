namespace HotelReservation
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.TFPASS = new System.Windows.Forms.TextBox();
            this.TFUSER = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.Location = new System.Drawing.Point(125, 122);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(66, 23);
            this.BTNEXIT.TabIndex = 11;
            this.BTNEXIT.Text = "EXIT";
            this.BTNEXIT.UseVisualStyleBackColor = true;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Location = new System.Drawing.Point(44, 122);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTNLOGIN.TabIndex = 8;
            this.BTNLOGIN.Text = "LOGIN";
            this.BTNLOGIN.UseVisualStyleBackColor = true;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // TFPASS
            // 
            this.TFPASS.Location = new System.Drawing.Point(44, 96);
            this.TFPASS.Name = "TFPASS";
            this.TFPASS.PasswordChar = '*';
            this.TFPASS.Size = new System.Drawing.Size(147, 20);
            this.TFPASS.TabIndex = 7;
            // 
            // TFUSER
            // 
            this.TFUSER.Location = new System.Drawing.Point(44, 49);
            this.TFUSER.Name = "TFUSER";
            this.TFUSER.Size = new System.Drawing.Size(147, 20);
            this.TFUSER.TabIndex = 6;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(244, 183);
            this.Controls.Add(this.BTNEXIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNLOGIN);
            this.Controls.Add(this.TFPASS);
            this.Controls.Add(this.TFUSER);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNEXIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.TextBox TFPASS;
        private System.Windows.Forms.TextBox TFUSER;
    }
}