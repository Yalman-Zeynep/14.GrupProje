namespace WindowsForms
{
    partial class TokenForm
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
            this.lblTokenTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTokenTimer
            // 
            this.lblTokenTimer.AutoSize = true;
            this.lblTokenTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTokenTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTokenTimer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTokenTimer.Location = new System.Drawing.Point(244, 139);
            this.lblTokenTimer.Name = "lblTokenTimer";
            this.lblTokenTimer.Size = new System.Drawing.Size(100, 34);
            this.lblTokenTimer.TabIndex = 0;
            this.lblTokenTimer.Text = "label1";
            this.lblTokenTimer.Click += new System.EventHandler(this.lblTokenTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir dakika içinde işleminizi yapınız, oturum sonlandırılacaktır.";
            // 
            // TokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTokenTimer);
            this.Name = "TokenForm";
            this.Text = "TokenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTokenTimer;
        private System.Windows.Forms.Label label1;
    }
}