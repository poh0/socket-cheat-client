namespace ZBase
{
    partial class Menu
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
            this.BunnyhopCheck = new System.Windows.Forms.CheckBox();
            this.ESPCheck = new System.Windows.Forms.CheckBox();
            this.ZbaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.boxesp_checkbox = new System.Windows.Forms.CheckBox();
            this.healthbar_checkbox = new System.Windows.Forms.CheckBox();
            this.snaplines_checkbox = new System.Windows.Forms.CheckBox();
            this.fov_trackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.fov_value_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fov_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // BunnyhopCheck
            // 
            this.BunnyhopCheck.AutoSize = true;
            this.BunnyhopCheck.Location = new System.Drawing.Point(12, 12);
            this.BunnyhopCheck.Name = "BunnyhopCheck";
            this.BunnyhopCheck.Size = new System.Drawing.Size(51, 17);
            this.BunnyhopCheck.TabIndex = 2;
            this.BunnyhopCheck.Text = "Bhop";
            this.BunnyhopCheck.UseVisualStyleBackColor = true;
            this.BunnyhopCheck.CheckedChanged += new System.EventHandler(this.BunnyhopCheck_CheckedChanged);
            // 
            // ESPCheck
            // 
            this.ESPCheck.AutoSize = true;
            this.ESPCheck.Location = new System.Drawing.Point(12, 35);
            this.ESPCheck.Name = "ESPCheck";
            this.ESPCheck.Size = new System.Drawing.Size(104, 17);
            this.ESPCheck.TabIndex = 7;
            this.ESPCheck.Text = "Visuals (Overlay)";
            this.ESPCheck.UseVisualStyleBackColor = true;
            this.ESPCheck.CheckedChanged += new System.EventHandler(this.ESPCheck_CheckedChanged);
            // 
            // ZbaseLinkLabel
            // 
            this.ZbaseLinkLabel.AutoSize = true;
            this.ZbaseLinkLabel.Location = new System.Drawing.Point(334, 165);
            this.ZbaseLinkLabel.Name = "ZbaseLinkLabel";
            this.ZbaseLinkLabel.Size = new System.Drawing.Size(38, 13);
            this.ZbaseLinkLabel.TabIndex = 8;
            this.ZbaseLinkLabel.TabStop = true;
            this.ZbaseLinkLabel.Text = "ZBase";
            this.ZbaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ZbaseLinkLabel_LinkClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(309, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Connecting...";
            // 
            // boxesp_checkbox
            // 
            this.boxesp_checkbox.AutoSize = true;
            this.boxesp_checkbox.Location = new System.Drawing.Point(22, 59);
            this.boxesp_checkbox.Name = "boxesp_checkbox";
            this.boxesp_checkbox.Size = new System.Drawing.Size(64, 17);
            this.boxesp_checkbox.TabIndex = 10;
            this.boxesp_checkbox.Text = "Box esp";
            this.boxesp_checkbox.UseVisualStyleBackColor = true;
            this.boxesp_checkbox.CheckedChanged += new System.EventHandler(this.boxesp_checkbox_CheckedChanged);
            // 
            // healthbar_checkbox
            // 
            this.healthbar_checkbox.AutoSize = true;
            this.healthbar_checkbox.Location = new System.Drawing.Point(22, 82);
            this.healthbar_checkbox.Name = "healthbar_checkbox";
            this.healthbar_checkbox.Size = new System.Drawing.Size(72, 17);
            this.healthbar_checkbox.TabIndex = 11;
            this.healthbar_checkbox.Text = "Healthbar";
            this.healthbar_checkbox.UseVisualStyleBackColor = true;
            this.healthbar_checkbox.CheckedChanged += new System.EventHandler(this.healthbar_checkbox_CheckedChanged);
            // 
            // snaplines_checkbox
            // 
            this.snaplines_checkbox.AutoSize = true;
            this.snaplines_checkbox.Location = new System.Drawing.Point(22, 105);
            this.snaplines_checkbox.Name = "snaplines_checkbox";
            this.snaplines_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.snaplines_checkbox.Size = new System.Drawing.Size(72, 17);
            this.snaplines_checkbox.TabIndex = 12;
            this.snaplines_checkbox.Text = "Snaplines";
            this.snaplines_checkbox.UseVisualStyleBackColor = true;
            this.snaplines_checkbox.CheckedChanged += new System.EventHandler(this.snaplines_checkbox_CheckedChanged);
            // 
            // fov_trackbar
            // 
            this.fov_trackbar.Location = new System.Drawing.Point(136, 31);
            this.fov_trackbar.Maximum = 180;
            this.fov_trackbar.Name = "fov_trackbar";
            this.fov_trackbar.Size = new System.Drawing.Size(104, 45);
            this.fov_trackbar.TabIndex = 13;
            this.fov_trackbar.Value = 90;
            this.fov_trackbar.Scroll += new System.EventHandler(this.fov_trackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "FOV";
            // 
            // fov_value_label
            // 
            this.fov_value_label.AutoSize = true;
            this.fov_value_label.Location = new System.Drawing.Point(175, 59);
            this.fov_value_label.Name = "fov_value_label";
            this.fov_value_label.Size = new System.Drawing.Size(35, 13);
            this.fov_value_label.TabIndex = 15;
            this.fov_value_label.Text = "label2";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.fov_value_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fov_trackbar);
            this.Controls.Add(this.snaplines_checkbox);
            this.Controls.Add(this.healthbar_checkbox);
            this.Controls.Add(this.boxesp_checkbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ZbaseLinkLabel);
            this.Controls.Add(this.ESPCheck);
            this.Controls.Add(this.BunnyhopCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "socket-cheat";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fov_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox BunnyhopCheck;
        private System.Windows.Forms.CheckBox ESPCheck;
        private System.Windows.Forms.LinkLabel ZbaseLinkLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox boxesp_checkbox;
        private System.Windows.Forms.CheckBox healthbar_checkbox;
        private System.Windows.Forms.CheckBox snaplines_checkbox;
        private System.Windows.Forms.TrackBar fov_trackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fov_value_label;
    }
}

