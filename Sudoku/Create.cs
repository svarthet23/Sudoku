using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace Sudoku
{
    class Create
    {
        private readonly Random rn1 = new Random();
        
        private int _i = 0;
        public int i
        {
           get { return _i; }
           set { 

                if (value > 9)
                {
                    _i = 0;
                    
                }
                if (value <= 9)
                {
                    _i = value;
                    
                }
            }
        }

        MainWindow mw1 = Application.Current.Windows
    .Cast<Window>()
    .FirstOrDefault(window => window is MainWindow) as MainWindow;

        public void Start()
        {
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb1.Clear();
            }
            else
            {
                mw1.tb1.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb2.Clear();
            }
            else
            {
                mw1.tb2.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb3.Clear();
            }
            else
            {
                mw1.tb3.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb4.Clear();
            }
            else
            {
                mw1.tb4.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb5.Clear();
            }
            else
            {
                mw1.tb5.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb6.Clear();
            }
            else
            {
                mw1.tb6.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb7.Clear();
            }
            else
            {
                mw1.tb7.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb8.Clear();
            }
            else
            {
                mw1.tb8.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb9.Clear();
            }
            else
            {
                mw1.tb9.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb10.Clear();
            }
            else
            {
                mw1.tb10.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb11.Clear();
            }
            else
            {
                mw1.tb11.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb12.Clear();
            }
            else
            {
                mw1.tb12.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb13.Clear();
            }
            else
            {
                mw1.tb13.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb14.Clear();
            }
            else
            {
                mw1.tb14.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb15.Clear();
            }
            else
            {
                mw1.tb15.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb16.Clear();
            }
            else
            {
                mw1.tb16.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb17.Clear();
            }
            else
            {
                mw1.tb17.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb18.Clear();
            }
            else
            {
                mw1.tb18.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb19.Clear();
            }
            else
            {
                mw1.tb19.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb20.Clear();
            }
            else
            {
                mw1.tb20.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb21.Clear();
            }
            else
            {
                mw1.tb21.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb22.Clear();
            }
            else
            {
                mw1.tb22.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb23.Clear();
            }
            else
            {
                mw1.tb23.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb24.Clear();
            }
            else
            {
                mw1.tb24.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb25.Clear();
            }
            else
            {
                mw1.tb25.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb26.Clear();
            }
            else
            {
                mw1.tb26.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb27.Clear();
            }
            else
            {
                mw1.tb27.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb28.Clear();
            }
            else
            {
                mw1.tb28.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb29.Clear();
            }
            else
            {
                mw1.tb29.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb30.Clear();
            }
            else
            {
                mw1.tb30.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb31.Clear();
            }
            else
            {
                mw1.tb31.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb32.Clear();
            }
            else
            {
                mw1.tb32.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb33.Clear();
            }
            else
            {
                mw1.tb33.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb34.Clear();
            }
            else
            {
                mw1.tb34.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb35.Clear();
            }
            else
            {
                mw1.tb35.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb36.Clear();
            }
            else
            {
                mw1.tb36.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb37.Clear();
            }
            else
            {
                mw1.tb37.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb38.Clear();
            }
            else
            {
                mw1.tb38.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb39.Clear();
            }
            else
            {
                mw1.tb39.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb40.Clear();
            }
            else
            {
                mw1.tb40.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb41.Clear();
            }
            else
            {
                mw1.tb41.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb42.Clear();
            }
            else
            {
                mw1.tb42.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb43.Clear();
            }
            else
            {
                mw1.tb43.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb44.Clear();
            }
            else
            {
                mw1.tb44.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb45.Clear();
            }
            else
            {
                mw1.tb45.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb46.Clear();
            }
            else
            {
                mw1.tb46.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb47.Clear();
            }
            else
            {
                mw1.tb47.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb48.Clear();
            }
            else
            {
                mw1.tb48.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb49.Clear();
            }
            else
            {
                mw1.tb49.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb50.Clear();
            }
            else
            {
                mw1.tb50.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb51.Clear();
            }
            else
            {
                mw1.tb51.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb52.Clear();
            }
            else
            {
                mw1.tb52.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb53.Clear();
            }
            else
            {
                mw1.tb53.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb54.Clear();
            }
            else
            {
                mw1.tb54.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb55.Clear();
            }
            else
            {
                mw1.tb55.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb56.Clear();
            }
            else
            {
                mw1.tb56.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb57.Clear();
            }
            else
            {
                mw1.tb57.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb58.Clear();
            }
            else
            {
                mw1.tb58.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb59.Clear();
            }
            else
            {
                mw1.tb59.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb60.Clear();
            }
            else
            {
                mw1.tb60.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb61.Clear();
            }
            else
            {
                mw1.tb61.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb62.Clear();
            }
            else
            {
                mw1.tb62.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb63.Clear();
            }
            else
            {
                mw1.tb63.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb64.Clear();
            }
            else
            {
                mw1.tb64.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb65.Clear();
            }
            else
            {
                mw1.tb65.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb66.Clear();
            }
            else
            {
                mw1.tb66.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb67.Clear();
            }
            else
            {
                mw1.tb67.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb68.Clear();
            }
            else
            {
                mw1.tb68.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb69.Clear();
            }
            else
            {
                mw1.tb69.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb70.Clear();
            }
            else
            {
                mw1.tb70.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb71.Clear();
            }
            else
            {
                mw1.tb71.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb72.Clear();
            }
            else
            {
                mw1.tb72.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb73.Clear();
            }
            else
            {
                mw1.tb73.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb74.Clear();
            }
            else
            {
                mw1.tb74.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb75.Clear();
            }
            else
            {
                mw1.tb75.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb76.Clear();
            }
            else
            {
                mw1.tb76.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb77.Clear();
            }
            else
            {
                mw1.tb77.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb78.Clear();
            }
            else
            {
                mw1.tb78.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb79.Clear();
            }
            else
            {
                mw1.tb79.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb80.Clear();
            }
            else
            {
                mw1.tb80.Text = _i.ToString();
            }
            Thread.Sleep(1);
            i = rn1.Next(1, 27);
            if (_i == 0)
            {
                mw1.tb81.Clear();
            }
            else
            {
                mw1.tb81.Text = _i.ToString();
            }
            Thread.Sleep(1);
        }
    }
}
