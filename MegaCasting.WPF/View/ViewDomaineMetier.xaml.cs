using MegaCasting.WPF.ViewModel;
using MegaCasting.WPF.ViewModel.Add;
using MegaCasting.WPF.Windows.Add;
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
    /// Logique d'interaction pour ViewDomaineMetier.xaml
    /// </summary>
    public partial class ViewDomaineMetier : UserControl
    {
        /// <summary>
        /// Contructeur de ViewDomaineMetier
        /// </summary>
        public ViewDomaineMetier()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouveau DomaineMetier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddDomaineMetier windowAddDomaineMetier = new WindowAddDomaineMetier();
            /// nouvelle instance de ViewModelAddDomaineMetier à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddDomaineMetier.DataContext = new ViewModelAddDomaineMetier(((ViewModelDomaineMetier)this.DataContext).Entities);
            windowAddDomaineMetier.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un DomaineMetier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomaineMetier)this.DataContext).DeleteDomaineMetier();
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du DomaineMetier sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomaineMetier)this.DataContext).SaveChanges();
        }
    }
}
