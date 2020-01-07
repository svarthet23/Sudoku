using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sudoku
{
    public static class Variables
    {
        //public static ushort var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13, var14, var15, var16, var17, var18, var19, var20,
        //            var21, var22, var23, var24, var25, var26, var27, var28, var29, var30, var31, var32, var33, var34, var35, var36, var37, var38, var39, var40,
        //            var41, var42, var43, var44, var45, var46, var47, var48, var49, var50, var51, var52, var53, var54, var55, var56, var57, var58, var59, var60,
        //            var61, var62, var63, var64, var65, var66, var67, var68, var69, var70, var71, var72, var73, var74, var75, var76, var77, var78, var79, var80, var81 = 0;

        public static ushort[,] fullBoard = new ushort[9, 9]
          { { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },};

        public static ushort[,] board1 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board2 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board3 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board4 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board5 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board6 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board7 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board8 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };
        public static ushort[,] board9 = new ushort[3, 3]
            { { 0, 0, 0 },
              { 0, 0, 0 },
              { 0, 0, 0 } };

    }
   
    public static class Algorithm
    {
       static MainWindow mw1 = Application.Current.Windows
   .Cast<Window>()
   .FirstOrDefault(window => window is MainWindow) as MainWindow;


        public static void tb1Check()
        {
            
            if (Variables.board1[0, 0] + Variables.board1[1, 0] + Variables.board1[2, 0] + Variables.board1[0, 1] + Variables.board1[1, 1] + Variables.board1[2, 1] + Variables.board1[0, 2] + Variables.board1[1, 2] + Variables.board1[2, 2] == 45)
            {

                mw1.tb5.Text = "O";
            }
            else
            {
                mw1.tb5.Text = "P";
            }
        }
    }
}
