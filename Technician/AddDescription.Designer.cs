namespace group3assignment
{
    partial class AddDescription
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Customer ID:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(20, 187);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(171, 23);
            this.txtid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add Description:";
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadd.Location = new System.Drawing.Point(20, 273);
            this.txtadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(171, 23);
            this.txtadd.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 368);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(33, 428);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 44);
            this.add.TabIndex = 14;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADD DATA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Add Collection Date:";
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.date.Location = new System.Drawing.Point(14, 367);
            this.date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(136, 23);
            this.date.TabIndex = 18;
            this.date.Value = new System.DateTime(2022, 2, 10, 0, 0, 0, 0);
            // 
            // AddDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(965, 526);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddDescription";
            this.Text = "Add Description";
            this.Load += new System.EventHandler(this.AddDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource serviceBindingSource;
        
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
    }
}