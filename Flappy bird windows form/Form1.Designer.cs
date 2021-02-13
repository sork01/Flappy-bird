
namespace Flappy_bird_windows_form
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.grund = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 611);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(86, 30);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // cloud2
            // 
            this.cloud2.Image = global::Flappy_bird_windows_form.Properties.Resources.toppng1;
            this.cloud2.Location = new System.Drawing.Point(257, 131);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(116, 104);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 6;
            this.cloud2.TabStop = false;
            // 
            // grund
            // 
            this.grund.Image = global::Flappy_bird_windows_form.Properties.Resources.ground;
            this.grund.Location = new System.Drawing.Point(-4, 555);
            this.grund.Name = "grund";
            this.grund.Size = new System.Drawing.Size(813, 106);
            this.grund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grund.TabIndex = 3;
            this.grund.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_bird_windows_form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(499, 350);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 215);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_bird_windows_form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(679, -6);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 201);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_bird_windows_form.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(103, 259);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(59, 51);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // cloud
            // 
            this.cloud.Image = global::Flappy_bird_windows_form.Properties.Resources.toppng_com_free_vector_nuage_cloud_cloud_800x533;
            this.cloud.Location = new System.Drawing.Point(720, 57);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(68, 66);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 5;
            this.cloud.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.grund);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.cloud2);
            this.Name = "Form1";
            this.Text = "Flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox grund;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.PictureBox cloud2;
    }
}

