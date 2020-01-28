using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sudoku
{
    public static class Generator
    {
        private static readonly Random rn1 = new Random();

        private static int _i = 0;
        private static int i
        {
            get { return _i; }
            set {

                if (value > 9)
                {
                    _i = 0;
                }
                else if (value <= 9)
                {
                    _i = value;
                }
            }
        }

        private static ushort breaker = 0;
        private static ushort looper = 200;
        public static bool done = false;

        static MainWindow mw1 = Application.Current.Windows
    .Cast<Window>()
    .FirstOrDefault(window => window is MainWindow) as MainWindow;

            public static void Start(ushort _value)
            {

            Game.ReEnter();
            Game.ResetFocus();
            Game.DefaultColor();

            while (done == false)
            {
                breaker = 0;
                Array.Clear(BoardsArrays.board1, 0, 9);
                Array.Clear(BoardsArrays.board2, 0, 9);
                Array.Clear(BoardsArrays.board3, 0, 9);
                Array.Clear(BoardsArrays.board4, 0, 9);
                Array.Clear(BoardsArrays.board5, 0, 9);
                Array.Clear(BoardsArrays.board6, 0, 9);
                Array.Clear(BoardsArrays.board7, 0, 9);
                Array.Clear(BoardsArrays.board8, 0, 9);
                Array.Clear(BoardsArrays.board9, 0, 9);
                Array.Clear(RowsArrays.row1, 0, 9);
                Array.Clear(RowsArrays.row2, 0, 9);
                Array.Clear(RowsArrays.row3, 0, 9);
                Array.Clear(RowsArrays.row4, 0, 9);
                Array.Clear(RowsArrays.row5, 0, 9);
                Array.Clear(RowsArrays.row6, 0, 9);
                Array.Clear(RowsArrays.row7, 0, 9);
                Array.Clear(RowsArrays.row8, 0, 9);
                Array.Clear(RowsArrays.row9, 0, 9);
                Array.Clear(ColumnsArrays.column1, 0, 9);
                Array.Clear(ColumnsArrays.column2, 0, 9);
                Array.Clear(ColumnsArrays.column3, 0, 9);
                Array.Clear(ColumnsArrays.column4, 0, 9);
                Array.Clear(ColumnsArrays.column5, 0, 9);
                Array.Clear(ColumnsArrays.column6, 0, 9);
                Array.Clear(ColumnsArrays.column7, 0, 9);
                Array.Clear(ColumnsArrays.column8, 0, 9);
                Array.Clear(ColumnsArrays.column9, 0, 9);
                Array.Clear(BoardsArrays.allBoards, 0, 9);

                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb1.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                         i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb1.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb1.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter();
                    breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb2.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb2.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb2.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb3.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb3.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb3.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb10.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb10.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb10.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb11.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb11.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb11.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb12.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb12.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb12.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb19.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb19.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb19.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb20.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb20.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb20.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb21.Clear();
                }
                else
                {
                    while (BoardsArrays.board1[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb21.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb21.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb31.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb31.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb31.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb32.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb32.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb32.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb33.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb33.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb33.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb40.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb40.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb40.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb41.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb41.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb41.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb42.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb42.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb42.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb49.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb49.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb49.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb50.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb50.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb50.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb51.Clear();
                }
                else
                {
                    while (BoardsArrays.board5[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb51.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb51.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb61.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb61.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb61.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb62.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb62.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb62.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb63.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb63.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb63.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb70.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb70.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb70.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb71.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb71.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb71.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb72.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb72.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb72.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb79.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb79.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb79.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb80.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb80.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb80.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb81.Clear();
                }
                else
                {
                    while (BoardsArrays.board9[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb81.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb81.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb28.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb28.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb28.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb29.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb29.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb29.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb30.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb30.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb30.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb37.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb37.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb37.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb38.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb38.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb38.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb39.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb39.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb39.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb46.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb46.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb46.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb47.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb47.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb47.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb48.Clear();
                }
                else
                {
                    while (BoardsArrays.board4[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb48.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb48.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb34.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb34.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb34.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb35.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb35.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb35.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb36.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row4[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb36.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb36.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb43.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb43.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb43.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb44.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb44.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb44.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb45.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row5[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb45.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb45.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb52.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb52.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb52.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb53.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb53.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb53.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb54.Clear();
                }
                else
                {
                    while (BoardsArrays.board6[_i - 1] == true || RowsArrays.row6[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb54.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb54.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb55.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb55.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb55.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb56.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb56.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb56.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb57.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb57.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb57.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb64.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb64.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb64.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb65.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb65.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb65.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb66.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb66.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb66.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb73.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column1[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb73.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb73.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb74.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column2[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb74.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb74.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb75.Clear();
                }
                else
                {
                    while (BoardsArrays.board7[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column3[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb75.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb75.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb7.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb7.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb7.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb8.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb8.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb8.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb9.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb9.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb9.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb16.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb16.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb16.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb17.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb17.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb17.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb18.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb18.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb18.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb25.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column7[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb25.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb25.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb26.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column8[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb26.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb26.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb27.Clear();
                }
                else
                {
                    while (BoardsArrays.board3[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column9[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb27.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb27.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb58.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb58.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb58.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb59.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb59.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb59.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb60.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row7[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb60.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb60.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb67.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb67.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb67.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb68.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb68.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb68.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb69.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row8[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb69.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb69.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb76.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb76.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb76.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb77.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb77.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb77.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb78.Clear();
                }
                else
                {
                    while (BoardsArrays.board8[_i - 1] == true || RowsArrays.row9[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb78.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb78.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb4.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb4.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb4.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb5.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb5.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb5.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb6.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row1[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb6.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb6.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 
                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb13.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb13.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb13.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb14.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb14.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb14.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb15.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row2[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb15.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb15.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
 

                i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb22.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column4[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb22.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb22.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb23.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column5[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb23.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb23.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }
                 i = rn1.Next(1, _value);
                if (_i == 0)
                {
                    mw1.tb24.Clear();
                }
                else
                {
                    while (BoardsArrays.board2[_i - 1] == true || RowsArrays.row3[_i - 1] == true || ColumnsArrays.column6[_i - 1] == true)
                    {
                        Thread.Sleep(1);
                        i = rn1.Next(1, _value);
                        while (_i == 0)
                        {
                             i = rn1.Next(1, _value);
                        }
                        breaker++;
                        if (breaker == looper)
                        {
                            mw1.tb24.Clear();
                            break;
                        }
                    }
                    if (breaker != looper)
                        mw1.tb24.Text = _i.ToString();
                    else
                        continue;
                    Game.ReEnter(); breaker = 0;
                }

                foreach (var tb in mw1.tbGrid.Children)
                {
                    if (tb is TextBox)
                    {
                        if (((TextBox)tb).Text == "")
                        {
                            ((TextBox)tb).Focusable = true;
                            ((TextBox)tb).Foreground = Brushes.Black;
                        }
                        else
                        {
                            ((TextBox)tb).Focusable = false;
                            ((TextBox)tb).Foreground = Brushes.LightGray;
                        }
                    }
                }
                done = true;
            }
        }
    }
}
    