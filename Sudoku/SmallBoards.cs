using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sudoku
{
    public static class Boards
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

        public static bool[] row1 = new bool[9];
        public static bool[] row2 = new bool[9];
        public static bool[] row3 = new bool[9];
        public static bool[] row4 = new bool[9];
        public static bool[] row5 = new bool[9];
        public static bool[] row6 = new bool[9];
        public static bool[] row7 = new bool[9];
        public static bool[] row8 = new bool[9];
        public static bool[] row9 = new bool[9];

        public static bool[] column1 = new bool[9];
        public static bool[] column2 = new bool[9];
        public static bool[] column3 = new bool[9];
        public static bool[] column4 = new bool[9];
        public static bool[] column5 = new bool[9];
        public static bool[] column6 = new bool[9];
        public static bool[] column7 = new bool[9];
        public static bool[] column8 = new bool[9];
        public static bool[] column9 = new bool[9];

        public static bool[] allBoards = new bool[9];
        
    }
   
    public static class SmallBoards
    {
       static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;

        public static void board1(ushort _value)
        {
            ushort value = _value;

           if (value == 9)
           {
                Boards.board1[8] = true;
           }
           else if (value == 8)
           {
                Boards.board1[7] = true;
            }
           else if (value == 7)
           {
                Boards.board1[6] = true;
            }
           else if (value == 6)
           {
                Boards.board1[5] = true;
            }
           else if (value == 5)
           {
                Boards.board1[4] = true;
            }
           else if (value == 4)
           {
                Boards.board1[3] = true;
            }
           else if (value == 3)
           {
                Boards.board1[2] = true;
            }
           else if (value == 2)
           {
                Boards.board1[1] = true;
            }
           else if (value == 1)
           {
                Boards.board1[0] = true;
            }
           else
           {

           }    
        }
        public static void board1Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board1[8] = false;
            }
            else if (value == 8)
            {
                Boards.board1[7] = false;
            }
            else if (value == 7)
            {
                Boards.board1[6] = false;
            }
            else if (value == 6)
            {
                Boards.board1[5] = false;
            }
            else if (value == 5)
            {
                Boards.board1[4] = false;
            }
            else if (value == 4)
            {
                Boards.board1[3] = false;
            }
            else if (value == 3)
            {
                Boards.board1[2] = false;
            }
            else if (value == 2)
            {
                Boards.board1[1] = false;
            }
            else if (value == 1)
            {
                Boards.board1[0] = false;
            }
            else
            {

            }
        }
        public static void board1Check()
        {
            if (Boards.board1[0] && Boards.board1[1] && Boards.board1[2] && Boards.board1[3] && Boards.board1[4] && Boards.board1[5] && Boards.board1[6] && Boards.board1[7] && Boards.board1[8] == true)
            {
                Boards.allBoards[0] = true;
                mw1.img1.Visibility = Visibility.Visible;
                mw1.imw1.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img1.Visibility = Visibility.Hidden;
                mw1.imw1.Visibility = Visibility.Visible;
            }
        }
        public static void board2(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board2[8] = true;
            }
            else if (value == 8)
            {
                Boards.board2[7] = true;
            }
            else if (value == 7)
            {
                Boards.board2[6] = true;
            }
            else if (value == 6)
            {
                Boards.board2[5] = true;
            }
            else if (value == 5)
            {
                Boards.board2[4] = true;
            }
            else if (value == 4)
            {
                Boards.board2[3] = true;
            }
            else if (value == 3)
            {
                Boards.board2[2] = true;
            }
            else if (value == 2)
            {
                Boards.board2[1] = true;
            }
            else if (value == 1)
            {
                Boards.board2[0] = true;
            }
            else
            {

            }
        }
        public static void board2Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board2[8] = false;
            }
            else if (value == 8)
            {
                Boards.board2[7] = false;
            }
            else if (value == 7)
            {
                Boards.board2[6] = false;
            }
            else if (value == 6)
            {
                Boards.board2[5] = false;
            }
            else if (value == 5)
            {
                Boards.board2[4] = false;
            }
            else if (value == 4)
            {
                Boards.board2[3] = false;
            }
            else if (value == 3)
            {
                Boards.board2[2] = false;
            }
            else if (value == 2)
            {
                Boards.board2[1] = false;
            }
            else if (value == 1)
            {
                Boards.board2[0] = false;
            }
            else
            {

            }
        }
        public static void board2Check()
        {
            if (Boards.board2[0] && Boards.board2[1] && Boards.board2[2] && Boards.board2[3] && Boards.board2[4] && Boards.board2[5] && Boards.board2[6] && Boards.board2[7] && Boards.board2[8] == true)
            {
                Boards.allBoards[1] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board3[8] = true;
            }
            else if (value == 8)
            {
                Boards.board3[7] = true;
            }
            else if (value == 7)
            {
                Boards.board3[6] = true;
            }
            else if (value == 6)
            {
                Boards.board3[5] = true;
            }
            else if (value == 5)
            {
                Boards.board3[4] = true;
            }
            else if (value == 4)
            {
                Boards.board3[3] = true;
            }
            else if (value == 3)
            {
                Boards.board3[2] = true;
            }
            else if (value == 2)
            {
                Boards.board3[1] = true;
            }
            else if (value == 1)
            {
                Boards.board3[0] = true;
            }
            else
            {

            }
        }
        public static void board3Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board3[8] = false;
            }
            else if (value == 8)
            {
                Boards.board3[7] = false;
            }
            else if (value == 7)
            {
                Boards.board3[6] = false;
            }
            else if (value == 6)
            {
                Boards.board3[5] = false;
            }
            else if (value == 5)
            {
                Boards.board3[4] = false;
            }
            else if (value == 4)
            {
                Boards.board3[3] = false;
            }
            else if (value == 3)
            {
                Boards.board3[2] = false;
            }
            else if (value == 2)
            {
                Boards.board3[1] = false;
            }
            else if (value == 1)
            {
                Boards.board3[0] = false;
            }
            else
            {

            }
        }
        public static void board3Check()
        {
            if (Boards.board3[0] && Boards.board3[1] && Boards.board3[2] && Boards.board3[3] && Boards.board3[4] && Boards.board3[5] && Boards.board3[6] && Boards.board3[7] && Boards.board3[8] == true)
            {
                Boards.allBoards[2] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board4[8] = true;
            }
            else if (value == 8)
            {
                Boards.board4[7] = true;
            }
            else if (value == 7)
            {
                Boards.board4[6] = true;
            }
            else if (value == 6)
            {
                Boards.board4[5] = true;
            }
            else if (value == 5)
            {
                Boards.board4[4] = true;
            }
            else if (value == 4)
            {
                Boards.board4[3] = true;
            }
            else if (value == 3)
            {
                Boards.board4[2] = true;
            }
            else if (value == 2)
            {
                Boards.board4[1] = true;
            }
            else if (value == 1)
            {
                Boards.board4[0] = true;
            }
            else
            {

            }
        }
        public static void board4Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board4[8] = false;
            }
            else if (value == 8)
            {
                Boards.board4[7] = false;
            }
            else if (value == 7)
            {
                Boards.board4[6] = false;
            }
            else if (value == 6)
            {
                Boards.board4[5] = false;
            }
            else if (value == 5)
            {
                Boards.board4[4] = false;
            }
            else if (value == 4)
            {
                Boards.board4[3] = false;
            }
            else if (value == 3)
            {
                Boards.board4[2] = false;
            }
            else if (value == 2)
            {
                Boards.board4[1] = false;
            }
            else if (value == 1)
            {
                Boards.board4[0] = false;
            }
            else
            {

            }
        }
        public static void board4Check()
        {
            if (Boards.board4[0] && Boards.board4[1] && Boards.board4[2] && Boards.board4[3] && Boards.board4[4] && Boards.board4[5] && Boards.board4[6] && Boards.board4[7] && Boards.board4[8] == true)
            {
                Boards.allBoards[3] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board5[8] = true;
            }
            else if (value == 8)
            {
                Boards.board5[7] = true;
            }
            else if (value == 7)
            {
                Boards.board5[6] = true;
            }
            else if (value == 6)
            {
                Boards.board5[5] = true;
            }
            else if (value == 5)
            {
                Boards.board5[4] = true;
            }
            else if (value == 4)
            {
                Boards.board5[3] = true;
            }
            else if (value == 3)
            {
                Boards.board5[2] = true;
            }
            else if (value == 2)
            {
                Boards.board5[1] = true;
            }
            else if (value == 1)
            {
                Boards.board5[0] = true;
            }
            else
            {

            }
        }
        public static void board5Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board5[8] = false;
            }
            else if (value == 8)
            {
                Boards.board5[7] = false;
            }
            else if (value == 7)
            {
                Boards.board5[6] = false;
            }
            else if (value == 6)
            {
                Boards.board5[5] = false;
            }
            else if (value == 5)
            {
                Boards.board5[4] = false;
            }
            else if (value == 4)
            {
                Boards.board5[3] = false;
            }
            else if (value == 3)
            {
                Boards.board5[2] = false;
            }
            else if (value == 2)
            {
                Boards.board5[1] = false;
            }
            else if (value == 1)
            {
                Boards.board5[0] = false;
            }
            else
            {

            }
        }
        public static void board5Check()
        {
            if (Boards.board5[0] && Boards.board5[1] && Boards.board5[2] && Boards.board5[3] && Boards.board5[4] && Boards.board5[5] && Boards.board5[6] && Boards.board5[7] && Boards.board5[8] == true)
            {
                Boards.allBoards[4] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board6[8] = true;
            }
            else if (value == 8)
            {
                Boards.board6[7] = true;
            }
            else if (value == 7)
            {
                Boards.board6[6] = true;
            }
            else if (value == 6)
            {
                Boards.board6[5] = true;
            }
            else if (value == 5)
            {
                Boards.board6[4] = true;
            }
            else if (value == 4)
            {
                Boards.board6[3] = true;
            }
            else if (value == 3)
            {
                Boards.board6[2] = true;
            }
            else if (value == 2)
            {
                Boards.board6[1] = true;
            }
            else if (value == 1)
            {
                Boards.board6[0] = true;
            }
            else
            {

            }
        }
        public static void board6Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board6[8] = false;
            }
            else if (value == 8)
            {
                Boards.board6[7] = false;
            }
            else if (value == 7)
            {
                Boards.board6[6] = false;
            }
            else if (value == 6)
            {
                Boards.board6[5] = false;
            }
            else if (value == 5)
            {
                Boards.board6[4] = false;
            }
            else if (value == 4)
            {
                Boards.board6[3] = false;
            }
            else if (value == 3)
            {
                Boards.board6[2] = false;
            }
            else if (value == 2)
            {
                Boards.board6[1] = false;
            }
            else if (value == 1)
            {
                Boards.board6[0] = false;
            }
            else
            {

            }
        }
        public static void board6Check()
        {
            if (Boards.board6[0] && Boards.board6[1] && Boards.board6[2] && Boards.board6[3] && Boards.board6[4] && Boards.board6[5] && Boards.board6[6] && Boards.board6[7] && Boards.board6[8] == true)
            {
                Boards.allBoards[5] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board7[8] = true;
            }
            else if (value == 8)
            {
                Boards.board7[7] = true;
            }
            else if (value == 7)
            {
                Boards.board7[6] = true;
            }
            else if (value == 6)
            {
                Boards.board7[5] = true;
            }
            else if (value == 5)
            {
                Boards.board7[4] = true;
            }
            else if (value == 4)
            {
                Boards.board7[3] = true;
            }
            else if (value == 3)
            {
                Boards.board7[2] = true;
            }
            else if (value == 2)
            {
                Boards.board7[1] = true;
            }
            else if (value == 1)
            {
                Boards.board7[0] = true;
            }
            else
            {

            }
        }
        public static void board7Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board7[8] = false;
            }
            else if (value == 8)
            {
                Boards.board7[7] = false;
            }
            else if (value == 7)
            {
                Boards.board7[6] = false;
            }
            else if (value == 6)
            {
                Boards.board7[5] = false;
            }
            else if (value == 5)
            {
                Boards.board7[4] = false;
            }
            else if (value == 4)
            {
                Boards.board7[3] = false;
            }
            else if (value == 3)
            {
                Boards.board7[2] = false;
            }
            else if (value == 2)
            {
                Boards.board7[1] = false;
            }
            else if (value == 1)
            {
                Boards.board7[0] = false;
            }
            else
            {

            }
        }
        public static void board7Check()
        {
            if (Boards.board7[0] && Boards.board7[1] && Boards.board7[2] && Boards.board7[3] && Boards.board7[4] && Boards.board7[5] && Boards.board7[6] && Boards.board7[7] && Boards.board7[8] == true)
            {
                Boards.allBoards[6] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board8[8] = true;
            }
            else if (value == 8)
            {
                Boards.board8[7] = true;
            }
            else if (value == 7)
            {
                Boards.board8[6] = true;
            }
            else if (value == 6)
            {
                Boards.board8[5] = true;
            }
            else if (value == 5)
            {
                Boards.board8[4] = true;
            }
            else if (value == 4)
            {
                Boards.board8[3] = true;
            }
            else if (value == 3)
            {
                Boards.board8[2] = true;
            }
            else if (value == 2)
            {
                Boards.board8[1] = true;
            }
            else if (value == 1)
            {
                Boards.board8[0] = true;
            }
            else
            {

            }
        }
        public static void board8Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board8[8] = false;
            }
            else if (value == 8)
            {
                Boards.board8[7] = false;
            }
            else if (value == 7)
            {
                Boards.board8[6] = false;
            }
            else if (value == 6)
            {
                Boards.board8[5] = false;
            }
            else if (value == 5)
            {
                Boards.board8[4] = false;
            }
            else if (value == 4)
            {
                Boards.board8[3] = false;
            }
            else if (value == 3)
            {
                Boards.board8[2] = false;
            }
            else if (value == 2)
            {
                Boards.board8[1] = false;
            }
            else if (value == 1)
            {
                Boards.board8[0] = false;
            }
            else
            {

            }
        }
        public static void board8Check()
        {
            if (Boards.board8[0] && Boards.board8[1] && Boards.board8[2] && Boards.board8[3] && Boards.board8[4] && Boards.board8[5] && Boards.board8[6] && Boards.board8[7] && Boards.board8[8] == true)
            {
                Boards.allBoards[7] = true;
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
            ushort value = _value;

            if (value == 9)
            {
                Boards.board9[8] = true;
            }
            else if (value == 8)
            {
                Boards.board9[7] = true;
            }
            else if (value == 7)
            {
                Boards.board9[6] = true;
            }
            else if (value == 6)
            {
                Boards.board9[5] = true;
            }
            else if (value == 5)
            {
                Boards.board9[4] = true;
            }
            else if (value == 4)
            {
                Boards.board9[3] = true;
            }
            else if (value == 3)
            {
                Boards.board9[2] = true;
            }
            else if (value == 2)
            {
                Boards.board9[1] = true;
            }
            else if (value == 1)
            {
                Boards.board9[0] = true;
            }
            else
            {

            }
        }
        public static void board9Clear(ushort _value)
        {
            ushort value = _value;

            if (value == 9)
            {
                Boards.board9[8] = false;
            }
            else if (value == 8)
            {
                Boards.board9[7] = false;
            }
            else if (value == 7)
            {
                Boards.board9[6] = false;
            }
            else if (value == 6)
            {
                Boards.board9[5] = false;
            }
            else if (value == 5)
            {
                Boards.board9[4] = false;
            }
            else if (value == 4)
            {
                Boards.board9[3] = false;
            }
            else if (value == 3)
            {
                Boards.board9[2] = false;
            }
            else if (value == 2)
            {
                Boards.board9[1] = false;
            }
            else if (value == 1)
            {
                Boards.board9[0] = false;
            }
            else
            {

            }
        }
        public static void board9Check()
        {
            if (Boards.board9[0] && Boards.board9[1] && Boards.board9[2] && Boards.board9[3] && Boards.board9[4] && Boards.board9[5] && Boards.board9[6] && Boards.board9[7] && Boards.board9[8] == true)
            {
                Boards.allBoards[8] = true;
                mw1.img9.Visibility = Visibility.Visible;
                mw1.imw9.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img9.Visibility = Visibility.Hidden;
                mw1.imw9.Visibility = Visibility.Visible;
            }
        }
    }
}
