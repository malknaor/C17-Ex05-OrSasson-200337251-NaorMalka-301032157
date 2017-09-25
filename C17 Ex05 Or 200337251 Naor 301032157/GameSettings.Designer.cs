namespace C17_Ex05_Or_200337251_Naor_301032157
{
    partial class GameSettings
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
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2CheckBox = new System.Windows.Forms.CheckBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.RowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(9, 10);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(47, 13);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players :";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(30, 35);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(51, 13);
            this.Player1Label.TabIndex = 1;
            this.Player1Label.Text = "Player 1 :";
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Location = new System.Drawing.Point(119, 28);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Player1TextBox.TabIndex = 2;
            this.Player1TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Player2CheckBox
            // 
            this.Player2CheckBox.AutoSize = true;
            this.Player2CheckBox.Location = new System.Drawing.Point(33, 57);
            this.Player2CheckBox.Name = "Player2CheckBox";
            this.Player2CheckBox.Size = new System.Drawing.Size(70, 17);
            this.Player2CheckBox.TabIndex = 3;
            this.Player2CheckBox.Text = "Player 2 :";
            this.Player2CheckBox.UseVisualStyleBackColor = true;
            this.Player2CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.Enabled = false;
            this.Player2TextBox.Location = new System.Drawing.Point(119, 54);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Player2TextBox.TabIndex = 4;
            this.Player2TextBox.Text = "[Computer]";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(9, 86);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(64, 13);
            this.BoardSizeLabel.TabIndex = 5;
            this.BoardSizeLabel.Text = "Board Size :";
            this.BoardSizeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // RowsNumericUpDown
            // 
            this.RowsNumericUpDown.AccessibleDescription = "";
            this.RowsNumericUpDown.AccessibleName = "";
            this.RowsNumericUpDown.Location = new System.Drawing.Point(75, 102);
            this.RowsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RowsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RowsNumericUpDown.Name = "RowsNumericUpDown";
            this.RowsNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.RowsNumericUpDown.TabIndex = 6;
            this.RowsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RowsNumericUpDown.ValueChanged += new System.EventHandler(this.rowsNumericUpDown_ValueChanged);
            // 
            // ColsNumericUpDown
            // 
            this.ColsNumericUpDown.Location = new System.Drawing.Point(171, 101);
            this.ColsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ColsNumericUpDown.Name = "ColsNumericUpDown";
            this.ColsNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.ColsNumericUpDown.TabIndex = 7;
            this.ColsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ColsNumericUpDown.ValueChanged += new System.EventHandler(this.colsNumericUpDown_ValueChanged);
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(33, 108);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(40, 13);
            this.RowsLabel.TabIndex = 8;
            this.RowsLabel.Text = "Rows :";
            this.RowsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(132, 108);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(33, 13);
            this.ColsLabel.TabIndex = 9;
            this.ColsLabel.Text = "Cols :";
            this.ColsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(75, 132);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.start_button_click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(231, 164);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.ColsNumericUpDown);
            this.Controls.Add(this.RowsNumericUpDown);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.Player2TextBox);
            this.Controls.Add(this.Player2CheckBox);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.PlayersLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.CheckBox Player2CheckBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.Label BoardSizeLabel;
        private System.Windows.Forms.NumericUpDown RowsNumericUpDown;
        private System.Windows.Forms.NumericUpDown ColsNumericUpDown;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

