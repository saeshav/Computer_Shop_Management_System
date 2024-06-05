namespace group3assignment
{
    partial class AddCustomer
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCemail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(373, 38);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(193, 25);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Customer Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(207, 99);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(207, 150);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(177, 205);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(129, 25);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(187, 270);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(115, 25);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service Type";
            // 
            // txtCname
            // 
            this.txtCname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCname.Location = new System.Drawing.Point(343, 99);
            this.txtCname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(155, 32);
            this.txtCname.TabIndex = 8;
            this.txtCname.TextChanged += new System.EventHandler(this.txtCname_TextChanged);
            // 
            // txtCemail
            // 
            this.txtCemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCemail.Location = new System.Drawing.Point(343, 150);
            this.txtCemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCemail.Name = "txtCemail";
            this.txtCemail.Size = new System.Drawing.Size(155, 32);
            this.txtCemail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(343, 201);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(155, 32);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister.Location = new System.Drawing.Point(257, 481);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(291, 36);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(177, 336);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 25);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Amount";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(177, 405);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(137, 25);
            this.lblPayment.TabIndex = 19;
            this.lblPayment.Text = "Payment Status";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshoot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement ",
            "Laptop battery replacement",
            "Operating system format and installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.cmbType.Location = new System.Drawing.Point(343, 260);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(608, 33);
            this.cmbType.TabIndex = 20;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Not Paid"});
            this.cmbStatus.Location = new System.Drawing.Point(343, 405);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 33);
            this.cmbStatus.TabIndex = 22;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtAmount.Location = new System.Drawing.Point(343, 336);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(155, 32);
            this.txtAmount.TabIndex = 23;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCemail);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegister);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegister;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblService;
        private TextBox txtCname;
        private TextBox txtCemail;
        private TextBox txtPhoneNumber;
        private Button btnRegister;
        private Label lblTotal;
        private Label lblPayment;
        private ComboBox cmbType;
        private ComboBox cmbStatus;
        private TextBox txtAmount;
    }
}