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
        public ViewStudios()
        {
            InitializeComponent();
        }

        private void _New_Studio_Click(object sender, RoutedEventArgs e)
        {
            WindowAddStudio windowAddStudio = new WindowAddStudio();
            windowAddStudio.DataContext = new ViewModelAddSudios(((ViewModelStudios)this.DataContext).Entities);
            windowAddStudio.ShowDialog();
        }

        private void _Delete_Studio_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelStudios)this.DataContext).DeleteStudio();
        }

        private void _Save_Studio_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelStudios)this.DataContext).SaveChanges();
        }
    }
}
