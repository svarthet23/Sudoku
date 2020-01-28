using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Sudoku
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Welcome welcome = new Welcome();
            welcome.Topmost = true;
        }

        private void tb_MouseMove(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Background = Brushes.DarkGray;
        }
        private void tb_MouseLeave(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Background = Brushes.Gray;
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tb1_GotFocus(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column1();
        }
        private void tb2_GotFocus(object sender, RoutedEventArgs e)
        {
            tb2.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column2();
        }
        private void tb3_GotFocus(object sender, RoutedEventArgs e)
        {
            tb3.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column3();
        }
        private void tb4_GotFocus(object sender, RoutedEventArgs e)
        {
            tb4.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column4();
        }
        private void tb5_GotFocus(object sender, RoutedEventArgs e)
        {
            tb5.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column5();
        }
        private void tb6_GotFocus(object sender, RoutedEventArgs e)
        {
            tb6.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column6();
        }
        private void tb7_GotFocus(object sender, RoutedEventArgs e)
        {
            tb7.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column7();
        }
        private void tb8_GotFocus(object sender, RoutedEventArgs e)
        {
            tb8.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column8();
        }
        private void tb9_GotFocus(object sender, RoutedEventArgs e)
        {
            tb9.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column9();
        }
        private void tb10_GotFocus(object sender, RoutedEventArgs e)
        {
            tb10.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column1();
        }
        private void tb11_GotFocus(object sender, RoutedEventArgs e)
        {
            tb11.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column2();
        }
        private void tb12_GotFocus(object sender, RoutedEventArgs e)
        {
            tb12.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column3();
        }
        private void tb13_GotFocus(object sender, RoutedEventArgs e)
        {
            tb13.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column4();
        }
        private void tb14_GotFocus(object sender, RoutedEventArgs e)
        {
            tb14.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column5();
        }
        private void tb15_GotFocus(object sender, RoutedEventArgs e)
        {
            tb15.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column6();
        }
        private void tb16_GotFocus(object sender, RoutedEventArgs e)
        {
            tb16.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column7();
        }
        private void tb17_GotFocus(object sender, RoutedEventArgs e)
        {
            tb17.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column8();
        }
        private void tb18_GotFocus(object sender, RoutedEventArgs e)
        {
            tb18.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column9();
        }
        private void tb19_GotFocus(object sender, RoutedEventArgs e)
        {
            tb19.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column1();
        }
        private void tb20_GotFocus(object sender, RoutedEventArgs e)
        {
            tb20.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column2();
        }
        private void tb21_GotFocus(object sender, RoutedEventArgs e)
        {
            tb21.Clear();
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column3();
        }
        private void tb22_GotFocus(object sender, RoutedEventArgs e)
        {
            tb22.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column4();
        }
        private void tb23_GotFocus(object sender, RoutedEventArgs e)
        {
            tb23.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column5();
        }
        private void tb24_GotFocus(object sender, RoutedEventArgs e)
        {
            tb24.Clear();
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column6();
        }
        private void tb25_GotFocus(object sender, RoutedEventArgs e)
        {
            tb25.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column7();
        }
        private void tb26_GotFocus(object sender, RoutedEventArgs e)
        {
            tb26.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column8();
        }
        private void tb27_GotFocus(object sender, RoutedEventArgs e)
        {
            tb27.Clear();
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column9();
        }
        private void tb28_GotFocus(object sender, RoutedEventArgs e)
        {
            tb28.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column1();
        }
        private void tb29_GotFocus(object sender, RoutedEventArgs e)
        {
            tb29.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column2();
        }
        private void tb30_GotFocus(object sender, RoutedEventArgs e)
        {
            tb30.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column3();
        }
        private void tb31_GotFocus(object sender, RoutedEventArgs e)
        {
            tb31.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column4();
        }
        private void tb32_GotFocus(object sender, RoutedEventArgs e)
        {
            tb32.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column5();
        }
        private void tb33_GotFocus(object sender, RoutedEventArgs e)
        {
            tb33.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column6();
        }
        private void tb34_GotFocus(object sender, RoutedEventArgs e)
        {
            tb34.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column7();
        }
        private void tb35_GotFocus(object sender, RoutedEventArgs e)
        {
            tb35.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column8();
        }
        private void tb36_GotFocus(object sender, RoutedEventArgs e)
        {
            tb36.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column9();
        }
        private void tb37_GotFocus(object sender, RoutedEventArgs e)
        {
            tb37.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column1();
        }
        private void tb38_GotFocus(object sender, RoutedEventArgs e)
        {
            tb38.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column2();
        }
        private void tb39_GotFocus(object sender, RoutedEventArgs e)
        {
            tb39.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column3();
        }
        private void tb40_GotFocus(object sender, RoutedEventArgs e)
        {
            tb40.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column4();
        }
        private void tb41_GotFocus(object sender, RoutedEventArgs e)
        {
            tb41.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column5();
        }
        private void tb42_GotFocus(object sender, RoutedEventArgs e)
        {
            tb42.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column6();
        }
        private void tb43_GotFocus(object sender, RoutedEventArgs e)
        {
            tb43.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column7();
        }
        private void tb44_GotFocus(object sender, RoutedEventArgs e)
        {
            tb44.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column8();
        }
        private void tb45_GotFocus(object sender, RoutedEventArgs e)
        {
            tb45.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column9();
        }
        private void tb46_GotFocus(object sender, RoutedEventArgs e)
        {
            tb46.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column1();
        }
        private void tb47_GotFocus(object sender, RoutedEventArgs e)
        {
            tb47.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column2();
        }
        private void tb48_GotFocus(object sender, RoutedEventArgs e)
        {
            tb48.Clear();
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column3();
        }
        private void tb49_GotFocus(object sender, RoutedEventArgs e)
        {
            tb49.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column4();
        }
        private void tb50_GotFocus(object sender, RoutedEventArgs e)
        {
            tb50.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column5();
        }
        private void tb51_GotFocus(object sender, RoutedEventArgs e)
        {
            tb51.Clear();
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column6();
        }
        private void tb52_GotFocus(object sender, RoutedEventArgs e)
        {
            tb52.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column7();
        }
        private void tb53_GotFocus(object sender, RoutedEventArgs e)
        {
            tb53.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column8();
        }
        private void tb54_GotFocus(object sender, RoutedEventArgs e)
        {
            tb54.Clear();
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column9();
        }
        private void tb55_GotFocus(object sender, RoutedEventArgs e)
        {
            tb55.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column1();
        }
        private void tb56_GotFocus(object sender, RoutedEventArgs e)
        {
            tb56.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column2();
        }
        private void tb57_GotFocus(object sender, RoutedEventArgs e)
        {
            tb57.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column3();
        }
        private void tb58_GotFocus(object sender, RoutedEventArgs e)
        {
            tb58.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column4();
        }
        private void tb59_GotFocus(object sender, RoutedEventArgs e)
        {
            tb59.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column5();
        }
        private void tb60_GotFocus(object sender, RoutedEventArgs e)
        {
            tb60.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column6();
        }
        private void tb61_GotFocus(object sender, RoutedEventArgs e)
        {
            tb61.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column7();
        }
        private void tb62_GotFocus(object sender, RoutedEventArgs e)
        {
            tb62.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column8();
        }
        private void tb63_GotFocus(object sender, RoutedEventArgs e)
        {
            tb63.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column9();
        }
        private void tb64_GotFocus(object sender, RoutedEventArgs e)
        {
            tb64.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column1();
        }
        private void tb65_GotFocus(object sender, RoutedEventArgs e)
        {
            tb65.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column2();
        }
        private void tb66_GotFocus(object sender, RoutedEventArgs e)
        {
            tb66.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column3();
        }
        private void tb67_GotFocus(object sender, RoutedEventArgs e)
        {
            tb67.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column4();
        }
        private void tb68_GotFocus(object sender, RoutedEventArgs e)
        {
            tb68.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column5();
        }
        private void tb69_GotFocus(object sender, RoutedEventArgs e)
        {
            tb69.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column6();
        }
        private void tb70_GotFocus(object sender, RoutedEventArgs e)
        {
            tb70.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column7();
        }
        private void tb71_GotFocus(object sender, RoutedEventArgs e)
        {
            tb71.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column8();
        }
        private void tb72_GotFocus(object sender, RoutedEventArgs e)
        {
            tb72.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column9();
        }
        private void tb73_GotFocus(object sender, RoutedEventArgs e)
        {
            tb73.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column1();
        }
        private void tb74_GotFocus(object sender, RoutedEventArgs e)
        {
            tb74.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column2();
        }
        private void tb75_GotFocus(object sender, RoutedEventArgs e)
        {
            tb75.Clear();
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column3();
        }
        private void tb76_GotFocus(object sender, RoutedEventArgs e)
        {
            tb76.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column4();
        }
        private void tb77_GotFocus(object sender, RoutedEventArgs e)
        {
            tb77.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column5();
        }
        private void tb78_GotFocus(object sender, RoutedEventArgs e)
        {
            tb78.Clear();
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column6();
        }
        private void tb79_GotFocus(object sender, RoutedEventArgs e)
        {
            tb79.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column7();
        }
        private void tb80_GotFocus(object sender, RoutedEventArgs e)
        {
            tb80.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column8();
        }
        private void tb81_GotFocus(object sender, RoutedEventArgs e)
        {
            tb81.Clear();
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column9();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column1();
        }
        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column2();
        }
        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column3();
        }
        private void tb4_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column4();
        }
        private void tb5_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column5();
        }
        private void tb6_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column6();
        }
        private void tb7_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column7();
        }
        private void tb8_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column8();
        }
        private void tb9_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column9();
        }
        private void tb10_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column1();
        }
        private void tb11_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column2();
        }
        private void tb12_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column3();
        }
        private void tb13_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column4();
        }
        private void tb14_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column5();
        }
        private void tb15_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column6();
        }
        private void tb16_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column7();
        }
        private void tb17_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column8();
        }
        private void tb18_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column9();
        }
        private void tb19_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column1();
        }
        private void tb20_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column2();
        }
        private void tb21_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column3();
        }
        private void tb22_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column4();
        }
        private void tb23_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column5();
        }
        private void tb24_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column6();
        }
        private void tb25_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column7();
        }
        private void tb26_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column8();
        }
        private void tb27_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column9();
        }
        private void tb28_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column1();
        }
        private void tb29_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column2();
        }
        private void tb30_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column3();
        }
        private void tb31_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column4();
        }
        private void tb32_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column5();
        }
        private void tb33_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column6();
        }
        private void tb34_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column7();
        }
        private void tb35_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column8();
        }
        private void tb36_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column9();
        }
        private void tb37_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column1();
        }
        private void tb38_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column2();
        }
        private void tb39_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column3();
        }
        private void tb40_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column4();
        }
        private void tb41_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column5();
        }
        private void tb42_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column6();
        }
        private void tb43_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column7();
        }
        private void tb44_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column8();
        }
        private void tb45_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column9();
        }
        private void tb46_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column1();
        }
        private void tb47_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column2();
        }
        private void tb48_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column3();
        }
        private void tb49_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column4();
        }
        private void tb50_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column5();
        }
        private void tb51_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column6();
        }
        private void tb52_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column7();
        }
        private void tb53_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column8();
        }
        private void tb54_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column9();
        }
        private void tb55_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column1();
        }
        private void tb56_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column2();
        }
        private void tb57_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column3();
        }
        private void tb58_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column4();
        }
        private void tb59_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column5();
        }
        private void tb60_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column6();
        }
        private void tb61_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column7();
        }
        private void tb62_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column8();
        }
        private void tb63_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column9();
        }
        private void tb64_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column1();
        }
        private void tb65_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column2();
        }
        private void tb66_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column3();
        }
        private void tb67_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column4();
        }
        private void tb68_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column5();
        }
        private void tb69_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column6();
        }
        private void tb70_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column7();
        }
        private void tb71_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column8();
        }
        private void tb72_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column9();
        }
        private void tb73_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column1();
        }
        private void tb74_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column2();
        }
        private void tb75_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column3();
        }
        private void tb76_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column4();
        }
        private void tb77_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column5();
        }
        private void tb78_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column6();
        }
        private void tb79_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column7();
        }
        private void tb80_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column8();
        }
        private void tb81_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column9();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void tb1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column1();
        }

        private void tb2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column2();
        }
        private void tb3_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column3();
        }
        private void tb4_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column4();
        }
        private void tb5_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column5();
        }
        private void tb6_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column6();
        }
        private void tb7_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column7();
        }
        private void tb8_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column8();
        }
        private void tb9_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row1();
            ColumnsAlgorithm.column9();
        }
        private void tb10_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column1();
        }
        private void tb11_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column2();
        }
        private void tb12_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column3();
        }
        private void tb13_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column4();
        }
        private void tb14_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column5();
        }
        private void tb15_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column6();
        }
        private void tb16_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column7();
        }
        private void tb17_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column8();
        }
        private void tb18_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row2();
            ColumnsAlgorithm.column9();
        }
        private void tb19_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column1();
        }
        private void tb20_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column2();
        }
        private void tb21_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board1();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column3();
        }
        private void tb22_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column4();
        }
        private void tb23_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column5();
        }
        private void tb24_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board2();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column6();
        }
        private void tb25_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column7();
        }
        private void tb26_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column8();
        }
        private void tb27_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board3();
            RowsAlgorithm.row3();
            ColumnsAlgorithm.column9();
        }
        private void tb28_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column1();
        }
        private void tb29_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column2();
        }
        private void tb30_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column3();
        }
        private void tb31_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column4();
        }
        private void tb32_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column5();
        }
        private void tb33_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column6();
        }
        private void tb34_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column7();
        }
        private void tb35_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column8();
        }
        private void tb36_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row4();
            ColumnsAlgorithm.column9();
        }
        private void tb37_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column1();
        }
        private void tb38_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column2();
        }
        private void tb39_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column3();
        }
        private void tb40_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column4();
        }
        private void tb41_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column5();
        }
        private void tb42_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column6();
        }
        private void tb43_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column7();
        }
        private void tb44_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column8();
        }
        private void tb45_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row5();
            ColumnsAlgorithm.column9();
        }
        private void tb46_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column1();
        }
        private void tb47_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column2();
        }
        private void tb48_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board4();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column3();
        }
        private void tb49_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column4();
        }
        private void tb50_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column5();
        }
        private void tb51_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board5();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column6();
        }
        private void tb52_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column7();
        }
        private void tb53_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column8();
        }
        private void tb54_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board6();
            RowsAlgorithm.row6();
            ColumnsAlgorithm.column9();
        }
        private void tb55_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column1();
        }
        private void tb56_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column2();
        }
        private void tb57_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column3();
        }
        private void tb58_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column4();
        }
        private void tb59_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column5();
        }
        private void tb60_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column6();
        }
        private void tb61_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column7();
        }
        private void tb62_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column8();
        }
        private void tb63_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row7();
            ColumnsAlgorithm.column9();
        }
        private void tb64_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column1();
        }
        private void tb65_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column2();
        }
        private void tb66_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column3();
        }
        private void tb67_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column4();
        }
        private void tb68_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column5();
        }
        private void tb69_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column6();
        }
        private void tb70_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column7();
        }
        private void tb71_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column8();
        }
        private void tb72_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row8();
            ColumnsAlgorithm.column9();
        }
        private void tb73_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column1();
        }
        private void tb74_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column2();
        }
        private void tb75_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board7();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column3();
        }
        private void tb76_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column4();
        }
        private void tb77_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column5();
        }
        private void tb78_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board8();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column6();
        }
        private void tb79_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column7();
        }
        private void tb80_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column8();
        }
        private void tb81_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BoardsAlgorithm.board9();
            RowsAlgorithm.row9();
            ColumnsAlgorithm.column9();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private ushort diffgene = 1;
        private ushort diffgame = 1;

        private void bStart_Click(object sender, RoutedEventArgs e)
        {
            Game.Start(diffgame);
            bStart.Content = "ReStart";
        }      
        private void bGenerate_Click(object sender, RoutedEventArgs e)
        {
            Generator.done = false;
            Generator.Start(diffgene);
            bGenerate.Content = "ReGenerate";
        }

        private void difficultySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (difficultySlider.Value == 1)
            {
                difficultyLabel.Content = "Łatwy";
                diffgene = 18;
                diffgame = 50;
            }
            else if (difficultySlider.Value == 2)
            {
                difficultyLabel.Content = "Średni";
                diffgene = 23;
                diffgame = 65;
            }
            else
            {
                difficultyLabel.Content = "Trudny";
                diffgene = 40;
                diffgame = 80;  
            }
        }
    }
}