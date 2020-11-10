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
    /// Logique d'interaction pour ViewStudios.xaml
    /// </summary>
    public partial class ViewStudios : UserControl
    {
        /// <summary>
        /// Contructeur de ViewStudios
        /// </summary>
        public ViewStudios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouveau Studio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Studio_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddStudio windowAddStudio = new WindowAddStudio();
            /// nouvelle instance de ViewModelAddSudios à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddStudio.DataContext = new ViewModelAddSudios(((ViewModelStudios)this.DataContext).Entities);
            windowAddStudio.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un Studio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_Studio_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelStudios)this.DataContext).DeleteStudio();
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du Studio sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Studio_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelStudios)this.DataContext).SaveChanges();
        }
    }
}
