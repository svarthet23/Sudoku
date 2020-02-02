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
        private static byte[] board90 = new byte[81];
        private static byte[] board270 = new byte[81];
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
        
        private static ushort i = 61;
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
                case 23:
                    Array.Copy(SudokuDatabase.sudoku23, board, 81);
                    break;
                case 24:
                    Array.Copy(SudokuDatabase.sudoku24, board, 81);
                    break;
                case 25:
                    Array.Copy(SudokuDatabase.sudoku25, board, 81);
                    break;
                case 26:
                    Array.Copy(SudokuDatabase.sudoku26, board, 81);
                    break;
                case 27:
                    Array.Copy(SudokuDatabase.sudoku27, board, 81);
                    break;
                case 28:
                    Array.Copy(SudokuDatabase.sudoku28, board, 81);
                    break;
                case 29:
                    Array.Copy(SudokuDatabase.sudoku29, board, 81);
                    break;
                case 30:
                    Array.Copy(SudokuDatabase.sudoku30, board, 81);
                    break;
                case 31:
                    Array.Copy(SudokuDatabase.sudoku31, board, 81);
                    break;
                case 32:
                    Array.Copy(SudokuDatabase.sudoku32, board, 81);
                    break;
                case 33:
                    Array.Copy(SudokuDatabase.sudoku33, board, 81);
                    break;
                case 34:
                    Array.Copy(SudokuDatabase.sudoku34, board, 81);
                    break;
                case 35:
                    Array.Copy(SudokuDatabase.sudoku35, board, 81);
                    break;
                case 36:
                    Array.Copy(SudokuDatabase.sudoku36, board, 81);
                    break;
                case 37:
                    Array.Copy(SudokuDatabase.sudoku37, board, 81);
                    break;
                case 38:
                    Array.Copy(SudokuDatabase.sudoku38, board, 81);
                    break;
                case 39:
                    Array.Copy(SudokuDatabase.sudoku39, board, 81);
                    break;
                case 40:
                    Array.Copy(SudokuDatabase.sudoku40, board, 81);
                    break;
                case 41:
                    Array.Copy(SudokuDatabase.sudoku41, board, 81);
                    break;
                case 42:
                    Array.Copy(SudokuDatabase.sudoku42, board, 81);
                    break;
                case 43:
                    Array.Copy(SudokuDatabase.sudoku43, board, 81);
                    break;
                case 44:
                    Array.Copy(SudokuDatabase.sudoku44, board, 81);
                    break;
                case 45:
                    Array.Copy(SudokuDatabase.sudoku45, board, 81);
                    break;
                case 46:
                    Array.Copy(SudokuDatabase.sudoku46, board, 81);
                    break;
                case 47:
                    Array.Copy(SudokuDatabase.sudoku47, board, 81);
                    break;
                case 48:
                    Array.Copy(SudokuDatabase.sudoku48, board, 81);
                    break;
                case 49:
                    Array.Copy(SudokuDatabase.sudoku49, board, 81);
                    break;
                case 50:
                    Array.Copy(SudokuDatabase.sudoku50, board, 81);
                    break;
                case 51:
                    Array.Copy(SudokuDatabase.sudoku51, board, 81);
                    break;
                case 52:
                    Array.Copy(SudokuDatabase.sudoku52, board, 81);
                    break;
                case 53:
                    Array.Copy(SudokuDatabase.sudoku53, board, 81);
                    break;
                case 54:
                    Array.Copy(SudokuDatabase.sudoku54, board, 81);
                    break;
                case 55:
                    Array.Copy(SudokuDatabase.sudoku55, board, 81);
                    break;
                case 56:
                    Array.Copy(SudokuDatabase.sudoku56, board, 81);
                    break;
                case 57:
                    Array.Copy(SudokuDatabase.sudoku57, board, 81);
                    break;
                case 58:
                    Array.Copy(SudokuDatabase.sudoku58, board, 81);
                    break;
                case 59:
                    Array.Copy(SudokuDatabase.sudoku59, board, 81);
                    break;
                case 60:
                    Array.Copy(SudokuDatabase.sudoku60, board, 81);
                    break;                    
            }

            Console.WriteLine(s);
            Thread.Sleep(1);

            s = random.Next(0, 4);

            if (s == 0)
            {
                Console.WriteLine("Normal");
            }               
            else if (s == 1)
            {
                Array.Reverse(board);
                Console.WriteLine("Rotated 180");
            }
            else if (s == 2)
            {
                board90[8] = board[0];
                board90[17] = board[1];
                board90[26] = board[2];
                board90[35] = board[3];
                board90[44] = board[4];
                board90[53] = board[5];
                board90[62] = board[6];
                board90[71] = board[7];
                board90[80] = board[8];
                board90[7] = board[9];
                board90[16] = board[10];
                board90[25] = board[11];
                board90[34] = board[12];
                board90[43] = board[13];
                board90[52] = board[14];
                board90[61] = board[15];
                board90[70] = board[16];
                board90[79] = board[17];
                board90[6] = board[18];
                board90[15] = board[19];
                board90[24] = board[20];
                board90[33] = board[21];
                board90[42] = board[22];
                board90[51] = board[23];
                board90[60] = board[24];
                board90[69] = board[25];
                board90[78] = board[26];
                board90[5] = board[27];
                board90[14] = board[28];
                board90[23] = board[29];
                board90[32] = board[30];
                board90[41] = board[31];
                board90[50] = board[32];
                board90[59] = board[33];
                board90[68] = board[34];
                board90[77] = board[35];
                board90[4] = board[36];
                board90[13] = board[37];
                board90[22] = board[38];
                board90[31] = board[39];
                board90[40] = board[40];
                board90[49] = board[41];
                board90[58] = board[42];
                board90[67] = board[43];
                board90[76] = board[44];
                board90[3] = board[45];
                board90[12] = board[46];
                board90[21] = board[47];
                board90[30] = board[48];
                board90[39] = board[49];
                board90[48] = board[50];
                board90[57] = board[51];
                board90[66] = board[52];
                board90[75] = board[53];
                board90[2] = board[54];
                board90[11] = board[55];
                board90[20] = board[56];
                board90[29] = board[57];
                board90[38] = board[58];
                board90[47] = board[59];
                board90[56] = board[60];
                board90[65] = board[61];
                board90[74] = board[62];
                board90[1] = board[63];
                board90[10] = board[64];
                board90[19] = board[65];
                board90[28] = board[66];
                board90[37] = board[67];
                board90[46] = board[68];
                board90[55] = board[69];
                board90[64] = board[70];
                board90[73] = board[71];
                board90[0] = board[72];
                board90[9] = board[73];
                board90[18] = board[74];
                board90[27] = board[75];
                board90[36] = board[76];
                board90[45] = board[77];
                board90[54] = board[78];
                board90[63] = board[79];
                board90[72] = board[80];
                Array.Copy(board90, 0, board, 0, 81);
                Console.WriteLine("Rotated90");
            }
            else if (s == 3)
            {
                board270[72] = board[0];
                board270[63] = board[1];
                board270[54] = board[2];
                board270[45] = board[3];
                board270[36] = board[4];
                board270[27] = board[5];
                board270[18] = board[6];
                board270[9] = board[7];
                board270[0] = board[8];
                board270[73] = board[9];
                board270[64] = board[10];
                board270[55] = board[11];
                board270[46] = board[12];
                board270[37] = board[13];
                board270[28] = board[14];
                board270[19] = board[15];
                board270[10] = board[16];
                board270[1] = board[17];
                board270[74] = board[18];
                board270[65] = board[19];
                board270[56] = board[20];
                board270[47] = board[21];
                board270[38] = board[22];
                board270[29] = board[23];
                board270[20] = board[24];
                board270[11] = board[25];
                board270[2] = board[26];
                board270[75] = board[27];
                board270[66] = board[28];
                board270[57] = board[29];
                board270[48] = board[30];
                board270[39] = board[31];
                board270[30] = board[32];
                board270[21] = board[33];
                board270[12] = board[34];
                board270[3] = board[35];
                board270[76] = board[36];
                board270[67] = board[37];
                board270[58] = board[38];
                board270[49] = board[39];
                board270[40] = board[40];
                board270[31] = board[41];
                board270[22] = board[42];
                board270[13] = board[43];
                board270[4] = board[44];
                board270[77] = board[45];
                board270[68] = board[46];
                board270[59] = board[47];
                board270[50] = board[48];
                board270[41] = board[49];
                board270[32] = board[50];
                board270[23] = board[51];
                board270[14] = board[52];
                board270[5] = board[53];
                board270[78] = board[54];
                board270[69] = board[55];
                board270[60] = board[56];
                board270[51] = board[57];
                board270[42] = board[58];
                board270[33] = board[59];
                board270[24] = board[60];
                board270[15] = board[61];
                board270[6] = board[62];
                board270[79] = board[63];
                board270[70] = board[64];
                board270[61] = board[65];
                board270[52] = board[66];
                board270[43] = board[67];
                board270[34] = board[68];
                board270[25] = board[69];
                board270[16] = board[70];
                board270[7] = board[71];
                board270[80] = board[72];
                board270[71] = board[73];
                board270[62] = board[74];
                board270[53] = board[75];
                board270[44] = board[76];
                board270[35] = board[77];
                board270[26] = board[78];
                board270[17] = board[79];
                board270[8] = board[80];
                Array.Copy(board270, 0, board, 0, 81);
                Console.WriteLine("Rotated270");
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