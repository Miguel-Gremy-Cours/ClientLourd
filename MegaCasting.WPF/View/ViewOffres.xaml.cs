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
    /// Logique d'interaction pour ViewOffres.xaml
    /// </summary>
    public partial class ViewOffres : UserControl
    {/// <summary>
     /// Contructeur de ViewOffre
     /// </summary>
        public ViewOffres()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour rappelle la fenêtre pour ajouter un nouvelle Offre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Offre_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddOffre windowAddOffre = new WindowAddOffre();
            /// nouvelle instance de ViewModelAddOffre à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddOffre.DataContext = new ViewModelAddOffres(((ViewModelOffres)this.DataContext).Entities);
            windowAddOffre.ShowDialog();

        }
        /// <summary>
        /// Boutton pour supprimer une Offre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffres)this.DataContext).DeleteOffre();

        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées de l'Offre sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Offre_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffres)this.DataContext).SaveChanges();
        }
    }
}
