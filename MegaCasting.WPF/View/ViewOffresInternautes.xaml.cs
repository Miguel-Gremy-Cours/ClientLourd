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
    /// Logique d'interaction pour ViewOffresInternautes.xaml
    /// </summary>
    public partial class ViewOffresInternautes : UserControl
    {
        public ViewOffresInternautes()
        {
            InitializeComponent();
        }

        private void _Save_Changes_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffresInternautes)this.DataContext).SaveChanges();
        }
    }
}
