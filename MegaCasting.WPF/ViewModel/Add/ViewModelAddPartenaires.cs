using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.RightsManagement;
using MegaCasting.WPF.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddPartenaires : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de Partenaire qui sera créé
        /// </summary>
        private Partenaire _Partenaire;
        /// <summary>
        /// Attribut contenant la liste des Partenaires de la base de données
        /// </summary>
        private ObservableCollection<Partenaire> _Partenaires;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste des Partenaires de la base de données
        /// </summary>
        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Employe, pour Employe qui sera créé
        /// </summary>
        public Partenaire Partenaire
        {
            get { return _Partenaire; }
            set { _Partenaire = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructeur de ViewModelAddPartenaires, dans lequel contient la liste des Partenaires
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddPartenaires(MegaCastingEntities entities) : base(entities)
        {
            this.Partenaire = new Partenaire();
            this.Entities.Partenaires.ToList();
            this.Partenaires = this.Entities.Partenaires.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// Méthode pour ajouter un nouveau partenaire, qui prendra les paramètres qui suivent
        /// </summary>
        /// <param name="siret"></param>
        /// <param name="adresse"></param>
        /// <param name="numeroAdresse"></param>
        /// <param name="libelle"></param>
        /// <param name="email"></param>
        /// <param name="telephone"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
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

            if (partenaire.Siret!=null&& partenaire.Adresse != null && partenaire.NumeroAdresse >0 && partenaire.Libelle != null && partenaire.Email != null && partenaire.Telephone != null && partenaire.Login != null && partenaire.Password != null)
            {
                if (!Entities.Partenaires.Any(c => c.Libelle == libelle))
                {

                this.Partenaires.Add(partenaire);
                this.SaveChanges();
                WindowSucces window = new WindowSucces();
                }
                else
                {
                    ErrorDoubleElement errorDoubleElement = new ErrorDoubleElement();
                }
            }
            else
            {
                WindowErrorChampEmpty window = new WindowErrorChampEmpty();
            }
        } 
        #endregion

    }
}
