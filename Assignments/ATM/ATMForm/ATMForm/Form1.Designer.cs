namespace ATMForm
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
            this.DisplayView = new System.Windows.Forms.TextBox();
            this.fLPNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // DisplayView
            // 
            this.DisplayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayView.Location = new System.Drawing.Point(13, 30);
            this.DisplayView.Name = "DisplayView";
            this.DisplayView.Size = new System.Drawing.Size(651, 38);
            this.DisplayView.TabIndex = 2;
            this.DisplayView.Text = "Insert Card";
            // 
            // fLPNumbers
            // 
            this.fLPNumbers.Location = new System.Drawing.Point(120, 119);
            this.fLPNumbers.Name = "fLPNumbers";
            this.fLPNumbers.Size = new System.Drawing.Size(407, 443);
            this.fLPNumbers.TabIndex = 3;
            this.fLPNumbers.Paint += new System.Windows.Forms.PaintEventHandler(this.fLPNumbers_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 639);
            this.Controls.Add(this.fLPNumbers);
            this.Controls.Add(this.DisplayView);
            this.Name = "Form1";
            this.Text = "ATM Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayView;
        private System.Windows.Forms.FlowLayoutPanel fLPNumbers;
    }
}

