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
        private Employe _Employe;
        private ObservableCollection<Civilite> _Civilites;
        private Civilite _SelectedCivilite;
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        private GroupeEmploye _SelectedGroupeEmploye;
        private ObservableCollection<Employe> _Employes;
        #endregion


        #region Accesseurs
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }

        public Employe Employe
        {
            get { return _Employe; }
            set { _Employe = value; }
        }
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelectedGroupeEmploye; }
            set { _SelectedGroupeEmploye = value; }
        }
        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        #endregion
        #region Constructor
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
