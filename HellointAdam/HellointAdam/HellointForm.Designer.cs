namespace HellointAdam
{
    partial class frm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radVietnamese = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(177, 90);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(411, 73);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.radVietnamese);
            this.grbRadioButtons.Controls.Add(this.radFrench);
            this.grbRadioButtons.Controls.Add(this.radGerman);
            this.grbRadioButtons.Controls.Add(this.radEnglish);
            this.grbRadioButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRadioButtons.Location = new System.Drawing.Point(58, 323);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(674, 100);
            this.grbRadioButtons.TabIndex = 1;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Text = "Language";
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrench.Location = new System.Drawing.Point(351, 44);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(91, 22);
            this.radFrench.TabIndex = 2;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGerman.Location = new System.Drawing.Point(190, 44);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(97, 22);
            this.radGerman.TabIndex = 1;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "Deutsche";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadArabic_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(42, 44);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(81, 22);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radVietnamese
            // 
            this.radVietnamese.AutoSize = true;
            this.radVietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVietnamese.Location = new System.Drawing.Point(503, 44);
            this.radVietnamese.Name = "radVietnamese";
            this.radVietnamese.Size = new System.Drawing.Size(100, 22);
            this.radVietnamese.TabIndex = 3;
            this.radVietnamese.TabStop = true;
            this.radVietnamese.Text = "Tiếng Việt";
            this.radVietnamese.UseVisualStyleBackColor = true;
            this.radVietnamese.CheckedChanged += new System.EventHandler(this.RadVietnamese_CheckedChanged);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frm";
            this.Text = "Hello,World! International by Adam";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radVietnamese;
    }
}

