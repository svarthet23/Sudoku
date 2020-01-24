using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace Sudoku
{
    public static class Game
    {
        private readonly static Random random = new Random();
        private static int s;        
        private static byte[] board = new byte[81];

        static MainWindow mw1 = Application.Current.Windows
    .Cast<Window>()
    .FirstOrDefault(window => window is MainWindow) as MainWindow;

        public static void ResetFocus()
        {
            mw1.tb1.Focusable = true;
            mw1.tb2.Focusable = true;
            mw1.tb3.Focusable = true;
            mw1.tb4.Focusable = true;
            mw1.tb5.Focusable = true;
            mw1.tb6.Focusable = true;
            mw1.tb7.Focusable = true;
            mw1.tb8.Focusable = true;
            mw1.tb9.Focusable = true;
            mw1.tb10.Focusable = true;
            mw1.tb11.Focusable = true;
            mw1.tb12.Focusable = true;
            mw1.tb13.Focusable = true;
            mw1.tb14.Focusable = true;
            mw1.tb15.Focusable = true;
            mw1.tb16.Focusable = true;
            mw1.tb17.Focusable = true;
            mw1.tb18.Focusable = true;
            mw1.tb19.Focusable = true;
            mw1.tb20.Focusable = true;
            mw1.tb21.Focusable = true;
            mw1.tb22.Focusable = true;
            mw1.tb23.Focusable = true;
            mw1.tb24.Focusable = true;
            mw1.tb25.Focusable = true;
            mw1.tb26.Focusable = true;
            mw1.tb27.Focusable = true;
            mw1.tb28.Focusable = true;
            mw1.tb29.Focusable = true;
            mw1.tb30.Focusable = true;
            mw1.tb31.Focusable = true;
            mw1.tb32.Focusable = true;
            mw1.tb33.Focusable = true;
            mw1.tb34.Focusable = true;
            mw1.tb35.Focusable = true;
            mw1.tb36.Focusable = true;
            mw1.tb37.Focusable = true;
            mw1.tb38.Focusable = true;
            mw1.tb39.Focusable = true;
            mw1.tb40.Focusable = true;
            mw1.tb41.Focusable = true;
            mw1.tb42.Focusable = true;
            mw1.tb43.Focusable = true;
            mw1.tb44.Focusable = true;
            mw1.tb45.Focusable = true;
            mw1.tb46.Focusable = true;
            mw1.tb47.Focusable = true;
            mw1.tb48.Focusable = true;
            mw1.tb49.Focusable = true;
            mw1.tb50.Focusable = true;
            mw1.tb51.Focusable = true;
            mw1.tb52.Focusable = true;
            mw1.tb53.Focusable = true;
            mw1.tb54.Focusable = true;
            mw1.tb55.Focusable = true;
            mw1.tb56.Focusable = true;
            mw1.tb57.Focusable = true;
            mw1.tb58.Focusable = true;
            mw1.tb59.Focusable = true;
            mw1.tb60.Focusable = true;
            mw1.tb61.Focusable = true;
            mw1.tb62.Focusable = true;
            mw1.tb63.Focusable = true;
            mw1.tb64.Focusable = true;
            mw1.tb65.Focusable = true;
            mw1.tb66.Focusable = true;
            mw1.tb67.Focusable = true;
            mw1.tb68.Focusable = true;
            mw1.tb69.Focusable = true;
            mw1.tb70.Focusable = true;
            mw1.tb71.Focusable = true;
            mw1.tb72.Focusable = true;
            mw1.tb73.Focusable = true;
            mw1.tb74.Focusable = true;
            mw1.tb75.Focusable = true;
            mw1.tb76.Focusable = true;
            mw1.tb77.Focusable = true;
            mw1.tb78.Focusable = true;
            mw1.tb79.Focusable = true;
            mw1.tb80.Focusable = true;
            mw1.tb81.Focusable = true;
        }
        private static void BoardToTextBox()
        {
            mw1.tb1.Text = board[0].ToString();
            mw1.tb2.Text = board[1].ToString();
            mw1.tb3.Text = board[2].ToString();
            mw1.tb4.Text = board[3].ToString();
            mw1.tb5.Text = board[4].ToString();
            mw1.tb6.Text = board[5].ToString();
            mw1.tb7.Text = board[6].ToString();
            mw1.tb8.Text = board[7].ToString();
            mw1.tb9.Text = board[8].ToString();
            mw1.tb10.Text = board[9].ToString();
            mw1.tb11.Text = board[10].ToString();
            mw1.tb12.Text = board[11].ToString();
            mw1.tb13.Text = board[12].ToString();
            mw1.tb14.Text = board[13].ToString();
            mw1.tb15.Text = board[14].ToString();
            mw1.tb16.Text = board[15].ToString();
            mw1.tb17.Text = board[16].ToString();
            mw1.tb18.Text = board[17].ToString();
            mw1.tb19.Text = board[18].ToString();
            mw1.tb20.Text = board[19].ToString();
            mw1.tb21.Text = board[20].ToString();
            mw1.tb22.Text = board[21].ToString();
            mw1.tb23.Text = board[22].ToString();
            mw1.tb24.Text = board[23].ToString();
            mw1.tb25.Text = board[24].ToString();
            mw1.tb26.Text = board[25].ToString();
            mw1.tb27.Text = board[26].ToString();
            mw1.tb28.Text = board[27].ToString();
            mw1.tb29.Text = board[28].ToString();
            mw1.tb30.Text = board[29].ToString();
            mw1.tb31.Text = board[30].ToString();
            mw1.tb32.Text = board[31].ToString();
            mw1.tb33.Text = board[32].ToString();
            mw1.tb34.Text = board[33].ToString();
            mw1.tb35.Text = board[34].ToString();
            mw1.tb36.Text = board[35].ToString();
            mw1.tb37.Text = board[36].ToString();
            mw1.tb38.Text = board[37].ToString();
            mw1.tb39.Text = board[38].ToString();
            mw1.tb40.Text = board[39].ToString();
            mw1.tb41.Text = board[40].ToString();
            mw1.tb42.Text = board[41].ToString();
            mw1.tb43.Text = board[42].ToString();
            mw1.tb44.Text = board[43].ToString();
            mw1.tb45.Text = board[44].ToString();
            mw1.tb46.Text = board[45].ToString();
            mw1.tb47.Text = board[46].ToString();
            mw1.tb48.Text = board[47].ToString();
            mw1.tb49.Text = board[48].ToString();
            mw1.tb50.Text = board[49].ToString();
            mw1.tb51.Text = board[50].ToString();
            mw1.tb52.Text = board[51].ToString();
            mw1.tb53.Text = board[52].ToString();
            mw1.tb54.Text = board[53].ToString();
            mw1.tb55.Text = board[54].ToString();
            mw1.tb56.Text = board[55].ToString();
            mw1.tb57.Text = board[56].ToString();
            mw1.tb58.Text = board[57].ToString();
            mw1.tb59.Text = board[58].ToString();
            mw1.tb60.Text = board[59].ToString();
            mw1.tb61.Text = board[60].ToString();
            mw1.tb62.Text = board[61].ToString();
            mw1.tb63.Text = board[62].ToString();
            mw1.tb64.Text = board[63].ToString();
            mw1.tb65.Text = board[64].ToString();
            mw1.tb66.Text = board[65].ToString();
            mw1.tb67.Text = board[66].ToString();
            mw1.tb68.Text = board[67].ToString();
            mw1.tb69.Text = board[68].ToString();
            mw1.tb70.Text = board[69].ToString();
            mw1.tb71.Text = board[70].ToString();
            mw1.tb72.Text = board[71].ToString();
            mw1.tb73.Text = board[72].ToString();
            mw1.tb74.Text = board[73].ToString();
            mw1.tb75.Text = board[74].ToString();
            mw1.tb76.Text = board[75].ToString();
            mw1.tb77.Text = board[76].ToString();
            mw1.tb78.Text = board[77].ToString();
            mw1.tb79.Text = board[78].ToString();
            mw1.tb80.Text = board[79].ToString();
            mw1.tb81.Text = board[80].ToString();
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
        public static void DefaultColor()
        {
            mw1.tb1.Foreground = Brushes.Black;
            mw1.tb2.Foreground = Brushes.Black;
            mw1.tb3.Foreground = Brushes.Black;
            mw1.tb4.Foreground = Brushes.Black;
            mw1.tb5.Foreground = Brushes.Black;
            mw1.tb6.Foreground = Brushes.Black;
            mw1.tb7.Foreground = Brushes.Black;
            mw1.tb8.Foreground = Brushes.Black;
            mw1.tb9.Foreground = Brushes.Black;
            mw1.tb10.Foreground = Brushes.Black;
            mw1.tb11.Foreground = Brushes.Black;
            mw1.tb12.Foreground = Brushes.Black;
            mw1.tb13.Foreground = Brushes.Black;
            mw1.tb14.Foreground = Brushes.Black;
            mw1.tb15.Foreground = Brushes.Black;
            mw1.tb16.Foreground = Brushes.Black;
            mw1.tb17.Foreground = Brushes.Black;
            mw1.tb18.Foreground = Brushes.Black;
            mw1.tb19.Foreground = Brushes.Black;
            mw1.tb20.Foreground = Brushes.Black;
            mw1.tb21.Foreground = Brushes.Black;
            mw1.tb22.Foreground = Brushes.Black;
            mw1.tb23.Foreground = Brushes.Black;
            mw1.tb24.Foreground = Brushes.Black;
            mw1.tb25.Foreground = Brushes.Black;
            mw1.tb26.Foreground = Brushes.Black;
            mw1.tb27.Foreground = Brushes.Black;
            mw1.tb28.Foreground = Brushes.Black;
            mw1.tb29.Foreground = Brushes.Black;
            mw1.tb30.Foreground = Brushes.Black;
            mw1.tb31.Foreground = Brushes.Black;
            mw1.tb32.Foreground = Brushes.Black;
            mw1.tb33.Foreground = Brushes.Black;
            mw1.tb34.Foreground = Brushes.Black;
            mw1.tb35.Foreground = Brushes.Black;
            mw1.tb36.Foreground = Brushes.Black;
            mw1.tb37.Foreground = Brushes.Black;
            mw1.tb38.Foreground = Brushes.Black;
            mw1.tb39.Foreground = Brushes.Black;
            mw1.tb40.Foreground = Brushes.Black;
            mw1.tb41.Foreground = Brushes.Black;
            mw1.tb42.Foreground = Brushes.Black;
            mw1.tb43.Foreground = Brushes.Black;
            mw1.tb44.Foreground = Brushes.Black;
            mw1.tb45.Foreground = Brushes.Black;
            mw1.tb46.Foreground = Brushes.Black;
            mw1.tb47.Foreground = Brushes.Black;
            mw1.tb48.Foreground = Brushes.Black;
            mw1.tb49.Foreground = Brushes.Black;
            mw1.tb50.Foreground = Brushes.Black;
            mw1.tb51.Foreground = Brushes.Black;
            mw1.tb52.Foreground = Brushes.Black;
            mw1.tb53.Foreground = Brushes.Black;
            mw1.tb54.Foreground = Brushes.Black;
            mw1.tb55.Foreground = Brushes.Black;
            mw1.tb56.Foreground = Brushes.Black;
            mw1.tb57.Foreground = Brushes.Black;
            mw1.tb58.Foreground = Brushes.Black;
            mw1.tb59.Foreground = Brushes.Black;
            mw1.tb60.Foreground = Brushes.Black;
            mw1.tb61.Foreground = Brushes.Black;
            mw1.tb62.Foreground = Brushes.Black;
            mw1.tb63.Foreground = Brushes.Black;
            mw1.tb64.Foreground = Brushes.Black;
            mw1.tb65.Foreground = Brushes.Black;
            mw1.tb66.Foreground = Brushes.Black;
            mw1.tb67.Foreground = Brushes.Black;
            mw1.tb68.Foreground = Brushes.Black;
            mw1.tb69.Foreground = Brushes.Black;
            mw1.tb70.Foreground = Brushes.Black;
            mw1.tb71.Foreground = Brushes.Black;
            mw1.tb72.Foreground = Brushes.Black;
            mw1.tb73.Foreground = Brushes.Black;
            mw1.tb74.Foreground = Brushes.Black;
            mw1.tb75.Foreground = Brushes.Black;
            mw1.tb76.Foreground = Brushes.Black;
            mw1.tb77.Foreground = Brushes.Black;
            mw1.tb78.Foreground = Brushes.Black;
            mw1.tb79.Foreground = Brushes.Black;
            mw1.tb80.Foreground = Brushes.Black;
            mw1.tb81.Foreground = Brushes.Black;
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

            for (ushort i = 0; i < value; i++)
            {                
            s = random.Next(0, 81);
                Thread.Sleep(2);
                board[s] = 0;              
            }

            ResetFocus();
            BoardToTextBox();

            if (board[0] == 0)
                mw1.tb1.Clear();
            else
            {
                mw1.tb1.Focusable = false;
                mw1.tb1.Foreground = Brushes.LightGray;
            }
            if (board[1] == 0)
                mw1.tb2.Clear();
            else
            {
                mw1.tb2.Focusable = false;
                mw1.tb2.Foreground = Brushes.LightGray;
            }
            if (board[2] == 0)
                mw1.tb3.Clear();
            else
            {
                mw1.tb3.Focusable = false;
                mw1.tb3.Foreground = Brushes.LightGray;
            }
            if (board[3] == 0)
                mw1.tb4.Clear();
            else
            {
                mw1.tb4.Focusable = false;
                mw1.tb4.Foreground = Brushes.LightGray;
            }
            if (board[4] == 0)
                mw1.tb5.Clear();
            else
            {
                mw1.tb5.Focusable = false;
                mw1.tb5.Foreground = Brushes.LightGray;
            }
            if (board[5] == 0)
                mw1.tb6.Clear();
            else
            {
                mw1.tb6.Focusable = false;
                mw1.tb6.Foreground = Brushes.LightGray;
            }
            if (board[6] == 0)
                mw1.tb7.Clear();
            else
            {
                mw1.tb7.Focusable = false;
                mw1.tb7.Foreground = Brushes.LightGray;
            }
            if (board[7] == 0)
                mw1.tb8.Clear();
            else
            {
                mw1.tb8.Focusable = false;
                mw1.tb8.Foreground = Brushes.LightGray;
            }
            if (board[8] == 0)
                mw1.tb9.Clear();
            else
            {
                mw1.tb9.Focusable = false;
                mw1.tb9.Foreground = Brushes.LightGray;
            }
            if (board[9] == 0)
                mw1.tb10.Clear();
            else
            {
                mw1.tb10.Focusable = false;
                mw1.tb10.Foreground = Brushes.LightGray;
            }
            if (board[10] == 0)
                mw1.tb11.Clear();
            else
            {
                mw1.tb11.Focusable = false;
                mw1.tb11.Foreground = Brushes.LightGray;
            }
            if (board[11] == 0)
                mw1.tb12.Clear();
            else
            {
                mw1.tb12.Focusable = false;
                mw1.tb12.Foreground = Brushes.LightGray;
            }
            if (board[12] == 0)
                mw1.tb13.Clear();
            else
            {
                mw1.tb13.Focusable = false;
                mw1.tb13.Foreground = Brushes.LightGray;
            }
            if (board[13] == 0)
                mw1.tb14.Clear();
            else
            {
                mw1.tb14.Focusable = false;
                mw1.tb14.Foreground = Brushes.LightGray;
            }
            if (board[14] == 0)
                mw1.tb15.Clear();
            else
            {
                mw1.tb15.Focusable = false;
                mw1.tb15.Foreground = Brushes.LightGray;
            }
            if (board[15] == 0)
                mw1.tb16.Clear();
            else
            {
                mw1.tb16.Focusable = false;
                mw1.tb16.Foreground = Brushes.LightGray;
            }
            if (board[16] == 0)
                mw1.tb17.Clear();
            else
            {
                mw1.tb17.Focusable = false;
                mw1.tb17.Foreground = Brushes.LightGray;
            }
            if (board[17] == 0)
                mw1.tb18.Clear();
            else
            {
                mw1.tb18.Focusable = false;
                mw1.tb18.Foreground = Brushes.LightGray;
            }
            if (board[18] == 0)
                mw1.tb19.Clear();
            else
            {
                mw1.tb19.Focusable = false;
                mw1.tb19.Foreground = Brushes.LightGray;
            }
            if (board[19] == 0)
                mw1.tb20.Clear();
            else
            {
                mw1.tb20.Focusable = false;
                mw1.tb20.Foreground = Brushes.LightGray;
            }
            if (board[20] == 0)
                mw1.tb21.Clear();
            else
            {
                mw1.tb21.Focusable = false;
                mw1.tb21.Foreground = Brushes.LightGray;
            }
            if (board[21] == 0)
                mw1.tb22.Clear();
            else
            {
                mw1.tb22.Focusable = false;
                mw1.tb22.Foreground = Brushes.LightGray;
            }
            if (board[22] == 0)
                mw1.tb23.Clear();
            else
            {
                mw1.tb23.Focusable = false;
                mw1.tb23.Foreground = Brushes.LightGray;
            }
            if (board[23] == 0)
                mw1.tb24.Clear();
            else
            {
                mw1.tb24.Focusable = false;
                mw1.tb24.Foreground = Brushes.LightGray;
            }
            if (board[24] == 0)
                mw1.tb25.Clear();
            else
            {
                mw1.tb25.Focusable = false;
                mw1.tb25.Foreground = Brushes.LightGray;
            }
            if (board[25] == 0)
                mw1.tb26.Clear();
            else
            {
                mw1.tb26.Focusable = false;
                mw1.tb26.Foreground = Brushes.LightGray;
            }
            if (board[26] == 0)
                mw1.tb27.Clear();
            else
            {
                mw1.tb27.Focusable = false;
                mw1.tb27.Foreground = Brushes.LightGray;
            }
            if (board[27] == 0)
                mw1.tb28.Clear();
            else
            {
                mw1.tb28.Focusable = false;
                mw1.tb28.Foreground = Brushes.LightGray;
            }
            if (board[28] == 0)
                mw1.tb29.Clear();
            else
            {
                mw1.tb29.Focusable = false;
                mw1.tb29.Foreground = Brushes.LightGray;
            }
            if (board[29] == 0)
                mw1.tb30.Clear();
            else
            {
                mw1.tb30.Focusable = false;
                mw1.tb30.Foreground = Brushes.LightGray;
            }
            if (board[30] == 0)
                mw1.tb31.Clear();
            else
            {
                mw1.tb31.Focusable = false;
                mw1.tb31.Foreground = Brushes.LightGray;
            }
            if (board[31] == 0)
                mw1.tb32.Clear();
            else
            {
                mw1.tb32.Focusable = false;
                mw1.tb32.Foreground = Brushes.LightGray;
            }
            if (board[32] == 0)
                mw1.tb33.Clear();
            else
            {
                mw1.tb33.Focusable = false;
                mw1.tb33.Foreground = Brushes.LightGray;
            }
            if (board[33] == 0)
                mw1.tb34.Clear();
            else
            {
                mw1.tb34.Focusable = false;
                mw1.tb34.Foreground = Brushes.LightGray;
            }
            if (board[34] == 0)
                mw1.tb35.Clear();
            else
            {
                mw1.tb35.Focusable = false;
                mw1.tb35.Foreground = Brushes.LightGray;
            }
            if (board[35] == 0)
                mw1.tb36.Clear();
            else
            {
                mw1.tb36.Focusable = false;
                mw1.tb36.Foreground = Brushes.LightGray;
            }
            if (board[36] == 0)
                mw1.tb37.Clear();
            else
            {
                mw1.tb37.Focusable = false;
                mw1.tb37.Foreground = Brushes.LightGray;
            }
            if (board[37] == 0)
                mw1.tb38.Clear();
            else
            {
                mw1.tb38.Focusable = false;
                mw1.tb38.Foreground = Brushes.LightGray;
            }
            if (board[38] == 0)
                mw1.tb39.Clear();
            else
            {
                mw1.tb39.Focusable = false;
                mw1.tb39.Foreground = Brushes.LightGray;
            }
            if (board[39] == 0)
                mw1.tb40.Clear();
            else
            {
                mw1.tb40.Focusable = false;
                mw1.tb40.Foreground = Brushes.LightGray;
            }
            if (board[40] == 0)
                mw1.tb41.Clear();
            else
            {
                mw1.tb41.Focusable = false;
                mw1.tb41.Foreground = Brushes.LightGray;
            }
            if (board[41] == 0)
                mw1.tb42.Clear();
            else
            {
                mw1.tb42.Focusable = false;
                mw1.tb42.Foreground = Brushes.LightGray;
            }
            if (board[42] == 0)
                mw1.tb43.Clear();
            else
            {
                mw1.tb43.Focusable = false;
                mw1.tb43.Foreground = Brushes.LightGray;
            }
            if (board[43] == 0)
                mw1.tb44.Clear();
            else
            {
                mw1.tb44.Focusable = false;
                mw1.tb44.Foreground = Brushes.LightGray;
            }
            if (board[44] == 0)
                mw1.tb45.Clear();
            else
            {
                mw1.tb45.Focusable = false;
                mw1.tb45.Foreground = Brushes.LightGray;
            }
            if (board[45] == 0)
                mw1.tb46.Clear();
            else
            {
                mw1.tb46.Focusable = false;
                mw1.tb46.Foreground = Brushes.LightGray;
            }
            if (board[46] == 0)
                mw1.tb47.Clear();
            else
            {
                mw1.tb47.Focusable = false;
                mw1.tb47.Foreground = Brushes.LightGray;
            }
            if (board[47] == 0)
                mw1.tb48.Clear();
            else
            {
                mw1.tb48.Focusable = false;
                mw1.tb48.Foreground = Brushes.LightGray;
            }
            if (board[48] == 0)
                mw1.tb49.Clear();
            else
            {
                mw1.tb49.Focusable = false;
                mw1.tb49.Foreground = Brushes.LightGray;
            }
            if (board[49] == 0)
                mw1.tb50.Clear();
            else
            {
                mw1.tb50.Focusable = false;
                mw1.tb50.Foreground = Brushes.LightGray;
            }
            if (board[50] == 0)
                mw1.tb51.Clear();
            else
            {
                mw1.tb51.Focusable = false;
                mw1.tb51.Foreground = Brushes.LightGray;
            }
            if (board[51] == 0)
                mw1.tb52.Clear();
            else
            {
                mw1.tb52.Focusable = false;
                mw1.tb52.Foreground = Brushes.LightGray;
            }
            if (board[52] == 0)
                mw1.tb53.Clear();
            else
            {
                mw1.tb53.Focusable = false;
                mw1.tb53.Foreground = Brushes.LightGray;
            }
            if (board[53] == 0)
                mw1.tb54.Clear();
            else
            {
                mw1.tb54.Focusable = false;
                mw1.tb54.Foreground = Brushes.LightGray;
            }
            if (board[54] == 0)
                mw1.tb55.Clear();
            else
            {
                mw1.tb55.Focusable = false;
                mw1.tb55.Foreground = Brushes.LightGray;
            }
            if (board[55] == 0)
                mw1.tb56.Clear();
            else
            {
                mw1.tb56.Focusable = false;
                mw1.tb56.Foreground = Brushes.LightGray;
            }
            if (board[56] == 0)
                mw1.tb57.Clear();
            else
            {
                mw1.tb57.Focusable = false;
                mw1.tb57.Foreground = Brushes.LightGray;
            }
            if (board[57] == 0)
                mw1.tb58.Clear();
            else
            {
                mw1.tb58.Focusable = false;
                mw1.tb58.Foreground = Brushes.LightGray;
            }
            if (board[58] == 0)
                mw1.tb59.Clear();
            else
            {
                mw1.tb59.Focusable = false;
                mw1.tb59.Foreground = Brushes.LightGray;
            }
            if (board[59] == 0)
                mw1.tb60.Clear();
            else
            {
                mw1.tb60.Focusable = false;
                mw1.tb60.Foreground = Brushes.LightGray;
            }
            if (board[60] == 0)
                mw1.tb61.Clear();
            else
            {
                mw1.tb61.Focusable = false;
                mw1.tb61.Foreground = Brushes.LightGray;
            }
            if (board[61] == 0)
                mw1.tb62.Clear();
            else
            {
                mw1.tb62.Focusable = false;
                mw1.tb62.Foreground = Brushes.LightGray;
            }
            if (board[62] == 0)
                mw1.tb63.Clear();
            else
            {
                mw1.tb63.Focusable = false;
                mw1.tb63.Foreground = Brushes.LightGray;
            }
            if (board[63] == 0)
                mw1.tb64.Clear();
            else
            {
                mw1.tb64.Focusable = false;
                mw1.tb64.Foreground = Brushes.LightGray;
            }
            if (board[64] == 0)
                mw1.tb65.Clear();
            else
            {
                mw1.tb65.Focusable = false;
                mw1.tb65.Foreground = Brushes.LightGray;
            }
            if (board[65] == 0)
                mw1.tb66.Clear();
            else
            {
                mw1.tb66.Focusable = false;
                mw1.tb66.Foreground = Brushes.LightGray;
            }
            if (board[66] == 0)
                mw1.tb67.Clear();
            else
            {
                mw1.tb67.Focusable = false;
                mw1.tb67.Foreground = Brushes.LightGray;
            }
            if (board[67] == 0)
                mw1.tb68.Clear();
            else
            {
                mw1.tb68.Focusable = false;
                mw1.tb68.Foreground = Brushes.LightGray;
            }
            if (board[68] == 0)
                mw1.tb69.Clear();
            else
            {
                mw1.tb69.Focusable = false;
                mw1.tb69.Foreground = Brushes.LightGray;
            }
            if (board[69] == 0)
                mw1.tb70.Clear();
            else
            {
                mw1.tb70.Focusable = false;
                mw1.tb70.Foreground = Brushes.LightGray;
            }
            if (board[70] == 0)
                mw1.tb71.Clear();
            else
            {
                mw1.tb71.Focusable = false;
                mw1.tb71.Foreground = Brushes.LightGray;
            }
            if (board[71] == 0)
                mw1.tb72.Clear();
            else
            {
                mw1.tb72.Focusable = false;
                mw1.tb72.Foreground = Brushes.LightGray;
            }
            if (board[72] == 0)
                mw1.tb73.Clear();
            else
            {
                mw1.tb73.Focusable = false;
                mw1.tb73.Foreground = Brushes.LightGray;
            }
            if (board[73] == 0)
                mw1.tb74.Clear();
            else
            {
                mw1.tb74.Focusable = false;
                mw1.tb74.Foreground = Brushes.LightGray;
            }
            if (board[74] == 0)
                mw1.tb75.Clear();
            else
            {
                mw1.tb75.Focusable = false;
                mw1.tb75.Foreground = Brushes.LightGray;
            }
            if (board[75] == 0)
                mw1.tb76.Clear();
            else
            {
                mw1.tb76.Focusable = false;
                mw1.tb76.Foreground = Brushes.LightGray;
            }
            if (board[76] == 0)
                mw1.tb77.Clear();
            else
            {
                mw1.tb77.Focusable = false;
                mw1.tb77.Foreground = Brushes.LightGray;
            }
            if (board[77] == 0)
                mw1.tb78.Clear();
            else
            {
                mw1.tb78.Focusable = false;
                mw1.tb78.Foreground = Brushes.LightGray;
            }
            if (board[78] == 0)
                mw1.tb79.Clear();
            else
            {
                mw1.tb79.Focusable = false;
                mw1.tb79.Foreground = Brushes.LightGray;
            }
            if (board[79] == 0)
                mw1.tb80.Clear();
            else
            {
                mw1.tb80.Focusable = false;
                mw1.tb80.Foreground = Brushes.LightGray;
            }
            if (board[80] == 0)
                mw1.tb81.Clear();
            else
            {
                mw1.tb81.Focusable = false;
                mw1.tb81.Foreground = Brushes.LightGray;
            }

            ReEnter();            
        }
    }
}
