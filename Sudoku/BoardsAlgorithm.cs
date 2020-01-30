using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Sudoku
{
    public static class BoardsArrays
    { 
        public static bool[] board1 = new bool[9];
        public static bool[] board2 = new bool[9];
        public static bool[] board3 = new bool[9];
        public static bool[] board4 = new bool[9];
        public static bool[] board5 = new bool[9];
        public static bool[] board6 = new bool[9];
        public static bool[] board7 = new bool[9];
        public static bool[] board8 = new bool[9];
        public static bool[] board9 = new bool[9];

        public static bool[] allBoards = new bool[9];
    }
   
    public static class BoardsAlgorithm
    {
       static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;

        private static void boardClear(ushort value)
        {
            switch (value)
            {
                case 1:
                    Array.Clear(BoardsArrays.board1, 0, 9);
                    break;                             
                case 2:                                
                    Array.Clear(BoardsArrays.board2, 0, 9);
                    break;                              
                case 3:                                 
                    Array.Clear(BoardsArrays.board3, 0, 9);
                    break;                              
                case 4:                                 
                    Array.Clear(BoardsArrays.board4, 0, 9);
                    break;                              
                case 5:                                 
                    Array.Clear(BoardsArrays.board5, 0, 9);
                    break;                              
                case 6:                                 
                    Array.Clear(BoardsArrays.board6, 0, 9);
                    break;                             
                case 7:                                
                    Array.Clear(BoardsArrays.board7, 0, 9);
                    break;                             
                case 8:                                
                    Array.Clear(BoardsArrays.board8, 0, 9);
                    break;                              
                case 9:                                 
                    Array.Clear(BoardsArrays.board9, 0, 9);
                    break;
            }
        }
        
        public static void board1()
        {
            boardClear(1);

            ushort o;
            UInt16.TryParse(mw1.tb1.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb2.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb3.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb10.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb11.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb12.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb19.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb20.Text, out o);
            board1ToArray(o);
            UInt16.TryParse(mw1.tb21.Text, out o);
            board1ToArray(o);

            board1Check();
        }
        private static void board1ToArray(ushort value)
        {            
            if (value > 0)
                  BoardsArrays.board1[value - 1] = true;
        }
        public static void board2()
        {
            boardClear(2);

            ushort o;
            UInt16.TryParse(mw1.tb4.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb5.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb6.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb13.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb14.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb15.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb22.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb23.Text, out o);
            board2ToArray(o);
            UInt16.TryParse(mw1.tb24.Text, out o);
            board2ToArray(o);

            board2Check();
        }
        private static void board2ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board2[value - 1] = true;
        }
        public static void board3()
        {
            boardClear(3);

            ushort o;
            UInt16.TryParse(mw1.tb7.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb8.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb9.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb16.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb17.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb18.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb25.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb26.Text, out o);
            board3ToArray(o);
            UInt16.TryParse(mw1.tb27.Text, out o);
            board3ToArray(o);

            board3Check();
        }
        private static void board3ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board3[value - 1] = true;
        }
        public static void board4()
        {
            boardClear(4);

            ushort o;
            UInt16.TryParse(mw1.tb28.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb29.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb30.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb37.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb38.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb39.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb46.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb47.Text, out o);
            board4ToArray(o);
            UInt16.TryParse(mw1.tb48.Text, out o);
            board4ToArray(o);

            board4Check();
        }
        private static void board4ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board4[value - 1] = true;
        }
        public static void board5()
        {
            boardClear(5);

            ushort o;
            UInt16.TryParse(mw1.tb31.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb32.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb33.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb40.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb41.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb42.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb49.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb50.Text, out o);
            board5ToArray(o);
            UInt16.TryParse(mw1.tb51.Text, out o);
            board5ToArray(o);

            board5Check();
        }
        private static void board5ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board5[value - 1] = true;
        }
        public static void board6()
        {
            boardClear(6);

            ushort o;
            UInt16.TryParse(mw1.tb34.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb35.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb36.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb43.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb44.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb45.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb52.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb53.Text, out o);
            board6ToArray(o);
            UInt16.TryParse(mw1.tb54.Text, out o);
            board6ToArray(o);

            board6Check();
        }
        private static void board6ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board6[value - 1] = true;
        }
        public static void board7()
        {
            boardClear(7);

            ushort o;
            UInt16.TryParse(mw1.tb55.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb56.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb57.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb64.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb65.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb66.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb73.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb74.Text, out o);
            board7ToArray(o);
            UInt16.TryParse(mw1.tb75.Text, out o);
            board7ToArray(o);

            board7Check();
        }
        private static void board7ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board7[value - 1] = true;
        }
        public static void board8()
        {
            boardClear(8);

            ushort o;
            UInt16.TryParse(mw1.tb58.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb59.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb60.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb67.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb68.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb69.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb76.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb77.Text, out o);
            board8ToArray(o);
            UInt16.TryParse(mw1.tb78.Text, out o);
            board8ToArray(o);

            board8Check();
        }
        private static void board8ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board8[value - 1] = true;
        }
        public static void board9()
        {
            boardClear(9);

            ushort o;
            UInt16.TryParse(mw1.tb61.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb62.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb63.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb70.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb71.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb72.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb79.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb80.Text, out o);
            board9ToArray(o);
            UInt16.TryParse(mw1.tb81.Text, out o);
            board9ToArray(o);

            board9Check();
        }
        private static void board9ToArray(ushort value)
        {
            if (value > 0)
                BoardsArrays.board9[value - 1] = true;
        }

        private static void board1Check()
        {
            if (BoardsArrays.board1[0] && BoardsArrays.board1[1] && BoardsArrays.board1[2] && BoardsArrays.board1[3] && BoardsArrays.board1[4] && BoardsArrays.board1[5] && BoardsArrays.board1[6] && BoardsArrays.board1[7] && BoardsArrays.board1[8] == true)
            {
                mw1.img1.Visibility = Visibility.Visible;
                mw1.imw1.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[0] = true;
                WinCheck();

            }
            else
            {
                mw1.img1.Visibility = Visibility.Hidden;
                mw1.imw1.Visibility = Visibility.Visible;                
                BoardsArrays.allBoards[0] = false;
            }
        }
        
        private static void board2Check()
        {
            if (BoardsArrays.board2[0] && BoardsArrays.board2[1] && BoardsArrays.board2[2] && BoardsArrays.board2[3] && BoardsArrays.board2[4] && BoardsArrays.board2[5] && BoardsArrays.board2[6] && BoardsArrays.board2[7] && BoardsArrays.board2[8] == true)
            {                
                mw1.img2.Visibility = Visibility.Visible;
                mw1.imw2.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[1] = true;
                WinCheck();

            }
            else
            {
                mw1.img2.Visibility = Visibility.Hidden;
                mw1.imw2.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[1] = false;
            }
        }
    
        private static void board3Check()
        {
            if (BoardsArrays.board3[0] && BoardsArrays.board3[1] && BoardsArrays.board3[2] && BoardsArrays.board3[3] && BoardsArrays.board3[4] && BoardsArrays.board3[5] && BoardsArrays.board3[6] && BoardsArrays.board3[7] && BoardsArrays.board3[8] == true)
            {                
                mw1.img3.Visibility = Visibility.Visible;
                mw1.imw3.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[2] = true;
                WinCheck();

            }
            else
            {
                mw1.img3.Visibility = Visibility.Hidden;
                mw1.imw3.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[2] = false;
            }
        }
        
        public static void board4Check()
        {
            if (BoardsArrays.board4[0] && BoardsArrays.board4[1] && BoardsArrays.board4[2] && BoardsArrays.board4[3] && BoardsArrays.board4[4] && BoardsArrays.board4[5] && BoardsArrays.board4[6] && BoardsArrays.board4[7] && BoardsArrays.board4[8] == true)
            {                
                mw1.img4.Visibility = Visibility.Visible;
                mw1.imw4.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[3] = true;
                WinCheck();

            }
            else
            {
                mw1.img4.Visibility = Visibility.Hidden;
                mw1.imw4.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[3] = false;
            }
        }
        
        public static void board5Check()
        {
            if (BoardsArrays.board5[0] && BoardsArrays.board5[1] && BoardsArrays.board5[2] && BoardsArrays.board5[3] && BoardsArrays.board5[4] && BoardsArrays.board5[5] && BoardsArrays.board5[6] && BoardsArrays.board5[7] && BoardsArrays.board5[8] == true)
            {
                mw1.img5.Visibility = Visibility.Visible;
                mw1.imw5.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[4] = true;
                WinCheck();

            }
            else
            {
                mw1.img5.Visibility = Visibility.Hidden;
                mw1.imw5.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[4] = false;
            }
        }
        
        public static void board6Check()
        {
            if (BoardsArrays.board6[0] && BoardsArrays.board6[1] && BoardsArrays.board6[2] && BoardsArrays.board6[3] && BoardsArrays.board6[4] && BoardsArrays.board6[5] && BoardsArrays.board6[6] && BoardsArrays.board6[7] && BoardsArrays.board6[8] == true)
            {
                mw1.img6.Visibility = Visibility.Visible;
                mw1.imw6.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[5] = true;
                WinCheck();

            }
            else
            {
                mw1.img6.Visibility = Visibility.Hidden;
                mw1.imw6.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[5] = false;
            }
        }
       
        public static void board7Check()
        {
            if (BoardsArrays.board7[0] && BoardsArrays.board7[1] && BoardsArrays.board7[2] && BoardsArrays.board7[3] && BoardsArrays.board7[4] && BoardsArrays.board7[5] && BoardsArrays.board7[6] && BoardsArrays.board7[7] && BoardsArrays.board7[8] == true)
            {
                mw1.img7.Visibility = Visibility.Visible;
                mw1.imw7.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[6] = true;
                WinCheck();

            }
            else
            {
                mw1.img7.Visibility = Visibility.Hidden;
                mw1.imw7.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[6] = false;
            }
        }
       
        public static void board8Check()
        {
            if (BoardsArrays.board8[0] && BoardsArrays.board8[1] && BoardsArrays.board8[2] && BoardsArrays.board8[3] && BoardsArrays.board8[4] && BoardsArrays.board8[5] && BoardsArrays.board8[6] && BoardsArrays.board8[7] && BoardsArrays.board8[8] == true)
            {
                mw1.img8.Visibility = Visibility.Visible;
                mw1.imw8.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[7] = true;
                WinCheck();
            }
            else
            {
                mw1.imw8.Visibility = Visibility.Visible;
                mw1.img8.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[7] = false;
            }
        }
        
        public static void board9Check()
        {
            if (BoardsArrays.board9[0] && BoardsArrays.board9[1] && BoardsArrays.board9[2] && BoardsArrays.board9[3] && BoardsArrays.board9[4] && BoardsArrays.board9[5] && BoardsArrays.board9[6] && BoardsArrays.board9[7] && BoardsArrays.board9[8] == true)
            {
                mw1.img9.Visibility = Visibility.Visible;
                mw1.imw9.Visibility = Visibility.Hidden;
                BoardsArrays.allBoards[8] = true;
                WinCheck();
            }
            else
            {
                mw1.img9.Visibility = Visibility.Hidden;
                mw1.imw9.Visibility = Visibility.Visible;
                BoardsArrays.allBoards[8] = false;
            }
        }   
        public static void WinCheck()
        {
            if(BoardsArrays.allBoards[0] && BoardsArrays.allBoards[1] && BoardsArrays.allBoards[2] && BoardsArrays.allBoards[3] && BoardsArrays.allBoards[4] && BoardsArrays.allBoards[5] && BoardsArrays.allBoards[6] && BoardsArrays.allBoards[7] && BoardsArrays.allBoards[8] == true && RowsArrays.allRows[0] && RowsArrays.allRows[1] && RowsArrays.allRows[2] && RowsArrays.allRows[3] && RowsArrays.allRows[4] && RowsArrays.allRows[5] && RowsArrays.allRows[6] && RowsArrays.allRows[7] && RowsArrays.allRows[8] == true && ColumnsArrays.allColumns[0] && ColumnsArrays.allColumns[1] && ColumnsArrays.allColumns[2] && ColumnsArrays.allColumns[3] && ColumnsArrays.allColumns[4] && ColumnsArrays.allColumns[5] && ColumnsArrays.allColumns[6] && ColumnsArrays.allColumns[7] && ColumnsArrays.allColumns[8] == true)
            {
                Generator.doneNew = true;
                MessageBox.Show("Wygrałeś");
            }
        }
    }
}
