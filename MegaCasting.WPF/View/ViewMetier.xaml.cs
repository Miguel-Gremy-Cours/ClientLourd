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
    /// Logique d'interaction pour ViewMetier.xaml
    /// </summary>
    public partial class ViewMetier : UserControl
    { /// <summary>
      /// Contructeur de ViewMetier
      /// </summary>
        public ViewMetier()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouveau Metier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Metier_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddMetier windowAddMetier = new WindowAddMetier();
            /// nouvelle instance de ViewModelAddMetier à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddMetier.DataContext = new ViewModelAddMetier(((ViewModelMetier)this.DataContext).Entities);
            windowAddMetier.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un Metier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_Metier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelMetier)this.DataContext).DeleteMetier();

        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du Metier sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Metier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelMetier)this.DataContext).SaveChanges();
        }
    }
}
