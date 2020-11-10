using MegaCasting.WPF.Windows;
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

namespace MegaCasting.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewMain.xaml
    /// </summary>
    public partial class ViewMain : UserControl
    {
        /// <summary>
        /// Contructeur de ViewMain
        /// </summary>
        public ViewMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boutton pour se connecter à la session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Logout_Click(object sender, RoutedEventArgs e)
        {

            Connexion connexion = new Connexion();
            connexion.Show();
            var window = Window.GetWindow(this);
            window.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Boutton pour aller sur le Client léger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Site_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
