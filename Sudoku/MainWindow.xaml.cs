using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading;

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
        }

        private void tb1_MouseMove(object sender, MouseEventArgs e)
        {
            tb1.Background = Brushes.LightGray;
        }
        private void tb1_MouseLeave(object sender, MouseEventArgs e)
        {
            tb1.Background = Brushes.Gray;
        }
        private void tb2_MouseMove(object sender, MouseEventArgs e)
        {
            tb2.Background = Brushes.LightGray;
        }
        private void tb2_MouseLeave(object sender, MouseEventArgs e)
        {
            tb2.Background = Brushes.Gray;
        }
        private void tb3_MouseMove(object sender, MouseEventArgs e)
        {
            tb3.Background = Brushes.LightGray;
        }
        private void tb3_MouseLeave(object sender, MouseEventArgs e)
        {
            tb3.Background = Brushes.Gray;
        }
        private void tb4_MouseMove(object sender, MouseEventArgs e)
        {
            tb4.Background = Brushes.LightGray;
        }
        private void tb4_MouseLeave(object sender, MouseEventArgs e)
        {
            tb4.Background = Brushes.Gray;
        }
        private void tb5_MouseMove(object sender, MouseEventArgs e)
        {
            tb5.Background = Brushes.LightGray;
        }
        private void tb5_MouseLeave(object sender, MouseEventArgs e)
        {
            tb5.Background = Brushes.Gray;
        }
        private void tb6_MouseMove(object sender, MouseEventArgs e)
        {
            tb6.Background = Brushes.LightGray;
        }
        private void tb6_MouseLeave(object sender, MouseEventArgs e)
        {
            tb6.Background = Brushes.Gray;
        }
        private void tb7_MouseMove(object sender, MouseEventArgs e)
        {
            tb7.Background = Brushes.LightGray;
        }
        private void tb7_MouseLeave(object sender, MouseEventArgs e)
        {
            tb7.Background = Brushes.Gray;
        }
        private void tb8_MouseMove(object sender, MouseEventArgs e)
        {
            tb8.Background = Brushes.LightGray;
        }
        private void tb8_MouseLeave(object sender, MouseEventArgs e)
        {
            tb8.Background = Brushes.Gray;
        }
        private void tb9_MouseMove(object sender, MouseEventArgs e)
        {
            tb9.Background = Brushes.LightGray;
        }
        private void tb9_MouseLeave(object sender, MouseEventArgs e)
        {
            tb9.Background = Brushes.Gray;
        }
        private void tb10_MouseMove(object sender, MouseEventArgs e)
        {
            tb10.Background = Brushes.LightGray;
        }
        private void tb10_MouseLeave(object sender, MouseEventArgs e)
        {
            tb10.Background = Brushes.Gray;
        }
        private void tb11_MouseMove(object sender, MouseEventArgs e)
        {
            tb11.Background = Brushes.LightGray;
        }
        private void tb11_MouseLeave(object sender, MouseEventArgs e)
        {
            tb11.Background = Brushes.Gray;
        }
        private void tb12_MouseMove(object sender, MouseEventArgs e)
        {
            tb12.Background = Brushes.LightGray;
        }
        private void tb12_MouseLeave(object sender, MouseEventArgs e)
        {
            tb12.Background = Brushes.Gray;
        }
        private void tb13_MouseMove(object sender, MouseEventArgs e)
        {
            tb13.Background = Brushes.LightGray;
        }
        private void tb13_MouseLeave(object sender, MouseEventArgs e)
        {
            tb13.Background = Brushes.Gray;
        }
        private void tb14_MouseMove(object sender, MouseEventArgs e)
        {
            tb14.Background = Brushes.LightGray;
        }
        private void tb14_MouseLeave(object sender, MouseEventArgs e)
        {
            tb14.Background = Brushes.Gray;
        }
        private void tb15_MouseMove(object sender, MouseEventArgs e)
        {
            tb15.Background = Brushes.LightGray;
        }
        private void tb15_MouseLeave(object sender, MouseEventArgs e)
        {
            tb15.Background = Brushes.Gray;
        }
        private void tb16_MouseMove(object sender, MouseEventArgs e)
        {
            tb16.Background = Brushes.LightGray;
        }
        private void tb16_MouseLeave(object sender, MouseEventArgs e)
        {
            tb16.Background = Brushes.Gray;
        }
        private void tb17_MouseMove(object sender, MouseEventArgs e)
        {
            tb17.Background = Brushes.LightGray;
        }
        private void tb17_MouseLeave(object sender, MouseEventArgs e)
        {
            tb17.Background = Brushes.Gray;
        }
        private void tb18_MouseMove(object sender, MouseEventArgs e)
        {
            tb18.Background = Brushes.LightGray;
        }
        private void tb18_MouseLeave(object sender, MouseEventArgs e)
        {
            tb18.Background = Brushes.Gray;
        }
        private void tb19_MouseMove(object sender, MouseEventArgs e)
        {
            tb19.Background = Brushes.LightGray;
        }
        private void tb19_MouseLeave(object sender, MouseEventArgs e)
        {
            tb19.Background = Brushes.Gray;
        }
        private void tb20_MouseMove(object sender, MouseEventArgs e)
        {
            tb20.Background = Brushes.LightGray;
        }
        private void tb20_MouseLeave(object sender, MouseEventArgs e)
        {
            tb20.Background = Brushes.Gray;
        }
        private void tb21_MouseMove(object sender, MouseEventArgs e)
        {
            tb21.Background = Brushes.LightGray;
        }
        private void tb21_MouseLeave(object sender, MouseEventArgs e)
        {
            tb21.Background = Brushes.Gray;
        }
        private void tb22_MouseMove(object sender, MouseEventArgs e)
        {
            tb22.Background = Brushes.LightGray;
        }
        private void tb22_MouseLeave(object sender, MouseEventArgs e)
        {
            tb22.Background = Brushes.Gray;
        }
        private void tb23_MouseMove(object sender, MouseEventArgs e)
        {
            tb23.Background = Brushes.LightGray;
        }
        private void tb23_MouseLeave(object sender, MouseEventArgs e)
        {
            tb23.Background = Brushes.Gray;
        }
        private void tb24_MouseMove(object sender, MouseEventArgs e)
        {
            tb24.Background = Brushes.LightGray;
        }
        private void tb24_MouseLeave(object sender, MouseEventArgs e)
        {
            tb24.Background = Brushes.Gray;
        }
        private void tb25_MouseMove(object sender, MouseEventArgs e)
        {
            tb25.Background = Brushes.LightGray;
        }
        private void tb25_MouseLeave(object sender, MouseEventArgs e)
        {
            tb25.Background = Brushes.Gray;
        }
        private void tb26_MouseMove(object sender, MouseEventArgs e)
        {
            tb26.Background = Brushes.LightGray;
        }
        private void tb26_MouseLeave(object sender, MouseEventArgs e)
        {
            tb26.Background = Brushes.Gray;
        }
        private void tb27_MouseMove(object sender, MouseEventArgs e)
        {
            tb27.Background = Brushes.LightGray;
        }
        private void tb27_MouseLeave(object sender, MouseEventArgs e)
        {
            tb27.Background = Brushes.Gray;
        }
        private void tb28_MouseMove(object sender, MouseEventArgs e)
        {
            tb28.Background = Brushes.LightGray;
        }
        private void tb28_MouseLeave(object sender, MouseEventArgs e)
        {
            tb28.Background = Brushes.Gray;
        }
        private void tb29_MouseMove(object sender, MouseEventArgs e)
        {
            tb29.Background = Brushes.LightGray;
        }
        private void tb29_MouseLeave(object sender, MouseEventArgs e)
        {
            tb29.Background = Brushes.Gray;
        }
        private void tb30_MouseMove(object sender, MouseEventArgs e)
        {
            tb30.Background = Brushes.LightGray;
        }
        private void tb30_MouseLeave(object sender, MouseEventArgs e)
        {
            tb30.Background = Brushes.Gray;
        }
        private void tb31_MouseMove(object sender, MouseEventArgs e)
        {
            tb31.Background = Brushes.LightGray;
        }
        private void tb31_MouseLeave(object sender, MouseEventArgs e)
        {
            tb31.Background = Brushes.Gray;
        }
        private void tb32_MouseMove(object sender, MouseEventArgs e)
        {
            tb32.Background = Brushes.LightGray;
        }
        private void tb32_MouseLeave(object sender, MouseEventArgs e)
        {
            tb32.Background = Brushes.Gray;
        }
        private void tb33_MouseMove(object sender, MouseEventArgs e)
        {
            tb33.Background = Brushes.LightGray;
        }
        private void tb33_MouseLeave(object sender, MouseEventArgs e)
        {
            tb33.Background = Brushes.Gray;
        }
        private void tb34_MouseMove(object sender, MouseEventArgs e)
        {
            tb34.Background = Brushes.LightGray;
        }
        private void tb34_MouseLeave(object sender, MouseEventArgs e)
        {
            tb34.Background = Brushes.Gray;
        }
        private void tb35_MouseMove(object sender, MouseEventArgs e)
        {
            tb35.Background = Brushes.LightGray;
        }
        private void tb35_MouseLeave(object sender, MouseEventArgs e)
        {
            tb35.Background = Brushes.Gray;
        }
        private void tb36_MouseMove(object sender, MouseEventArgs e)
        {
            tb36.Background = Brushes.LightGray;
        }
        private void tb36_MouseLeave(object sender, MouseEventArgs e)
        {
            tb36.Background = Brushes.Gray;
        }
        private void tb37_MouseMove(object sender, MouseEventArgs e)
        {
            tb37.Background = Brushes.LightGray;
        }
        private void tb37_MouseLeave(object sender, MouseEventArgs e)
        {
            tb37.Background = Brushes.Gray;
        }
        private void tb38_MouseMove(object sender, MouseEventArgs e)
        {
            tb38.Background = Brushes.LightGray;
        }
        private void tb38_MouseLeave(object sender, MouseEventArgs e)
        {
            tb38.Background = Brushes.Gray;
        }
        private void tb39_MouseMove(object sender, MouseEventArgs e)
        {
            tb39.Background = Brushes.LightGray;
        }
        private void tb39_MouseLeave(object sender, MouseEventArgs e)
        {
            tb39.Background = Brushes.Gray;
        }
        private void tb40_MouseMove(object sender, MouseEventArgs e)
        {
            tb40.Background = Brushes.LightGray;
        }
        private void tb40_MouseLeave(object sender, MouseEventArgs e)
        {
            tb40.Background = Brushes.Gray;
        }
        private void tb41_MouseMove(object sender, MouseEventArgs e)
        {
            tb41.Background = Brushes.LightGray;
        }
        private void tb41_MouseLeave(object sender, MouseEventArgs e)
        {
            tb41.Background = Brushes.Gray;
        }
        private void tb42_MouseMove(object sender, MouseEventArgs e)
        {
            tb42.Background = Brushes.LightGray;
        }
        private void tb42_MouseLeave(object sender, MouseEventArgs e)
        {
            tb42.Background = Brushes.Gray;
        }
        private void tb43_MouseMove(object sender, MouseEventArgs e)
        {
            tb43.Background = Brushes.LightGray;
        }
        private void tb43_MouseLeave(object sender, MouseEventArgs e)
        {
            tb43.Background = Brushes.Gray;
        }
        private void tb44_MouseMove(object sender, MouseEventArgs e)
        {
            tb44.Background = Brushes.LightGray;
        }
        private void tb44_MouseLeave(object sender, MouseEventArgs e)
        {
            tb44.Background = Brushes.Gray;
        }
        private void tb45_MouseMove(object sender, MouseEventArgs e)
        {
            tb45.Background = Brushes.LightGray;
        }
        private void tb45_MouseLeave(object sender, MouseEventArgs e)
        {
            tb45.Background = Brushes.Gray;
        }
        private void tb46_MouseMove(object sender, MouseEventArgs e)
        {
            tb46.Background = Brushes.LightGray;
        }
        private void tb46_MouseLeave(object sender, MouseEventArgs e)
        {
            tb46.Background = Brushes.Gray;
        }
        private void tb47_MouseMove(object sender, MouseEventArgs e)
        {
            tb47.Background = Brushes.LightGray;
        }
        private void tb47_MouseLeave(object sender, MouseEventArgs e)
        {
            tb47.Background = Brushes.Gray;
        }
        private void tb48_MouseMove(object sender, MouseEventArgs e)
        {
            tb48.Background = Brushes.LightGray;
        }
        private void tb48_MouseLeave(object sender, MouseEventArgs e)
        {
            tb48.Background = Brushes.Gray;
        }
        private void tb49_MouseMove(object sender, MouseEventArgs e)
        {
            tb49.Background = Brushes.LightGray;
        }
        private void tb49_MouseLeave(object sender, MouseEventArgs e)
        {
            tb49.Background = Brushes.Gray;
        }
        private void tb50_MouseMove(object sender, MouseEventArgs e)
        {
            tb50.Background = Brushes.LightGray;
        }
        private void tb50_MouseLeave(object sender, MouseEventArgs e)
        {
            tb50.Background = Brushes.Gray;
        }
        private void tb51_MouseMove(object sender, MouseEventArgs e)
        {
            tb51.Background = Brushes.LightGray;
        }
        private void tb51_MouseLeave(object sender, MouseEventArgs e)
        {
            tb51.Background = Brushes.Gray;
        }
        private void tb52_MouseMove(object sender, MouseEventArgs e)
        {
            tb52.Background = Brushes.LightGray;
        }
        private void tb52_MouseLeave(object sender, MouseEventArgs e)
        {
            tb52.Background = Brushes.Gray;
        }
        private void tb53_MouseMove(object sender, MouseEventArgs e)
        {
            tb53.Background = Brushes.LightGray;
        }
        private void tb53_MouseLeave(object sender, MouseEventArgs e)
        {
            tb53.Background = Brushes.Gray;
        }
        private void tb54_MouseMove(object sender, MouseEventArgs e)
        {
            tb54.Background = Brushes.LightGray;
        }
        private void tb54_MouseLeave(object sender, MouseEventArgs e)
        {
            tb54.Background = Brushes.Gray;
        }
        private void tb55_MouseMove(object sender, MouseEventArgs e)
        {
            tb55.Background = Brushes.LightGray;
        }
        private void tb55_MouseLeave(object sender, MouseEventArgs e)
        {
            tb55.Background = Brushes.Gray;
        }
        private void tb56_MouseMove(object sender, MouseEventArgs e)
        {
            tb56.Background = Brushes.LightGray;
        }
        private void tb56_MouseLeave(object sender, MouseEventArgs e)
        {
            tb56.Background = Brushes.Gray;
        }
        private void tb57_MouseMove(object sender, MouseEventArgs e)
        {
            tb57.Background = Brushes.LightGray;
        }
        private void tb57_MouseLeave(object sender, MouseEventArgs e)
        {
            tb57.Background = Brushes.Gray;
        }
        private void tb58_MouseMove(object sender, MouseEventArgs e)
        {
            tb58.Background = Brushes.LightGray;
        }
        private void tb58_MouseLeave(object sender, MouseEventArgs e)
        {
            tb58.Background = Brushes.Gray;
        }
        private void tb59_MouseMove(object sender, MouseEventArgs e)
        {
            tb59.Background = Brushes.LightGray;
        }
        private void tb59_MouseLeave(object sender, MouseEventArgs e)
        {
            tb59.Background = Brushes.Gray;
        }
        private void tb60_MouseMove(object sender, MouseEventArgs e)
        {
            tb60.Background = Brushes.LightGray;
        }
        private void tb60_MouseLeave(object sender, MouseEventArgs e)
        {
            tb60.Background = Brushes.Gray;
        }
        private void tb61_MouseMove(object sender, MouseEventArgs e)
        {
            tb61.Background = Brushes.LightGray;
        }
        private void tb61_MouseLeave(object sender, MouseEventArgs e)
        {
            tb61.Background = Brushes.Gray;
        }
        private void tb62_MouseMove(object sender, MouseEventArgs e)
        {
            tb62.Background = Brushes.LightGray;
        }
        private void tb62_MouseLeave(object sender, MouseEventArgs e)
        {
            tb62.Background = Brushes.Gray;
        }
        private void tb63_MouseMove(object sender, MouseEventArgs e)
        {
            tb63.Background = Brushes.LightGray;
        }
        private void tb63_MouseLeave(object sender, MouseEventArgs e)
        {
            tb63.Background = Brushes.Gray;
        }
        private void tb64_MouseMove(object sender, MouseEventArgs e)
        {
            tb64.Background = Brushes.LightGray;
        }
        private void tb64_MouseLeave(object sender, MouseEventArgs e)
        {
            tb64.Background = Brushes.Gray;
        }
        private void tb65_MouseMove(object sender, MouseEventArgs e)
        {
            tb65.Background = Brushes.LightGray;
        }
        private void tb65_MouseLeave(object sender, MouseEventArgs e)
        {
            tb65.Background = Brushes.Gray;
        }
        private void tb66_MouseMove(object sender, MouseEventArgs e)
        {
            tb66.Background = Brushes.LightGray;
        }
        private void tb66_MouseLeave(object sender, MouseEventArgs e)
        {
            tb66.Background = Brushes.Gray;
        }
        private void tb67_MouseMove(object sender, MouseEventArgs e)
        {
            tb67.Background = Brushes.LightGray;
        }
        private void tb67_MouseLeave(object sender, MouseEventArgs e)
        {
            tb67.Background = Brushes.Gray;
        }
        private void tb68_MouseMove(object sender, MouseEventArgs e)
        {
            tb68.Background = Brushes.LightGray;
        }
        private void tb68_MouseLeave(object sender, MouseEventArgs e)
        {
            tb68.Background = Brushes.Gray;
        }
        private void tb69_MouseMove(object sender, MouseEventArgs e)
        {
            tb69.Background = Brushes.LightGray;
        }
        private void tb69_MouseLeave(object sender, MouseEventArgs e)
        {
            tb69.Background = Brushes.Gray;
        }
        private void tb70_MouseMove(object sender, MouseEventArgs e)
        {
            tb70.Background = Brushes.LightGray;
        }
        private void tb70_MouseLeave(object sender, MouseEventArgs e)
        {
            tb70.Background = Brushes.Gray;
        }
        private void tb71_MouseMove(object sender, MouseEventArgs e)
        {
            tb71.Background = Brushes.LightGray;
        }
        private void tb71_MouseLeave(object sender, MouseEventArgs e)
        {
            tb71.Background = Brushes.Gray;
        }
        private void tb72_MouseMove(object sender, MouseEventArgs e)
        {
            tb72.Background = Brushes.LightGray;
        }
        private void tb72_MouseLeave(object sender, MouseEventArgs e)
        {
            tb72.Background = Brushes.Gray;
        }
        private void tb73_MouseMove(object sender, MouseEventArgs e)
        {
            tb73.Background = Brushes.LightGray;
        }
        private void tb73_MouseLeave(object sender, MouseEventArgs e)
        {
            tb73.Background = Brushes.Gray;
        }
        private void tb74_MouseMove(object sender, MouseEventArgs e)
        {
            tb74.Background = Brushes.LightGray;
        }
        private void tb74_MouseLeave(object sender, MouseEventArgs e)
        {
            tb74.Background = Brushes.Gray;
        }
        private void tb75_MouseMove(object sender, MouseEventArgs e)
        {
            tb75.Background = Brushes.LightGray;
        }
        private void tb75_MouseLeave(object sender, MouseEventArgs e)
        {
            tb75.Background = Brushes.Gray;
        }
        private void tb76_MouseMove(object sender, MouseEventArgs e)
        {
            tb76.Background = Brushes.LightGray;
        }
        private void tb76_MouseLeave(object sender, MouseEventArgs e)
        {
            tb76.Background = Brushes.Gray;
        }
        private void tb77_MouseMove(object sender, MouseEventArgs e)
        {
            tb77.Background = Brushes.LightGray;
        }
        private void tb77_MouseLeave(object sender, MouseEventArgs e)
        {
            tb77.Background = Brushes.Gray;
        }
        private void tb78_MouseMove(object sender, MouseEventArgs e)
        {
            tb78.Background = Brushes.LightGray;
        }
        private void tb78_MouseLeave(object sender, MouseEventArgs e)
        {
            tb78.Background = Brushes.Gray;
        }
        private void tb79_MouseMove(object sender, MouseEventArgs e)
        {
            tb79.Background = Brushes.LightGray;
        }
        private void tb79_MouseLeave(object sender, MouseEventArgs e)
        {
            tb79.Background = Brushes.Gray;
        }
        private void tb80_MouseMove(object sender, MouseEventArgs e)
        {
            tb80.Background = Brushes.LightGray;
        }
        private void tb80_MouseLeave(object sender, MouseEventArgs e)
        {
            tb80.Background = Brushes.Gray;
        }
        private void tb81_MouseMove(object sender, MouseEventArgs e)
        {
            tb81.Background = Brushes.LightGray;
        }
        private void tb81_MouseLeave(object sender, MouseEventArgs e)
        {
            tb81.Background = Brushes.Gray;
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

        private ushort diff = 1;

        private void bStart_Click(object sender, RoutedEventArgs e)
        {
            Create.Start(diff);            
            bStart.Content = "Restart";
        }

        private void difficultySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            if (difficultySlider.Value == 1)
            {
                difficultyLabel.Content = "Łatwy";
                diff = 20;
            }
            else if (difficultySlider.Value == 2)
            {
                difficultyLabel.Content = "Średni";
                diff = 30;
            }
            else
            {
                difficultyLabel.Content = "Trudny";
                diff = 50;
            }
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
    }
}