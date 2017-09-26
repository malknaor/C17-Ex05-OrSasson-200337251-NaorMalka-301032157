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
        private ePlayer m_CurrentPlayer;
        private readonly ePlayerType m_OpponentType;
        private /*static*/ int m_PlayerScore;
        private /*static*/ int m_OpponentScore;

        public BoardForm(int i_Size, ePlayerType i_Opponent)
        {
            r_GameBoardSize = i_Size;
            r_ButtonsMatrix = new BoardButton[r_GameBoardSize, r_GameBoardSize];
            r_TicTacToeBoard = new TicTacToeBoard(i_Size, i_Opponent);
            m_OpponentType = i_Opponent;
            m_CurrentPlayer = r_TicTacToeBoard.CurrentPlayer;
            m_PlayerScore = 0;
            m_OpponentScore = 0;

            int buttonHeight = 40;
            int buttonWidth = 40;
            int startHeight = this.Top;
            int startWidth = this.Left;

            InitializeComponent();

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
        }

        internal TicTacToeBoard TicTacToeBoard
        {
            get
            {
                return r_TicTacToeBoard;
            }
        }

        internal ePlayer CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
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

            button.Text = m_CurrentPlayer == ePlayer.Player ? "X" : "O";
            button.Enabled = false;
            TicTacToeBoard.playTurn(ref rowIndex, ref colIndex);
            switchPlayersTurn();

            if (m_OpponentType == ePlayerType.Computer)
            {
                generateButtonClick();
            }
        }

        private void onTie(object sender, EventArgs e)
        {
            string massage = @"A Tie!
Would you like to play another round?";


        }

        private void onWin(object sender, EventArgs e)
        {
            string massage = @"A Win!
Would you like to play another round?";

        }

        private void generateButtonClick()
        {
            int i = 0;
            int j = 0;
            TicTacToeBoard.playTurn(ref i, ref j); 
            ButtonsMatrix[i, j].Text = "O";
            ButtonsMatrix[i, j].Enabled = false;

            switchPlayersTurn();
        }

        private bool isGameTied()
        {
            return r_TicTacToeBoard.IsFull;
        }

        private void updateScore()
        {
            if (r_TicTacToeBoard.CurrentPlayer == ePlayer.Player)
            {
                // it is a REVERSED tic tac toe game. Hence, if the players get a sequence, they lose!
                m_OpponentScore++;
            }
            else
            {
                m_PlayerScore++;
            }
        }

        private void switchPlayersTurn()
        {
            r_TicTacToeBoard.CurrentPlayer = r_TicTacToeBoard.CurrentPlayer == ePlayer.Player ? ePlayer.Opponent : ePlayer.Player;
        }

        private void prepareNextRound()
        {
            r_TicTacToeBoard.initializeGameBoard();
            r_TicTacToeBoard.CurrentPlayer = ePlayer.Player;
            r_TicTacToeBoard.CountOfOccupiedCells = 0;
            r_TicTacToeBoard.IsFull = false;
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
    }
}