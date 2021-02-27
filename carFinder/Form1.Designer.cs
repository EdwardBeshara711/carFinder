
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
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.dgCarList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMake
            // 
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(12, 61);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(375, 21);
            this.cbMake.TabIndex = 0;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(12, 88);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(375, 21);
            this.cbModel.TabIndex = 1;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(12, 34);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(375, 21);
            this.cbYear.TabIndex = 2;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // dgCarList
            // 
            this.dgCarList.AllowUserToAddRows = false;
            this.dgCarList.AllowUserToDeleteRows = false;
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
            this.Controls.Add(this.dgCarList);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.DataGridView dgCarList;
    }
}

