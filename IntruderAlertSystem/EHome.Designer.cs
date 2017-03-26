namespace Alarm
{
    partial class EHome
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.SHouse = new System.Windows.Forms.GroupBox();
            this.vHouses = new System.Windows.Forms.ComboBox();
            this.Shom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 13);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(392, 314);
            this.dgv.TabIndex = 0;
            // 
            // SHouse
            // 
            this.SHouse.Controls.Add(this.Shom);
            this.SHouse.Controls.Add(this.vHouses);
            this.SHouse.Location = new System.Drawing.Point(412, 13);
            this.SHouse.Name = "SHouse";
            this.SHouse.Size = new System.Drawing.Size(219, 79);
            this.SHouse.TabIndex = 1;
            this.SHouse.TabStop = false;
            this.SHouse.Text = "Select House";
            // 
            // vHouses
            // 
            this.vHouses.FormattingEnabled = true;
            this.vHouses.Location = new System.Drawing.Point(7, 20);
            this.vHouses.Name = "vHouses";
            this.vHouses.Size = new System.Drawing.Size(206, 21);
            this.vHouses.TabIndex = 0;
            // 
            // Shom
            // 
            this.Shom.Location = new System.Drawing.Point(6, 47);
            this.Shom.Name = "Shom";
            this.Shom.Size = new System.Drawing.Size(207, 23);
            this.Shom.TabIndex = 1;
            this.Shom.Text = "Select Home";
            this.Shom.UseVisualStyleBackColor = true;
            this.Shom.Click += new System.EventHandler(this.Shom_Click);
            // 
            // EHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 402);
            this.Controls.Add(this.SHouse);
            this.Controls.Add(this.dgv);
            this.Name = "EHome";
            this.Text = "EHome";
            this.Load += new System.EventHandler(this.EHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.SHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox SHouse;
        private System.Windows.Forms.Button Shom;
        private System.Windows.Forms.ComboBox vHouses;
    }
}