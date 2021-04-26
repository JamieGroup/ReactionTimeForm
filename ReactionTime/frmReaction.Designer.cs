namespace ReactionTime
{
    partial class frmReaction
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbAverageScoreInfo = new System.Windows.Forms.Label();
            this.lbAverageScore = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClick2 = new System.Windows.Forms.Button();
            this.tmrTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(29, 35);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(220, 104);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Reaction Time:\r\n\r\nWhen you are ready, click the button to start.\r\nA button will a" +
    "ppear on your screen.\r\nClick it.\r\n\r\n\r\nAttempts:";
            // 
            // lbAttempts
            // 
            this.lbAttempts.AutoSize = true;
            this.lbAttempts.Location = new System.Drawing.Point(95, 125);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(0, 13);
            this.lbAttempts.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(400, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Click me to Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(425, 192);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(37, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(666, 35);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(24, 25);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "0";
            // 
            // lbAverageScoreInfo
            // 
            this.lbAverageScoreInfo.AutoSize = true;
            this.lbAverageScoreInfo.Location = new System.Drawing.Point(671, 81);
            this.lbAverageScoreInfo.Name = "lbAverageScoreInfo";
            this.lbAverageScoreInfo.Size = new System.Drawing.Size(81, 13);
            this.lbAverageScoreInfo.TabIndex = 5;
            this.lbAverageScoreInfo.Text = "Average Score:";
            // 
            // lbAverageScore
            // 
            this.lbAverageScore.AutoSize = true;
            this.lbAverageScore.Location = new System.Drawing.Point(759, 81);
            this.lbAverageScore.Name = "lbAverageScore";
            this.lbAverageScore.Size = new System.Drawing.Size(0, 13);
            this.lbAverageScore.TabIndex = 6;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnClick2
            // 
            this.btnClick2.Location = new System.Drawing.Point(612, 191);
            this.btnClick2.Name = "btnClick2";
            this.btnClick2.Size = new System.Drawing.Size(75, 23);
            this.btnClick2.TabIndex = 7;
            this.btnClick2.Text = "click me too";
            this.btnClick2.UseVisualStyleBackColor = true;
            this.btnClick2.Click += new System.EventHandler(this.btnClick2_Click);
            // 
            // frmReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 384);
            this.Controls.Add(this.btnClick2);
            this.Controls.Add(this.lbAverageScore);
            this.Controls.Add(this.lbAverageScoreInfo);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.lbInfo);
            this.Name = "frmReaction";
            this.Text = "Reaction Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbAttempts;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbAverageScoreInfo;
        private System.Windows.Forms.Label lbAverageScore;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnClick2;
        private System.Windows.Forms.Timer tmrTimer2;
    }
}

