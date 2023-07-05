
namespace Assignment1_Mlangeni_37743856
{
    partial class Search
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.txtSearchUniversity = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSearchUniversity = new System.Windows.Forms.Label();
            this.lblSearchSport = new System.Windows.Forms.Label();
            this.lblSearchPoints = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbSport
            // 
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.Location = new System.Drawing.Point(694, 367);
            this.cmbSport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(173, 28);
            this.cmbSport.TabIndex = 1;
            this.cmbSport.SelectedIndexChanged += new System.EventHandler(this.cmbSport_SelectedIndexChanged);
            // 
            // txtSearchUniversity
            // 
            this.txtSearchUniversity.Location = new System.Drawing.Point(693, 170);
            this.txtSearchUniversity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUniversity.Name = "txtSearchUniversity";
            this.txtSearchUniversity.Size = new System.Drawing.Size(174, 26);
            this.txtSearchUniversity.TabIndex = 2;
            this.txtSearchUniversity.TextChanged += new System.EventHandler(this.txtSearchUniversity_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSearch.Location = new System.Drawing.Point(691, 97);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(94, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by:";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Maroon;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeading.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblHeading.Location = new System.Drawing.Point(250, 36);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(535, 33);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "INTER-UNIVERSITY TOURNAMENT 2022";
            // 
            // lblSearchUniversity
            // 
            this.lblSearchUniversity.AutoSize = true;
            this.lblSearchUniversity.Location = new System.Drawing.Point(691, 134);
            this.lblSearchUniversity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchUniversity.Name = "lblSearchUniversity";
            this.lblSearchUniversity.Size = new System.Drawing.Size(83, 20);
            this.lblSearchUniversity.TabIndex = 5;
            this.lblSearchUniversity.Text = "Uni Name:";
            // 
            // lblSearchSport
            // 
            this.lblSearchSport.AutoSize = true;
            this.lblSearchSport.Location = new System.Drawing.Point(690, 330);
            this.lblSearchSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchSport.Name = "lblSearchSport";
            this.lblSearchSport.Size = new System.Drawing.Size(52, 20);
            this.lblSearchSport.TabIndex = 6;
            this.lblSearchSport.Text = "Sport:";
            // 
            // lblSearchPoints
            // 
            this.lblSearchPoints.AutoSize = true;
            this.lblSearchPoints.Location = new System.Drawing.Point(691, 230);
            this.lblSearchPoints.Name = "lblSearchPoints";
            this.lblSearchPoints.Size = new System.Drawing.Size(57, 20);
            this.lblSearchPoints.TabIndex = 7;
            this.lblSearchPoints.Text = "Points:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(695, 270);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(174, 27);
            this.hScrollBar1.TabIndex = 8;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(694, 433);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(105, 34);
            this.btnClose2.TabIndex = 9;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assignment1_Mlangeni_37743856.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(47, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment1_Mlangeni_37743856.Properties.Resources._360_F_390661775_BY3omV6LTS2064GbghxN9MBxgp4oV67W;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lblSearchPoints);
            this.Controls.Add(this.lblSearchSport);
            this.Controls.Add(this.lblSearchUniversity);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchUniversity);
            this.Controls.Add(this.cmbSport);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.TextBox txtSearchUniversity;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSearchUniversity;
        private System.Windows.Forms.Label lblSearchSport;
        private System.Windows.Forms.Label lblSearchPoints;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}