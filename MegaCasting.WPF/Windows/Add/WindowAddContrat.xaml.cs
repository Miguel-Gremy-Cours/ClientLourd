using MahApps.Metro.Controls;
using MegaCasting.WPF.ViewModel.Add;
using Panuon.UI.Silver;
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
using System.Windows.Shapes;

namespace MegaCasting.WPF.Windows.Add
{
    /// <summary>
    /// Logique d'interaction pour WindowAddContrat.xaml
    /// </summary>
    public partial class WindowAddContrat : MetroWindow
    {    /// <summary>
         /// Constructeur de la fenêtre WindowAddContrat
         /// </summary>
        public WindowAddContrat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boutton pour annuler la fermeture de cette fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Annulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Boutton pour valider les information de du contrat puis l'ajouter dans la base de donner
        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAddContrat)this.DataContext).InsertContrat(_DatePicker_DebutContrat.DisplayDate, Convert.ToInt32(_TextBox_DureContrat.Text), _Textbox_CodeContrat.Text, _TextBox_FichierContrat.Text);


            this.Close();
        }
    }
}
