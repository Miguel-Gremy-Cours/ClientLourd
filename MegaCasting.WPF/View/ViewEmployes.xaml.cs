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
    /// Logique d'interaction pour ViewEmployes.xaml
    /// </summary>
    public partial class ViewEmployes : UserControl
    {/// <summary>
     /// Contructeur de ViewEmploye
     /// </summary>
        public ViewEmployes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton qui rappelle la fenêtre pour ajouter nouvel employe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Employe_Click(object sender, RoutedEventArgs e)
        {/// nouvelle instance de la fenêtre 
            WindowAddEmploye windowAddEmploye = new WindowAddEmploye();
            /// nouvelle instance de ViewModelAddEmployes à partir de Entities de BDD, puis affecter à dataContext de cette fénêtre.
            windowAddEmploye.DataContext = new ViewModelAddEmployes(((ViewModelEmployes)this.DataContext).Entities);
            windowAddEmploye.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un Employe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmployes)this.DataContext).DeleteEmploye();
        }
        /// <summary>
        /// Boutton pou sauvegarder les modifications effectuées du Employe sélectionné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Save_Employe_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmployes)this.DataContext).SaveChanges();
        }
    }
}
