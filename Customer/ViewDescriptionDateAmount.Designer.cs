namespace group3assignment
{
    partial class ViewDescriptionDateAmount
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
            this.lblDescriptionDateAmount = new System.Windows.Forms.Label();
            this.CustomerdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescriptionDateAmount
            // 
            this.lblDescriptionDateAmount.AutoSize = true;
            this.lblDescriptionDateAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescriptionDateAmount.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionDateAmount.Location = new System.Drawing.Point(200, 40);
            this.lblDescriptionDateAmount.Name = "lblDescriptionDateAmount";
            this.lblDescriptionDateAmount.Size = new System.Drawing.Size(314, 28);
            this.lblDescriptionDateAmount.TabIndex = 0;
            this.lblDescriptionDateAmount.Text = "Description, Date and Total Amount";
            // 
            // CustomerdataGridView1
            // 
            this.CustomerdataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CustomerdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerdataGridView1.Location = new System.Drawing.Point(81, 124);
            this.CustomerdataGridView1.Name = "CustomerdataGridView1";
            this.CustomerdataGridView1.RowHeadersWidth = 51;
            this.CustomerdataGridView1.RowTemplate.Height = 24;
            this.CustomerdataGridView1.Size = new System.Drawing.Size(921, 242);
            this.CustomerdataGridView1.TabIndex = 1;
            // 
            // ViewDescriptionDateAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1060, 422);
            this.Controls.Add(this.CustomerdataGridView1);
            this.Controls.Add(this.lblDescriptionDateAmount);
            this.Name = "ViewDescriptionDateAmount";
            this.Text = "ViewDescriptionDateAmount";
            this.Load += new System.EventHandler(this.ViewDescriptionDateAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescriptionDateAmount;
        private System.Windows.Forms.DataGridView CustomerdataGridView1;
    }
}