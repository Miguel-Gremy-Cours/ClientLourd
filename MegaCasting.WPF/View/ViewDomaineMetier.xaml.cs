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
        public ViewDomaineMetier()
        {
            InitializeComponent();
        }

        private void _New_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            WindowAddDomaineMetier windowAddDomaineMetier = new WindowAddDomaineMetier();
            windowAddDomaineMetier.DataContext = new ViewModelAddDomaineMetier(((ViewModelDomaineMetier)this.DataContext).Entities);
            windowAddDomaineMetier.ShowDialog();
        }

        private void _Delete_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomaineMetier)this.DataContext).DeleteDomaineMetier();
        }

        private void _Save_DomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomaineMetier)this.DataContext).SaveChanges();
        }
    }
}
