using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Sudoku
{
    public static class Game
    {
        private readonly static Random random = new Random();

        private static int s;
        
        public static byte[] board = new byte[81];
        private static byte[] solved = new byte[81];

        static MainWindow mw1 = Application.Current.Windows
    .Cast<Window>()
    .FirstOrDefault(window => window is MainWindow) as MainWindow;

        public static void ResetFocus()
        {
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {
                    ((TextBox)tb).Focusable = true;
                }
            }            
        }

        public static void BoardToTextBox()
        {
            ushort i = 0;
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {
                    ((TextBox)tb).Text = board[i].ToString();
                    i++;
                }
            }
        }

        public static void DefaultColor()
        {
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {                
                    ((TextBox)tb).Foreground = Brushes.Black;                    
                }
            }            
        }
       
        public static void MakeNotFocusable()
        {
            ushort c = 0;
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {
                    if (board[c] == 0)
                    {
                        ((TextBox)tb).Clear();
                    }
                    else
                    {
                        ((TextBox)tb).Focusable = false;
                        ((TextBox)tb).Foreground = new SolidColorBrush(Color.FromRgb(60, 60, 60));
                    }
                    c++;
                }
            }
        }

        public static void SolvePuzzle()
        {
            ushort i = 0;
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {
                    ((TextBox)tb).Text = solved[i].ToString();
                    i++;
                }
            }
        }

        public static void ReEnter()
        {
            BoardsAlgorithm.board1();
            BoardsAlgorithm.board2();
            BoardsAlgorithm.board3();
            BoardsAlgorithm.board4();
            BoardsAlgorithm.board5();
            BoardsAlgorithm.board6();
            BoardsAlgorithm.board7();
            BoardsAlgorithm.board8();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row1();
            RowsAlgorithm.row2();
            RowsAlgorithm.row3();
            RowsAlgorithm.row4();
            RowsAlgorithm.row5();
            RowsAlgorithm.row6();
            RowsAlgorithm.row7();
            RowsAlgorithm.row8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column1();
            ColumnsAlgorithm.column2();
            ColumnsAlgorithm.column3();
            ColumnsAlgorithm.column4();
            ColumnsAlgorithm.column5();
            ColumnsAlgorithm.column6();
            ColumnsAlgorithm.column7();
            ColumnsAlgorithm.column8();
            ColumnsAlgorithm.column9();
        }
        
        private static ushort i = 23;
        public static void Start(ushort value)
        {
            DefaultColor();

            s = random.Next(1, i);
            switch (s)
                {
                case 1:
                    Array.Copy(SudokuDatabase.sudoku1, board, 81);
                    break;
                case 2:
                    Array.Copy(SudokuDatabase.sudoku2, board, 81);
                    break;
                case 3:
                    Array.Copy(SudokuDatabase.sudoku3, board, 81);
                    break;
                case 4:
                    Array.Copy(SudokuDatabase.sudoku4, board, 81);
                    break;
                case 5:
                    Array.Copy(SudokuDatabase.sudoku5, board, 81);
                    break;
                case 6:
                    Array.Copy(SudokuDatabase.sudoku6, board, 81);
                    break;
                case 7:
                    Array.Copy(SudokuDatabase.sudoku7, board, 81);
                    break;
                case 8:
                    Array.Copy(SudokuDatabase.sudoku8, board, 81);
                    break;
                case 9:
                    Array.Copy(SudokuDatabase.sudoku9, board, 81);
                    break;
                case 10:
                    Array.Copy(SudokuDatabase.sudoku10, board, 81);
                    break;
                case 11:
                    Array.Copy(SudokuDatabase.sudoku11, board, 81);
                    break;
                case 12:
                    Array.Copy(SudokuDatabase.sudoku12, board, 81);
                    break;
                case 13:
                    Array.Copy(SudokuDatabase.sudoku13, board, 81);
                    break;
                case 14:
                    Array.Copy(SudokuDatabase.sudoku14, board, 81);
                    break;
                case 15:
                    Array.Copy(SudokuDatabase.sudoku15, board, 81);
                    break;
                case 16:
                    Array.Copy(SudokuDatabase.sudoku16, board, 81);
                    break;
                case 17:
                    Array.Copy(SudokuDatabase.sudoku17, board, 81);
                    break;
                case 18:
                    Array.Copy(SudokuDatabase.sudoku18, board, 81);
                    break;
                case 19:
                    Array.Copy(SudokuDatabase.sudoku19, board, 81);
                    break;
                case 20:
                    Array.Copy(SudokuDatabase.sudoku20, board, 81);
                    break;
                case 21:
                    Array.Copy(SudokuDatabase.sudoku21, board, 81);
                    break;
                case 22:
                    Array.Copy(SudokuDatabase.sudoku22, board, 81);
                    break;
            }

            Thread.Sleep(1);

            s = random.Next(0, 2);
            if (s == 1)
            {
                Array.Reverse(board);
                Console.WriteLine("Reversed");
            }
               
            Array.Copy(board, solved, 81);

            for (ushort i = 0; i < value; i++)
            {                
            s = random.Next(0, 81);
                Thread.Sleep(2);
                board[s] = 0;              
            }

            ResetFocus();
            BoardToTextBox();
            MakeNotFocusable();
           
            ReEnter();            
        }
    }
}
