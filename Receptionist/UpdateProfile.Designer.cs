namespace group3assignment
{
    partial class Update_Profile
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdate.Location = new System.Drawing.Point(251, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(149, 29);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "Update Profile";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(196, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(196, 281);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(89, 18);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Phone Number";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMail.Location = new System.Drawing.Point(316, 208);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 24);
            this.txtMail.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNumber.Location = new System.Drawing.Point(316, 278);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(125, 24);
            this.txtNumber.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(278, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtname.Location = new System.Drawing.Point(316, 141);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 24);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // Update_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUpdate);
            this.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Update_Profile";
            this.Load += new System.EventHandler(this.Update_Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUpdate;
        private Label lblEmail;
        private Label lblNumber;
        private TextBox txtMail;
        private TextBox txtNumber;
        private Button btnUpdate;
        private Label label1;
        private TextBox txtname;
    }
}