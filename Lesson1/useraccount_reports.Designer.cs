namespace Lesson2
{
    partial class useraccount_reports
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
            this.exit_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.optionInputTxtbox = new System.Windows.Forms.TextBox();
            this.optionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(1116, 55);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(129, 36);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit_button);
            this.groupBox1.Controls.Add(this.back_button);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.optionInputTxtbox);
            this.groupBox1.Controls.Add(this.optionCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1900, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(981, 55);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(129, 36);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(846, 55);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(129, 36);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // optionInputTxtbox
            // 
            this.optionInputTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionInputTxtbox.Location = new System.Drawing.Point(464, 59);
            this.optionInputTxtbox.Name = "optionInputTxtbox";
            this.optionInputTxtbox.Size = new System.Drawing.Size(365, 27);
            this.optionInputTxtbox.TabIndex = 2;
            // 
            // optionCombo
            // 
            this.optionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCombo.FormattingEnabled = true;
            this.optionCombo.Location = new System.Drawing.Point(289, 59);
            this.optionCombo.Name = "optionCombo";
            this.optionCombo.Size = new System.Drawing.Size(169, 28);
            this.optionCombo.TabIndex = 1;
            this.optionCombo.SelectedIndexChanged += new System.EventHandler(this.optionCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an option:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1900, 792);
            this.dataGridView1.TabIndex = 5;
            // 
            // useraccount_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "useraccount_reports";
            this.Text = "useraccount_reports";
            this.Load += new System.EventHandler(this.useraccount_reports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox optionInputTxtbox;
        private System.Windows.Forms.ComboBox optionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}