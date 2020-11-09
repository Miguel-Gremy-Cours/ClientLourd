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
    class ViewModelAddEmployes : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut d'Employe qui sera créé
        /// </summary>
        private Employe _Employe;
        /// <summary>
        /// Attribut contenant la liste des Civilites de la base de données
        /// </summary>
        private ObservableCollection<Civilite> _Civilites;
        /// <summary>
        /// Attribut contenant la Civilité selectionnée dans la vue
        /// </summary>
        private Civilite _SelectedCivilite;
        /// <summary>
        /// Attribut contenant la liste des GroupeEmplyes de la base de données
        /// </summary>
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        /// <summary>
        /// Attribut contenant le GroupeEmploye selectionné dans la vue
        /// </summary>
        private GroupeEmploye _SelectedGroupeEmploye;
        /// <summary>
        /// Attribut contenant la liste des Emplyes de la base de données
        /// </summary>
        private ObservableCollection<Employe> _Employes;
        #endregion


        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste d'Employes de la base de données
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Employe, pour Employe qui sera créé
        /// </summary>
        public Employe Employe
        {
            get { return _Employe; }
            set { _Employe = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste des Civilites de la base de données
        /// </summary>
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Civilite, pour la Civilite qui sera sélectionnée dans la vue
        /// </summary>
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe GroupeEmploye, pour le GroupeEmploye qui sera sélectionné dans la vue
        /// </summary>
        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelectedGroupeEmploye; }
            set { _SelectedGroupeEmploye = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste des GroupeEmploye de la base de données
        /// </summary>
        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddEmployes, dans lequel contient la nouvelle instance de Employe, liste de Civilites, GroupeEmployes, Employes
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddEmployes(MegaCastingEntities entities) : base(entities)
        {
            this.Employe = new Employe();

            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;

            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;

            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter un nouvel Employe, prendra les parametères qui suivent
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void InsertEmploye(string nom, string prenom,   string login, string password)
        {
            Employe employe = new Employe();
            employe.Nom = nom;
            employe.Prenom = prenom;
            employe.Civilite = SelectedCivilite;
            employe.GroupeEmploye = SelectedGroupeEmploye;
            employe.Login = login;
            employe.Password = password;

            this.Employes.Add(employe);
            this.SaveChanges();

        }
        #endregion
    }
}
