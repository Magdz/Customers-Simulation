namespace Customers_Simulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WH_Label = new System.Windows.Forms.Label();
            this.Aph_Label = new System.Windows.Forms.Label();
            this.ST_Label = new System.Windows.Forms.Label();
            this.S_Button = new System.Windows.Forms.Button();
            this.Out_Box = new System.Windows.Forms.TextBox();
            this.WW_Box = new System.Windows.Forms.TextBox();
            this.CW_Box = new System.Windows.Forms.TextBox();
            this.WW_Label = new System.Windows.Forms.Label();
            this.CW_Label = new System.Windows.Forms.Label();
            this.DS_Label = new System.Windows.Forms.Label();
            this.WH_NBox = new System.Windows.Forms.NumericUpDown();
            this.ST_NBox = new System.Windows.Forms.NumericUpDown();
            this.Aph_NBox = new System.Windows.Forms.NumericUpDown();
            this.OT_Box = new System.Windows.Forms.TextBox();
            this.OT_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WN_NBox = new System.Windows.Forms.NumericUpDown();
            this.G_Button = new System.Windows.Forms.Button();
            this.G_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Days_NBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WH_NBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_NBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aph_NBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WN_NBox)).BeginInit();
            this.G_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days_NBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WH_Label
            // 
            this.WH_Label.AutoSize = true;
            this.WH_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WH_Label.Location = new System.Drawing.Point(16, 121);
            this.WH_Label.Name = "WH_Label";
            this.WH_Label.Size = new System.Drawing.Size(115, 19);
            this.WH_Label.TabIndex = 0;
            this.WH_Label.Text = "Working Hours";
            // 
            // Aph_Label
            // 
            this.Aph_Label.AutoSize = true;
            this.Aph_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Aph_Label.Location = new System.Drawing.Point(16, 185);
            this.Aph_Label.Name = "Aph_Label";
            this.Aph_Label.Size = new System.Drawing.Size(152, 19);
            this.Aph_Label.TabIndex = 2;
            this.Aph_Label.Text = "Customers per Hour";
            // 
            // ST_Label
            // 
            this.ST_Label.AutoSize = true;
            this.ST_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ST_Label.Location = new System.Drawing.Point(12, 244);
            this.ST_Label.Name = "ST_Label";
            this.ST_Label.Size = new System.Drawing.Size(179, 19);
            this.ST_Label.TabIndex = 4;
            this.ST_Label.Text = "Service Time in minutes";
            // 
            // S_Button
            // 
            this.S_Button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.S_Button.Location = new System.Drawing.Point(81, 291);
            this.S_Button.Name = "S_Button";
            this.S_Button.Size = new System.Drawing.Size(154, 42);
            this.S_Button.TabIndex = 6;
            this.S_Button.Text = "Simulate";
            this.S_Button.UseVisualStyleBackColor = true;
            this.S_Button.Click += new System.EventHandler(this.Simulate);
            // 
            // Out_Box
            // 
            this.Out_Box.BackColor = System.Drawing.Color.White;
            this.Out_Box.ForeColor = System.Drawing.Color.Black;
            this.Out_Box.Location = new System.Drawing.Point(375, 61);
            this.Out_Box.MaxLength = 999999999;
            this.Out_Box.Multiline = true;
            this.Out_Box.Name = "Out_Box";
            this.Out_Box.ReadOnly = true;
            this.Out_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Out_Box.Size = new System.Drawing.Size(274, 287);
            this.Out_Box.TabIndex = 7;
            // 
            // WW_Box
            // 
            this.WW_Box.BackColor = System.Drawing.Color.White;
            this.WW_Box.ForeColor = System.Drawing.Color.Black;
            this.WW_Box.Location = new System.Drawing.Point(717, 97);
            this.WW_Box.Name = "WW_Box";
            this.WW_Box.ReadOnly = true;
            this.WW_Box.Size = new System.Drawing.Size(154, 20);
            this.WW_Box.TabIndex = 8;
            // 
            // CW_Box
            // 
            this.CW_Box.BackColor = System.Drawing.Color.White;
            this.CW_Box.ForeColor = System.Drawing.Color.Black;
            this.CW_Box.Location = new System.Drawing.Point(717, 170);
            this.CW_Box.Name = "CW_Box";
            this.CW_Box.ReadOnly = true;
            this.CW_Box.Size = new System.Drawing.Size(154, 20);
            this.CW_Box.TabIndex = 9;
            // 
            // WW_Label
            // 
            this.WW_Label.AutoSize = true;
            this.WW_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WW_Label.Location = new System.Drawing.Point(689, 62);
            this.WW_Label.Name = "WW_Label";
            this.WW_Label.Size = new System.Drawing.Size(232, 19);
            this.WW_Label.TabIndex = 10;
            this.WW_Label.Text = "Average Worker\'s Waiting Time";
            // 
            // CW_Label
            // 
            this.CW_Label.AutoSize = true;
            this.CW_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CW_Label.Location = new System.Drawing.Point(677, 135);
            this.CW_Label.Name = "CW_Label";
            this.CW_Label.Size = new System.Drawing.Size(249, 19);
            this.CW_Label.TabIndex = 11;
            this.CW_Label.Text = "Average Customers\' Waiting Time";
            // 
            // DS_Label
            // 
            this.DS_Label.AutoSize = true;
            this.DS_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DS_Label.Location = new System.Drawing.Point(433, 29);
            this.DS_Label.Name = "DS_Label";
            this.DS_Label.Size = new System.Drawing.Size(146, 19);
            this.DS_Label.TabIndex = 12;
            this.DS_Label.Text = "Detailed Simulation";
            // 
            // WH_NBox
            // 
            this.WH_NBox.Location = new System.Drawing.Point(197, 120);
            this.WH_NBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WH_NBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WH_NBox.Name = "WH_NBox";
            this.WH_NBox.Size = new System.Drawing.Size(120, 20);
            this.WH_NBox.TabIndex = 13;
            this.WH_NBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ST_NBox
            // 
            this.ST_NBox.Location = new System.Drawing.Point(197, 243);
            this.ST_NBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ST_NBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ST_NBox.Name = "ST_NBox";
            this.ST_NBox.Size = new System.Drawing.Size(120, 20);
            this.ST_NBox.TabIndex = 14;
            this.ST_NBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Aph_NBox
            // 
            this.Aph_NBox.Location = new System.Drawing.Point(197, 184);
            this.Aph_NBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Aph_NBox.Name = "Aph_NBox";
            this.Aph_NBox.Size = new System.Drawing.Size(120, 20);
            this.Aph_NBox.TabIndex = 15;
            this.Aph_NBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OT_Box
            // 
            this.OT_Box.BackColor = System.Drawing.Color.White;
            this.OT_Box.ForeColor = System.Drawing.Color.Black;
            this.OT_Box.Location = new System.Drawing.Point(717, 246);
            this.OT_Box.Name = "OT_Box";
            this.OT_Box.ReadOnly = true;
            this.OT_Box.Size = new System.Drawing.Size(154, 20);
            this.OT_Box.TabIndex = 16;
            // 
            // OT_Label
            // 
            this.OT_Label.AutoSize = true;
            this.OT_Label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.OT_Label.Location = new System.Drawing.Point(723, 210);
            this.OT_Label.Name = "OT_Label";
            this.OT_Label.Size = new System.Drawing.Size(143, 19);
            this.OT_Label.TabIndex = 17;
            this.OT_Label.Text = "Over Time Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number of Workers";
            // 
            // WN_NBox
            // 
            this.WN_NBox.Location = new System.Drawing.Point(197, 61);
            this.WN_NBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WN_NBox.Name = "WN_NBox";
            this.WN_NBox.Size = new System.Drawing.Size(120, 20);
            this.WN_NBox.TabIndex = 20;
            this.WN_NBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // G_Button
            // 
            this.G_Button.Font = new System.Drawing.Font("Tahoma", 12F);
            this.G_Button.Location = new System.Drawing.Point(18, 19);
            this.G_Button.Name = "G_Button";
            this.G_Button.Size = new System.Drawing.Size(104, 42);
            this.G_Button.TabIndex = 21;
            this.G_Button.Text = "Graph";
            this.G_Button.UseVisualStyleBackColor = true;
            this.G_Button.Click += new System.EventHandler(this.Graph);
            // 
            // G_Panel
            // 
            this.G_Panel.Controls.Add(this.G_Button);
            this.G_Panel.Controls.Add(this.Days_NBox);
            this.G_Panel.Controls.Add(this.label3);
            this.G_Panel.Enabled = false;
            this.G_Panel.Location = new System.Drawing.Point(681, 272);
            this.G_Panel.Name = "G_Panel";
            this.G_Panel.Padding = new System.Windows.Forms.Padding(15, 16, 0, 0);
            this.G_Panel.Size = new System.Drawing.Size(245, 84);
            this.G_Panel.TabIndex = 22;
            // 
            // Days_NBox
            // 
            this.Days_NBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Days_NBox.Location = new System.Drawing.Point(128, 31);
            this.Days_NBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Days_NBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Days_NBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Days_NBox.Name = "Days_NBox";
            this.Days_NBox.Size = new System.Drawing.Size(52, 20);
            this.Days_NBox.TabIndex = 22;
            this.Days_NBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(186, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(777, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Copyright © Ahmed Magdy Ibrahim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G_Panel);
            this.Controls.Add(this.WN_NBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OT_Label);
            this.Controls.Add(this.OT_Box);
            this.Controls.Add(this.Aph_NBox);
            this.Controls.Add(this.ST_NBox);
            this.Controls.Add(this.WH_NBox);
            this.Controls.Add(this.DS_Label);
            this.Controls.Add(this.CW_Label);
            this.Controls.Add(this.WW_Label);
            this.Controls.Add(this.CW_Box);
            this.Controls.Add(this.WW_Box);
            this.Controls.Add(this.Out_Box);
            this.Controls.Add(this.S_Button);
            this.Controls.Add(this.ST_Label);
            this.Controls.Add(this.Aph_Label);
            this.Controls.Add(this.WH_Label);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Customers Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.WH_NBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_NBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aph_NBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WN_NBox)).EndInit();
            this.G_Panel.ResumeLayout(false);
            this.G_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days_NBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WH_Label;
        private System.Windows.Forms.Label Aph_Label;
        private System.Windows.Forms.Label ST_Label;
        private System.Windows.Forms.Button S_Button;
        private System.Windows.Forms.TextBox Out_Box;
        private System.Windows.Forms.TextBox WW_Box;
        private System.Windows.Forms.TextBox CW_Box;
        private System.Windows.Forms.Label WW_Label;
        private System.Windows.Forms.Label CW_Label;
        private System.Windows.Forms.Label DS_Label;
        private System.Windows.Forms.NumericUpDown WH_NBox;
        private System.Windows.Forms.NumericUpDown ST_NBox;
        private System.Windows.Forms.NumericUpDown Aph_NBox;
        private System.Windows.Forms.TextBox OT_Box;
        private System.Windows.Forms.Label OT_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WN_NBox;
        private System.Windows.Forms.Button G_Button;
        private System.Windows.Forms.FlowLayoutPanel G_Panel;
        private System.Windows.Forms.NumericUpDown Days_NBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

