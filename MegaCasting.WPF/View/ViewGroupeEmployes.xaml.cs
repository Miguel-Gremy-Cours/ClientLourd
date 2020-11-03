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
    {
        public ViewGroupeEmployes()
        {
            InitializeComponent();
        }

        private void _New_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {
            WindowAddGroupeEmploye windowAddGroupeEmploye = new WindowAddGroupeEmploye();
            windowAddGroupeEmploye.DataContext = new ViewModelAddGroupeEmployes(((ViewModelGroupeEmployes)this.DataContext).Entities);
            windowAddGroupeEmploye.ShowDialog();
        }

        private void _Delete_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelGroupeEmployes)this.DataContext).DeleteGropue();
        }

        private void _Save_GroupeEmploye_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelGroupeEmployes)this.DataContext).SaveChanges();
        }
    }
}
