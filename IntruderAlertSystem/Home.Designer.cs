namespace Alarm
{
    partial class Home
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
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crtFloor = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.test1)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(634, 20);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 20);
            this.X.TabIndex = 0;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(634, 46);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 20);
            this.Y.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // crtFloor
            // 
            this.crtFloor.Location = new System.Drawing.Point(634, 73);
            this.crtFloor.Name = "crtFloor";
            this.crtFloor.Size = new System.Drawing.Size(100, 23);
            this.crtFloor.TabIndex = 4;
            this.crtFloor.Text = "Create Floor";
            this.crtFloor.UseVisualStyleBackColor = true;
            this.crtFloor.Click += new System.EventHandler(this.crtFloor_Click);
            // 
            // test1
            // 
            this.test1.AllowUserToAddRows = false;
            this.test1.AllowUserToDeleteRows = false;
            this.test1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.test1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.test1.Location = new System.Drawing.Point(12, 14);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(379, 327);
            this.test1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(428, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a House";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.crtFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.test1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button crtFloor;
        private System.Windows.Forms.DataGridView test1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}