namespace group3assignment
{
    partial class ReceptionistHome
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(165, 17);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(248, 29);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Receptionist Home Page";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentity.Location = new System.Drawing.Point(270, 75);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(44, 18);
            this.lblIdentity.TabIndex = 1;
            this.lblIdentity.Text = "label2";
            this.lblIdentity.Click += new System.EventHandler(this.lblIdentity_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnadd.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(197, 131);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(197, 22);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Register Customer";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPayment.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(197, 182);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(197, 22);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(197, 238);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 22);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceptionistHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblHome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReceptionistHome";
            this.Text = "ReceptionistHome";
            this.Load += new System.EventHandler(this.ReceptionistHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHome;
        private Label lblIdentity;
        private Button btnadd;
        private Button btnPayment;
        private Button btnUpdate;
    }
}