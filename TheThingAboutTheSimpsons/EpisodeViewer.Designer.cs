﻿namespace TheThingAboutTheSimpsons {
    partial class EpisodeViewer {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpisodeViewer));
            this.Title = new System.Windows.Forms.Label();
            this.episodeNbLb = new System.Windows.Forms.Label();
            this.seasonNbLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.summaryLb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gold;
            this.Title.Location = new System.Drawing.Point(9, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(57, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "title";
            // 
            // episodeNbLb
            // 
            this.episodeNbLb.AutoSize = true;
            this.episodeNbLb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeNbLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.episodeNbLb.Location = new System.Drawing.Point(24, 23);
            this.episodeNbLb.Name = "episodeNbLb";
            this.episodeNbLb.Size = new System.Drawing.Size(68, 13);
            this.episodeNbLb.TabIndex = 1;
            this.episodeNbLb.Text = "no episode";
            // 
            // seasonNbLb
            // 
            this.seasonNbLb.AutoSize = true;
            this.seasonNbLb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonNbLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seasonNbLb.Location = new System.Drawing.Point(24, 41);
            this.seasonNbLb.Name = "seasonNbLb";
            this.seasonNbLb.Size = new System.Drawing.Size(60, 13);
            this.seasonNbLb.TabIndex = 2;
            this.seasonNbLb.Text = "no saison";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dateLb.Location = new System.Drawing.Point(24, 59);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(33, 13);
            this.dateLb.TabIndex = 4;
            this.dateLb.Text = "date";
            // 
            // summaryLb
            // 
            this.summaryLb.AutoSize = true;
            this.summaryLb.BackColor = System.Drawing.Color.Silver;
            this.summaryLb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.summaryLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.summaryLb.Location = new System.Drawing.Point(11, 79);
            this.summaryLb.MaximumSize = new System.Drawing.Size(363, 144);
            this.summaryLb.Name = "summaryLb";
            this.summaryLb.Size = new System.Drawing.Size(363, 144);
            this.summaryLb.TabIndex = 5;
            this.summaryLb.Text = "label1\r\nsddsasdasdasdasasd\r\nasdddddddddads\r\nsdssssssssssssssssssssqqqqqqqqqqsssss" +
    "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss\r\na\r\na\r\na\r\na\r\na\r" +
    "\na\r\na\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(289, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 52);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EpisodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.summaryLb);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.seasonNbLb);
            this.Controls.Add(this.episodeNbLb);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Name = "EpisodeViewer";
            this.Size = new System.Drawing.Size(384, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label episodeNbLb;
        public System.Windows.Forms.Label seasonNbLb;
        public System.Windows.Forms.Label dateLb;
        public System.Windows.Forms.Label summaryLb;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
