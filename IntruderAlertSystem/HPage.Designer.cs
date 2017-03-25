namespace Alarm
{
    partial class HPage
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
            this.VHLogs = new System.Windows.Forms.Button();
            this.SLogs = new System.Windows.Forms.Button();
            this.viewHouse = new System.Windows.Forms.Button();
            this.createHouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // VHLogs
            // 
            this.VHLogs.Location = new System.Drawing.Point(28, 33);
            this.VHLogs.Name = "VHLogs";
            this.VHLogs.Size = new System.Drawing.Size(231, 41);
            this.VHLogs.TabIndex = 1;
            this.VHLogs.Text = "View House Logs";
            this.VHLogs.UseVisualStyleBackColor = true;
            this.VHLogs.Click += new System.EventHandler(this.VHLogs_Click);
            // 
            // SLogs
            // 
            this.SLogs.Location = new System.Drawing.Point(28, 80);
            this.SLogs.Name = "SLogs";
            this.SLogs.Size = new System.Drawing.Size(231, 41);
            this.SLogs.TabIndex = 2;
            this.SLogs.Text = "Sensors and Logs";
            this.SLogs.UseVisualStyleBackColor = true;
            this.SLogs.Click += new System.EventHandler(this.SLogs_Click);
            // 
            // viewHouse
            // 
            this.viewHouse.Location = new System.Drawing.Point(28, 127);
            this.viewHouse.Name = "viewHouse";
            this.viewHouse.Size = new System.Drawing.Size(231, 37);
            this.viewHouse.TabIndex = 3;
            this.viewHouse.Text = "View Houses";
            this.viewHouse.UseVisualStyleBackColor = true;
            this.viewHouse.Click += new System.EventHandler(this.viewHouse_Click);
            // 
            // createHouse
            // 
            this.createHouse.Location = new System.Drawing.Point(28, 170);
            this.createHouse.Name = "createHouse";
            this.createHouse.Size = new System.Drawing.Size(231, 37);
            this.createHouse.TabIndex = 4;
            this.createHouse.Text = "Create a House";
            this.createHouse.UseVisualStyleBackColor = true;
            this.createHouse.Click += new System.EventHandler(this.createHouse_Click_1);
            // 
            // HPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 296);
            this.Controls.Add(this.createHouse);
            this.Controls.Add(this.viewHouse);
            this.Controls.Add(this.SLogs);
            this.Controls.Add(this.VHLogs);
            this.Controls.Add(this.label1);
            this.Name = "HPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VHLogs;
        private System.Windows.Forms.Button SLogs;
        private System.Windows.Forms.Button viewHouse;
        private System.Windows.Forms.Button createHouse;
        private System.Windows.Forms.Label label1;
    }
}