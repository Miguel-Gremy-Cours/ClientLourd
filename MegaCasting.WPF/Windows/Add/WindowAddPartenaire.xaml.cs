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
    /// Logique d'interaction pour WindowAddPartenaire.xaml
    /// </summary>
    public partial class WindowAddPartenaire : MetroWindow
    {
        public WindowAddPartenaire()
        {
            InitializeComponent();
        }

        private void _Btn_Annulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAddPartenaires)this.DataContext).InsertPartenaire(_TextBox_Siret.Text, _TextBox_Adresse.Text, Convert.ToInt32(_TextBox_NumeroAdresse.Text), _TextBox_Libelle.Text, _TextBox_Email.Text, _TextBox_Telephone.Text, _TextBox_Login.Text, _TextBox_Password.Text);
            this.Close();
        }
    }
}
