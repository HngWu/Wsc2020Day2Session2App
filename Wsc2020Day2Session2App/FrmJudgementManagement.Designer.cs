namespace Wsc2020Day2Session2App
{
    partial class FrmJudgementManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJudgementManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvjudges = new System.Windows.Forms.DataGridView();
            this.btncreate = new System.Windows.Forms.Button();
            this.btncompetitormanagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjudges)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Judges Management Screen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgvjudges
            // 
            this.dgvjudges.AllowUserToOrderColumns = true;
            this.dgvjudges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvjudges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjudges.Location = new System.Drawing.Point(12, 264);
            this.dgvjudges.Name = "dgvjudges";
            this.dgvjudges.Size = new System.Drawing.Size(1271, 688);
            this.dgvjudges.TabIndex = 4;
            this.dgvjudges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjudges_CellContentClick);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(12, 223);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 5;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btncompetitormanagement
            // 
            this.btncompetitormanagement.Location = new System.Drawing.Point(103, 223);
            this.btncompetitormanagement.Name = "btncompetitormanagement";
            this.btncompetitormanagement.Size = new System.Drawing.Size(164, 23);
            this.btncompetitormanagement.TabIndex = 6;
            this.btncompetitormanagement.Text = "Competitor Management";
            this.btncompetitormanagement.UseVisualStyleBackColor = true;
            this.btncompetitormanagement.Click += new System.EventHandler(this.btncompetitormanagement_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1208, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmJudgementManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 964);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncompetitormanagement);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dgvjudges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmJudgementManagement";
            this.Text = "FrmJudgementManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjudges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvjudges;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncompetitormanagement;
        private System.Windows.Forms.Button button1;
    }
}