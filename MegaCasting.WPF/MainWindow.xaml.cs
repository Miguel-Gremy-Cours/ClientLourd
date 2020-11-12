using MegaCasting.WPF.ViewModel;
using MahApps.Metro.Controls;
using MegaCasting.DBLib;
using MegaCasting.WPF.View;
using MegaCasting.WPF.Windows;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using MaterialDesignThemes.Wpf;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
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

        #region contructor
        /// <summary>
        /// Constructeur de MainWindow
        /// </summary>
        /// <param name="entities"></param>
        public MainWindow()
        {
            InitializeComponent();
            this.Entities = new MegaCastingEntities();
            _Label_Emp.Content = Application.Current.Resources["currentEmp"];
            ChangeMenuItemVisibility();

            //this.DataContext = new ViewModelMainWindow(Entities); 
            //=> ces deux lignes ont été déplacées dans Connexion.Xaml.cs
        }
        #endregion

        #region Fonctionnal click
        /// <summary>
        /// Button click de base dans la template de listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
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
        /// Boutton pour fermer la fenêtre de connexion, ce qui rappellera un popup de confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            ConfirmationExit confirmation = new ConfirmationExit();
            confirmation.ShowDialog();

            //MessageBoxResult result = MessageBox.Show("Fermer l'application", "Fermeture", MessageBoxButton.OKCancel);
            //switch (result)
            //{
            //    case MessageBoxResult.OK:
            //        this.Close();
            //        break;
            //    default:
            //        break;
            //}
        }
        #endregion




        private void ChangeMenuItemVisibility()
        {
            string login = Application.Current.Resources["currentEmp"].ToString();
            Employe emp = this.Entities.Employes.FirstOrDefault(employe => employe.Login == login);

            if (emp.IdGroupeEmployes==2)
            {
                ViewEmploye.Visibility = Visibility.Visible;
                Btn_ViewEmploye.Visibility = Visibility.Visible;

                ViewGroupe.Visibility = Visibility.Visible;
                Btn_ViewGroupe.Visibility = Visibility.Visible;

                ViewInternaute.Visibility = Visibility.Visible;
                Btn_ViewInternaute.Visibility = Visibility.Visible;

                ViewOffreInternaute.Visibility = Visibility.Visible;
                Btn_ViewOffreInternaute.Visibility = Visibility.Visible;

                
            }
           
        }

        #region MenuClick
        private void Btn_ViewMain_Click(object sender, RoutedEventArgs e)
        {

            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewMain
            this.DockPanelView.Children.Clear();
            ViewModelMainWindow viewModel = new ViewModelMainWindow(this.Entities);
            ViewMain view = new ViewMain();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewTypeContrat_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewTypeContrat

            this.DockPanelView.Children.Clear();
            ViewModelTypeContrat viewModel = new ViewModelTypeContrat(this.Entities);
            ViewTypeContrat view = new ViewTypeContrat();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        // this.DockPanelView.Children.Clear();
        //    ViewModelCivilite viewModel = new ViewModelCivilite(this.Entities);
        //ViewCivilite view = new ViewCivilite();
        //view.DataContext = viewModel;

        //    this.DockPanelView.Children.Add(view);

        private void Btn_ViewContrat_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewContrat
            this.DockPanelView.Children.Clear();
            ViewModelContrat viewModel = new ViewModelContrat(this.Entities);
            ViewContrat view = new ViewContrat();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewOffre_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewOffre
            this.DockPanelView.Children.Clear();
            ViewModelOffres viewModel = new ViewModelOffres(this.Entities);
            ViewOffres view = new ViewOffres();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewOffreInternaute_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewOffreInternaute
            this.DockPanelView.Children.Clear();
            ViewModelOffresInternautes viewModel = new ViewModelOffresInternautes(this.Entities);
            ViewOffresInternautes view = new ViewOffresInternautes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewInternaute_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewInternaute
            this.DockPanelView.Children.Clear();
            ViewModelInternautes viewModel = new ViewModelInternautes(this.Entities);
            ViewInternautes view = new ViewInternautes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewMetier_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewMetier
            this.DockPanelView.Children.Clear();
            ViewModelMetier viewModel = new ViewModelMetier(this.Entities);
            ViewMetier view = new ViewMetier();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewDomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewDomaineMetier
            this.DockPanelView.Children.Clear();
            ViewModelDomaineMetier viewModel = new ViewModelDomaineMetier(this.Entities);
            ViewDomaineMetier view = new ViewDomaineMetier();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewStudio_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewStudio
            this.DockPanelView.Children.Clear();
            ViewModelStudios viewModel = new ViewModelStudios(this.Entities);
            ViewStudios view = new ViewStudios();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewPartenaire_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewPartenaire
            this.DockPanelView.Children.Clear();
            ViewModelPartenaires viewModel = new ViewModelPartenaires(this.Entities);
            ViewPartenaires view = new ViewPartenaires();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewEmploye_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewEmploye
            this.DockPanelView.Children.Clear();
            ViewModelEmployes viewModel = new ViewModelEmployes(this.Entities);
            ViewEmployes view = new ViewEmployes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewGroupe_Click(object sender, RoutedEventArgs e)
        {
            // Vider les éléments enfants (UserControl,Vue) de mainWindow dans ce DockPanel, puis ajouter la vue de ViewGroupeEmploye
            this.DockPanelView.Children.Clear();
            ViewModelGroupeEmployes viewModel = new ViewModelGroupeEmployes(this.Entities);
            ViewGroupeEmployes view = new ViewGroupeEmployes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }


        #endregion

        #region Animation Menu

        /// <summary>
        /// Méthode pour activer une animation d'une barre pour indiquer la position de la souris lorsqu'elle entre dans la zone de menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void ListBoxItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var currentItem = sender as ListBoxItem;
            // Définir un point de départ qui est par défaut 0,0 -> X,Y. Ici le point de départ est sur le ListBoxItem, sur la bar qui est nommé PointerRail

            var offset = currentItem.TranslatePoint(new Point(0, 0), PointerRail).Y;
            // Récupérer la valeur de l'axe Y

            var animation = new DoubleAnimation
            {
                To = offset,
                Duration = TimeSpan.FromSeconds(0.3)
            };

            PointOffset.BeginAnimation(TranslateTransform.YProperty, animation);
        }
        #endregion

    }
}
