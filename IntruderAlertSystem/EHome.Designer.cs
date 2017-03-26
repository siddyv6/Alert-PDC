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
            this.Shom = new System.Windows.Forms.Button();
            this.vHouses = new System.Windows.Forms.ComboBox();
            this.roomInfo = new System.Windows.Forms.GroupBox();
            this.XX = new System.Windows.Forms.TextBox();
            this.YY = new System.Windows.Forms.TextBox();
            this.CLDL = new System.Windows.Forms.CheckedListBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.CBCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SHouse.SuspendLayout();
            this.roomInfo.SuspendLayout();
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
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // SHouse
            // 
            this.SHouse.Controls.Add(this.Shom);
            this.SHouse.Controls.Add(this.vHouses);
            this.SHouse.Location = new System.Drawing.Point(412, 13);
            this.SHouse.Name = "SHouse";
            this.SHouse.Size = new System.Drawing.Size(224, 79);
            this.SHouse.TabIndex = 1;
            this.SHouse.TabStop = false;
            this.SHouse.Text = "Select House";
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
            // vHouses
            // 
            this.vHouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vHouses.FormattingEnabled = true;
            this.vHouses.Location = new System.Drawing.Point(7, 20);
            this.vHouses.Name = "vHouses";
            this.vHouses.Size = new System.Drawing.Size(206, 21);
            this.vHouses.TabIndex = 0;
            // 
            // roomInfo
            // 
            this.roomInfo.Controls.Add(this.addRoom);
            this.roomInfo.Controls.Add(this.label2);
            this.roomInfo.Controls.Add(this.label1);
            this.roomInfo.Controls.Add(this.CBCat);
            this.roomInfo.Controls.Add(this.CBType);
            this.roomInfo.Controls.Add(this.CLDL);
            this.roomInfo.Controls.Add(this.YY);
            this.roomInfo.Controls.Add(this.XX);
            this.roomInfo.Location = new System.Drawing.Point(13, 359);
            this.roomInfo.Name = "roomInfo";
            this.roomInfo.Size = new System.Drawing.Size(392, 134);
            this.roomInfo.TabIndex = 2;
            this.roomInfo.TabStop = false;
            this.roomInfo.Text = "roomInfo";
            // 
            // XX
            // 
            this.XX.Location = new System.Drawing.Point(7, 20);
            this.XX.Name = "XX";
            this.XX.ReadOnly = true;
            this.XX.Size = new System.Drawing.Size(24, 20);
            this.XX.TabIndex = 0;
            // 
            // YY
            // 
            this.YY.Location = new System.Drawing.Point(37, 20);
            this.YY.Name = "YY";
            this.YY.ReadOnly = true;
            this.YY.Size = new System.Drawing.Size(24, 20);
            this.YY.TabIndex = 1;
            // 
            // CLDL
            // 
            this.CLDL.FormattingEnabled = true;
            this.CLDL.Location = new System.Drawing.Point(266, 19);
            this.CLDL.Name = "CLDL";
            this.CLDL.Size = new System.Drawing.Size(120, 94);
            this.CLDL.TabIndex = 2;
            // 
            // CBType
            // 
            this.CBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(7, 72);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 21);
            this.CBType.TabIndex = 3;
            // 
            // CBCat
            // 
            this.CBCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCat.FormattingEnabled = true;
            this.CBCat.Location = new System.Drawing.Point(77, 20);
            this.CBCat.Name = "CBCat";
            this.CBCat.Size = new System.Drawing.Size(121, 21);
            this.CBCat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Type";
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.SystemColors.Control;
            this.addRoom.Location = new System.Drawing.Point(7, 100);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(121, 23);
            this.addRoom.TabIndex = 7;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // EHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 505);
            this.Controls.Add(this.roomInfo);
            this.Controls.Add(this.SHouse);
            this.Controls.Add(this.dgv);
            this.Name = "EHome";
            this.Text = "EHome";
            this.Load += new System.EventHandler(this.EHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.SHouse.ResumeLayout(false);
            this.roomInfo.ResumeLayout(false);
            this.roomInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox SHouse;
        private System.Windows.Forms.Button Shom;
        private System.Windows.Forms.ComboBox vHouses;
        private System.Windows.Forms.GroupBox roomInfo;
        private System.Windows.Forms.TextBox XX;
        private System.Windows.Forms.TextBox YY;
        private System.Windows.Forms.CheckedListBox CLDL;
        private System.Windows.Forms.ComboBox CBCat;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRoom;
    }
}