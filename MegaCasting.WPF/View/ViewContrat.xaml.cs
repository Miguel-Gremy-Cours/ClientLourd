using ClientLourd.ViewModel;
using MaterialDesignThemes.Wpf;
using MegaCasting.DBLib;
using MegaCasting.WPF.View.Add;
using MegaCasting.WPF.ViewModel.Add;
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
    /// Logique d'interaction pour ViewContrat.xaml
    /// </summary>
    public partial class ViewContrat : UserControl
    {
        public ViewContrat()
        {
            InitializeComponent();
        }

        private void _New_Contrat_Click(object sender, RoutedEventArgs e)
        {
            ViewAddContrat viewAddContrat = new ViewAddContrat();
            viewAddContrat.DataContext = new ViewModelAddContrat((
                (ViewModelContrat)this.DataContext)
                .Entities);
            viewAddContrat.ShowDialog();
        }

        private void _Delete_Contrat_Click(object sender, RoutedEventArgs e)
        {

        }


        private void _Save_Contrat_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
