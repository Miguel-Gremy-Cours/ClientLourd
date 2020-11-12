using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace MegaCasting.WPF.Windows.Add
{
    /// <summary>
    /// Logique d'interaction pour WindowAddEmploye.xaml
    /// </summary>
    public partial class WindowAddEmploye : MetroWindow
    {   /// <summary>
        /// Contructeur de WindowAddEmploye
        /// </summary>
        public WindowAddEmploye()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boutton pour annuler l'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Annulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boutton pour valider les information d'Employe puis l'ajouter dans la base de donner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            ((ViewModelAddEmployes)this.DataContext).InsertEmploye(_TextBox_Nom.Text, _TextBox_Prenom.Text, _TextBox_Login.Text, _TextBox_Password.Text);
            }
            catch (Exception)
            {

                
            }
            finally
            {

            this.Close();
            }
        }
    }
}
