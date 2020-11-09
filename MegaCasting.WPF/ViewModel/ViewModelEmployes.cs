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
    public class ViewModelEmployes : ViewModelBase

    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la liste des GroupeEmployes de la base de donnée
        /// </summary>
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        /// <summary>
        /// Attribut contenant la liste des Civilites de la base de donnée
        /// </summary>
        private ObservableCollection<Civilite> _Civilites;
        /// <summary>
        /// Attribut contenant la liste des Employes de la base de donnée
        /// </summary>
        private ObservableCollection<Employe> _Employes;
        /// <summary>
        /// Attributs contenant la liste des offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant le GroupeEmploye de la vue
        /// </summary>
        private GroupeEmploye _SelectedGroupeEmploye;
        /// <summary>
        /// Attribut contenant la Ciilite de la vue
        /// </summary>
        private Civilite _SelectedCivilite;
        /// <summary>
        /// Attribut contenant l'employe de la vue
        /// </summary>
        private Employe _SelectedEmploye;
        #endregion
        #region Properties
        /// <summary>
        /// Offres de la base de donnée
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// GroupeEmployes de la base de donnée
        /// </summary>
        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        /// <summary>
        /// GroupeEmploye de la vue
        /// </summary>
        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelectedGroupeEmploye; }
            set { _SelectedGroupeEmploye = value; }
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
        /// Civilites de la base de donnée
        /// </summary>
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        /// <summary>
        /// Civilite de la vue
        /// </summary>
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        #endregion
        #region constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelEmployes
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelEmployes(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des Employes dans la variable 
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
            // Initialisation de la liste des Civilites dans la variable
            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
            // Initialisation de la liste des GroupesEmployes dans la variable
            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;
            // Initialisation de la liste des Offres dans la variable
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un employé
        /// </summary>
        public void DeleteEmploye()
        {
            // Vérification de droit de suppression puis suppréssion d'élément
            if(!SelectedEmploye.Offres.Any())
            {
                this.Employes.Remove(SelectedEmploye);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Impossble de supprimer cet élément", "OK");
            }
        }
        #endregion
    }
}
