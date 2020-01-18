using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sudoku
{
        public static class ColumnsArrays
    {
        public static bool[] column1 = new bool[9];
        public static bool[] column2 = new bool[9];
        public static bool[] column3 = new bool[9];
        public static bool[] column4 = new bool[9];
        public static bool[] column5 = new bool[9];
        public static bool[] column6 = new bool[9];
        public static bool[] column7 = new bool[9];
        public static bool[] column8 = new bool[9];
        public static bool[] column9 = new bool[9];
    }
    public static class ColumnsAlgorithm
    {
        static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;

        private static ushort oldvalue;
        private static ushort value;

        public static void column1(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column1[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column1[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column1[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column1[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column1[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column1[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column1[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column1[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column1[0] = true;
            }
            else
            {

            }
        }
        public static void column1Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column1[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column1[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column1[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column1[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column1[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column1[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column1[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column1[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column1[0] = false;
            }
            else
            {

            }
        }
        public static void column1Check()
        {
            if (ColumnsArrays.column1[0] && ColumnsArrays.column1[1] && ColumnsArrays.column1[2] && ColumnsArrays.column1[3] && ColumnsArrays.column1[4] && ColumnsArrays.column1[5] && ColumnsArrays.column1[6] && ColumnsArrays.column1[7] && ColumnsArrays.column1[8] == true)
            {

                mw1.cbc.IsChecked = true;
            }
            else
            {
                mw1.cbc.IsChecked = false;
            }
        }
        public static void column2(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column2[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column2[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column2[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column2[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column2[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column2[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column2[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column2[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column2[0] = true;
            }
            else
            {

            }
        }
        public static void column2Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column2[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column2[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column2[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column2[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column2[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column2[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column2[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column2[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column2[0] = false;
            }
            else
            {

            }
        }
        public static void column2Check()
        {
            if (ColumnsArrays.column2[0] && ColumnsArrays.column2[1] && ColumnsArrays.column2[2] && ColumnsArrays.column2[3] && ColumnsArrays.column2[4] && ColumnsArrays.column2[5] && ColumnsArrays.column2[6] && ColumnsArrays.column2[7] && ColumnsArrays.column2[8] == true)
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
        public static void column3(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column3[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column3[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column3[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column3[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column3[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column3[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column3[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column3[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column3[0] = true;
            }
            else
            {

            }
        }
        public static void column3Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column3[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column3[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column3[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column3[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column3[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column3[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column3[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column3[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column3[0] = false;
            }
            else
            {

            }
        }
        public static void column3Check()
        {
            if (ColumnsArrays.column3[0] && ColumnsArrays.column3[1] && ColumnsArrays.column3[2] && ColumnsArrays.column3[3] && ColumnsArrays.column3[4] && ColumnsArrays.column3[5] && ColumnsArrays.column3[6] && ColumnsArrays.column3[7] && ColumnsArrays.column3[8] == true)
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
        public static void column4(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column4[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column4[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column4[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column4[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column4[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column4[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column4[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column4[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column4[0] = true;
            }
            else
            {

            }
        }
        public static void column4Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column4[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column4[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column4[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column4[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column4[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column4[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column4[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column4[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column4[0] = false;
            }
            else
            {

            }
        }
        public static void column4Check()
        {
            if (ColumnsArrays.column4[0] && ColumnsArrays.column4[1] && ColumnsArrays.column4[2] && ColumnsArrays.column4[3] && ColumnsArrays.column4[4] && ColumnsArrays.column4[5] && ColumnsArrays.column4[6] && ColumnsArrays.column4[7] && ColumnsArrays.column4[8] == true)
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
        public static void column5(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column5[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column5[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column5[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column5[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column5[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column5[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column5[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column5[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column5[0] = true;
            }
            else
            {

            }
        }
        public static void column5Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column5[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column5[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column5[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column5[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column5[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column5[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column5[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column5[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column5[0] = false;
            }
            else
            {

            }
        }
        public static void column5Check()
        {
            if (ColumnsArrays.column5[0] && ColumnsArrays.column5[1] && ColumnsArrays.column5[2] && ColumnsArrays.column5[3] && ColumnsArrays.column5[4] && ColumnsArrays.column5[5] && ColumnsArrays.column5[6] && ColumnsArrays.column5[7] && ColumnsArrays.column5[8] == true)
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
        public static void column6(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column6[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column6[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column6[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column6[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column6[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column6[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column6[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column6[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column6[0] = true;
            }
            else
            {

            }
        }
        public static void column6Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column6[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column6[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column6[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column6[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column6[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column6[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column6[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column6[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column6[0] = false;
            }
            else
            {

            }
        }
        public static void column6Check()
        {
            if (ColumnsArrays.column6[0] && ColumnsArrays.column6[1] && ColumnsArrays.column6[2] && ColumnsArrays.column6[3] && ColumnsArrays.column6[4] && ColumnsArrays.column6[5] && ColumnsArrays.column6[6] && ColumnsArrays.column6[7] && ColumnsArrays.column6[8] == true)
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
        public static void column7(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column7[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column7[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column7[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column7[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column7[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column7[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column7[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column7[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column7[0] = true;
            }
            else
            {

            }
        }
        public static void column7Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column7[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column7[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column7[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column7[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column7[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column7[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column7[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column7[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column7[0] = false;
            }
            else
            {

            }
        }
        public static void column7Check()
        {
            if (ColumnsArrays.column7[0] && ColumnsArrays.column7[1] && ColumnsArrays.column7[2] && ColumnsArrays.column7[3] && ColumnsArrays.column7[4] && ColumnsArrays.column7[5] && ColumnsArrays.column7[6] && ColumnsArrays.column7[7] && ColumnsArrays.column7[8] == true)
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
        public static void column8(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column8[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column8[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column8[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column8[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column8[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column8[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column8[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column8[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column8[0] = true;
            }
            else
            {

            }
        }
        public static void column8Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column8[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column8[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column8[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column8[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column8[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column8[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column8[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column8[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column8[0] = false;
            }
            else
            {

            }
        }
        public static void column8Check()
        {
            if (ColumnsArrays.column8[0] && ColumnsArrays.column8[1] && ColumnsArrays.column8[2] && ColumnsArrays.column8[3] && ColumnsArrays.column8[4] && ColumnsArrays.column8[5] && ColumnsArrays.column8[6] && ColumnsArrays.column8[7] && ColumnsArrays.column8[8] == true)
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
        public static void column9(ushort _value)
        {
            if (_value > 0)
            {
                oldvalue = value;
            }
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column9[8] = true;
            }
            else if (value == 8)
            {
                ColumnsArrays.column9[7] = true;
            }
            else if (value == 7)
            {
                ColumnsArrays.column9[6] = true;
            }
            else if (value == 6)
            {
                ColumnsArrays.column9[5] = true;
            }
            else if (value == 5)
            {
                ColumnsArrays.column9[4] = true;
            }
            else if (value == 4)
            {
                ColumnsArrays.column9[3] = true;
            }
            else if (value == 3)
            {
                ColumnsArrays.column9[2] = true;
            }
            else if (value == 2)
            {
                ColumnsArrays.column9[1] = true;
            }
            else if (value == 1)
            {
                ColumnsArrays.column9[0] = true;
            }
            else
            {

            }
        }
        public static void column9Clear(ushort _value)
        {
            value = _value;

            if (value == 9)
            {
                ColumnsArrays.column9[8] = false;
            }
            else if (value == 8)
            {
                ColumnsArrays.column9[7] = false;
            }
            else if (value == 7)
            {
                ColumnsArrays.column9[6] = false;
            }
            else if (value == 6)
            {
                ColumnsArrays.column9[5] = false;
            }
            else if (value == 5)
            {
                ColumnsArrays.column9[4] = false;
            }
            else if (value == 4)
            {
                ColumnsArrays.column9[3] = false;
            }
            else if (value == 3)
            {
                ColumnsArrays.column9[2] = false;
            }
            else if (value == 2)
            {
                ColumnsArrays.column9[1] = false;
            }
            else if (value == 1)
            {
                ColumnsArrays.column9[0] = false;
            }
            else
            {

            }
        }
        public static void column9Check()
        {
            if (ColumnsArrays.column9[0] && ColumnsArrays.column9[1] && ColumnsArrays.column9[2] && ColumnsArrays.column9[3] && ColumnsArrays.column9[4] && ColumnsArrays.column9[5] && ColumnsArrays.column9[6] && ColumnsArrays.column9[7] && ColumnsArrays.column9[8] == true)
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

        public static void column1Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column1[oldvalue - 1] = false;
            }
        }
        public static void column2Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column2[oldvalue - 1] = false;
            }
        }
        public static void column3Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column3[oldvalue - 1] = false;
            }
        }
        public static void column4Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column4[oldvalue - 1] = false;
            }
        }
        public static void column5Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column5[oldvalue - 1] = false;
            }
        }
        public static void column6Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column6[oldvalue - 1] = false;
            }
        }
        public static void column7Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column7[oldvalue - 1] = false;
            }
        }
        public static void column8Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column8[oldvalue - 1] = false;
            }
        }
        public static void column9Clear()
        {
            if (oldvalue > 0)
            {
                ColumnsArrays.column9[oldvalue - 1] = false;
            }
        }

    }
}
