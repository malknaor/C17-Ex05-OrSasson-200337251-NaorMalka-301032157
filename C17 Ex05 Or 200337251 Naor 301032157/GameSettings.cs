using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C17_Ex02_Naor_301032157_Or_200337251;

namespace C17_Ex05_Or_200337251_Naor_301032157
{
    public partial class GameSettings : Form
    {
        private ePlayerType m_Opponent;
        private int m_Size;

        public GameSettings()
        {
            m_Opponent = ePlayerType.Computer;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Player2TextBox.Enabled)
            {
                Player2TextBox.Enabled = true;
                m_Opponent = ePlayerType.Human;
            }
            else
            {
                Player2TextBox.Enabled = false;
                m_Opponent = ePlayerType.Computer;
            }
        }

        private void rowsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ColsNumericUpDown.Value = RowsNumericUpDown.Value;
            m_Size = int.Parse(RowsNumericUpDown.Value.ToString());
        }

        private void colsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RowsNumericUpDown.Value = ColsNumericUpDown.Value;
            m_Size = int.Parse(ColsNumericUpDown.Value.ToString());
        }

        private void start_button_click(object sender, EventArgs e)
        {
            
        }
    }
}
