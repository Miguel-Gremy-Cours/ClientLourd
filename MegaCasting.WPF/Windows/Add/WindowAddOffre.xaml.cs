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
    /// Logique d'interaction pour WindowAddOffre.xaml
    /// </summary>
    public partial class WindowAddOffre : MetroWindow
    {   /// <summary>
        /// Contructeur de WindowAddOffre
        /// </summary>
        public WindowAddOffre()
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
        /// Boutton pour valider les information de l'Offre puis l'ajouter dans la base de donner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            ((ViewModelAddOffres)this.DataContext).InsertOffre(_TextBox_Intitule.Text, _DatePicker_DatePublication.DisplayDate, Convert.ToInt32(_TextBox_DureDiffusion.Text), Convert.ToInt32(_TextBox_NombrePostes.Text), _TextBox_DescriptionPoste.Text, _TextBox_DescriptionProfile.Text, _TextBox_Localisation.Text, _TextBox_CodeOffre.Text);

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
