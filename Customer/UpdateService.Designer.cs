namespace group3assignment
{
    partial class UpdateService
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblNewService = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(280, 37);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(144, 28);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Update Service";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServiceID.Location = new System.Drawing.Point(102, 143);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(152, 26);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Enter Service ID:";
            // 
            // lblNewService
            // 
            this.lblNewService.AutoSize = true;
            this.lblNewService.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewService.Location = new System.Drawing.Point(102, 226);
            this.lblNewService.Name = "lblNewService";
            this.lblNewService.Size = new System.Drawing.Size(169, 26);
            this.lblNewService.TabIndex = 2;
            this.lblNewService.Text = "Enter New Service:";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(280, 334);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(103, 38);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Remove virus, malware or spyware - Normal",
            "Remove virus, malware or spyware - Urgent",
            "Troubleshot and fix computer running slow - Normal",
            "Troubleshot and fix computer running slow - Urgent",
            "Laptop screen replacement - Normal",
            "Laptop screen replacement - Urgent",
            "Laptop keyboard replacement - Normal",
            "Laptop keyboard replacement - Urgent",
            "Laptop battery replacement - Normal",
            "Laptop battery replacement - Urgent",
            "Operating System Format and Installation - Normal",
            "Operating System Format and Installation - Urgent",
            "Data backup and recovery - Normal",
            "Data backup and recovery - Urgent",
            "Internet connectivity issues - Normal",
            "Internet connectivity issues - Urgent"});
            this.cboService.Location = new System.Drawing.Point(280, 226);
            this.cboService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(238, 23);
            this.cboService.TabIndex = 6;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Location = new System.Drawing.Point(280, 143);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(238, 23);
            this.txtServiceId.TabIndex = 7;
            this.txtServiceId.TextChanged += new System.EventHandler(this.txtServiceID_TextChanged);
            // 
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.lblNewService);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.lblTittle);
            this.Name = "UpdateService";
            this.Text = "ServiceRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblNewService;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private ComboBox cboService;
        private TextBox txtServiceId;
    }
}