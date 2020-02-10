namespace helloWorldAdam
{
    partial class frmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.lblsignature = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHelloWorld.Location = new System.Drawing.Point(50, 59);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(310, 55);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            // 
            // lblsignature
            // 
            this.lblsignature.AutoSize = true;
            this.lblsignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignature.ForeColor = System.Drawing.Color.Lime;
            this.lblsignature.Location = new System.Drawing.Point(643, 384);
            this.lblsignature.Name = "lblsignature";
            this.lblsignature.Size = new System.Drawing.Size(114, 29);
            this.lblsignature.TabIndex = 1;
            this.lblsignature.Text = "By: Adam";
            // 
            // pic
            // 
            this.pic.Image = global::helloWorldAdam.Properties.Resources.image_ducatilogo;
            this.pic.Location = new System.Drawing.Point(457, 112);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 105);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblsignature);
            this.Controls.Add(this.lblHelloWorld);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmHelloWorld";
            this.Text = "Hello, World! by: Adam";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Label lblsignature;
        private System.Windows.Forms.PictureBox pic;
    }
}

