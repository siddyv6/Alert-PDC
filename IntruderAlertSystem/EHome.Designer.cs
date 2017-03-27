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
            this.addRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCat = new System.Windows.Forms.ComboBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.CLDL = new System.Windows.Forms.CheckedListBox();
            this.YY = new System.Windows.Forms.TextBox();
            this.XX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sValue = new System.Windows.Forms.TextBox();
            this.sensorTypess = new System.Windows.Forms.ComboBox();
            this.SList = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.removeSensor = new System.Windows.Forms.Button();
            this.addSensor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SHouse.SuspendLayout();
            this.roomInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(266, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.Size = new System.Drawing.Size(465, 418);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // SHouse
            // 
            this.SHouse.Controls.Add(this.Shom);
            this.SHouse.Controls.Add(this.vHouses);
            this.SHouse.Location = new System.Drawing.Point(14, 12);
            this.SHouse.Name = "SHouse";
            this.SHouse.Size = new System.Drawing.Size(246, 74);
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
            this.roomInfo.Controls.Add(this.label3);
            this.roomInfo.Controls.Add(this.addRoom);
            this.roomInfo.Controls.Add(this.label2);
            this.roomInfo.Controls.Add(this.label1);
            this.roomInfo.Controls.Add(this.CBCat);
            this.roomInfo.Controls.Add(this.CBType);
            this.roomInfo.Controls.Add(this.CLDL);
            this.roomInfo.Controls.Add(this.YY);
            this.roomInfo.Controls.Add(this.XX);
            this.roomInfo.Location = new System.Drawing.Point(9, 92);
            this.roomInfo.Name = "roomInfo";
            this.roomInfo.Size = new System.Drawing.Size(235, 245);
            this.roomInfo.TabIndex = 2;
            this.roomInfo.TabStop = false;
            this.roomInfo.Text = "Add Room";
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.SystemColors.Control;
            this.addRoom.Location = new System.Drawing.Point(3, 199);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(125, 23);
            this.addRoom.TabIndex = 7;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Location";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBCat
            // 
            this.CBCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCat.FormattingEnabled = true;
            this.CBCat.Location = new System.Drawing.Point(108, 34);
            this.CBCat.Name = "CBCat";
            this.CBCat.Size = new System.Drawing.Size(121, 21);
            this.CBCat.TabIndex = 4;
            this.CBCat.Visible = false;
            this.CBCat.SelectedIndexChanged += new System.EventHandler(this.CBCat_SelectedIndexChanged);
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
            // CLDL
            // 
            this.CLDL.FormattingEnabled = true;
            this.CLDL.Location = new System.Drawing.Point(6, 114);
            this.CLDL.Name = "CLDL";
            this.CLDL.Size = new System.Drawing.Size(121, 79);
            this.CLDL.TabIndex = 2;
            this.CLDL.SelectedIndexChanged += new System.EventHandler(this.CLDL_SelectedIndexChanged);
            // 
            // YY
            // 
            this.YY.Location = new System.Drawing.Point(37, 20);
            this.YY.Name = "YY";
            this.YY.ReadOnly = true;
            this.YY.Size = new System.Drawing.Size(24, 20);
            this.YY.TabIndex = 1;
            // 
            // XX
            // 
            this.XX.Location = new System.Drawing.Point(7, 20);
            this.XX.Name = "XX";
            this.XX.ReadOnly = true;
            this.XX.Size = new System.Drawing.Size(24, 20);
            this.XX.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sValue);
            this.groupBox1.Controls.Add(this.sensorTypess);
            this.groupBox1.Controls.Add(this.SList);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.removeSensor);
            this.groupBox1.Controls.Add(this.addSensor);
            this.groupBox1.Location = new System.Drawing.Point(737, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Information";
            // 
            // sValue
            // 
            this.sValue.Location = new System.Drawing.Point(7, 296);
            this.sValue.Name = "sValue";
            this.sValue.Size = new System.Drawing.Size(132, 20);
            this.sValue.TabIndex = 13;
            // 
            // sensorTypess
            // 
            this.sensorTypess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorTypess.FormattingEnabled = true;
            this.sensorTypess.Location = new System.Drawing.Point(7, 252);
            this.sensorTypess.Name = "sensorTypess";
            this.sensorTypess.Size = new System.Drawing.Size(132, 21);
            this.sensorTypess.TabIndex = 12;
            // 
            // SList
            // 
            this.SList.AllowUserToAddRows = false;
            this.SList.AllowUserToDeleteRows = false;
            this.SList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SList.Location = new System.Drawing.Point(7, 20);
            this.SList.Name = "SList";
            this.SList.Size = new System.Drawing.Size(315, 159);
            this.SList.TabIndex = 11;
            this.SList.SelectionChanged += new System.EventHandler(this.SList_SelectionChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update Sensor Values";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // removeSensor
            // 
            this.removeSensor.Location = new System.Drawing.Point(7, 188);
            this.removeSensor.Name = "removeSensor";
            this.removeSensor.Size = new System.Drawing.Size(297, 40);
            this.removeSensor.TabIndex = 9;
            this.removeSensor.Text = "Remove Sensor";
            this.removeSensor.UseVisualStyleBackColor = true;
            this.removeSensor.Click += new System.EventHandler(this.removeSensor_Click);
            // 
            // addSensor
            // 
            this.addSensor.Location = new System.Drawing.Point(145, 252);
            this.addSensor.Name = "addSensor";
            this.addSensor.Size = new System.Drawing.Size(159, 21);
            this.addSensor.TabIndex = 8;
            this.addSensor.Text = "Add Sensor";
            this.addSensor.UseVisualStyleBackColor = true;
            this.addSensor.Click += new System.EventHandler(this.addSensor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Door Location";
            // 
            // EHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 434);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SList)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeSensor;
        private System.Windows.Forms.Button addSensor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView SList;
        private System.Windows.Forms.ComboBox sensorTypess;
        private System.Windows.Forms.TextBox sValue;
        private System.Windows.Forms.Label label3;
    }
}