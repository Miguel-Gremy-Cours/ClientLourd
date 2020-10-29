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

        private void Btn_Add_Contract_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Btn_Add_Contract");
        }

        private void Btn_Del_Contract_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Btn_Del_Contract");
        }

        private void Btn_Save_Contract_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Btn_Save_Contract");
        }
    }
}
