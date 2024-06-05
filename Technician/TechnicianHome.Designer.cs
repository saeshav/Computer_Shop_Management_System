namespace group3assignment
{
    partial class TechnicianHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianHome));
            this.label1 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "TECHNICIAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.View.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(54, 117);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(140, 61);
            this.View.TabIndex = 2;
            this.View.Text = "VIEW SERVICE";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(246, 117);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 61);
            this.Add.TabIndex = 3;
            this.Add.Text = "ADD DESCRIPTION";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(54, 224);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 61);
            this.update.TabIndex = 4;
            this.update.Text = "UPDATE PROFILE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(246, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(200, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(2, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // TechnicianHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(488, 333);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.View);
            this.Controls.Add(this.label1);
            this.Name = "TechnicianHome";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.TechnicianHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblName;
    }
}