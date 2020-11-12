using MahApps.Metro.Controls;
using MegaCasting.DBLib;
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
    /// Logique d'interaction pour WindowAddDomaineMetier.xaml
    /// </summary>
    public partial class WindowAddDomaineMetier : MetroWindow
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant le nouveau DomaineMetier
        /// </summary>
        private DomaineMetier _NewDomaine;
        #endregion

        #region Properties
        /// <summary>
        /// Properties de DomaineMetier de la BDD
        /// </summary>
        public DomaineMetier NewDomaine
        {
            get { return _NewDomaine; }
            set { _NewDomaine = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Contructeur de WindowAddDomaineMetier
        /// </summary>
        public WindowAddDomaineMetier()
        {
            InitializeComponent();
        }
        #endregion
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
        /// Boutton pour valider les information du DomaineMetier puis l'ajouter dans la base de donner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
           

           ((ViewModelAddDomaineMetier)this.DataContext).InsertDomaineMetier(_TextBox_Libelle.Text);
         

                this.Close();
           
            //ToDo, Ajouter Une procédure de vérification et MessageBox en cas d'erreur
            
        }
    }
}
