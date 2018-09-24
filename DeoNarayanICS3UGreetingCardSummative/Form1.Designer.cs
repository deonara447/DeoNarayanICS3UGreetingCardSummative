namespace DeoNarayanICS3UGreetingCardSummative
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.christmasTreeLabel = new System.Windows.Forms.Label();
            this.santaLabel = new System.Windows.Forms.Label();
            this.envelopeLabel = new System.Windows.Forms.Label();
            this.fallingSnowImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fallingSnowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // christmasTreeLabel
            // 
            this.christmasTreeLabel.BackColor = System.Drawing.Color.Red;
            this.christmasTreeLabel.Image = global::DeoNarayanICS3UGreetingCardSummative.Properties.Resources.transparentTree;
            this.christmasTreeLabel.Location = new System.Drawing.Point(29, 237);
            this.christmasTreeLabel.Name = "christmasTreeLabel";
            this.christmasTreeLabel.Size = new System.Drawing.Size(276, 371);
            this.christmasTreeLabel.TabIndex = 3;
            this.christmasTreeLabel.Visible = false;
            // 
            // santaLabel
            // 
            this.santaLabel.BackColor = System.Drawing.Color.Red;
            this.santaLabel.Image = global::DeoNarayanICS3UGreetingCardSummative.Properties.Resources.transSanta;
            this.santaLabel.Location = new System.Drawing.Point(753, 332);
            this.santaLabel.Name = "santaLabel";
            this.santaLabel.Size = new System.Drawing.Size(168, 228);
            this.santaLabel.TabIndex = 2;
            this.santaLabel.Visible = false;
            // 
            // envelopeLabel
            // 
            this.envelopeLabel.Image = global::DeoNarayanICS3UGreetingCardSummative.Properties.Resources.transEnvolope1;
            this.envelopeLabel.Location = new System.Drawing.Point(176, 74);
            this.envelopeLabel.Name = "envelopeLabel";
            this.envelopeLabel.Size = new System.Drawing.Size(606, 437);
            this.envelopeLabel.TabIndex = 1;
            this.envelopeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.envelopeLabel.Click += new System.EventHandler(this.Envolope_Click);
            // 
            // fallingSnowImage
            // 
            this.fallingSnowImage.Image = global::DeoNarayanICS3UGreetingCardSummative.Properties.Resources.SnowFallingGif;
            this.fallingSnowImage.Location = new System.Drawing.Point(-6, 2);
            this.fallingSnowImage.Name = "fallingSnowImage";
            this.fallingSnowImage.Size = new System.Drawing.Size(972, 636);
            this.fallingSnowImage.TabIndex = 0;
            this.fallingSnowImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 631);
            this.Controls.Add(this.christmasTreeLabel);
            this.Controls.Add(this.santaLabel);
            this.Controls.Add(this.envelopeLabel);
            this.Controls.Add(this.fallingSnowImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ChristmasCard";
            ((System.ComponentModel.ISupportInitialize)(this.fallingSnowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fallingSnowImage;
        private System.Windows.Forms.Label envelopeLabel;
        private System.Windows.Forms.Label santaLabel;
        private System.Windows.Forms.Label christmasTreeLabel;
    }
}

