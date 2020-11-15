namespace TheThingAboutTheSimpsons {
    partial class MainForm {
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.submitBtn = new System.Windows.Forms.Button();
            this.aboutUsBtn = new System.Windows.Forms.Label();
            this.ourMissionBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.episodeViewer1 = new TheThingAboutTheSimpsons.EpisodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitBtn.Location = new System.Drawing.Point(54, 204);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(259, 75);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "search";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // aboutUsBtn
            // 
            this.aboutUsBtn.AutoSize = true;
            this.aboutUsBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.aboutUsBtn.Location = new System.Drawing.Point(820, 505);
            this.aboutUsBtn.Name = "aboutUsBtn";
            this.aboutUsBtn.Size = new System.Drawing.Size(97, 25);
            this.aboutUsBtn.TabIndex = 7;
            this.aboutUsBtn.Text = "About US";
            this.aboutUsBtn.Click += new System.EventHandler(this.aboutUsBtn_Click);
            // 
            // ourMissionBtn
            // 
            this.ourMissionBtn.AutoSize = true;
            this.ourMissionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ourMissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourMissionBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.ourMissionBtn.Location = new System.Drawing.Point(800, 547);
            this.ourMissionBtn.Name = "ourMissionBtn";
            this.ourMissionBtn.Size = new System.Drawing.Size(117, 25);
            this.ourMissionBtn.TabIndex = 8;
            this.ourMissionBtn.Text = "Our Mission";
            this.ourMissionBtn.Click += new System.EventHandler(this.ourMissionBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 45);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // episodeViewer1
            // 
            this.episodeViewer1.BackColor = System.Drawing.Color.Transparent;
            this.episodeViewer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("episodeViewer1.BackgroundImage")));
            this.episodeViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.episodeViewer1.Location = new System.Drawing.Point(12, 344);
            this.episodeViewer1.Name = "episodeViewer1";
            this.episodeViewer1.Size = new System.Drawing.Size(384, 235);
            this.episodeViewer1.TabIndex = 13;
            this.episodeViewer1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 581);
            this.Controls.Add(this.episodeViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ourMissionBtn);
            this.Controls.Add(this.aboutUsBtn);
            this.Controls.Add(this.submitBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "simpsonComparator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label aboutUsBtn;
        private System.Windows.Forms.Label ourMissionBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EpisodeViewer episodeViewer1;
    }
}

