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
    /// Logique d'interaction pour ViewGroupeEmployes.xaml
    /// </summary>
    public partial class ViewGroupeEmployes : UserControl
    {/// <summary>
     /// Contructeur de ViewGroupeEmployes
     /// </summary>
        public ViewGroupeEmployes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouveau GroupeEmploye
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddGroupeEmploye windowAddGroupeEmploye = new WindowAddGroupeEmploye();
            /// nouvelle instance de WindowAddGroupeEmploye à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddGroupeEmploye.DataContext = new ViewModelAddGroupeEmployes(((ViewModelGroupeEmployes)this.DataContext).Entities);
            windowAddGroupeEmploye.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un GroupeEmploye
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelGroupeEmployes)this.DataContext).DeleteGropue(); //Ne peut pas s'exécuter lorsque le groupe contient 
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du GroupeEmploye sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelGroupeEmployes)this.DataContext).SaveChanges();
        }
    }
}
