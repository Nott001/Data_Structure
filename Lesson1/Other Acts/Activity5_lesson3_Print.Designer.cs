namespace Lesson2
{
    partial class Activity5_lesson3_Print
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
            this.Payslip_view_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Payslip_view_listbox
            // 
            this.Payslip_view_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payslip_view_listbox.FormattingEnabled = true;
            this.Payslip_view_listbox.ItemHeight = 18;
            this.Payslip_view_listbox.Location = new System.Drawing.Point(323, 12);
            this.Payslip_view_listbox.Name = "Payslip_view_listbox";
            this.Payslip_view_listbox.Size = new System.Drawing.Size(477, 976);
            this.Payslip_view_listbox.TabIndex = 1;
            // 
            // Activity5_lesson3_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 1041);
            this.Controls.Add(this.Payslip_view_listbox);
            this.Name = "Activity5_lesson3_Print";
            this.Text = "Activity5_lesson3_Print";
            this.Load += new System.EventHandler(this.Activity5_lesson3_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Payslip_view_listbox;
    }
}