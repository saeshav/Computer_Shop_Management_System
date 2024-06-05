namespace group3assignment
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lblPay = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.rdbTransfer = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPay.Location = new System.Drawing.Point(181, 9);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(99, 29);
            this.lblPay.TabIndex = 0;
            this.lblPay.Text = "Payment";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.Location = new System.Drawing.Point(14, 104);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(97, 18);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer Name";
            this.lblCustomer.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblService.Location = new System.Drawing.Point(27, 188);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(78, 18);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "ServiceType";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFee.Location = new System.Drawing.Point(57, 265);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(35, 18);
            this.lblFee.TabIndex = 4;
            this.lblFee.Text = "Fees";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMethod.Location = new System.Drawing.Point(5, 323);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(100, 18);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Payment Method";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtType.Location = new System.Drawing.Point(181, 186);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(344, 24);
            this.txtType.TabIndex = 8;
            this.txtType.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtFees.Location = new System.Drawing.Point(181, 262);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(344, 24);
            this.txtFees.TabIndex = 9;
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Location = new System.Drawing.Point(183, 326);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(126, 22);
            this.rdbCredit.TabIndex = 10;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Cerdit/Debit Card";
            this.rdbCredit.UseVisualStyleBackColor = true;
            // 
            // rdbTransfer
            // 
            this.rdbTransfer.AutoSize = true;
            this.rdbTransfer.Location = new System.Drawing.Point(350, 326);
            this.rdbTransfer.Name = "rdbTransfer";
            this.rdbTransfer.Size = new System.Drawing.Size(103, 22);
            this.rdbTransfer.TabIndex = 11;
            this.rdbTransfer.TabStop = true;
            this.rdbTransfer.Text = "Bank transfer";
            this.rdbTransfer.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPay.Location = new System.Drawing.Point(14, 459);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 30);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerate.Location = new System.Drawing.Point(131, 459);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 30);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.Location = new System.Drawing.Point(372, 459);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(575, -2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(608, 535);
            this.txtResult.TabIndex = 15;
            this.txtResult.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(255, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayment.Location = new System.Drawing.Point(329, 391);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(64, 17);
            this.txtPayment.TabIndex = 17;
            this.txtPayment.Text = "Paid";
            this.txtPayment.Visible = false;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpdate.Location = new System.Drawing.Point(116, 391);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(277, 20);
            this.lblUpdate.TabIndex = 18;
            this.lblUpdate.Text = "Payment will be updated in the system after Paid";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(177, 104);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(348, 26);
            this.cmbCustomer.TabIndex = 19;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.rdbTransfer);
            this.Controls.Add(this.rdbCredit);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblPay);
            this.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPay;
        private Label lblCustomer;
        private Label lblService;
        private Label lblFee;
        private Label lblMethod;
        private TextBox txtType;
        private TextBox txtFees;
        private RadioButton rdbCredit;
        private RadioButton rdbTransfer;
        private Button btnPay;
        private Button btnGenerate;
        private Button btnPrint;
        private RichTextBox txtResult;
        private Button btnCancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox txtPayment;
        private Label lblUpdate;
        private ComboBox cmbCustomer;
    }
}