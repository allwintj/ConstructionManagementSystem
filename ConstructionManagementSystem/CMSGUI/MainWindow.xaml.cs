using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMSGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SiteBrowser sb = new SiteBrowser();
            sb.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WorkerBrowser wb = new WorkerBrowser();
            wb.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BillingWindow bw = new BillingWindow();
            bw.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InstrumentsWindow inw = new InstrumentsWindow();
            inw.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RawMaterialWindow rmw = new RawMaterialWindow();
            rmw.ShowDialog();
        }
    }
}
