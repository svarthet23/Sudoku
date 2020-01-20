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

        private static void rowClear(ushort value)
        {
            switch (value)
            {
                case 1:
                    Array.Clear(RowsArrays.row1, 0, 9);
                    break;
                case 2:
                    Array.Clear(RowsArrays.row2, 0, 9);
                    break;
                case 3:
                    Array.Clear(RowsArrays.row3, 0, 9);
                    break;
                case 4:
                    Array.Clear(RowsArrays.row4, 0, 9);
                    break;
                case 5:
                    Array.Clear(RowsArrays.row5, 0, 9);
                    break;
                case 6:
                    Array.Clear(RowsArrays.row6, 0, 9);
                    break;
                case 7:
                    Array.Clear(RowsArrays.row7, 0, 9);
                    break;
                case 8:
                    Array.Clear(RowsArrays.row8, 0, 9);
                    break;
                case 9:
                    Array.Clear(RowsArrays.row9, 0, 9);
                    break;
            }
        }

        public static void row1()
        {
            rowClear(1);

            ushort o;
            UInt16.TryParse(mw1.tb1.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb2.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb3.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb4.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb5.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb6.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb7.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb8.Text, out o);
            row1ToArray(o);
            UInt16.TryParse(mw1.tb9.Text, out o);
            row1ToArray(o);

            row1Check();
        }
        private static void row1ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row1[value - 1] = true;
        }
        public static void row2()
        {
            rowClear(2);

            ushort o;
            UInt16.TryParse(mw1.tb10.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb11.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb12.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb13.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb14.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb15.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb16.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb17.Text, out o);
            row2ToArray(o);
            UInt16.TryParse(mw1.tb18.Text, out o);
            row2ToArray(o);

            row2Check();
        }
        private static void row2ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row2[value - 1] = true;
        }
        public static void row3()
        {
            rowClear(3);

            ushort o;
            UInt16.TryParse(mw1.tb19.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb20.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb21.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb22.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb23.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb24.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb25.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb26.Text, out o);
            row3ToArray(o);
            UInt16.TryParse(mw1.tb27.Text, out o);
            row3ToArray(o);

            row3Check();
        }
        private static void row3ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row3[value - 1] = true;
        }
        public static void row4()
        {
            rowClear(4);

            ushort o;
            UInt16.TryParse(mw1.tb28.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb29.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb30.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb31.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb32.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb33.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb34.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb35.Text, out o);
            row4ToArray(o);
            UInt16.TryParse(mw1.tb36.Text, out o);
            row4ToArray(o);

            row4Check();
        }
        private static void row4ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row4[value - 1] = true;
        }
        public static void row5()
        {
            rowClear(5);

            ushort o;
            UInt16.TryParse(mw1.tb37.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb38.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb39.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb40.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb41.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb42.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb43.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb44.Text, out o);
            row5ToArray(o);
            UInt16.TryParse(mw1.tb45.Text, out o);
            row5ToArray(o);

            row5Check();
        }
        private static void row5ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row5[value - 1] = true;
        }
        public static void row6()
        {
            rowClear(6);

            ushort o;
            UInt16.TryParse(mw1.tb46.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb47.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb48.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb49.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb50.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb51.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb52.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb53.Text, out o);
            row6ToArray(o);
            UInt16.TryParse(mw1.tb54.Text, out o);
            row6ToArray(o);

            row6Check();
        }
        private static void row6ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row6[value - 1] = true;
        }
        public static void row7()
        {
            rowClear(7);

            ushort o;
            UInt16.TryParse(mw1.tb55.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb56.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb57.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb58.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb59.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb60.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb61.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb62.Text, out o);
            row7ToArray(o);
            UInt16.TryParse(mw1.tb63.Text, out o);
            row7ToArray(o);

            row7Check();
        }
        private static void row7ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row7[value - 1] = true;
        }
        public static void row8()
        {
            rowClear(8);

            ushort o;
            UInt16.TryParse(mw1.tb64.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb65.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb66.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb67.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb68.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb69.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb70.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb71.Text, out o);
            row8ToArray(o);
            UInt16.TryParse(mw1.tb72.Text, out o);
            row8ToArray(o);

            row8Check();
        }
        private static void row8ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row8[value - 1] = true;
        }
        public static void row9()
        {
            rowClear(9);

            ushort o;
            UInt16.TryParse(mw1.tb73.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb74.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb75.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb76.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb77.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb78.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb79.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb80.Text, out o);
            row9ToArray(o);
            UInt16.TryParse(mw1.tb81.Text, out o);
            row9ToArray(o);

            row9Check();
        }
        private static void row9ToArray(ushort value)
        {
            if (value > 0)
                RowsArrays.row9[value - 1] = true;
        }

        private static void row1Check()
        {
            if (RowsArrays.row1[0] && RowsArrays.row1[1] && RowsArrays.row1[2] && RowsArrays.row1[3] && RowsArrays.row1[4] && RowsArrays.row1[5] && RowsArrays.row1[6] && RowsArrays.row1[7] && RowsArrays.row1[8] == true)
            {
            }
            else
            {
            }
        }

        private static void row2Check()
        {
            if (RowsArrays.row2[0] && RowsArrays.row2[1] && RowsArrays.row2[2] && RowsArrays.row2[3] && RowsArrays.row2[4] && RowsArrays.row2[5] && RowsArrays.row2[6] && RowsArrays.row2[7] && RowsArrays.row2[8] == true)
            {
            }
            else
            {
            }
        }

        private static void row3Check()
        {
            if (RowsArrays.row3[0] && RowsArrays.row3[1] && RowsArrays.row3[2] && RowsArrays.row3[3] && RowsArrays.row3[4] && RowsArrays.row3[5] && RowsArrays.row3[6] && RowsArrays.row3[7] && RowsArrays.row3[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row4Check()
        {
            if (RowsArrays.row4[0] && RowsArrays.row4[1] && RowsArrays.row4[2] && RowsArrays.row4[3] && RowsArrays.row4[4] && RowsArrays.row4[5] && RowsArrays.row4[6] && RowsArrays.row4[7] && RowsArrays.row4[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row5Check()
        {
            if (RowsArrays.row5[0] && RowsArrays.row5[1] && RowsArrays.row5[2] && RowsArrays.row5[3] && RowsArrays.row5[4] && RowsArrays.row5[5] && RowsArrays.row5[6] && RowsArrays.row5[7] && RowsArrays.row5[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row6Check()
        {
            if (RowsArrays.row6[0] && RowsArrays.row6[1] && RowsArrays.row6[2] && RowsArrays.row6[3] && RowsArrays.row6[4] && RowsArrays.row6[5] && RowsArrays.row6[6] && RowsArrays.row6[7] && RowsArrays.row6[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row7Check()
        {
            if (RowsArrays.row7[0] && RowsArrays.row7[1] && RowsArrays.row7[2] && RowsArrays.row7[3] && RowsArrays.row7[4] && RowsArrays.row7[5] && RowsArrays.row7[6] && RowsArrays.row7[7] && RowsArrays.row7[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row8Check()
        {
            if (RowsArrays.row8[0] && RowsArrays.row8[1] && RowsArrays.row8[2] && RowsArrays.row8[3] && RowsArrays.row8[4] && RowsArrays.row8[5] && RowsArrays.row8[6] && RowsArrays.row8[7] && RowsArrays.row8[8] == true)
            {
            }
            else
            {
            }
        }

        public static void row9Check()
        {
            if (RowsArrays.row9[0] && RowsArrays.row9[1] && RowsArrays.row9[2] && RowsArrays.row9[3] && RowsArrays.row9[4] && RowsArrays.row9[5] && RowsArrays.row9[6] && RowsArrays.row9[7] && RowsArrays.row9[8] == true)
            {
            }
            else
            {
            }
        }
    }
}
