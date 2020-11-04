using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddGroupeEmployes : ViewModelBase
    {
        #region Attributes
        private GroupeEmploye _GroupeEmploye;
        #endregion

        private ObservableCollection<GroupeEmploye> _GroupeEmployes;

        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }

        #region Accesseurs
        public GroupeEmploye GroupeEmploye
        {
            get { return _GroupeEmploye; }
            set { _GroupeEmploye = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddGroupeEmployes(MegaCastingEntities entities) : base(entities)
        {
            this.GroupeEmploye = new GroupeEmploye();
            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;
        }
        #endregion

        #region Method
        public void InsertGroupeEmploye(string libelle)
        {
            GroupeEmploye groupeEmploye = new GroupeEmploye();
            groupeEmploye.Libelle = libelle;
            this.GroupeEmployes.Add(groupeEmploye);
            this.SaveChanges();
        }
        #endregion
    }
}
