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
    /// Logique d'interaction pour ViewPartenaires.xaml
    /// </summary>
    public partial class ViewPartenaires : UserControl
    {
        public ViewPartenaires()
        {
            InitializeComponent();
        }

        private void _New_Partenaire_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPartenaire windowAddPartenaire = new WindowAddPartenaire();
            windowAddPartenaire.DataContext = new ViewModelAddPartenaires(((ViewModelPartenaires)this.DataContext).Entities);
            windowAddPartenaire.ShowDialog();
        }

        private void _Delete_Partenaire_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPartenaires)this.DataContext).DeletePartenaire();
        }

        private void _Save_Partenaire_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPartenaires)this.DataContext).SaveChanges();
        }
    }
}
