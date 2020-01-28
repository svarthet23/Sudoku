using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sudoku
{
    /// <summary>
    /// Logika interakcji dla klasy Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
            Thread welcomethread = new Thread(WelcomeCloseTimer);
            welcomethread.Start();
        }
        private void WelcomeCloseTimer()
        {
            Thread.Sleep(2500);
            Dispatcher.Invoke(() =>
            {
                SystemCommands.CloseWindow(this);
            });          
        }
        public void WelcomeClose()
        {
            Dispatcher.Invoke(() =>
            {
                SystemCommands.CloseWindow(this);
            });
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                SystemCommands.CloseWindow(this);
            });
        }
    }
}
