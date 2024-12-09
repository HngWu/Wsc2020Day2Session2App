namespace Wsc2020Day2Session2App
{
    partial class FrmCompetitorManagementScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompetitorManagementScreen));
            this.btncreate = new System.Windows.Forms.Button();
            this.dgvcompetitor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnjudgementmanagement = new System.Windows.Forms.Button();
            this.btngeneratereport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompetitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(12, 215);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 9;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // dgvcompetitor
            // 
            this.dgvcompetitor.AllowUserToOrderColumns = true;
            this.dgvcompetitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompetitor.Location = new System.Drawing.Point(12, 256);
            this.dgvcompetitor.Name = "dgvcompetitor";
            this.dgvcompetitor.Size = new System.Drawing.Size(1271, 688);
            this.dgvcompetitor.TabIndex = 8;
            this.dgvcompetitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjudges_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Competitor Management Screen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnjudgementmanagement
            // 
            this.btnjudgementmanagement.Location = new System.Drawing.Point(108, 215);
            this.btnjudgementmanagement.Name = "btnjudgementmanagement";
            this.btnjudgementmanagement.Size = new System.Drawing.Size(224, 23);
            this.btnjudgementmanagement.TabIndex = 10;
            this.btnjudgementmanagement.Text = "Judge Management";
            this.btnjudgementmanagement.UseVisualStyleBackColor = true;
            this.btnjudgementmanagement.Click += new System.EventHandler(this.btnjudgementmanagement_Click);
            // 
            // btngeneratereport
            // 
            this.btngeneratereport.Location = new System.Drawing.Point(350, 215);
            this.btngeneratereport.Name = "btngeneratereport";
            this.btngeneratereport.Size = new System.Drawing.Size(224, 23);
            this.btngeneratereport.TabIndex = 11;
            this.btngeneratereport.Text = "Generate Report";
            this.btngeneratereport.UseVisualStyleBackColor = true;
            this.btngeneratereport.Click += new System.EventHandler(this.btngeneratereport_Click);
            // 
            // FrmCompetitorManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 964);
            this.Controls.Add(this.btngeneratereport);
            this.Controls.Add(this.btnjudgementmanagement);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dgvcompetitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCompetitorManagementScreen";
            this.Text = "FrmCompetitorManagementScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompetitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.DataGridView dgvcompetitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnjudgementmanagement;
        private System.Windows.Forms.Button btngeneratereport;
    }
}