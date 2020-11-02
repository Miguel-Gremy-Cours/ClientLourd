using Caliburn.Micro;
using ClientLourd.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddContrat : ViewModelBase
    {
        #region Attribute
        private ObservableCollection<TypeContrat> _TypeContrats;
        private TypeContrat _SelectedTypeContrat;
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffre;
        private ObservableCollection<Contrat> _Contrats;
        private Contrat _SelectedContrat;

        #endregion
        #region Accesseurs
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddContrat(MegaCastingEntities entities) : base(entities)
        {
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;

            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion
    }
}
