using MahApps.Metro.Controls;
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

namespace MegaCasting.WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour ConfirmationExit.xaml
    /// </summary>
    public partial class ConfirmationExit : MetroWindow
    {   /// <summary>
        /// nouvelle instance 
        /// </summary>
        public ConfirmationExit()
        {
            InitializeComponent();
        }
        
       /// <summary>
       /// /Boutton pour annuler l'action de fermeture de l'application
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void _Btn_Annulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boutton pour Confirmer l'action de fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_OK_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            
        }
    }
}
