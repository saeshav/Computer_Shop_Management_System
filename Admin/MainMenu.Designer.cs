namespace group3assignment
{
    partial class MainMenu
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
            this.btnRegisterTec = new System.Windows.Forms.Button();
            this.btnRegisterRec = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.btnViewService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterTec
            // 
            this.btnRegisterTec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegisterTec.Location = new System.Drawing.Point(260, 72);
            this.btnRegisterTec.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterTec.Name = "btnRegisterTec";
            this.btnRegisterTec.Size = new System.Drawing.Size(78, 32);
            this.btnRegisterTec.TabIndex = 0;
            this.btnRegisterTec.Text = "Register";
            this.btnRegisterTec.UseVisualStyleBackColor = false;
            this.btnRegisterTec.Click += new System.EventHandler(this.btnRegisterTec_Click);
            // 
            // btnRegisterRec
            // 
            this.btnRegisterRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegisterRec.Location = new System.Drawing.Point(260, 109);
            this.btnRegisterRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterRec.Name = "btnRegisterRec";
            this.btnRegisterRec.Size = new System.Drawing.Size(78, 32);
            this.btnRegisterRec.TabIndex = 1;
            this.btnRegisterRec.Text = "Register";
            this.btnRegisterRec.UseVisualStyleBackColor = false;
            this.btnRegisterRec.Click += new System.EventHandler(this.btnRegisterRec_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewIncome.Location = new System.Drawing.Point(260, 144);
            this.btnViewIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(78, 32);
            this.btnViewIncome.TabIndex = 2;
            this.btnViewIncome.Text = "View";
            this.btnViewIncome.UseVisualStyleBackColor = false;
            this.btnViewIncome.Click += new System.EventHandler(this.btnViewIncome_Click);
            // 
            // btnViewService
            // 
            this.btnViewService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewService.Location = new System.Drawing.Point(260, 182);
            this.btnViewService.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewService.Name = "btnViewService";
            this.btnViewService.Size = new System.Drawing.Size(78, 32);
            this.btnViewService.TabIndex = 3;
            this.btnViewService.Text = "View";
            this.btnViewService.UseVisualStyleBackColor = false;
            this.btnViewService.Click += new System.EventHandler(this.btnViewService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Register new technician";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Register new Receptionist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "View Total Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "View Service Report";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewService);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnRegisterRec);
            this.Controls.Add(this.btnRegisterTec);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegisterTec;
        private Button btnRegisterRec;
        private Button btnViewIncome;
        private Button btnViewService;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}