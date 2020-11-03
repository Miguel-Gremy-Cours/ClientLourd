using MaterialDesignThemes.Wpf;
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
    /// Logique d'interaction pour ViewTypeContrat.xaml
    /// </summary>
    public partial class ViewTypeContrat : UserControl
    {
        public ViewTypeContrat()
        {
            InitializeComponent();
        }

        private void _New_Type_Click(object sender, RoutedEventArgs e)
        {
            WindowAddTypeContrat windowAddTypeContrat = new WindowAddTypeContrat();
            windowAddTypeContrat.DataContext = new ViewModelAddTypeContrat(((ViewModelTypeContrat)this.DataContext).Entities);
            windowAddTypeContrat.ShowDialog();
        }

        private void _Delete_Type_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelTypeContrat)this.DataContext).DeleteTypeContrats();
        }

        private void _Save_Type_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelTypeContrat)this.DataContext).SaveChanges();
        }
    }
}
