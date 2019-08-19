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
using System.Windows.Shapes;

namespace FakeInstaller
{
    /// <summary>
    /// Interaction logic for InstallScreen.xaml
    /// </summary>
    public partial class InstallScreen : Window
    {

        public InstallScreen()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(InstallScreen_Loaded);
        }

        private void InstallScreen_Loaded(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            var completionWindow = new CompletionWindow();
            void closeAndShow()
            {
                this.Close();
                completionWindow.Show();
                Console.WriteLine("Installed Program: System Process: Cactus Complete");
            }

            Execute(closeAndShow, random.Next(10000,100000));

        }
        public async Task Execute(Action action, int timeoutInMilliseconds)
        {
            await Task.Delay(timeoutInMilliseconds);
            action();
        }


    }
}
