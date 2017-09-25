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
        private static int m_PlayerScore;
        private static int m_OpponentScore;

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

        private void board_button_click(object sender, EventArgs e)
        {
            BoardButton button = (sender as BoardButton);

            button.Text = m_CurrentPlayer == ePlayer.Player ? "X" : "O";
            button.Enabled = false;
        }

        private void generate_button_click(object sender, EventArgs e)
        {
            //here we need the computer to generate indexes
        }

        //    private void runGame()
        //    {
        //        int inputtedRowNum = 0;
        //        int inputtedColNum = 0;
        //        bool isWon = false;
        //        bool currentRoundOver = false;
        //        bool keepPlaying = true;
        //        bool isTied = false;
        //        bool didPlayerQuit = false;

        //        Console.WriteLine("Click any key to start the Game.");
        //        Console.ReadLine();
        //        drawBoard();

        //        do
        //        {
        //            // Since player1 is always human.
        //            if (r_TicTacToeBoard.OpponentType == ePlayerType.Human || r_TicTacToeBoard.CurrentPlayer == ePlayer.Player)
        //            {
        //                getCellCoordinatesFromUser(out inputtedRowNum, out inputtedColNum, out didPlayerQuit);
        //            }

        //            if (!didPlayerQuit)
        //            {
        //                r_TicTacToeBoard.PlayTurn(ref inputtedRowNum, ref inputtedColNum);
        //                drawBoard();

        //                if (r_TicTacToeBoard.checkBoardForSequence(inputtedRowNum, inputtedColNum))
        //                {
        //                    updateScore();
        //                    showPlayersScore();
        //                    isWon = true;
        //                }
        //                else if (isGameTied())
        //                {
        //                    Console.WriteLine("{0}{1}", "The Game finished at Draw", Environment.NewLine);
        //                    showPlayersScore();
        //                    isTied = true;
        //                }

        //                switchPlayersTurn();
        //            }

        //            currentRoundOver = isTied || isWon || didPlayerQuit;

        //            if (currentRoundOver)
        //            {
        //                Console.WriteLine("The current game has ended. Would you like to play another round? Y/N");
        //                string userSelection = Console.ReadLine();

        //                if (userSelection == "N" || userSelection == "n")
        //                {
        //                    keepPlaying = false;
        //                }
        //                else
        //                {
        //                    prepareNextRound();
        //                    isWon = false;
        //                    isTied = false;
        //                    currentRoundOver = false;
        //                }
        //            }
        //        }
        //        while (keepPlaying);

        //        Console.WriteLine("Hope you Enjoyed! Click any key to exit.)");
        //        Console.ReadLine();
        //    }

        //    private void getCellCoordinatesFromUser(out int o_Rows, out int o_Cols, out bool o_QuitGame)
        //    {
        //        int selectedRow = 0;
        //        int selectedCol = 0;
        //        string rowStr = string.Empty;
        //        string colStr = string.Empty;
        //        bool isValidInput = true;

        //        do
        //        {
        //            Console.Write("Rows Index: ");
        //            rowStr = Console.ReadLine();

        //            if (didPlayerQuit(rowStr))
        //            {
        //                o_QuitGame = true;
        //                break;
        //            }

        //            Console.Write("Cols Index: ");
        //            colStr = Console.ReadLine();

        //            int.TryParse(rowStr, out selectedRow);
        //            int.TryParse(colStr, out selectedCol);

        //            o_QuitGame = didPlayerQuit(rowStr);

        //            // We decrement the coordinates in order to match the indices we print - matrix starts from 0, UI from 1.
        //            selectedCol--;
        //            selectedRow--;
        //            isValidInput = !(isOutOfRange(selectedRow, selectedCol, r_TicTacToeBoard.Size) || r_TicTacToeBoard.isCellOccupied(selectedRow, selectedCol));
        //        }
        //        while (!isValidInput);

        //        o_Rows = selectedRow;
        //        o_Cols = selectedCol;
        //    }

        //    private bool isGameTied()
        //    {
        //        return r_TicTacToeBoard.IsFull;
        //    }

        //    private void updateScore()
        //    {
        //        if (r_TicTacToeBoard.CurrentPlayer == ePlayer.Player)
        //        {
        //            // it is a REVERSED tic tac toe game. Hence, if the players get a sequence, they lose!
        //            Console.WriteLine("{0}{1}", "Opponent Wins!", Environment.NewLine);
        //            s_OpponentScore++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("{0}{1}", "Player Wins!", Environment.NewLine);
        //            s_PlayerScore++;
        //        }
        //    }

        //    private void switchPlayersTurn()
        //    {
        //        r_TicTacToeBoard.CurrentPlayer = r_TicTacToeBoard.CurrentPlayer == ePlayer.Player ? ePlayer.Opponent : ePlayer.Player;
        //    }

        //    private void prepareNextRound()
        //    {
        //        r_TicTacToeBoard.initializeGameBoard();
        //        drawBoard();
        //        r_TicTacToeBoard.CurrentPlayer = ePlayer.Player;
        //        r_TicTacToeBoard.CountOfOccupiedCells = 0;
        //        r_TicTacToeBoard.IsFull = false;
        //    }

    }
}