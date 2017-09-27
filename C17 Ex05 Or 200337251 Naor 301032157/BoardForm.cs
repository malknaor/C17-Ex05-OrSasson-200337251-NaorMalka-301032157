using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using C17_Ex02_Naor_301032157_Or_200337251;

namespace C17_Ex05_Or_200337251_Naor_301032157
{
    public partial class BoardForm : Form
    {
        private readonly int r_GameBoardSize;
        private readonly Button[,] r_ButtonsMatrix;
        private readonly TicTacToeBoard r_TicTacToeBoard;
        private readonly ePlayerType m_OpponentType;
        private string m_Player1Name;
        private string m_Player2Name;
        private GameSettings m_GameSetting;
        private Label m_Label1;
        private Label m_Label2;
        private Label m_LabelOpponentScore;
        private Label m_LabelPlayerScore;
            
        public BoardForm()
        {
            m_GameSetting = new GameSettings();
            m_GameSetting.ShowDialog();
            r_GameBoardSize = m_GameSetting.Size;
            m_Player1Name = m_GameSetting.Player1Name;
            m_Player2Name = m_GameSetting.Player2Name;
            m_OpponentType = m_GameSetting.OpponentType;
            r_ButtonsMatrix = new BoardButton[r_GameBoardSize, r_GameBoardSize];
            r_TicTacToeBoard = new TicTacToeBoard(r_GameBoardSize, m_OpponentType);
            TicTacToeBoard.Tie += onTie;
            TicTacToeBoard.Win += onWin;
            TicTacToeBoard.OnCellChanged += onCellChanged;

            int buttonHeight = 40;
            int buttonWidth = 40;
            int startHeight = this.Top;
            int startWidth = this.Left;
            int space = 10;

            this.m_Label1 = new System.Windows.Forms.Label();
            this.m_Label2 = new System.Windows.Forms.Label();
            this.m_LabelOpponentScore = new System.Windows.Forms.Label();
            this.m_LabelPlayerScore = new System.Windows.Forms.Label();

            InitializeComponent();

            m_Label1.Text = m_Player1Name + ":";
            m_Label2.Text = m_Player2Name + ":";

            for (int i = 0; i < r_GameBoardSize; i++)
            {
                for (int j = 0; j < r_GameBoardSize; j++)
                {
                    r_ButtonsMatrix[i, j] = new BoardButton(i, j);
                    r_ButtonsMatrix[i, j].Top = startHeight + i * buttonHeight;
                    r_ButtonsMatrix[i, j].Left = startWidth + j * buttonWidth;
                    r_ButtonsMatrix[i, j].Height = buttonHeight;
                    r_ButtonsMatrix[i, j].Width = buttonWidth;
                    r_ButtonsMatrix[i, j].Text = "";
                    r_ButtonsMatrix[i, j].Click += OnClick;
                    this.Controls.Add(r_ButtonsMatrix[i, j]);
                }
            }

            
            this.Controls.Add(m_Label1);
            this.m_Label1.Left = this.Left + 10;
            this.m_Label1.Top = r_ButtonsMatrix[r_GameBoardSize - 1, r_GameBoardSize - 1].Top + buttonHeight;
            this.m_Label1.AutoSize = true;

            this.Controls.Add(m_LabelPlayerScore);
            this.m_LabelPlayerScore.Left = m_Label1.Left + m_Label1.Width + 10;
            this.m_LabelPlayerScore.Top = m_Label1.Top;
            this.m_LabelPlayerScore.Text = "0";
            this.m_LabelPlayerScore.AutoSize = true;

            this.Controls.Add(m_Label2);
            this.m_Label2.Left = m_LabelPlayerScore.Left + m_LabelPlayerScore.Width + 10;
            this.m_Label2.Top = m_Label1.Top;
            this.m_Label2.AutoSize = true;

            this.Controls.Add(m_LabelOpponentScore);
            this.m_LabelOpponentScore.Left = m_Label2.Left + m_Label2.Width + 10;
            this.m_LabelOpponentScore.Top = m_Label1.Top;
            this.m_LabelOpponentScore.Text = "0";
            this.m_LabelOpponentScore.AutoSize = true;

        }

        private void onCellChanged(int i_Row, int i_Col)
        {
            ButtonsMatrix[i_Row, i_Col].Text = "O";
            ButtonsMatrix[i_Row, i_Col].Enabled = false;
        }

        internal TicTacToeBoard TicTacToeBoard
        {
            get
            {
                return r_TicTacToeBoard;
            }
        }

        public Button[,] ButtonsMatrix
        {
            get
            {
                return r_ButtonsMatrix;
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            BoardButton button = (sender as BoardButton);
            int rowIndex = button.RowIndex;
            int colIndex = button.ColIndex;

            button.Text = TicTacToeBoard.CurrentPlayer == ePlayer.Player ? "X" : "O";
            button.Enabled = false;
            TicTacToeBoard.PlayTurn(ref rowIndex, ref colIndex);

            if (m_OpponentType == ePlayerType.Computer && !TicTacToeBoard.NewGame)
            {
                generateButtonClick();
            }

            TicTacToeBoard.NewGame = false;
        }

        private void onTie(object sender, EventArgs e)
        {
            string massage = @"A Tie!
Would you like to play another round?";

            DialogResult result = MessageBox.Show(massage, "Tie!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                prepareNextRound();
            }
            else
            {
                this.Close();
            }
        }

        private string gameStateToString()
        {
            string name = string.Empty;

            switch (TicTacToeBoard.GameState)
            {
                case eGameState.Player1:
                    name = m_Player1Name;
                    break;
                case eGameState.Player2:
                    name = m_Player2Name;
                    break;
                default:
                    break;
            }

            return name;
        }

        private void onWin(object sender, EventArgs e)
        {
            string massage = string.Format(@"The winner is {0}! 
Would you like to play another round?", gameStateToString());
            DialogResult result = MessageBox.Show(massage, "Win!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                m_LabelPlayerScore.Text = TicTacToeBoard.PlayerScore.ToString();
                m_LabelOpponentScore.Text = TicTacToeBoard.OpponentScore.ToString();
                prepareNextRound();
            }
            else
            {
                this.Close();
            }
        }

        private void generateButtonClick()
        {
            int i = 0;
            int j = 0;

            TicTacToeBoard.PlayTurn(ref i, ref j);
        }

        private void prepareNextRound()
        {
            TicTacToeBoard.initializeGameBoard();
            initializeBoardButtons();
        }

        private void initializeBoardButtons()
        {
            foreach(BoardButton buttun in ButtonsMatrix)
            {
                buttun.Text = "";
                buttun.Enabled = true;
            }
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {

        }
    }
}