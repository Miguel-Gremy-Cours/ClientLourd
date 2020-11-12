using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
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
using System.Security.Cryptography;

namespace MegaCasting.WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : WindowX
    {
        #region Attributues
        private MegaCastingEntities _Entities;
        private Employe _CurrentEmployee;
        private bool _IsLogsValids;
        #endregion
        #region  Properties
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }


        }
        public Employe CurrentEmployee
        {
            get { return _CurrentEmployee; }
            set { _CurrentEmployee = value; }
        }
        public bool IsLogValids
        {
            get { return _IsLogsValids; }
            set { _IsLogsValids = value; }
        }
        #endregion
        #region constrcutor
        public Connexion()
        {
            InitializeComponent();
            //
            //this.ShowDialog();
            this.Entities = new MegaCastingEntities();
            this.DataContext = new ViewModelConnexion(Entities);
        }
        #endregion

        /// <summary>
        /// Méthode pour autoriser le redispositionner la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowX_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        /// <summary>
        /// Méthode pour le boutton login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {    // on récupère le chaine de de connexion et mot de passe
            CurrentEmployee = ((ViewModelConnexion)this.DataContext).GetEmployeeByLogs(TxtBx_Login.Text, PwBx_Password.Password);

            #if DEBUG
                CurrentEmployee = ((ViewModelConnexion)this.DataContext).GetEmployeeByLogs("spickover0", "eG3Agf");
            #endif

            if (CurrentEmployee == null)
            {
                //Si Login et Mot de passe de correspond à aucune valuer dans la base de données, on nettoye la zone de Textbox login et mot de passe.
                TxtBx_Login.Text = "";
                PwBx_Password.Password = "";
                ConnexionError connexionError = new ConnexionError();
                connexionError.ShowDialog();
                //WindowError windowError = new WindowError();
                //windowError.ShowDialog();

            }
            else
            {
                // quand les valuers de login et de mot de passe correspond à celles dans la BDD, on instancie une la Mainwindow et fermer la fenêtre de connexion.
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.ShowDialog();
            }
        }
    }
}
