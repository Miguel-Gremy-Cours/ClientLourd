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


        private void WindowX_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            CurrentEmployee = ((ViewModelConnexion)this.DataContext).GetEmployeeByLogs(TxtBx_Login.Text, PwBx_Password.Password);

            if (CurrentEmployee == null)
            {
                TxtBx_Login.Text = "";
                PwBx_Password.Password = "";
                ConnexionError connexionError = new ConnexionError();
                connexionError.ShowDialog();
                //WindowError windowError = new WindowError();
                //windowError.ShowDialog();

            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.ShowDialog();
            }

        }
    }
}
