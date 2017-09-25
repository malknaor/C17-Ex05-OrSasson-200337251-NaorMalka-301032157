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
                    r_ButtonsMatrix[i, j].Click += board_button_click;
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

        private void board_button_click(object sender, EventArgs e)
        {
            BoardButton button = (sender as BoardButton);
            int rowIndex = button.RowIndex;
            int colIndex = button.ColIndex;

            button.Text = m_CurrentPlayer == ePlayer.Player ? "X" : "O";
            button.Enabled = false;
            TicTacToeBoard.playTurn(ref rowIndex, ref colIndex);
        }

        private void generate_button_click(ref int io_RowIndex, ref int io_ColIndex)
        {
            TicTacToeBoard.playTurn(ref io_RowIndex, ref io_ColIndex); 
            ButtonsMatrix[io_RowIndex, io_ColIndex].Text = "O";
            ButtonsMatrix[io_RowIndex, io_ColIndex].Enabled = false;
        }

        protected 

        //private void runGame()
        //{
        //    int inputtedRowNum = 0;
        //    int inputtedColNum = 0;
        //    bool isWon = false;
        //    bool currentRoundOver = false;
        //    bool keepPlaying = true;
        //    bool isTied = false;

        //    do
        //    {
        //        if (m_CurrentPlayer == ePlayer.Player)
        //        {
        //            // WAIT FOR BUTTON CLICK
        //            TicTacToeBoard.playTurn(ref inputtedRowNum, ref inputtedColNum);
        //        }
        //        else
        //        {
        //            if (m_OpponentType == ePlayerType.Computer)
        //            {
        //                TicTacToeBoard.playTurn(ref inputtedRowNum, ref inputtedColNum);
        //            }
        //            else
        //            {
        //                // WAIT FOR BUTTON CLICK
        //            }
        //        }

        //        if (r_TicTacToeBoard.checkBoardForSequence(inputtedRowNum, inputtedColNum))
        //        {
        //            //DISPLAY A MASSAGE A WIN!**************
        //            //MASSAGE TO USER ASKING PLAY ANOTHER ROUND?**************
        //            //IF USER PRESS YES WE PREPARE ANOTHER ROUND****************
        //            isWon = true;
        //        }
        //        else if (isGameTied())
        //        {
        //            //DISPLAY A MASSAGE A TIE!**************
        //            //MASSAGE TO USER ASKING PLAY ANOTHER ROUND?**************
        //            //IF USER PRESS YES WE PREPARE ANOTHER ROUND****************
        //            isTied = true;
        //        }

        //        switchPlayersTurn();

        //        currentRoundOver = isTied || isWon;

        //        if (currentRoundOver)
        //        {
        //            //MASSAGE TO USER ASKING PLAY ANOTHER ROUND?**************
        //            //IF USER PRESS YES WE PREPARE ANOTHER ROUND****************
        //            prepareNextRound();
        //            isWon = false;
        //            isTied = false;
        //            currentRoundOver = false;
        //        }
        //    }
        //    while (keepPlaying);

        //    //DISPLAY A MASSAGE THANKS FOR PLAYING**************
        //}

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