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
    {
        public ViewOffres()
        {
            InitializeComponent();
        }

        private void _New_Offre_Click(object sender, RoutedEventArgs e)
        {
            WindowAddOffre windowAddOffre = new WindowAddOffre();
            windowAddOffre.DataContext = new ViewModelAddOffres(((ViewModelOffres)this.DataContext).Entities);
            windowAddOffre.ShowDialog();

        }

        private void _Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffres)this.DataContext).DeleteOffre();

        }

        private void _Save_Offre_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffres)this.DataContext).SaveChanges();
        }
    }
}
