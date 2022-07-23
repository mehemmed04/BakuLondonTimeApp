namespace TASK1
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
            this.bakiBTN = new System.Windows.Forms.Button();
            this.londonBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bakiBTN
            // 
            this.bakiBTN.BackColor = System.Drawing.Color.Lime;
            this.bakiBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bakiBTN.Location = new System.Drawing.Point(132, 26);
            this.bakiBTN.Name = "bakiBTN";
            this.bakiBTN.Size = new System.Drawing.Size(212, 58);
            this.bakiBTN.TabIndex = 0;
            this.bakiBTN.Text = "BAKİ";
            this.bakiBTN.UseVisualStyleBackColor = false;
            this.bakiBTN.Click += new System.EventHandler(this.bakiBTN_Click);
            // 
            // londonBTN
            // 
            this.londonBTN.BackColor = System.Drawing.Color.Lime;
            this.londonBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.londonBTN.Location = new System.Drawing.Point(429, 26);
            this.londonBTN.Name = "londonBTN";
            this.londonBTN.Size = new System.Drawing.Size(212, 58);
            this.londonBTN.TabIndex = 2;
            this.londonBTN.Text = "LONDON";
            this.londonBTN.UseVisualStyleBackColor = false;
            this.londonBTN.Click += new System.EventHandler(this.londonBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(368, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.londonBTN);
            this.Controls.Add(this.bakiBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bakiBTN;
        private System.Windows.Forms.Button londonBTN;
        private System.Windows.Forms.Label label1;
    }
}

