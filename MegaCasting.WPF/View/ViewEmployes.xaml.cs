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
    {
        public ViewEmployes()
        {
            InitializeComponent();
        }

        private void _New_Employe_Click(object sender, RoutedEventArgs e)
        {
            WindowAddEmploye windowAddEmploye = new WindowAddEmploye();
            windowAddEmploye.DataContext = new ViewModelAddEmployes(((ViewModelEmployes)this.DataContext).Entities);
            windowAddEmploye.ShowDialog();
        }

        private void _Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmployes)this.DataContext).DeleteEmploye();
        }

        private void _Save_Employe_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmployes)this.DataContext).SaveChanges();
        }
    }
}
