﻿namespace Alarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.crtFloor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dHouse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // crtFloor
            // 
            this.crtFloor.Location = new System.Drawing.Point(88, 73);
            this.crtFloor.Name = "crtFloor";
            this.crtFloor.Size = new System.Drawing.Size(152, 23);
            this.crtFloor.TabIndex = 4;
            this.crtFloor.Text = "Create House";
            this.crtFloor.UseVisualStyleBackColor = true;
            this.crtFloor.Click += new System.EventHandler(this.crtFloor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SizeCB);
            this.groupBox1.Controls.Add(this.crtFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a House";
            // 
            // hName
            // 
            this.hName.Location = new System.Drawing.Point(88, 20);
            this.hName.Name = "hName";
            this.hName.Size = new System.Drawing.Size(152, 20);
            this.hName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // SizeCB
            // 
            this.SizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeCB.FormattingEnabled = true;
            this.SizeCB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.SizeCB.Location = new System.Drawing.Point(88, 46);
            this.SizeCB.Name = "SizeCB";
            this.SizeCB.Size = new System.Drawing.Size(152, 21);
            this.SizeCB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dHouse);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 188);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete a House";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(288, 133);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dHouse
            // 
            this.dHouse.Location = new System.Drawing.Point(6, 159);
            this.dHouse.Name = "dHouse";
            this.dHouse.Size = new System.Drawing.Size(289, 23);
            this.dHouse.TabIndex = 8;
            this.dHouse.Text = "Delete House";
            this.dHouse.UseVisualStyleBackColor = true;
            this.dHouse.Click += new System.EventHandler(this.dHouse_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crtFloor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SizeCB;
        private System.Windows.Forms.TextBox hName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dHouse;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}