
namespace FinalProject
{
    partial class StartPage
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
            this.BloodBMSlevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BloodBMSlevel
            // 
            this.BloodBMSlevel.AutoSize = true;
            this.BloodBMSlevel.BackColor = System.Drawing.Color.OrangeRed;
            this.BloodBMSlevel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodBMSlevel.Location = new System.Drawing.Point(210, 38);
            this.BloodBMSlevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodBMSlevel.Name = "BloodBMSlevel";
            this.BloodBMSlevel.Size = new System.Drawing.Size(378, 31);
            this.BloodBMSlevel.TabIndex = 1;
            this.BloodBMSlevel.Text = "Blood Bank Management System";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 466);
            this.Controls.Add(this.BloodBMSlevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BloodBMSlevel;
    }
}