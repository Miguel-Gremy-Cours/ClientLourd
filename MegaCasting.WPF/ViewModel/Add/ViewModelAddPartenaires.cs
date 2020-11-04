using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.RightsManagement;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddPartenaires : ViewModelBase
    {
        #region Attributes
        private Partenaire _Partenaire;
        private ObservableCollection<Partenaire> _Partenaires;
        #endregion

        #region Accesseurs
        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }

        public Partenaire Partenaire
        {
            get { return _Partenaire; }
            set { _Partenaire = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddPartenaires(MegaCastingEntities entities) : base(entities)
        {
            this.Partenaire = new Partenaire();
            this.Entities.Partenaires.ToList();
            this.Partenaires = this.Entities.Partenaires.Local;
        }
        #endregion
        #region Method
        public void InsertPartenaire(string siret, string adresse,int numeroAdresse, string libelle, string email, string telephone,string login, string password)

        { 
            Partenaire partenaire = new Partenaire();
            partenaire.Siret = siret;
            partenaire.Adresse = adresse;
            partenaire.NumeroAdresse = numeroAdresse;
            partenaire.Libelle = libelle;
            partenaire.Email = email;
            partenaire.Telephone = telephone;
            partenaire.Login = login;
            partenaire.Password = password;
            this.Partenaires.Add(partenaire);
            this.SaveChanges();
        } 
        #endregion

    }
}
