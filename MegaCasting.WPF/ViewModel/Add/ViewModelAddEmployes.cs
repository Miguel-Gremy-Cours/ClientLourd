using ClientLourd.ViewModel;
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
        #endregion
        #region Accesseurs
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
        }
        #endregion
    }
}
