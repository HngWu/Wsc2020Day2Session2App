namespace Wsc2020Day2Session2App
{
    partial class FrmJudgingPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJudgingPortal));
            this.dgvsubmissions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbrounds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbskillarea = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsubmissions
            // 
            this.dgvsubmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubmissions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvsubmissions.Location = new System.Drawing.Point(12, 236);
            this.dgvsubmissions.Name = "dgvsubmissions";
            this.dgvsubmissions.Size = new System.Drawing.Size(1271, 688);
            this.dgvsubmissions.TabIndex = 9;
            this.dgvsubmissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjudges_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Judging Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Skill Area:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbrounds
            // 
            this.cbrounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrounds.FormattingEnabled = true;
            this.cbrounds.Location = new System.Drawing.Point(124, 180);
            this.cbrounds.Name = "cbrounds";
            this.cbrounds.Size = new System.Drawing.Size(212, 32);
            this.cbrounds.TabIndex = 11;
            this.cbrounds.SelectedIndexChanged += new System.EventHandler(this.cbrounds_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Round:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbskillarea
            // 
            this.lbskillarea.AutoSize = true;
            this.lbskillarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbskillarea.Location = new System.Drawing.Point(124, 139);
            this.lbskillarea.Name = "lbskillarea";
            this.lbskillarea.Size = new System.Drawing.Size(0, 24);
            this.lbskillarea.TabIndex = 13;
            this.lbskillarea.Click += new System.EventHandler(this.lbskillarea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1203, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmJudgingPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 925);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbskillarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbrounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvsubmissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmJudgingPortal";
            this.Text = "FrmJudgingPortal";
            this.Load += new System.EventHandler(this.FrmJudgingPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvsubmissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbrounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbskillarea;
        private System.Windows.Forms.Button button1;
    }
}