namespace Customers_Simulation
{
    partial class Alert
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
            this.Alert_Box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Alert_Box
            // 
            this.Alert_Box.AutoSize = true;
            this.Alert_Box.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Alert_Box.Location = new System.Drawing.Point(145, 57);
            this.Alert_Box.Name = "Alert_Box";
            this.Alert_Box.Size = new System.Drawing.Size(59, 23);
            this.Alert_Box.TabIndex = 0;
            this.Alert_Box.Text = "label1";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 142);
            this.Controls.Add(this.Alert_Box);
            this.Name = "Alert";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alert_Box;
    }
}