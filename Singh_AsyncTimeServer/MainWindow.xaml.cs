using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Singh_SocketAsyncLib;
namespace Singh_AsyncTimeServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    public partial class MainWindow : Window
    {
        AsyncSocketServer mServer;
        public MainWindow()
        {
            InitializeComponent();
            mServer = new AsyncSocketServer();
            Icon_refersh.Visibility = Visibility.Hidden;
        }

        private void btn_ascolto_Click(object sender, RoutedEventArgs e)
        {
            mServer.InAscolto();
            btn_ascolto.IsEnabled = false;
            btn_Disconetti.IsEnabled = true;

            Icon_refersh.Spin = true;
            Icon_refersh.Visibility = Visibility.Visible;

        }

        private void btn_Disconetti_Click(object sender, RoutedEventArgs e)
        {
            mServer.Disconnetti();
        }

        

    }
}
