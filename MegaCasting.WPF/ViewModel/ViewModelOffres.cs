using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
   public  class ViewModelOffres:ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la liste des Metiers de la base de donnée
        /// </summary>
        private ObservableCollection<Metier> _Metiers;
        /// <summary>
        /// Attribut contenant le Metier de la vue
        /// </summary>
        private Metier _SelectedMetier;
        /// <summary>
        /// Attribut contennat la liste des Studios de la base de donnée
        /// </summary>
        private ObservableCollection<Studio> _Studios;
        /// <summary>
        /// Attribut contenantn le Studio de la vue
        /// </summary>
        private Studio _SelectedStudio;
        /// <summary>
        /// Attribut contenant la liste des offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant l'Offre de la vue
        /// </summary>
        private Offre _SelectedOffres;
        /// <summary>
        /// Attribut contenant la liste des Employes de la base de donnée
        /// </summary>
        private ObservableCollection<Employe> _Employes;
        /// <summary>
        /// Attribut contenant l'Employe de la vue
        /// </summary>
        private Employe _SelectedEmploye;
        /// <summary>
        /// Attribut contenant la liste des Contrats de la base de donnée
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;
        #endregion
        #region Properties
        /// <summary>
        /// Contrats de la base de donnée
        /// </summary>
        public ObservableCollection<Contrat> Contrats 
        {
            get { return _Contrats; }
            set {  _Contrats= value; }
        }
        /// <summary>
        /// Employes de la base de donnée
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }
        /// <summary>
        /// Employe de la vue
        /// </summary>
        public Employe SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }
        /// <summary>
        /// Metier de la vue
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        /// <summary>
        /// Metiers de la base de donnée
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }

            set { _Metiers = value; }
        }
        /// <summary>
        /// Studios de la base de donnée
        /// </summary>
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        /// <summary>
        /// Offres de la base de donnée
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Studio de la vue
        /// </summary>
        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        /// <summary>
        /// Offre de la vue
        /// </summary>
        public Offre SelectedOffre
        {
            get { return _SelectedOffres; }
            set { _SelectedOffres = value; }
        }
        #endregion
        #region Constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelOffres
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelOffres(MegaCastingEntities entities):base(entities)
        {
            // Initialisation de la liste des Offres dans la base de donnée
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
            // Initialisation de la liste des Studios dans la base de donnée
            this.Entities.Studios.ToList();
            this.Studios = this.Entities.Studios.Local;
            // Initialisation de la liste des Metiers dans la base de donnée
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
            // Initialisation de la liste des Employes dans la base de donnée
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
            // Initialisation de la liste des Contrats dans la base de donnée
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer une offre
        /// </summary>

        public void DeleteOffre()
        {
            // vérification de droit de suppression puis suppréssion de l'élément
            try
            {
                this.Offres.Remove(SelectedOffre);
                this.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            }
        }
        #endregion
    }
}
