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
    /// Logique d'interaction pour WindowAddOffre.xaml
    /// </summary>
    public partial class WindowAddOffre : MetroWindow
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant les données de la base de données
        /// </summary>
        private MegaCastingEntities _Entities;
        /// <summary>
        /// Attribut contenant les données de la base de données
        /// </summary>
        private Employe _CurrentEmploye;

        #endregion

        #region Properties
        /// <summary>
        /// properties de Employe actuel
        /// </summary>
        public Employe CurrentEmploye
        {
            get { return _CurrentEmploye; }
            set { _CurrentEmploye = value; }
        }

        /// <summary>
        /// Entitées de la base de donnée
        /// </summary>
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Contructeur de WindowAddOffre
        /// </summary>
        public WindowAddOffre()
        {
            InitializeComponent();
            this.Entities = new MegaCastingEntities();
            _Label_Employe.Content= Application.Current.Resources["currentEmp"];
            
        }

        #endregion

        /// <summary>
        /// Boutton pour annuler l'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

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
            string currentLogin = Application.Current.Resources["currentEmp"].ToString();
           Employe employe = this.Entities.Employes.FirstOrDefault(emp => emp.Login == currentLogin);
            int empId = employe.Id;

            if (int.TryParse(_TextBox_NombrePostes.Text, out int resultNbPoste)!=false&& int.TryParse(_TextBox_DureDiffusion.Text, out int resultDuree) !=false&& _TextBox_Intitule.Text != null&& _TextBox_DescriptionPoste.Text!=null&& _TextBox_DescriptionProfile.Text!=null&& _TextBox_Localisation.Text!=null&& _TextBox_CodeOffre.Text!=null)
            {

            ((ViewModelAddOffres)this.DataContext).InsertOffre(_TextBox_Intitule.Text, _DatePicker_DatePublication.DisplayDate, Convert.ToInt32(_TextBox_DureDiffusion.Text), Convert.ToInt32(_TextBox_NombrePostes.Text), empId,  _TextBox_DescriptionPoste.Text, _TextBox_DescriptionProfile.Text, _TextBox_Localisation.Text, _TextBox_CodeOffre.Text);

            this.Close();
            }

            else
            {
                WindowErrorChampEmpty windowErrorChampEmpty = new WindowErrorChampEmpty();
            }
            
         
            
        }
    }
}
