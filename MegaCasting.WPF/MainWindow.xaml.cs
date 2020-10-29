using ClientLourd.ViewModel;
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

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        #region Attributes
        private MegaCastingEntities _Entities;

        #endregion

        #region Properties

        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }
        #endregion

        #region contructor
        public MainWindow()
        {

            InitializeComponent();

            this.Entities = new MegaCastingEntities();
            Connexion connexion = new Connexion();
            connexion.DataContext = new ViewModelConnexion(Entities);
            connexion.ShowDialog();


            if (connexion.CurrentEmployee == null)
            {
                this.Close();
            }
            else
            {
                /// TODO : récupéré le currentEmployee via connexion.
                this.Visibility = Visibility.Visible;
            }
        }
        #endregion

        #region Fonctionnal click


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Connexion connexion = new Connexion();
            connexion.ShowDialog();
            this.Close();

        }



        private void WindowX_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion




        #region MenuClick


        private void Btn_ViewMain_Click(object sender, RoutedEventArgs e)
        {


            this.DockPanelView.Children.Clear();
            ViewModelMainWindow viewModel = new ViewModelMainWindow(this.Entities);
            ViewMain view = new ViewMain();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewTypeContrat_Click(object sender, RoutedEventArgs e)
        {


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
            this.DockPanelView.Children.Clear();
            ViewModelContrat viewModel = new ViewModelContrat(this.Entities);
            ViewContrat view = new ViewContrat();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewOffre_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelOffres viewModel = new ViewModelOffres(this.Entities);
            ViewOffres view = new ViewOffres();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewOffreInternaute_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelOffresInternautes viewModel = new ViewModelOffresInternautes(this.Entities);
            ViewOffresInternautes view = new ViewOffresInternautes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewInternaute_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelInternautes viewModel = new ViewModelInternautes(this.Entities);
            ViewInternautes view = new ViewInternautes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewMetier_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelMetier viewModel = new ViewModelMetier(this.Entities);
            ViewMetier view = new ViewMetier();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewDomaineMetier_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelDomaineMetier viewModel = new ViewModelDomaineMetier(this.Entities);
            ViewDomaineMetier view = new ViewDomaineMetier();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewStudio_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelStudios viewModel = new ViewModelStudios(this.Entities);
            ViewStudios view = new ViewStudios();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewPartenaire_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelPartenaires viewModel = new ViewModelPartenaires(this.Entities);
            ViewPartenaires view = new ViewPartenaires();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewEmploye_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelEmployes viewModel = new ViewModelEmployes(this.Entities);
            ViewEmployes view = new ViewEmployes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Btn_ViewGroupe_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelGroupeEmployes viewModel = new ViewModelGroupeEmployes(this.Entities);
            ViewGroupeEmployes view = new ViewGroupeEmployes();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }


        #endregion

        #region Animation Menu

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        #endregion

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

        private void _Btn_ViewMain_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewTypeContrat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewContrat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewOffre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewOffreInternaute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewInternaute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewMetier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewStudio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewStudio_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewPartenaire_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewEmploye_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Btn_ViewGroupe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
