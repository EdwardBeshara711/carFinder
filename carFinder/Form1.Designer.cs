
namespace carFinder
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
            this.cbDriveType = new System.Windows.Forms.ComboBox();
            this.cbTransmission = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCarList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDriveType
            // 
            this.cbDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriveType.FormattingEnabled = true;
            this.cbDriveType.Location = new System.Drawing.Point(12, 25);
            this.cbDriveType.Name = "cbDriveType";
            this.cbDriveType.Size = new System.Drawing.Size(375, 21);
            this.cbDriveType.TabIndex = 4;
            this.cbDriveType.SelectedIndexChanged += new System.EventHandler(this.cbDriveType_SelectedIndexChanged);
            // 
            // cbTransmission
            // 
            this.cbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmission.FormattingEnabled = true;
            this.cbTransmission.Location = new System.Drawing.Point(12, 65);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(375, 21);
            this.cbTransmission.TabIndex = 5;
            this.cbTransmission.SelectedIndexChanged += new System.EventHandler(this.cbTransmission_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car Drive Train";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transmission";
            // 
            // cbMake
            // 
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(12, 105);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(375, 21);
            this.cbMake.TabIndex = 8;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Make";
            // 
            // dgCarList
            // 
            this.dgCarList.AllowUserToAddRows = false;
            this.dgCarList.AllowUserToDeleteRows = false;
            this.dgCarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarList.Location = new System.Drawing.Point(12, 269);
            this.dgCarList.Name = "dgCarList";
            this.dgCarList.ReadOnly = true;
            this.dgCarList.Size = new System.Drawing.Size(1106, 388);
            this.dgCarList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTransmission);
            this.Controls.Add(this.cbDriveType);
            this.Controls.Add(this.dgCarList);
            this.Name = "Form1";
            this.Text = "Car Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDriveType;
        private System.Windows.Forms.ComboBox cbTransmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCarList;
    }
}

