using MegaCasting.WPF.ViewModel;
using MaterialDesignThemes.Wpf;
using MegaCasting.DBLib;
using MegaCasting.WPF.Windows.Add;
using MegaCasting.WPF.ViewModel.Add;
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
    /// Logique d'interaction pour ViewContrat.xaml
    /// </summary>
    public partial class ViewContrat : UserControl
    {
        /// <summary>
        /// Contructeur de ViewContrat
        /// </summary>
        public ViewContrat()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton qui rappelle la fenêtre pour ajouter nouveau contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _New_Contrat_Click(object sender, RoutedEventArgs e)
        {//nouvelle instance de WindowAddContrat
            WindowAddContrat WindowAddContrat = new WindowAddContrat();


            WindowAddContrat.DataContext = new ViewModelAddContrat(((ViewModelContrat)this.DataContext).Entities);
            WindowAddContrat.ShowDialog();
        }
        /// <summary>
        /// Boutton pour supprimer un contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Delete_Contrat_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContrat)this.DataContext).DeleteContrat();
        }
        /// <summary>
        /// boutton pour sauvegarder les modifications effectuées du contrat sélectioné dans la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _Save_Contrat_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContrat)this.DataContext).SaveChanges();
        }

    }
}
