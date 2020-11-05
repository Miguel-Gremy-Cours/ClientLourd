using MahApps.Metro.Controls;
using MegaCasting.WPF.ViewModel.Add;
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

namespace MegaCasting.WPF.Windows.Add
{
    /// <summary>
    /// Logique d'interaction pour WindowAddEmploye.xaml
    /// </summary>
    public partial class WindowAddEmploye : MetroWindow
    {
        public WindowAddEmploye()
        {
            InitializeComponent();
        }

        private void _Btn_Annulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAddEmployes)this.DataContext).InsertEmploye(_TextBox_Nom.Text, _TextBox_Prenom.Text, _TextBox_Login.Text, _TextBox_Password.Text);
            this.Close();
        }
    }
}
