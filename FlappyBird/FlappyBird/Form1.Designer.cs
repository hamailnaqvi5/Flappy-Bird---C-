namespace FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipetop
            // 
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(489, 1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 156);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 0;
            this.pipetop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(148, 209);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(125, 76);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::FlappyBird.Properties.Resources.pipeup;
            this.pipebottom.Location = new System.Drawing.Point(439, 360);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(100, 132);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 0;
            this.pipebottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-39, 489);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(872, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 12);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(59, 13);
            this.scoretext.TabIndex = 1;
            this.scoretext.Text = "Score : 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipetop);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}

