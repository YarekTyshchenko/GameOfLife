namespace WindowsApplication4
{
    partial class Form2
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
            this.OKButton = new System.Windows.Forms.Button();
            this.RuleBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wrapCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SimSpeedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimSpeed = new System.Windows.Forms.TrackBar();
            this.GridSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.GridCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(205, 238);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RuleBox
            // 
            this.RuleBox.Location = new System.Drawing.Point(128, 17);
            this.RuleBox.Name = "RuleBox";
            this.RuleBox.Size = new System.Drawing.Size(133, 20);
            this.RuleBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridCheckbox);
            this.groupBox1.Controls.Add(this.wrapCheckbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SimSpeedLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SimSpeed);
            this.groupBox1.Controls.Add(this.GridSizeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GridBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RuleBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation";
            // 
            // wrapCheckbox
            // 
            this.wrapCheckbox.AutoSize = true;
            this.wrapCheckbox.Location = new System.Drawing.Point(10, 60);
            this.wrapCheckbox.Name = "wrapCheckbox";
            this.wrapCheckbox.Size = new System.Drawing.Size(115, 17);
            this.wrapCheckbox.TabIndex = 104;
            this.wrapCheckbox.Text = "Wrap life on edges";
            this.wrapCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "fps";
            // 
            // SimSpeedLabel
            // 
            this.SimSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SimSpeedLabel.AutoSize = true;
            this.SimSpeedLabel.Location = new System.Drawing.Point(194, 128);
            this.SimSpeedLabel.Name = "SimSpeedLabel";
            this.SimSpeedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SimSpeedLabel.Size = new System.Drawing.Size(35, 13);
            this.SimSpeedLabel.TabIndex = 102;
            this.SimSpeedLabel.Text = "label4";
            this.SimSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Simulation Speed:";
            // 
            // SimSpeed
            // 
            this.SimSpeed.Location = new System.Drawing.Point(6, 83);
            this.SimSpeed.Maximum = 100;
            this.SimSpeed.Minimum = 1;
            this.SimSpeed.Name = "SimSpeed";
            this.SimSpeed.Size = new System.Drawing.Size(250, 42);
            this.SimSpeed.TabIndex = 100;
            this.SimSpeed.TickFrequency = 10;
            this.SimSpeed.Value = 10;
            this.SimSpeed.ValueChanged += new System.EventHandler(this.SimSpeed_ValueChanged);
            // 
            // GridSizeLabel
            // 
            this.GridSizeLabel.AutoSize = true;
            this.GridSizeLabel.Location = new System.Drawing.Point(221, 189);
            this.GridSizeLabel.Name = "GridSizeLabel";
            this.GridSizeLabel.Size = new System.Drawing.Size(35, 13);
            this.GridSizeLabel.TabIndex = 5;
            this.GridSizeLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grid Multiplier:";
            // 
            // GridBar
            // 
            this.GridBar.Location = new System.Drawing.Point(6, 144);
            this.GridBar.Maximum = 16;
            this.GridBar.Minimum = 1;
            this.GridBar.Name = "GridBar";
            this.GridBar.Size = new System.Drawing.Size(251, 42);
            this.GridBar.TabIndex = 3;
            this.GridBar.Value = 1;
            this.GridBar.ValueChanged += new System.EventHandler(this.GridBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rule:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(124, 237);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // GridCheckbox
            // 
            this.GridCheckbox.AutoSize = true;
            this.GridCheckbox.Location = new System.Drawing.Point(132, 60);
            this.GridCheckbox.Name = "GridCheckbox";
            this.GridCheckbox.Size = new System.Drawing.Size(73, 17);
            this.GridCheckbox.TabIndex = 105;
            this.GridCheckbox.Text = "Show grid";
            this.GridCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKButton);
            this.Name = "Form2";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox RuleBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar GridBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GridSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TrackBar SimSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SimSpeedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox wrapCheckbox;
        private System.Windows.Forms.CheckBox GridCheckbox;
    }
}