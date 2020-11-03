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
    {
        public ViewMetier()
        {
            InitializeComponent();
        }

        private void _New_Metier_Click(object sender, RoutedEventArgs e)
        {
            WindowAddMetier windowAddMetier = new WindowAddMetier();
            windowAddMetier.DataContext = new ViewModelAddMetier(((ViewModelMetier)this.DataContext).Entities);
            windowAddMetier.ShowDialog();
        }

        private void _Delete_Metier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelMetier)this.DataContext).DeleteMetier();

        }

        private void _Save_Metier_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelMetier)this.DataContext).SaveChanges();
        }
    }
}
