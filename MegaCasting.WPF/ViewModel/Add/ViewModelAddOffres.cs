using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddOffres : ViewModelBase
    {
        #region Attributes
        private Offre _Offre;
        private ObservableCollection<Studio> _Studios;
        private Studio _SelectedStudio;
        private ObservableCollection<Metier> _Metiers;
        private Metier _SelectedMetier;
        private ObservableCollection<Employe> _Employes;
        private Employe _SelectedEmploye;
        private ObservableCollection<Offre> _Offres;
        #endregion

        #region Accesseurs
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }

        public Offre Offre
        {
            get { return _Offre; }
            set { _Offre = value; }
        }
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }
        public Employe SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }
        #endregion
        #region Constructor
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
        public void InsertOffre( string intitule,  DateTime datePublication, int dureDiffusion, int nombrePoste, string descriptionPoste, string descriptionProfile, string localisatoin, string codeOffre)
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
            offre.Employe = SelectedEmploye;
            offre.Localisation = localisatoin;
            offre.CodeOffre = codeOffre;

            this.Offres.Add(offre);
            this.SaveChanges();
        }
        #endregion
    }
}
