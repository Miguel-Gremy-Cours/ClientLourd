using MegaCasting.WPF.ViewModel;
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
    /// Logique d'interaction pour ViewInternautes.xaml
    /// </summary>
    public partial class ViewInternautes : UserControl
    {
        public ViewInternautes()
        {
            InitializeComponent();
        }

        private void _Delete_Internaute_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelInternautes)this.DataContext).DeleteInternaute();
        }

        private void _Save_internaute_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelInternautes)this.DataContext).SaveChanges();
        }
    }
}
