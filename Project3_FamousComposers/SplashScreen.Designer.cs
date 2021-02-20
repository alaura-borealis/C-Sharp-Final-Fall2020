namespace Project3_FamousComposers
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblLoading = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSplash = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Linen;
            this.lblLoading.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(157, 152);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 15);
            this.lblLoading.TabIndex = 38;
            this.lblLoading.Text = "Loading - Please Wait...";
            // 
            // prgLoading
            // 
            this.prgLoading.BackColor = System.Drawing.Color.Linen;
            this.prgLoading.ForeColor = System.Drawing.Color.YellowGreen;
            this.prgLoading.Location = new System.Drawing.Point(103, 176);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(242, 23);
            this.prgLoading.Step = 5;
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLoading.TabIndex = 37;
            this.prgLoading.UseWaitCursor = true;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(29, 30);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(391, 43);
            this.lblAppName.TabIndex = 39;
            this.lblAppName.Text = "Famous Music Composers";
            // 
            // lblSplash
            // 
            this.lblSplash.AutoSize = true;
            this.lblSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.Location = new System.Drawing.Point(108, 84);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(233, 15);
            this.lblSplash.TabIndex = 40;
            this.lblSplash.Text = "Laura Waite | CS 218 | Fall Quarter 2020";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Project3_FamousComposers.Properties.Resources._558325894_crop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 234);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.prgLoading);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.Timer tmrSplash;
    }
}