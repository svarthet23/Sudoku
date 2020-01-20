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

        private static void columnClear(ushort value)
        {
            switch (value)
            {
                case 1:
                    Array.Clear(ColumnsArrays.column1, 0, 9);
                    break;
                case 2:
                    Array.Clear(ColumnsArrays.column2, 0, 9);
                    break;
                case 3:
                    Array.Clear(ColumnsArrays.column3, 0, 9);
                    break;
                case 4:
                    Array.Clear(ColumnsArrays.column4, 0, 9);
                    break;
                case 5:
                    Array.Clear(ColumnsArrays.column5, 0, 9);
                    break;
                case 6:
                    Array.Clear(ColumnsArrays.column6, 0, 9);
                    break;
                case 7:
                    Array.Clear(ColumnsArrays.column7, 0, 9);
                    break;
                case 8:
                    Array.Clear(ColumnsArrays.column8, 0, 9);
                    break;
                case 9:
                    Array.Clear(ColumnsArrays.column9, 0, 9);
                    break;
            }
        }

        public static void column1()
        {
            columnClear(1);

            ushort o;
            UInt16.TryParse(mw1.tb1.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb10.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb19.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb28.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb37.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb46.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb55.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb64.Text, out o);
            column1ToArray(o);
            UInt16.TryParse(mw1.tb73.Text, out o);
            column1ToArray(o);

            column1Check();
        }
        private static void column1ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column1[value - 1] = true;
        }
        public static void column2()
        {
            columnClear(2);

            ushort o;
            UInt16.TryParse(mw1.tb2.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb11.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb20.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb29.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb38.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb47.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb56.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb65.Text, out o);
            column2ToArray(o);
            UInt16.TryParse(mw1.tb74.Text, out o);
            column2ToArray(o);

            column2Check();
        }
        private static void column2ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column2[value - 1] = true;
        }
        public static void column3()
        {
            columnClear(3);

            ushort o;
            UInt16.TryParse(mw1.tb3.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb12.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb21.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb30.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb39.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb48.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb57.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb66.Text, out o);
            column3ToArray(o);
            UInt16.TryParse(mw1.tb75.Text, out o);
            column3ToArray(o);

            column3Check();
        }
        private static void column3ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column3[value - 1] = true;
        }
        public static void column4()
        {
            columnClear(4);

            ushort o;
            UInt16.TryParse(mw1.tb4.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb13.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb22.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb31.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb40.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb49.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb58.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb67.Text, out o);
            column4ToArray(o);
            UInt16.TryParse(mw1.tb76.Text, out o);
            column4ToArray(o);

            column4Check();
        }
        private static void column4ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column4[value - 1] = true;
        }
        public static void column5()
        {
            columnClear(5);

            ushort o;
            UInt16.TryParse(mw1.tb5.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb14.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb23.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb32.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb41.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb50.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb59.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb68.Text, out o);
            column5ToArray(o);
            UInt16.TryParse(mw1.tb77.Text, out o);
            column5ToArray(o);

            column5Check();
        }
        private static void column5ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column5[value - 1] = true;
        }
        public static void column6()
        {
            columnClear(6);

            ushort o;
            UInt16.TryParse(mw1.tb6.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb15.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb24.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb33.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb42.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb51.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb60.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb69.Text, out o);
            column6ToArray(o);
            UInt16.TryParse(mw1.tb78.Text, out o);
            column6ToArray(o);

            column6Check();
        }
        private static void column6ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column6[value - 1] = true;
        }
        public static void column7()
        {
            columnClear(7);

            ushort o;
            UInt16.TryParse(mw1.tb7.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb16.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb25.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb34.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb43.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb52.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb61.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb70.Text, out o);
            column7ToArray(o);
            UInt16.TryParse(mw1.tb79.Text, out o);
            column7ToArray(o);

            column7Check();
        }
        private static void column7ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column7[value - 1] = true;
        }
        public static void column8()
        {
            columnClear(8);

            ushort o;
            UInt16.TryParse(mw1.tb8.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb17.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb26.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb35.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb44.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb53.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb62.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb71.Text, out o);
            column8ToArray(o);
            UInt16.TryParse(mw1.tb80.Text, out o);
            column8ToArray(o);

            column8Check();
        }
        private static void column8ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column8[value - 1] = true;
        }
        public static void column9()
        {
            columnClear(9);

            ushort o;
            UInt16.TryParse(mw1.tb9.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb18.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb27.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb36.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb45.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb54.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb63.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb72.Text, out o);
            column9ToArray(o);
            UInt16.TryParse(mw1.tb81.Text, out o);
            column9ToArray(o);

            column9Check();
        }
        private static void column9ToArray(ushort value)
        {
            if (value > 0)
                ColumnsArrays.column9[value - 1] = true;
        }

        private static void column1Check()
        {
            if (ColumnsArrays.column1[0] && ColumnsArrays.column1[1] && ColumnsArrays.column1[2] && ColumnsArrays.column1[3] && ColumnsArrays.column1[4] && ColumnsArrays.column1[5] && ColumnsArrays.column1[6] && ColumnsArrays.column1[7] && ColumnsArrays.column1[8] == true)
            {
            }
            else
            {
            }
        }

        private static void column2Check()
        {
            if (ColumnsArrays.column2[0] && ColumnsArrays.column2[1] && ColumnsArrays.column2[2] && ColumnsArrays.column2[3] && ColumnsArrays.column2[4] && ColumnsArrays.column2[5] && ColumnsArrays.column2[6] && ColumnsArrays.column2[7] && ColumnsArrays.column2[8] == true)
            {
            }
            else
            {
            }
        }

        private static void column3Check()
        {
            if (ColumnsArrays.column3[0] && ColumnsArrays.column3[1] && ColumnsArrays.column3[2] && ColumnsArrays.column3[3] && ColumnsArrays.column3[4] && ColumnsArrays.column3[5] && ColumnsArrays.column3[6] && ColumnsArrays.column3[7] && ColumnsArrays.column3[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column4Check()
        {
            if (ColumnsArrays.column4[0] && ColumnsArrays.column4[1] && ColumnsArrays.column4[2] && ColumnsArrays.column4[3] && ColumnsArrays.column4[4] && ColumnsArrays.column4[5] && ColumnsArrays.column4[6] && ColumnsArrays.column4[7] && ColumnsArrays.column4[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column5Check()
        {
            if (ColumnsArrays.column5[0] && ColumnsArrays.column5[1] && ColumnsArrays.column5[2] && ColumnsArrays.column5[3] && ColumnsArrays.column5[4] && ColumnsArrays.column5[5] && ColumnsArrays.column5[6] && ColumnsArrays.column5[7] && ColumnsArrays.column5[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column6Check()
        {
            if (ColumnsArrays.column6[0] && ColumnsArrays.column6[1] && ColumnsArrays.column6[2] && ColumnsArrays.column6[3] && ColumnsArrays.column6[4] && ColumnsArrays.column6[5] && ColumnsArrays.column6[6] && ColumnsArrays.column6[7] && ColumnsArrays.column6[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column7Check()
        {
            if (ColumnsArrays.column7[0] && ColumnsArrays.column7[1] && ColumnsArrays.column7[2] && ColumnsArrays.column7[3] && ColumnsArrays.column7[4] && ColumnsArrays.column7[5] && ColumnsArrays.column7[6] && ColumnsArrays.column7[7] && ColumnsArrays.column7[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column8Check()
        {
            if (ColumnsArrays.column8[0] && ColumnsArrays.column8[1] && ColumnsArrays.column8[2] && ColumnsArrays.column8[3] && ColumnsArrays.column8[4] && ColumnsArrays.column8[5] && ColumnsArrays.column8[6] && ColumnsArrays.column8[7] && ColumnsArrays.column8[8] == true)
            {
            }
            else
            {
            }
        }

        public static void column9Check()
        {
            if (ColumnsArrays.column9[0] && ColumnsArrays.column9[1] && ColumnsArrays.column9[2] && ColumnsArrays.column9[3] && ColumnsArrays.column9[4] && ColumnsArrays.column9[5] && ColumnsArrays.column9[6] && ColumnsArrays.column9[7] && ColumnsArrays.column9[8] == true)
            {
            }
            else
            {
            }
        }
    }
}
