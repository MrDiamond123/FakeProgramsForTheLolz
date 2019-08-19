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

namespace FakeInstaller
{
    
    /// <summary>
    /// Interaction logic for LicenseConfirmWindow.xaml
    /// </summary>
    public partial class LicenseConfirmWindow : Window
    {
        public LicenseConfirmWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var installScreen = new InstallScreen();
            var checkLicence = new Licence(licenceKeyTextBox.Text, IDTextBox.Text, PINTextBox.Text).CheckLicenceValid();
            if (checkLicence)
            {
                MessageBox.Show("Licence Key: " + licenceKeyTextBox.Text + Environment.NewLine +
                           "ID: " + IDTextBox.Text + Environment.NewLine +
                           "Program Index Number: " + PINTextBox.Text + Environment.NewLine +
                           "All Vaild :D");

                this.Close();
                installScreen.Show();
            } else { MessageBox.Show("Info invalid please try again"); };
           

        }
    }
}
