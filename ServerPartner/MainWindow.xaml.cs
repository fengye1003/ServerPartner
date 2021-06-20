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
using System.Diagnostics;

namespace ServerPartner
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            welcome.Visibility = Visibility.Visible;
        }
        public static string UseCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/S /C " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true
            };

            var process = new Process { StartInfo = processInfo };
            process.Start();
            var outpup = process.StandardOutput.ReadToEnd();

            process.WaitForExit();
            return outpup;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StartRcon(object sender, RoutedEventArgs e)
        {
            welcome.Visibility = Visibility.Hidden;
            MenuPage.Visibility= Visibility.Hidden;
            RconPage.Visibility= Visibility.Visible;
            SettingPage.Visibility= Visibility.Hidden;
        }
    }
    
}
