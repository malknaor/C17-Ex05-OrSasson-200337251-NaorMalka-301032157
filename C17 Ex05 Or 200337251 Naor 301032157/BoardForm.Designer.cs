namespace C17_Ex05_Or_200337251_Naor_301032157
{
    partial class BoardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOpponentScore = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2:";
            // 
            // labelOpponentScore
            // 
            this.labelOpponentScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelOpponentScore.AutoSize = true;
            this.labelOpponentScore.Location = new System.Drawing.Point(154, 231);
            this.labelOpponentScore.Name = "labelOpponentScore";
            this.labelOpponentScore.Size = new System.Drawing.Size(13, 13);
            this.labelOpponentScore.TabIndex = 6;
            this.labelOpponentScore.Text = "0";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Location = new System.Drawing.Point(69, 231);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.labelPlayerScore.TabIndex = 6;
            this.labelPlayerScore.Text = "0";
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(247, 253);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelOpponentScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BoardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeMisere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOpponentScore;
        private System.Windows.Forms.Label labelPlayerScore;
    }
}