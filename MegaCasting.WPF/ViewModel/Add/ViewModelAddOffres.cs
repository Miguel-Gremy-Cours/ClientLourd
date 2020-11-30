using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Application = System.Windows.Application;
using MegaCasting.WPF.Windows;
using System.Data.Entity;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddOffres : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut d'Offre qui sera créée
        /// </summary>
        private Offre _Offre;
        /// <summary>
        /// Attribut contenant la liste des Studios de la base de données
        /// </summary>
        private ObservableCollection<Studio> _Studios;
        /// <summary>
        /// Attribut contenant le Studio selectionné dans la vue
        /// </summary>
        private Studio _SelectedStudio;
        /// <summary>
        /// Attribut contenant la liste des Metiers de la base de données
        /// </summary>
        private ObservableCollection<Metier> _Metiers;
        /// <summary>
        /// Attribut contenant le Metier selectionné dans la vue
        /// </summary>
        private Metier _SelectedMetier;
        /// <summary>
        /// Attribut contenant la liste des Employes de la base de données
        /// </summary>
        private ObservableCollection<Employe> _Employes;
        /// <summary>
        /// Attribut contenant l'Emplye selectionné dans la vue
        /// </summary>
        private Employe _SelectedEmploye;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de données
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste d'Offre de la base de données
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Offre, pour Offre qui sera créé
        /// </summary>
        public Offre Offre
        {
            get { return _Offre; }
            set { _Offre = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de Studios de la base de données
        /// </summary>
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Studio, pour Studio qui sera sélectionné dans la vue
        /// </summary>
        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Metier, pour Metier qui sera sélectionné dans la vue
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de Metiers de la base de données
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Employe, pour Employe qui sera sélectionné dans la vue
        /// </summary>
        public Employe SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value;}
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de Emplyes de la base de données
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructuer de ViewModelAddOffres, dans lequel contient les listes de Studios, Metiers, Offres et Employes de la base de données
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddOffres(MegaCastingEntities entities) : base(entities)
        {
            this.Offre = new Offre();

            this.Entities.Studios.ToList();
            this.Studios = this.Entities.Studios.Local;

            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;

            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
            

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;

           
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter une nouvelle offre qui prendra les paramètres qui suivent
        /// </summary>
        /// <param name="intitule"></param>
        /// <param name="datePublication"></param>
        /// <param name="dureDiffusion"></param>
        /// <param name="nombrePoste"></param>
        /// <param name="descriptionPoste"></param>
        /// <param name="descriptionProfile"></param>
        /// <param name="localisatoin"></param>
        /// <param name="codeOffre"></param>
        public void InsertOffre( string intitule,  DateTime datePublication, int dureDiffusion, int nombrePoste, int idEmploye, string descriptionPoste, string descriptionProfile, string localisatoin, string codeOffre)
        {
            Offre offre = new Offre();
            

            offre.Studio = SelectedStudio;
            offre.Intitule = intitule;
            offre.Metier = SelectedMetier;
            offre.DatePublication = datePublication;
            offre.DescriptionPoste = descriptionPoste;
            offre.DescriptionProfile = descriptionProfile;
            offre.DureDiffusion = dureDiffusion;
            offre.NombrePostes = nombrePoste;
            offre.IdEmploye= idEmploye;
            offre.Localisation = localisatoin;
            offre.CodeOffre = codeOffre;


            if (offre.Studio!=null && offre.Intitule!= null && offre.Metier!= null && offre.DatePublication!= null && offre.DescriptionPoste!= null && offre.DescriptionProfile!= null && offre.IdEmploye!=null && offre.Localisation!= null && offre.CodeOffre!=null)
            {
            this.Offres.Add(offre);
            this.SaveChanges();
                WindowSucces window = new WindowSucces();
            }
            else
            {
                WindowErrorChampEmpty window = new WindowErrorChampEmpty();
            }
        }
        #endregion
    }
}
