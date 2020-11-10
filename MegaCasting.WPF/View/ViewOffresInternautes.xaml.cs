using MegaCasting.WPF.ViewModel;
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
    /// Logique d'interaction pour ViewOffresInternautes.xaml
    /// </summary>
    public partial class ViewOffresInternautes : UserControl
    {
        /// <summary>
        /// Contructeur de ViewDomaineMetier
        /// </summary>
        public ViewOffresInternautes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du OffreInternaute sélectionnée dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Changes_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffresInternautes)this.DataContext).SaveChanges();
        }
    }
}
