using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sudoku
{
    public static class RowsArrays
    {
        public static bool[] row1 = new bool[9];
        public static bool[] row2 = new bool[9];
        public static bool[] row3 = new bool[9];
        public static bool[] row4 = new bool[9];
        public static bool[] row5 = new bool[9];
        public static bool[] row6 = new bool[9];
        public static bool[] row7 = new bool[9];
        public static bool[] row8 = new bool[9];
        public static bool[] row9 = new bool[9];
    }
    public static class RowsAlgorithm
    {
        static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;

        private static ushort oldvalue;
        private static ushort value;

        public static void row1(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row1[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row1[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row1[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row1[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row1[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row1[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row1[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row1[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row1[0] = true;
            }
            else
            {

            }
        }
        public static void row1Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row1[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row1[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row1[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row1[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row1[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row1[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row1[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row1[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row1[0] = false;
            }
            else
            {

            }
        }
        public static void row1Check()
        {
            if (RowsArrays.row1[0] && RowsArrays.row1[1] && RowsArrays.row1[2] && RowsArrays.row1[3] && RowsArrays.row1[4] && RowsArrays.row1[5] && RowsArrays.row1[6] && RowsArrays.row1[7] && RowsArrays.row1[8] == true)
            {
                mw1.cbr.IsChecked = true;
            }
            else
            {
                mw1.cbr.IsChecked = false;
            }
        }
        public static void row2(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row2[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row2[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row2[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row2[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row2[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row2[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row2[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row2[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row2[0] = true;
            }
            else
            {

            }
        }
        public static void row2Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row2[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row2[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row2[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row2[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row2[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row2[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row2[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row2[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row2[0] = false;
            }
            else
            {

            }
        }
        public static void row2Check()
        {
            if (RowsArrays.row2[0] && RowsArrays.row2[1] && RowsArrays.row2[2] && RowsArrays.row2[3] && RowsArrays.row2[4] && RowsArrays.row2[5] && RowsArrays.row2[6] && RowsArrays.row2[7] && RowsArrays.row2[8] == true)
            {
                
                mw1.img2.Visibility = Visibility.Visible;
                mw1.imw2.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img2.Visibility = Visibility.Hidden;
                mw1.imw2.Visibility = Visibility.Visible;
            }
        }
        public static void row3(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row3[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row3[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row3[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row3[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row3[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row3[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row3[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row3[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row3[0] = true;
            }
            else
            {

            }
        }
        public static void row3Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row3[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row3[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row3[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row3[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row3[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row3[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row3[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row3[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row3[0] = false;
            }
            else
            {

            }
        }
        public static void row3Check()
        {
            if (RowsArrays.row3[0] && RowsArrays.row3[1] && RowsArrays.row3[2] && RowsArrays.row3[3] && RowsArrays.row3[4] && RowsArrays.row3[5] && RowsArrays.row3[6] && RowsArrays.row3[7] && RowsArrays.row3[8] == true)
            {
                
                mw1.img3.Visibility = Visibility.Visible;
                mw1.imw3.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img3.Visibility = Visibility.Hidden;
                mw1.imw3.Visibility = Visibility.Visible;
            }
        }
        public static void row4(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row4[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row4[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row4[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row4[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row4[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row4[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row4[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row4[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row4[0] = true;
            }
            else
            {

            }
        }
        public static void row4Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row4[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row4[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row4[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row4[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row4[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row4[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row4[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row4[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row4[0] = false;
            }
            else
            {

            }
        }
        public static void row4Check()
        {
            if (RowsArrays.row4[0] && RowsArrays.row4[1] && RowsArrays.row4[2] && RowsArrays.row4[3] && RowsArrays.row4[4] && RowsArrays.row4[5] && RowsArrays.row4[6] && RowsArrays.row4[7] && RowsArrays.row4[8] == true)
            {
                
                mw1.img4.Visibility = Visibility.Visible;
                mw1.imw4.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img4.Visibility = Visibility.Hidden;
                mw1.imw4.Visibility = Visibility.Visible;
            }
        }
        public static void row5(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row5[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row5[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row5[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row5[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row5[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row5[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row5[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row5[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row5[0] = true;
            }
            else
            {

            }
        }
        public static void row5Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row5[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row5[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row5[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row5[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row5[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row5[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row5[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row5[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row5[0] = false;
            }
            else
            {

            }
        }
        public static void row5Check()
        {
            if (RowsArrays.row5[0] && RowsArrays.row5[1] && RowsArrays.row5[2] && RowsArrays.row5[3] && RowsArrays.row5[4] && RowsArrays.row5[5] && RowsArrays.row5[6] && RowsArrays.row5[7] && RowsArrays.row5[8] == true)
            {                
                mw1.img5.Visibility = Visibility.Visible;
                mw1.imw5.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img5.Visibility = Visibility.Hidden;
                mw1.imw5.Visibility = Visibility.Visible;
            }
        }
        public static void row6(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row6[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row6[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row6[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row6[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row6[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row6[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row6[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row6[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row6[0] = true;
            }
            else
            {

            }
        }
        public static void row6Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row6[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row6[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row6[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row6[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row6[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row6[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row6[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row6[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row6[0] = false;
            }
            else
            {

            }
        }
        public static void row6Check()
        {
            if (RowsArrays.row6[0] && RowsArrays.row6[1] && RowsArrays.row6[2] && RowsArrays.row6[3] && RowsArrays.row6[4] && RowsArrays.row6[5] && RowsArrays.row6[6] && RowsArrays.row6[7] && RowsArrays.row6[8] == true)
            {                
                mw1.img6.Visibility = Visibility.Visible;
                mw1.imw6.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img6.Visibility = Visibility.Hidden;
                mw1.imw6.Visibility = Visibility.Visible;
            }
        }
        public static void row7(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row7[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row7[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row7[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row7[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row7[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row7[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row7[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row7[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row7[0] = true;
            }
            else
            {

            }
        }
        public static void row7Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row7[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row7[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row7[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row7[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row7[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row7[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row7[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row7[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row7[0] = false;
            }
            else
            {

            }
        }
        public static void row7Check()
        {
            if (RowsArrays.row7[0] && RowsArrays.row7[1] && RowsArrays.row7[2] && RowsArrays.row7[3] && RowsArrays.row7[4] && RowsArrays.row7[5] && RowsArrays.row7[6] && RowsArrays.row7[7] && RowsArrays.row7[8] == true)
            {
                mw1.img7.Visibility = Visibility.Visible;
                mw1.imw7.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img7.Visibility = Visibility.Hidden;
                mw1.imw7.Visibility = Visibility.Visible;
            }
        }
        public static void row8(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row8[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row8[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row8[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row8[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row8[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row8[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row8[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row8[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row8[0] = true;
            }
            else
            {

            }
        }
        public static void row8Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row8[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row8[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row8[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row8[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row8[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row8[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row8[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row8[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row8[0] = false;
            }
            else
            {

            }
        }
        public static void row8Check()
        {
            if (RowsArrays.row8[0] && RowsArrays.row8[1] && RowsArrays.row8[2] && RowsArrays.row8[3] && RowsArrays.row8[4] && RowsArrays.row8[5] && RowsArrays.row8[6] && RowsArrays.row8[7] && RowsArrays.row8[8] == true)
            {               
                mw1.img8.Visibility = Visibility.Visible;
                mw1.imw8.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.imw8.Visibility = Visibility.Visible;
                mw1.img8.Visibility = Visibility.Hidden;
            }
        }
        public static void row9(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                RowsArrays.row9[8] = true;
            }
            else if (value == 8)
            {
                RowsArrays.row9[7] = true;
            }
            else if (value == 7)
            {
                RowsArrays.row9[6] = true;
            }
            else if (value == 6)
            {
                RowsArrays.row9[5] = true;
            }
            else if (value == 5)
            {
                RowsArrays.row9[4] = true;
            }
            else if (value == 4)
            {
                RowsArrays.row9[3] = true;
            }
            else if (value == 3)
            {
                RowsArrays.row9[2] = true;
            }
            else if (value == 2)
            {
                RowsArrays.row9[1] = true;
            }
            else if (value == 1)
            {
                RowsArrays.row9[0] = true;
            }
            else
            {

            }
        }
        public static void row9Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                RowsArrays.row9[8] = false;
            }
            else if (value == 8)
            {
                RowsArrays.row9[7] = false;
            }
            else if (value == 7)
            {
                RowsArrays.row9[6] = false;
            }
            else if (value == 6)
            {
                RowsArrays.row9[5] = false;
            }
            else if (value == 5)
            {
                RowsArrays.row9[4] = false;
            }
            else if (value == 4)
            {
                RowsArrays.row9[3] = false;
            }
            else if (value == 3)
            {
                RowsArrays.row9[2] = false;
            }
            else if (value == 2)
            {
                RowsArrays.row9[1] = false;
            }
            else if (value == 1)
            {
                RowsArrays.row9[0] = false;
            }
            else
            {

            }
        }
        public static void row9Check()
        {
            if (RowsArrays.row9[0] && RowsArrays.row9[1] && RowsArrays.row9[2] && RowsArrays.row9[3] && RowsArrays.row9[4] && RowsArrays.row9[5] && RowsArrays.row9[6] && RowsArrays.row9[7] && RowsArrays.row9[8] == true)
            {
                mw1.img9.Visibility = Visibility.Visible;
                mw1.imw9.Visibility = Visibility.Hidden;
            }
            else
            {
                mw1.img9.Visibility = Visibility.Hidden;
                mw1.imw9.Visibility = Visibility.Visible;
            }
        }

        public static void row1Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row1[oldvalue - 1] = false;
            }
        }
        public static void row2Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row2[oldvalue - 1] = false;
            }
        }
        public static void row3Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row3[oldvalue - 1] = false;
            }
        }
        public static void row4Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row4[oldvalue - 1] = false;
            }
        }
        public static void row5Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row5[oldvalue - 1] = false;
            }
        }
        public static void row6Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row6[oldvalue - 1] = false;
            }
        }
        public static void row7Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row7[oldvalue - 1] = false;
            }
        }
        public static void row8Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row8[oldvalue - 1] = false;
            }
        }
        public static void row9Clear()
        {
            if (oldvalue > 0)
            {
                RowsArrays.row9[oldvalue - 1] = false;
            }
        }
    }
}
