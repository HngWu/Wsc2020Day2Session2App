namespace Wsc2020Day2Session2App
{
    partial class FrmLiveCompetitionScoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiveCompetitionScoreboard));
            this.lbskillarea = new System.Windows.Forms.Label();
            this.cbskillarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcompetitors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbskillarea
            // 
            this.lbskillarea.AutoSize = true;
            this.lbskillarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbskillarea.Location = new System.Drawing.Point(135, 151);
            this.lbskillarea.Name = "lbskillarea";
            this.lbskillarea.Size = new System.Drawing.Size(0, 24);
            this.lbskillarea.TabIndex = 20;
            // 
            // cbskillarea
            // 
            this.cbskillarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbskillarea.FormattingEnabled = true;
            this.cbskillarea.Location = new System.Drawing.Point(135, 192);
            this.cbskillarea.Name = "cbskillarea";
            this.cbskillarea.Size = new System.Drawing.Size(212, 32);
            this.cbskillarea.TabIndex = 18;
            this.cbskillarea.SelectedIndexChanged += new System.EventHandler(this.cbskillarea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Skill Area:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvcompetitors
            // 
            this.dgvcompetitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompetitors.Location = new System.Drawing.Point(23, 248);
            this.dgvcompetitors.Name = "dgvcompetitors";
            this.dgvcompetitors.Size = new System.Drawing.Size(1271, 688);
            this.dgvcompetitors.TabIndex = 16;
            this.dgvcompetitors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcompetitors_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Live Competition Scoreboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLiveCompetitionScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 948);
            this.Controls.Add(this.lbskillarea);
            this.Controls.Add(this.cbskillarea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvcompetitors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLiveCompetitionScoreboard";
            this.Text = "FrmLiveCompetitionScoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbskillarea;
        private System.Windows.Forms.ComboBox cbskillarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvcompetitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}