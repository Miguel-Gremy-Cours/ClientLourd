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
    class ViewModelAddGroupeEmployes : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de GroupeEmploye qui sera créé
        /// </summary>
        private GroupeEmploye _GroupeEmploye;
        /// <summary>
        /// Attribut contenant la liste des GroupeEmploye de la base de données
        /// </summary>
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de GroupeEmployes de la base de données
        /// </summary>
        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe GroupeEmploye, pour GroupeEmploye qui sera créé
        /// </summary>
        public GroupeEmploye GroupeEmploye
        {
            get { return _GroupeEmploye; }
            set { _GroupeEmploye = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddGroupeEmployes, dans lequel contient une nouvelle instance de GroupeEmploye, liste de GroupeEmploye de la base de données
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddGroupeEmployes(MegaCastingEntities entities) : base(entities)
        {
            this.GroupeEmploye = new GroupeEmploye();
            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter un GroupeEmploye, qui prendra le paramètre qui suit
        /// </summary>
        /// <param name="libelle"></param>
        public void InsertGroupeEmploye(string libelle)
        {
            GroupeEmploye groupeEmploye = new GroupeEmploye();
            groupeEmploye.Libelle = libelle;
            if (groupeEmploye.Libelle!=null)
            {
            this.GroupeEmployes.Add(groupeEmploye);
            this.SaveChanges();
                WindowSucces windowSucces = new WindowSucces();
            }
            else
            {
                WindowErrorChampEmpty window = new WindowErrorChampEmpty();
            }

        }


        #endregion
    }
}
