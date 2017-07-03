namespace Mastermind
{
    partial class speelRij
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnScoreD = new WindowsFormsApplication1.RoundButton();
            this.rbtnScoreC = new WindowsFormsApplication1.RoundButton();
            this.rbtnScoreB = new WindowsFormsApplication1.RoundButton();
            this.rbtnScoreA = new WindowsFormsApplication1.RoundButton();
            this.rbtnD = new WindowsFormsApplication1.RoundButton();
            this.rbtnC = new WindowsFormsApplication1.RoundButton();
            this.rbtnB = new WindowsFormsApplication1.RoundButton();
            this.rbtnA = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnScoreD
            // 
            this.rbtnScoreD.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnScoreD.Enabled = false;
            this.rbtnScoreD.Location = new System.Drawing.Point(272, 32);
            this.rbtnScoreD.Name = "rbtnScoreD";
            this.rbtnScoreD.Size = new System.Drawing.Size(20, 20);
            this.rbtnScoreD.TabIndex = 7;
            this.rbtnScoreD.UseVisualStyleBackColor = false;
            // 
            // rbtnScoreC
            // 
            this.rbtnScoreC.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnScoreC.Enabled = false;
            this.rbtnScoreC.Location = new System.Drawing.Point(246, 32);
            this.rbtnScoreC.Name = "rbtnScoreC";
            this.rbtnScoreC.Size = new System.Drawing.Size(20, 20);
            this.rbtnScoreC.TabIndex = 6;
            this.rbtnScoreC.UseVisualStyleBackColor = false;
            // 
            // rbtnScoreB
            // 
            this.rbtnScoreB.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnScoreB.Enabled = false;
            this.rbtnScoreB.Location = new System.Drawing.Point(272, 7);
            this.rbtnScoreB.Name = "rbtnScoreB";
            this.rbtnScoreB.Size = new System.Drawing.Size(20, 20);
            this.rbtnScoreB.TabIndex = 5;
            this.rbtnScoreB.UseVisualStyleBackColor = false;
            // 
            // rbtnScoreA
            // 
            this.rbtnScoreA.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnScoreA.Enabled = false;
            this.rbtnScoreA.Location = new System.Drawing.Point(246, 7);
            this.rbtnScoreA.Name = "rbtnScoreA";
            this.rbtnScoreA.Size = new System.Drawing.Size(20, 20);
            this.rbtnScoreA.TabIndex = 4;
            this.rbtnScoreA.UseVisualStyleBackColor = false;
            // 
            // rbtnD
            // 
            this.rbtnD.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnD.Enabled = false;
            this.rbtnD.Location = new System.Drawing.Point(181, 4);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(50, 50);
            this.rbtnD.TabIndex = 3;
            this.rbtnD.UseVisualStyleBackColor = false;
            this.rbtnD.Click += new System.EventHandler(this.rbtnD_Click);
            // 
            // rbtnC
            // 
            this.rbtnC.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnC.Enabled = false;
            this.rbtnC.Location = new System.Drawing.Point(125, 4);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(50, 50);
            this.rbtnC.TabIndex = 2;
            this.rbtnC.UseVisualStyleBackColor = false;
            this.rbtnC.Click += new System.EventHandler(this.rbtnC_Click);
            // 
            // rbtnB
            // 
            this.rbtnB.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnB.Enabled = false;
            this.rbtnB.Location = new System.Drawing.Point(69, 4);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(50, 50);
            this.rbtnB.TabIndex = 1;
            this.rbtnB.UseVisualStyleBackColor = false;
            this.rbtnB.Click += new System.EventHandler(this.rbtnB_Click);
            // 
            // rbtnA
            // 
            this.rbtnA.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnA.Location = new System.Drawing.Point(13, 4);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(50, 50);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.UseVisualStyleBackColor = false;
            this.rbtnA.Click += new System.EventHandler(this.rbtnA_Click);
            // 
            // speelRij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnScoreD);
            this.Controls.Add(this.rbtnScoreC);
            this.Controls.Add(this.rbtnScoreB);
            this.Controls.Add(this.rbtnScoreA);
            this.Controls.Add(this.rbtnD);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Name = "speelRij";
            this.Size = new System.Drawing.Size(306, 62);
            this.ResumeLayout(false);

        }

        #endregion
        internal WindowsFormsApplication1.RoundButton rbtnA;
        internal WindowsFormsApplication1.RoundButton rbtnB;
        internal WindowsFormsApplication1.RoundButton rbtnC;
        internal WindowsFormsApplication1.RoundButton rbtnD;
        internal WindowsFormsApplication1.RoundButton rbtnScoreA;
        internal WindowsFormsApplication1.RoundButton rbtnScoreB;
        internal WindowsFormsApplication1.RoundButton rbtnScoreC;
        internal WindowsFormsApplication1.RoundButton rbtnScoreD;
    }
}
