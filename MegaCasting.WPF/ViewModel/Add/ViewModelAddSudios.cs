using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.WPF.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddSudios : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de Studio qui sera créé
        /// </summary>
        private Studio _Studio;
        /// <summary>
        /// Attribut contenant la liste des Studios de la base de données
        /// </summary>
        private ObservableCollection<Studio> _Studios;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste des Studios de la base de données
        /// </summary>
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Studio, pour Studio qui sera créé
        /// </summary>
        public Studio Studio
        {
            get { return _Studio; }
            set { _Studio = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddSudios,  dans lequel contient la liste des Studios
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddSudios(MegaCastingEntities entities) : base(entities)
        {
            this.Studio = new Studio();
            this.Entities.Studios.ToList();
            this.Studios= this.Entities.Studios.Local;
        }
        #endregion
        #region Method

        /// <summary>
        /// Méthode pour ajouter un nouveau Studio, qui prendra les paramètres qui suivent
        /// </summary>
        /// <param name="siret"></param>
        /// <param name="adresse"></param>
        /// <param name="numeroAdresse"></param>
        /// <param name="libelle"></param>
        /// <param name="email"></param>
        /// <param name="telephone"></param>
        public void InsertStudio(string siret, string adresse, int numeroAdresse, string libelle, string email, string telephone)
        {
            Studio studio = new Studio();
            studio.Siret = siret;
            studio.Adresse = adresse;
            studio.NumeroAdresse = numeroAdresse;
            studio.Libelle = libelle;
            studio.Email = email;
            studio.Telephone = telephone;

            if (studio.Siret != null && studio.Adresse != null && studio.NumeroAdresse != null && studio.Libelle != null && studio.Email != null && studio.Telephone != null)
            {
            this.Studios.Add(studio);
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
