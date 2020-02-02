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
            set
            {

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

                ClearArrays();

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
        private static void NotFocusGreyColor()
        {
            foreach (var tb in mw1.tbGrid.Children)
            {
                if (tb is TextBox)
                {
                    if (((TextBox)tb).Text == "")
                    {
                        ((TextBox)tb).Clear();
                        ((TextBox)tb).Focusable = true;
                        ((TextBox)tb).Foreground = Brushes.Black;
                    }
                    else
                    {
                        ((TextBox)tb).Focusable = false;
                        ((TextBox)tb).Foreground = new SolidColorBrush(Color.FromRgb(50, 50, 50));
                    }
                }
            }
        }

        private static void ClearArrays()
        {            
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
            Array.Clear(RowsArrays.allRows, 0, 9);
            Array.Clear(ColumnsArrays.allColumns, 0, 9);
        }

        static ushort stop = 0;

        private static void BackTrack(int old1, int old2, int old3, int old4, int old5, int old6)
        {
            laps = 0;
            stop++;

            switch (old1)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            switch (old2)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            switch (old3)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            switch (old4)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            switch (old5)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            switch (old6)
            {
                case 1:
                    mw1.tb1.Clear();
                    break;
                case 2:
                    mw1.tb2.Clear();
                    break;
                case 3:
                    mw1.tb3.Clear();
                    break;
                case 4:
                    mw1.tb4.Clear();
                    break;
                case 5:
                    mw1.tb5.Clear();
                    break;
                case 6:
                    mw1.tb6.Clear();
                    break;
                case 7:
                    mw1.tb7.Clear();
                    break;
                case 8:
                    mw1.tb8.Clear();
                    break;
                case 9:
                    mw1.tb9.Clear();
                    break;
                case 10:
                    mw1.tb10.Clear();
                    break;
                case 11:
                    mw1.tb11.Clear();
                    break;
                case 12:
                    mw1.tb12.Clear();
                    break;
                case 13:
                    mw1.tb13.Clear();
                    break;
                case 14:
                    mw1.tb14.Clear();
                    break;
                case 15:
                    mw1.tb15.Clear();
                    break;
                case 16:
                    mw1.tb16.Clear();
                    break;
                case 17:
                    mw1.tb17.Clear();
                    break;
                case 18:
                    mw1.tb18.Clear();
                    break;
                case 19:
                    mw1.tb19.Clear();
                    break;
                case 20:
                    mw1.tb20.Clear();
                    break;
                case 21:
                    mw1.tb21.Clear();
                    break;
                case 22:
                    mw1.tb22.Clear();
                    break;
                case 23:
                    mw1.tb23.Clear();
                    break;
                case 24:
                    mw1.tb24.Clear();
                    break;
                case 25:
                    mw1.tb25.Clear();
                    break;
                case 26:
                    mw1.tb26.Clear();
                    break;
                case 27:
                    mw1.tb27.Clear();
                    break;
                case 28:
                    mw1.tb28.Clear();
                    break;
                case 29:
                    mw1.tb29.Clear();
                    break;
                case 30:
                    mw1.tb30.Clear();
                    break;
                case 31:
                    mw1.tb31.Clear();
                    break;
                case 32:
                    mw1.tb32.Clear();
                    break;
                case 33:
                    mw1.tb33.Clear();
                    break;
                case 34:
                    mw1.tb34.Clear();
                    break;
                case 35:
                    mw1.tb35.Clear();
                    break;
                case 36:
                    mw1.tb36.Clear();
                    break;
                case 37:
                    mw1.tb37.Clear();
                    break;
                case 38:
                    mw1.tb38.Clear();
                    break;
                case 39:
                    mw1.tb39.Clear();
                    break;
                case 40:
                    mw1.tb40.Clear();
                    break;
                case 41:
                    mw1.tb41.Clear();
                    break;
                case 42:
                    mw1.tb42.Clear();
                    break;
                case 43:
                    mw1.tb43.Clear();
                    break;
                case 44:
                    mw1.tb44.Clear();
                    break;
                case 45:
                    mw1.tb45.Clear();
                    break;
                case 46:
                    mw1.tb46.Clear();
                    break;
                case 47:
                    mw1.tb47.Clear();
                    break;
                case 48:
                    mw1.tb48.Clear();
                    break;
                case 49:
                    mw1.tb49.Clear();
                    break;
                case 50:
                    mw1.tb50.Clear();
                    break;
                case 51:
                    mw1.tb51.Clear();
                    break;
                case 52:
                    mw1.tb52.Clear();
                    break;
                case 53:
                    mw1.tb53.Clear();
                    break;
                case 54:
                    mw1.tb54.Clear();
                    break;
                case 55:
                    mw1.tb55.Clear();
                    break;
                case 56:
                    mw1.tb56.Clear();
                    break;
                case 57:
                    mw1.tb57.Clear();
                    break;
                case 58:
                    mw1.tb58.Clear();
                    break;
                case 59:
                    mw1.tb59.Clear();
                    break;
                case 60:
                    mw1.tb60.Clear();
                    break;
                case 61:
                    mw1.tb61.Clear();
                    break;
                case 62:
                    mw1.tb62.Clear();
                    break;
                case 63:
                    mw1.tb63.Clear();
                    break;
                case 64:
                    mw1.tb64.Clear();
                    break;
                case 65:
                    mw1.tb65.Clear();
                    break;
                case 66:
                    mw1.tb66.Clear();
                    break;
                case 67:
                    mw1.tb67.Clear();
                    break;
                case 68:
                    mw1.tb68.Clear();
                    break;
                case 69:
                    mw1.tb69.Clear();
                    break;
                case 70:
                    mw1.tb70.Clear();
                    break;
                case 71:
                    mw1.tb71.Clear();
                    break;
                case 72:
                    mw1.tb72.Clear();
                    break;
                case 73:
                    mw1.tb73.Clear();
                    break;
                case 74:
                    mw1.tb74.Clear();
                    break;
                case 75:
                    mw1.tb75.Clear();
                    break;
                case 76:
                    mw1.tb76.Clear();
                    break;
                case 77:
                    mw1.tb77.Clear();
                    break;
                case 78:
                    mw1.tb78.Clear();
                    break;
                case 79:
                    mw1.tb79.Clear();
                    break;
                case 80:
                    mw1.tb80.Clear();
                    break;
                case 81:
                    mw1.tb81.Clear();
                    break;
            }
            Array.Clear(doneArray, 0, doneArray.Length);

            if (stop == 80)
            {
                ClearArrays();                
                stop = 0;
            }

            Game.ReEnter();

        }

        private static int laps = 0;
        public static bool doneNew = false;
        private static int old1 = 0;
        private static int old2 = 0;
        private static int old3 = 0;
        private static int old4 = 0;
        private static int old5 = 0;
        private static int old6 = 0;
        private static int swi = 0;
        private static bool[] doneArray = new bool[81];

        private static void SetOldValues()
        {
            old6 = old5;
            old5 = old4;
            old4 = old3;
            old3 = old2;
            old2 = old1;
            old1 = swi;
        }

        public static void StartNew()
        {
            stop = 0;

            ClearArrays();

            while (doneNew == false)
            {               
                swi = rn1.Next(1, 81);

                switch (swi)
                {
                    case 1:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb1.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 2:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb2.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 3:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb3.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 4:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb4.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 5:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb5.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 6:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb6.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 7:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb7.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 8:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb8.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 9:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row1[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb9.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 10:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb10.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 11:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb11.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 12:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb12.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 13:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb13.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 14:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb14.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 15:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb15.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 16:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb16.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 17:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb17.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 18:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row2[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb18.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 19:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb19.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 20:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb20.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 21:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board1[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb21.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 22:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb22.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 23:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb23.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 24:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board2[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb24.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 25:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb25.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 26:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb26.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 27:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board3[ind] != true && RowsArrays.row3[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb27.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 28:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb28.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 29:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb29.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 30:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb30.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 31:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb31.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 32:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb32.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 33:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb33.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 34:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb34.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 35:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb35.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 36:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row4[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb36.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 37:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb37.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 38:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb38.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 39:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb39.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 40:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb40.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 41:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb41.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 42:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb42.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 43:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb43.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 44:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb44.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 45:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row5[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb45.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 46:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb46.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 47:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb47.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 48:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board4[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb48.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 49:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb49.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 50:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb50.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 51:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board5[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb51.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 52:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb52.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 53:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb53.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 54:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board6[ind] != true && RowsArrays.row6[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb54.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 55:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb55.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 56:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb56.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 57:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb57.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 58:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb58.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 59:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb59.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 60:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb60.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 61:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb61.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 62:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb62.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 63:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row7[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb63.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 64:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb64.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 65:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb65.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 66:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb66.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 67:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb67.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 68:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb68.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 69:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb69.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 70:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb70.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 71:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb71.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 72:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row8[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb72.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 73:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column1[ind] != true)
                                {
                                    ind++;
                                    mw1.tb73.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 74:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column2[ind] != true)
                                {
                                    ind++;
                                    mw1.tb74.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 75:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board7[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column3[ind] != true)
                                {
                                    ind++;
                                    mw1.tb75.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 76:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column4[ind] != true)
                                {
                                    ind++;
                                    mw1.tb76.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 77:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column5[ind] != true)
                                {
                                    ind++;
                                    mw1.tb77.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 78:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board8[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column6[ind] != true)
                                {
                                    ind++;
                                    mw1.tb78.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 79:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column7[ind] != true)
                                {
                                    ind++;
                                    mw1.tb79.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 80:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column8[ind] != true)
                                {
                                    ind++;
                                    mw1.tb80.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                    case 81:
                        if (doneArray[swi - 1] == false)
                        {
                            for (ushort ind = 0; ind <= 8; ind++)
                            {
                                if (BoardsArrays.board9[ind] != true && RowsArrays.row9[ind] != true && ColumnsArrays.column9[ind] != true)
                                {
                                    ind++;
                                    mw1.tb81.Text = ind.ToString();
                                    Game.ReEnter(); SetOldValues(); doneArray[swi - 1] = true;
                                    break;
                                }
                                //
                                else if (ind == 8)
                                { laps = 0; BackTrack(old1, old2, old3, old4, old5, old6); }
                            }
                        }
                        break;
                }
                laps++;
                //Thread.Sleep(1);
                Console.WriteLine(laps);
               
                BoardsAlgorithm.WinCheck();
                RowsAlgorithm.WinCheck();
                ColumnsAlgorithm.WinCheck();
            }
            NotFocusGreyColor();
        }
    }
}
