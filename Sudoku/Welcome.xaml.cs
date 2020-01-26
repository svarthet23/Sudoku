using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sudoku
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
            Thread welcomethread = new Thread(WelcomeClose);
            welcomethread.Start();
        }
        private void WelcomeClose()
        {
            Thread.Sleep(2500);
            Dispatcher.Invoke(() =>
            {
                SystemCommands.CloseWindow(this);
            });
           
        }
    }
}
