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
    /// Logique d'interaction pour ViewPartenaires.xaml
    /// </summary>
    public partial class ViewPartenaires : UserControl
    {
        /// <summary>
        /// Contructeur de ViewPartenaires
        /// </summary>
        public ViewPartenaires()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouveau Partenaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Partenaire_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre
            WindowAddPartenaire windowAddPartenaire = new WindowAddPartenaire();
            /// nouvelle instance de ViewModelAddPartenaire à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddPartenaire.DataContext = new ViewModelAddPartenaires(((ViewModelPartenaires)this.DataContext).Entities);
            windowAddPartenaire.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un Partenaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_Partenaire_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPartenaires)this.DataContext).DeletePartenaire();
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du Partenaire sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Partenaire_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPartenaires)this.DataContext).SaveChanges();
        }
    }
}
