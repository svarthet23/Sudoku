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
        public static ushort[] oldvalue = new ushort[9];
    }
   
    public static class BoardsAlgorithm
    {
       static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;

        public static ushort oldvalue;
        private static ushort value;

        public static void board1Initialize()
        {
            ushort o = 0;
            UInt16.TryParse(mw1.tb1.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb2.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb3.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb10.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb11.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb12.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb19.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb20.Text, out o);
            board1(o);
            UInt16.TryParse(mw1.tb21.Text, out o);
            board1(o);
        }
        public static void board1InitializeClear()
        {
            ushort o = 0;
            UInt16.TryParse(mw1.tb1.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb2.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb3.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb10.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb11.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb12.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb19.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb20.Text, out o);
            board1Clear(o);
            UInt16.TryParse(mw1.tb21.Text, out o);
            board1Clear(o);
            for(ushort i = 1; i < 9; i++)
            {
                board1Clear(i);
            }


        }

        public static void board1(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

           if (value == 9)
           {
                BoardsArrays.board1[8] = true;

            }
           else if (value == 8)
           {
                BoardsArrays.board1[7] = true;

            }
           else if (value == 7)
           {
                BoardsArrays.board1[6] = true;

            }
           else if (value == 6)
           {
                BoardsArrays.board1[5] = true;

            }
           else if (value == 5)
           {
                BoardsArrays.board1[4] = true;

            }
           else if (value == 4)
           {
                BoardsArrays.board1[3] = true;

            }
           else if (value == 3)
           {
                BoardsArrays.board1[2] = true;

            }
           else if (value == 2)
           {
                BoardsArrays.board1[1] = true;                
            }
           else if (value == 1)
           {
                BoardsArrays.board1[0] = true;
            }
           else
           {
                mw1.img1.Visibility = Visibility.Hidden;
                mw1.imw1.Visibility = Visibility.Visible;
            }           
            
        }
                
        public static void board1Clear(ushort _value)
        {                       
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board1[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board1[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board1[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board1[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board1[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board1[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board1[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board1[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board1[0] = false;
            }
            else
            {
                mw1.img1.Visibility = Visibility.Hidden;
                mw1.imw1.Visibility = Visibility.Visible;
            }
        }
        public static void board1Check()
        {
            if (BoardsArrays.board1[0] && BoardsArrays.board1[1] && BoardsArrays.board1[2] && BoardsArrays.board1[3] && BoardsArrays.board1[4] && BoardsArrays.board1[5] && BoardsArrays.board1[6] && BoardsArrays.board1[7] && BoardsArrays.board1[8] == true)
            {
                BoardsArrays.allBoards[0] = true;
                mw1.img1.Visibility = Visibility.Visible;
                mw1.imw1.Visibility = Visibility.Hidden;
            }
            else
            {
                BoardsArrays.allBoards[0] = false;
                mw1.img1.Visibility = Visibility.Hidden;
                mw1.imw1.Visibility = Visibility.Visible;                
            }
        }
        public static void board2(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board2[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board2[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board2[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board2[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board2[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board2[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board2[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board2[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board2[0] = true;
            }
            else
            {

            }
        }
        

        public static void board2Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board2[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board2[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board2[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board2[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board2[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board2[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board2[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board2[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board2[0] = false;
            }
            else
            {

            }
        }
        public static void board2Check()
        {
            if (BoardsArrays.board2[0] && BoardsArrays.board2[1] && BoardsArrays.board2[2] && BoardsArrays.board2[3] && BoardsArrays.board2[4] && BoardsArrays.board2[5] && BoardsArrays.board2[6] && BoardsArrays.board2[7] && BoardsArrays.board2[8] == true)
            {
                BoardsArrays.allBoards[1] = true;
                mw1.img2.Visibility = Visibility.Visible;
                mw1.imw2.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img2.Visibility = Visibility.Hidden;
                mw1.imw2.Visibility = Visibility.Visible;
            }
        }
        public static void board3(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board3[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board3[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board3[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board3[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board3[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board3[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board3[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board3[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board3[0] = true;
            }
            else
            {

            }
        }
        public static void board3Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board3[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board3[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board3[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board3[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board3[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board3[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board3[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board3[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board3[0] = false;
            }
            else
            {

            }
        }
        public static void board3Check()
        {
            if (BoardsArrays.board3[0] && BoardsArrays.board3[1] && BoardsArrays.board3[2] && BoardsArrays.board3[3] && BoardsArrays.board3[4] && BoardsArrays.board3[5] && BoardsArrays.board3[6] && BoardsArrays.board3[7] && BoardsArrays.board3[8] == true)
            {
                BoardsArrays.allBoards[2] = true;
                mw1.img3.Visibility = Visibility.Visible;
                mw1.imw3.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img3.Visibility = Visibility.Hidden;
                mw1.imw3.Visibility = Visibility.Visible;
            }
        }
        public static void board4(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board4[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board4[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board4[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board4[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board4[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board4[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board4[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board4[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board4[0] = true;
            }
            else
            {

            }
        }
        public static void board4Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board4[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board4[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board4[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board4[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board4[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board4[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board4[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board4[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board4[0] = false;
            }
            else
            {

            }
        }
        public static void board4Check()
        {
            if (BoardsArrays.board4[0] && BoardsArrays.board4[1] && BoardsArrays.board4[2] && BoardsArrays.board4[3] && BoardsArrays.board4[4] && BoardsArrays.board4[5] && BoardsArrays.board4[6] && BoardsArrays.board4[7] && BoardsArrays.board4[8] == true)
            {
                BoardsArrays.allBoards[3] = true;
                mw1.img4.Visibility = Visibility.Visible;
                mw1.imw4.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img4.Visibility = Visibility.Hidden;
                mw1.imw4.Visibility = Visibility.Visible;
            }
        }
        public static void board5(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board5[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board5[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board5[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board5[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board5[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board5[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board5[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board5[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board5[0] = true;
            }
            else
            {

            }
        }
        public static void board5Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board5[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board5[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board5[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board5[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board5[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board5[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board5[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board5[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board5[0] = false;
            }
            else
            {

            }
        }
        public static void board5Check()
        {
            if (BoardsArrays.board5[0] && BoardsArrays.board5[1] && BoardsArrays.board5[2] && BoardsArrays.board5[3] && BoardsArrays.board5[4] && BoardsArrays.board5[5] && BoardsArrays.board5[6] && BoardsArrays.board5[7] && BoardsArrays.board5[8] == true)
            {
                BoardsArrays.allBoards[4] = true;
                mw1.img5.Visibility = Visibility.Visible;
                mw1.imw5.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img5.Visibility = Visibility.Hidden;
                mw1.imw5.Visibility = Visibility.Visible;
            }
        }
        public static void board6(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board6[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board6[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board6[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board6[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board6[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board6[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board6[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board6[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board6[0] = true;
            }
            else
            {

            }
        }
        public static void board6Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board6[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board6[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board6[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board6[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board6[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board6[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board6[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board6[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board6[0] = false;
            }
            else
            {

            }
        }
        public static void board6Check()
        {
            if (BoardsArrays.board6[0] && BoardsArrays.board6[1] && BoardsArrays.board6[2] && BoardsArrays.board6[3] && BoardsArrays.board6[4] && BoardsArrays.board6[5] && BoardsArrays.board6[6] && BoardsArrays.board6[7] && BoardsArrays.board6[8] == true)
            {
                BoardsArrays.allBoards[5] = true;
                mw1.img6.Visibility = Visibility.Visible;
                mw1.imw6.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img6.Visibility = Visibility.Hidden;
                mw1.imw6.Visibility = Visibility.Visible;
            }
        }
        public static void board7(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board7[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board7[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board7[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board7[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board7[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board7[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board7[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board7[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board7[0] = true;
            }
            else
            {

            }
        }
        public static void board7Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board7[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board7[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board7[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board7[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board7[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board7[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board7[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board7[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board7[0] = false;
            }
            else
            {

            }
        }
        public static void board7Check()
        {
            if (BoardsArrays.board7[0] && BoardsArrays.board7[1] && BoardsArrays.board7[2] && BoardsArrays.board7[3] && BoardsArrays.board7[4] && BoardsArrays.board7[5] && BoardsArrays.board7[6] && BoardsArrays.board7[7] && BoardsArrays.board7[8] == true)
            {
                BoardsArrays.allBoards[6] = true;
                mw1.img7.Visibility = Visibility.Visible;
                mw1.imw7.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img7.Visibility = Visibility.Hidden;
                mw1.imw7.Visibility = Visibility.Visible;
            }
        }
        public static void board8(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board8[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board8[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board8[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board8[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board8[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board8[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board8[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board8[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board8[0] = true;
            }
            else
            {

            }
        }
        public static void board8Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board8[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board8[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board8[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board8[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board8[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board8[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board8[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board8[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board8[0] = false;
            }
            else
            {

            }
        }
        public static void board8Check()
        {
            if (BoardsArrays.board8[0] && BoardsArrays.board8[1] && BoardsArrays.board8[2] && BoardsArrays.board8[3] && BoardsArrays.board8[4] && BoardsArrays.board8[5] && BoardsArrays.board8[6] && BoardsArrays.board8[7] && BoardsArrays.board8[8] == true)
            {
                BoardsArrays.allBoards[7] = true;
                mw1.img8.Visibility = Visibility.Visible;
                mw1.imw8.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.imw8.Visibility = Visibility.Visible;
                mw1.img8.Visibility = Visibility.Hidden;
            }
        }
        public static void board9(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board9[8] = true;
            }
            else if (value == 8)
            {
                BoardsArrays.board9[7] = true;
            }
            else if (value == 7)
            {
                BoardsArrays.board9[6] = true;
            }
            else if (value == 6)
            {
                BoardsArrays.board9[5] = true;
            }
            else if (value == 5)
            {
                BoardsArrays.board9[4] = true;
            }
            else if (value == 4)
            {
                BoardsArrays.board9[3] = true;
            }
            else if (value == 3)
            {
                BoardsArrays.board9[2] = true;
            }
            else if (value == 2)
            {
                BoardsArrays.board9[1] = true;
            }
            else if (value == 1)
            {
                BoardsArrays.board9[0] = true;
            }
            else
            {

            }
        }
        public static void board9Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                BoardsArrays.board9[8] = false;
            }
            else if (value == 8)
            {
                BoardsArrays.board9[7] = false;
            }
            else if (value == 7)
            {
                BoardsArrays.board9[6] = false;
            }
            else if (value == 6)
            {
                BoardsArrays.board9[5] = false;
            }
            else if (value == 5)
            {
                BoardsArrays.board9[4] = false;
            }
            else if (value == 4)
            {
                BoardsArrays.board9[3] = false;
            }
            else if (value == 3)
            {
                BoardsArrays.board9[2] = false;
            }
            else if (value == 2)
            {
                BoardsArrays.board9[1] = false;
            }
            else if (value == 1)
            {
                BoardsArrays.board9[0] = false;
            }
            else
            {

            }
        }
        public static void board9Check()
        {
            if (BoardsArrays.board9[0] && BoardsArrays.board9[1] && BoardsArrays.board9[2] && BoardsArrays.board9[3] && BoardsArrays.board9[4] && BoardsArrays.board9[5] && BoardsArrays.board9[6] && BoardsArrays.board9[7] && BoardsArrays.board9[8] == true)
            {
                BoardsArrays.allBoards[8] = true;
                mw1.img9.Visibility = Visibility.Visible;
                mw1.imw9.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img9.Visibility = Visibility.Hidden;
                mw1.imw9.Visibility = Visibility.Visible;
            }
        }

        public static void board1Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board1[oldvalue - 1] = false;
            }

        }
        public static void board2Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board2[oldvalue - 1] = false;
            }
        }
        public static void board3Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board3[oldvalue - 1] = false;
            }
        }
        public static void board4Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board4[oldvalue - 1] = false;
            }
        }
        public static void board5Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board5[oldvalue - 1] = false;
            }
        }
        public static void board6Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board6[oldvalue - 1] = false;
            }
        }
        public static void board7Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board7[oldvalue - 1] = false;
            }
        }
        public static void board8Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board8[oldvalue - 1] = false;
            }
        }
        public static void board9Clear()
        {
            if (oldvalue > 0)
            {
                BoardsArrays.board9[oldvalue - 1] = false;
            }
        }
    }
}
