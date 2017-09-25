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
    internal class BoardButton : Button
    {
        private Button m_Button;
        private readonly int r_RowIndex;
        private readonly int r_ColIndex;

        public BoardButton(int i_RowIndex, int i_ColIndex)
        {
            r_RowIndex = i_RowIndex;
            r_ColIndex = i_ColIndex;
            m_Button = new Button();
        }

        public Button Button
        {
            get
            {
                return m_Button;
            }
        }

        public int RowIndex
        {
            get
            {
                return r_RowIndex;
            }
        }

        public int ColIndex
        {
            get
            {
                return r_ColIndex;
            }
        }
    }
}
