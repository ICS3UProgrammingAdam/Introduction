namespace PerAreaVolAdam
{
    partial class frmPerAreaVol
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
            this.btnPerimiter = new System.Windows.Forms.Button();
            this.lblPerimiter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerimiter
            // 
            this.btnPerimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimiter.Location = new System.Drawing.Point(12, 12);
            this.btnPerimiter.Name = "btnPerimiter";
            this.btnPerimiter.Size = new System.Drawing.Size(327, 161);
            this.btnPerimiter.TabIndex = 0;
            this.btnPerimiter.Text = "Calculate the perimiter of a rectangle with length = 12cm and width =\r\n 4cm\r\n";
            this.btnPerimiter.UseVisualStyleBackColor = true;
            this.btnPerimiter.Click += new System.EventHandler(this.BtnPerimiter_Click);
            // 
            // lblPerimiter
            // 
            this.lblPerimiter.AutoSize = true;
            this.lblPerimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimiter.Location = new System.Drawing.Point(496, 86);
            this.lblPerimiter.Name = "lblPerimiter";
            this.lblPerimiter.Size = new System.Drawing.Size(51, 25);
            this.lblPerimiter.TabIndex = 1;
            this.lblPerimiter.Text = "???";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(496, 271);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 25);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "???";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(496, 454);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 25);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "???";
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(12, 197);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(327, 161);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calculate the area of a circle with the radious of 6km\r\n";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(12, 380);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(327, 161);
            this.btnVolume.TabIndex = 5;
            this.btnVolume.Text = "Calculate the volume of a sphere with the radious 25m";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 563);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimiter);
            this.Controls.Add(this.btnPerimiter);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimiter, Area, Volume by Adam";
            this.Load += new System.EventHandler(this.FrmPerAreaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerimiter;
        private System.Windows.Forms.Label lblPerimiter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
    }
}

